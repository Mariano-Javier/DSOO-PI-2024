using DSOO_PI_ComC_Grupo12.Interfaces;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using DSOO_PI_ComC_Grupo12.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarCuota : Form, IPago, ILimpiezaForm
    {
        public Cliente? ClienteSeleccionado { get; set; }
        public string FormaPago = "Efectivo";
        public Decimal TotalPagar;
        public int TipoCuota;
        private List<Actividad> actividades;
        private List<Form> ventanasAbiertas;

        public DateTime CantidadMesesPagos;
        public int MesesSeleccionados;

        public RegistrarCuota()
        {
            InitializeComponent();
            dateFechaPago.Value = DateTime.Now;
            dateDiaInicio.Value = DateTime.Now;

            CantidadMesesPagos = dateDiaInicio.Value.AddMonths(1);

            btnPagar.Enabled = false;
            btnComprobante.Enabled = false;
            btnCalcular.Enabled = false;
            TotalPagar = 0;
            comboBoxTipoSocio.SelectedIndex = 0;
            TipoCuota = 1;
            actividades = new List<Actividad>();
            ventanasAbiertas = new List<Form>();

            comboBoxMesSus.SelectedIndex = 0;
            MesesSeleccionados = 1;
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
            dateDiaInicio.Value = DateTime.Now;
            lblTotalPagar.Text = string.Empty;
            ResetearRadioButtons();
            btnPagar.Enabled = false;
            btnComprobante.Enabled = false;
            TotalPagar = 0;
            ClienteSeleccionado = null;
            dataGridResumen.Rows.Clear();
            actividades.Clear();
            comboBoxTipoSocio.SelectedIndex = 0;
            comboBoxMesSus.SelectedIndex = 0;
            MesesSeleccionados = 1;
            btnCalcular.Enabled = false;
            lblBuscarStatus.Text = string.Empty;
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

        private void ResetearRadioButtons()
        {
            radioEfectivo.Checked = true;
            // Restablecer el valor de la variable a su valor original
            FormaPago = "Efectivo";
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
                        if (cliente.EsSocio)
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
                            lblBuscarStatus.Text = "El cliente no esta registrado como socio";
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

        private void comboBoxTipoSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validar el índice seleccionado
            if (comboBoxTipoSocio.SelectedIndex == 1) // Índice de "Premium"
            {
                TipoCuota = 2;
            }
            else if (comboBoxTipoSocio.SelectedIndex == 0) // Índice de "Regular"
            {
                TipoCuota = 1;
            }
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            // Crear una instancia del repositorio de descuentos y actualizar los valores desde la base de datos
            var descuentosRepo = new DescuentosRepository();
            descuentosRepo.CargarDescuentos();  // Actualiza los valores en ConfiguracionDescuentos

            // Crear una instancia del repositorio de cuotas
            CuotaSocioRepository cuotaSocioRepository = new CuotaSocioRepository();
            TotalPagar = 0;
            actividades.Clear();
            btnComprobante.Enabled = false;

            // Actualizar la fecha de fin del periodo de acuerdo a la selección de meses
            CantidadMesesPagos = dateDiaInicio.Value.AddMonths(MesesSeleccionados);

            try
            {
                // Obtener la cuota correspondiente al tipo de socio seleccionado
                var (descripcion, monto) = cuotaSocioRepository.ObtenerCuotaPorId(TipoCuota);

                if (!string.IsNullOrEmpty(descripcion) && monto > 0)
                {
                    // Calcular el total a pagar
                    TotalPagar = monto * MesesSeleccionados;
                    actividades.Add(new Actividad { Nombre = "Cuota " + comboBoxTipoSocio.Text, Precio = TotalPagar });

                    // Aplicar el descuento usando los valores actualizados
                    var (totalConDescuento, montoDescuento) = DescuentoUtils.TotalDescuento(TotalPagar, FormaPago);

                    // Mostrar el total con descuento
                    TotalPagar = totalConDescuento;
                    lblTotalPagar.Text = TotalPagar.ToString("C2") + " $";

                    if (TotalPagar > 0)
                    {
                        actividades.Add(new Actividad { Nombre = "Descuento:", Precio = -montoDescuento });
                    }

                    // Cargar los datos en el DataGridView
                    CargarDataGridView(actividades);

                    btnPagar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontró el tipo de socio seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el precio a pagar: " + ex.Message);
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
                    dateDiaInicio.Value,
                    CantidadMesesPagos,
                    true,  // socio_al_pagar es true
                    TipoCuota // id_cuota
                );

                PagoRepository pagoRepository = new PagoRepository();
                pagoRepository.RegistrarPago(pago);

                MessageBox.Show("Pago registrado exitosamente.");

                btnComprobante.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message);
            }
        }

        public void btnComprobante_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un cliente
            if (ClienteSeleccionado != null)
            {
                // Guardar las ventanas abiertas en la lista, excluyendo la ventana de Login
                ventanasAbiertas.Clear();
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && !(form is Login)) // Omitimos la ventana actual y la ventana de Login
                    {
                        ventanasAbiertas.Add(form);
                        form.Hide();
                    }
                }

                // Oculta la ventana actual (si es necesario)
                this.Hide();

                // Obtener la fecha seleccionada en el DateTimePicker
                DateTime fechaPago = dateFechaPago.Value;
                DateTime fechaInicio = dateDiaInicio.Value;
                DateTime fechaFin = CantidadMesesPagos;

                // Crea y muestra la ventana emergente
                Comprobante comprobante = new Comprobante(ClienteSeleccionado, fechaPago, FormaPago, TotalPagar, actividades, fechaInicio, fechaFin);
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

        private void comboBoxMesSus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMesSus.SelectedItem != null)
            {
                MesesSeleccionados = Convert.ToInt32(comboBoxMesSus.SelectedItem.ToString());
            }
        }
    }
}
