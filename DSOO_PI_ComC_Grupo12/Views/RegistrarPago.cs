using DSOO_PI_ComC_Grupo12.Interfaces;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using DSOO_PI_ComC_Grupo12.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarPago : Form, IPago, ILimpiezaForm
    {
        public Cliente? ClienteSeleccionado { get; set; }
        public string FormaPago = "Efectivo";
        private List<Form> ventanasAbiertas;
        public List<string> actividadesSeleccionadas;
        private ActividadRepository actividadRepository;
        public Decimal TotalPagar;
        private bool EstadoPagado;
        private List<Actividad> actividades;

        public RegistrarPago()
        {
            InitializeComponent();
            ventanasAbiertas = new List<Form>();
            actividadesSeleccionadas = new List<string>();
            actividadRepository = new ActividadRepository();
            TotalPagar = 0;
            EstadoPagado = false;
            dateFechaPago.Value = DateTime.Now;
            dateDiaSeleccionado.Value = DateTime.Now;
            btnPagar.Enabled = false;
            btnComprobante.Enabled = false;
            btnCalcular.Enabled = false;

            // Cargar las actividades en el DataGridView
            CargarActividadesEnDataGrid();
        }

        private void ResetearRadioButtons()
        {
            radioEfectivo.Checked = true;
            // Restablecer el valor de la variable a su valor original
            FormaPago = "Efectivo";
        }

        private void ResetearCheckBoxes()
        {
            foreach (DataGridViewRow row in dataGridSelecActi.Rows)
            {
                // Establecer el valor de la columna "Seleccion" a false
                row.Cells["Seleccion"].Value = false;
            }
        }

        private void CargarDataGridView(List<Actividad> actividades)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridResumen.Rows.Clear();

            // Iterar a través de la lista de actividades y agregar filas al DataGridView
            foreach (var actividad in actividades)
            {
                dataGridResumen.Rows.Add(actividad.Nombre, actividad.Precio);
            }
        }

        public void btnComprobante_Click(object sender, EventArgs e)
        {
            if (EstadoPagado == false)
            {
                MessageBox.Show("Debe realizar el pago antes de poder emitir el comprobante.");
                return;
            }
            // Verificar si se ha seleccionado un cliente
            if (ClienteSeleccionado != null)
            {
                // Guardar las ventanas abiertas en la lista, excluyendo la ventana de Login
                ventanasAbiertas.Clear();
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && !(form is Login)) // Se omite la ventana actual y la ventana de Login
                    {
                        ventanasAbiertas.Add(form);
                        form.Hide();
                    }
                }

                // Oculta la ventana actual (si es necesario)
                this.Hide();

                // Obtener la fecha seleccionada en el DateTimePicker
                DateTime fechaPago = dateFechaPago.Value;

                DateTime fechaSeleccionada = dateDiaSeleccionado.Value;

                // Crea y muestra la ventana emergente
                Comprobante comprobante = new Comprobante(ClienteSeleccionado, fechaPago, FormaPago, TotalPagar, actividades, fechaSeleccionada);
                comprobante.ShowDialog(); // Mostrar como ventana modal

                // Cuando la ventana emergente se cierra, volvemos a mostrar todas las ventanas ocultas
                this.Show();
                foreach (Form form in ventanasAbiertas)
                {
                    form.Show();
                }
            }
            else
            {
                // Mostrar un mensaje de error si no se ha seleccionado un cliente
                MessageBox.Show("Por favor, busque y seleccione un cliente antes de generar el comprobante.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClienteID.Text = string.Empty;
            Limpiar();
        }

        private void Limpiar()
        {
            lblNombreApellido.Text = string.Empty;
            lblDNI.Text = string.Empty;
            dateFechaPago.Value = DateTime.Now;
            dateDiaSeleccionado.Value = DateTime.Now;
            lblTotalPagar.Text = string.Empty;
            ResetearRadioButtons();
            actividadesSeleccionadas.Clear();
            TotalPagar = 0;
            ClienteSeleccionado = null;
            dataGridResumen.Rows.Clear();
            EstadoPagado = false;
            btnPagar.Enabled = false;
            btnComprobante.Enabled = false;
            btnCalcular.Enabled = false;
            lblBuscarStatus.Text = string.Empty;
            ResetearCheckBoxes();

            if (actividades != null && actividades.Count > 0)
            {
                actividades.Clear();
            }
        }

        public void btnPagar_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de realizar el pago.");
                return;
            }

            if (TotalPagar <= 0)
            {
                MessageBox.Show("El monto a pagar debe ser mayor que cero.");
                return;
            }

            try
            {
                Pago pago = new Pago(
                    ClienteSeleccionado.Id,
                    TotalPagar,
                    FormaPago,
                    dateFechaPago.Value,
                    dateDiaSeleccionado.Value,
                    null, // periodo_fin es null
                    false,  // socio_al_pagar es false
                    null // id_cuota no usado para no socios
                );

                PagoRepository pagoRepository = new PagoRepository();
                pagoRepository.RegistrarPago(pago);

                EstadoPagado = true;

                MessageBox.Show("Pago registrado exitosamente.");

                btnComprobante.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message);
            }
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            btnComprobante.Enabled = false;

            // Actualizar los valores de descuento desde la base de datos
            var descuentosRepo = new DescuentosRepository();
            descuentosRepo.CargarDescuentos();

            // Obtener las actividades seleccionadas
            ObtenerActividadesSeleccionadas();

            // Verificar si hay actividades seleccionadas
            if (actividadesSeleccionadas.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una actividad.");
                return;
            }

            // Obtener los precios de las actividades seleccionadas
            actividades = actividadRepository.ObtenerActividades().FindAll(a => actividadesSeleccionadas.Contains(a.Nombre));

            // Calcular el total
            TotalPagar = 0;
            foreach (var actividad in actividades)
            {
                TotalPagar += actividad.Precio;
            }

            // Usar DescuentoUtils para calcular el total con descuento aplicando los valores recién cargados
            var (totalConDescuento, montoDescuento) = DescuentoUtils.TotalDescuento(TotalPagar, FormaPago);

            // Mostrar el total actualizado
            TotalPagar = totalConDescuento;
            lblTotalPagar.Text = TotalPagar.ToString("C2") + " $";

            // Cargar los datos en el DataGridView
            if (actividades.Count > 0)
            {
                actividades.Add(new Actividad { Nombre = "Descuento:", Precio = -montoDescuento });
            }
            CargarDataGridView(actividades);

            btnPagar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Limpiar();
            // Obtener el ID del cliente desde el TextBox
            if (int.TryParse(txtClienteID.Text, out int clienteId))
            {
                // Crear una instancia del repositorio de clientes
                ClienteRepository clienteRepository = new ClienteRepository();

                try
                {
                    // Buscar el cliente por ID
                    Cliente? cliente = clienteRepository.BuscarClientePorId(clienteId);

                    if (cliente != null)
                    {
                        if (!cliente.EsSocio)
                        {
                            // Mostrar los datos del cliente en los labels
                            lblNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
                            lblDNI.Text = cliente.Dni;

                            // Almacenar el cliente en la propiedad ClienteSeleccionado
                            ClienteSeleccionado = cliente;
                            btnCalcular.Enabled = true;
                            lblBuscarStatus.Text = "Cliente encontrado con éxito";
                        }
                        else
                        {
                            lblBuscarStatus.Text = "El cliente esta registrado como socio";
                            btnCalcular.Enabled = false;
                        }
                    }
                    else
                    {
                        // Mostrar un mensaje de error si el cliente no se encuentra
                        MessageBox.Show("No se encontró un cliente con el ID proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el cliente: " + ex.Message);
                }
            }
            else
            {
                // Mostrar un mensaje de error si el ID no es un número válido
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.");
            }
        }

        private void radioEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEfectivo.Checked)
            {
                FormaPago = "Efectivo";
            }
        }

        private void radioCuota3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCuota3.Checked)
            {
                FormaPago = "Tarjeta en 3 cuotas";
            }
        }

        private void radioCuota6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCuota6.Checked)
            {
                FormaPago = "Tarjeta en 6 cuotas";
            }
        }

        private void CargarActividadesEnDataGrid()
        {
            // Obtener las actividades desde el repositorio
            var actividades = actividadRepository.ObtenerActividades();

            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridSelecActi.Rows.Clear();

            // Iterar a través de las actividades y agregar filas al DataGridView
            foreach (var actividad in actividades)
            {
                dataGridSelecActi.Rows.Add(false, actividad.Nombre, actividad.Precio);
            }
        }

        private void ObtenerActividadesSeleccionadas()
        {
            actividadesSeleccionadas.Clear();

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow row in dataGridSelecActi.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleccion"].Value))
                {
                    actividadesSeleccionadas.Add(row.Cells["Nombre"].Value.ToString());
                }
            }
        }
    }
}
