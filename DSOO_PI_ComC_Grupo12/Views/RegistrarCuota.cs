using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarCuota : Form
    {
        public Cliente? ClienteSeleccionado { get; set; }
        public string FormaPago = "Efectivo";
        public Decimal TotalPagar;
        public int TipoCuota;
        Dictionary<string, decimal> preciosActividades;
        private List<Form> ventanasAbiertas;

        public RegistrarCuota()
        {
            InitializeComponent();
            dateFechaPago.Value = DateTime.Now;
            dateDiaInicio.Value = DateTime.Now;
            dateDiaFin.Value = dateDiaInicio.Value.AddMonths(1);
            btnPagar.Enabled = false;
            btnComprobante.Enabled = false;
            TotalPagar = 0;
            comboBoxTipoSocio.SelectedIndex = 0; 
            TipoCuota = 1;
            preciosActividades = new Dictionary<string, decimal>();
            ventanasAbiertas = new List<Form>();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClienteID.Text = string.Empty;
            lblNombreApellido.Text = string.Empty;
            lblDNI.Text = string.Empty;
            dateFechaPago.Value = DateTime.Now;
            dateDiaInicio.Value = DateTime.Now;
            dateDiaFin.Value = dateDiaInicio.Value.AddMonths(1);
            lblTotalPagar.Text = string.Empty;
            ResetearRadioButtons();
            btnPagar.Enabled = false;
            btnComprobante.Enabled = false;
            TotalPagar = 0;
            ClienteSeleccionado = null;
            dataGridResumen.Rows.Clear();
            preciosActividades.Clear();
            comboBoxTipoSocio.SelectedIndex = 0;
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
            // Restablecer el valor de la variable  a su valor original
            FormaPago = "Efectivo";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
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
                        // Mostrar los datos del cliente en los labels
                        lblNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
                        lblDNI.Text = cliente.Dni;

                        // Almacenar el cliente en la propiedad ClienteSeleccionado
                        ClienteSeleccionado = cliente;
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Crear una instancia del repositorio de cuotas
            CuotaSocioRepository cuotaSocioRepository = new CuotaSocioRepository();
            TotalPagar = 0;
            preciosActividades.Clear();
            btnComprobante.Enabled = false;
            try
            {
                // Obtener la cuota correspondiente al tipo de socio seleccionado
                var (descripcion, monto) = cuotaSocioRepository.ObtenerCuotaPorId(TipoCuota);

                if (!string.IsNullOrEmpty(descripcion) && monto > 0)
                {
                    // Calcular el total a pagar
                    TotalPagar = monto;



                    preciosActividades.Add("Cuota "+comboBoxTipoSocio.Text, TotalPagar);


                    var (totalConDescuento, montoDescuento) = TotalDescuento(TotalPagar, FormaPago);

                    

                    // Mostrar el total
                    TotalPagar = totalConDescuento;
                    lblTotalPagar.Text = TotalPagar.ToString() + " $";

                    if (TotalPagar > 0)
                    {
                        preciosActividades.Add("Descuento:", -montoDescuento);
                    }

                    CargarDataGridView(preciosActividades);

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

        private void CargarDataGridView(Dictionary<string, decimal> preciosActividades)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridResumen.Rows.Clear();

            // Iterar a través del diccionario y agregar filas al DataGridView
            foreach (var actividad in preciosActividades)
            {
                dataGridResumen.Rows.Add(actividad.Key, actividad.Value);
            }
        }

        private (decimal TotalConDescuento, decimal MontoDescuento) TotalDescuento(decimal Total, string FormaPago)
        {
            decimal TotalConDescuento = Total;
            decimal MontoDescuento = 0m;

            if (FormaPago == "Tarjeta en 3 cuotas")
            {
                MontoDescuento = Math.Round(Total * 0.10m, 2);  // 10% de descuento, redondeado a 2 decimales
                TotalConDescuento = Math.Round(Total - MontoDescuento, 2);  // Total con descuento redondeado
            }
            else if (FormaPago == "Tarjeta en 6 cuotas")
            {
                MontoDescuento = Math.Round(Total * 0.15m, 2);  // 15% de descuento, redondeado a 2 decimales
                TotalConDescuento = Math.Round(Total - MontoDescuento, 2);  // Total con descuento redondeado
            }
            // Si es en efectivo o cualquier otra forma de pago, no hay descuento

            return (TotalConDescuento, MontoDescuento);
        }

        private void btnPagar_Click(object sender, EventArgs e)
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
                PagoRepository pagoRepository = new PagoRepository();
                pagoRepository.RegistrarPago(
                    ClienteSeleccionado.Id,
                    TotalPagar,
                    FormaPago,
                    dateFechaPago.Value,
                    dateDiaInicio.Value,
                    dateDiaFin.Value, // periodo_fin es null
                    true,  // socio_al_pagar es true
                    TipoCuota // id_cuota 
                );

                

                MessageBox.Show("Pago registrado exitosamente.");

                btnComprobante.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message);
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
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
                DateTime fechaFin = dateDiaFin.Value;

                // Crea y muestra la ventana emergente
                Comprobante comprobante = new Comprobante(ClienteSeleccionado, fechaPago, FormaPago, TotalPagar, preciosActividades, fechaInicio,fechaFin);
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
    }
}
