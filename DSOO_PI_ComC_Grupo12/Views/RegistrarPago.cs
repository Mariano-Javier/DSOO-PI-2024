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
    public partial class RegistrarPago : Form
    {
        public Cliente? ClienteSeleccionado { get; set; }
        public string FormaPago = "Efectivo";
        public RegistrarPago()
        {
            InitializeComponent();
        }

        private void ResetearRadioButtons()
        {
            radioEfectivo.Checked = true;
            // Restablecer el valor de la variable  a su valor original
            FormaPago = "Efectivo";
        }
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un cliente
            if (ClienteSeleccionado != null)
            {
                // Obtener la fecha seleccionada en el DateTimePicker
                DateTime fechaPago = dateFechaPago.Value;

                // Ocultar todas las ventanas abiertas menos la ventana emergente
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this) // Omitimos la ventana actual, se oculta al final
                    {
                        form.Hide();
                    }
                }

                // Oculta la ventana actual (si es necesario)
                this.Hide();

                // Crea y muestra la ventana emergente
                Comprobante comprobante = new Comprobante(ClienteSeleccionado, fechaPago, FormaPago);
                comprobante.ShowDialog(); // Mostrar como ventana modal

                // Cuando la ventana emergente se cierra, volvemos a mostrar todas las ventanas ocultas
                foreach (Form form in Application.OpenForms)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //dateFechaPago
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //
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
    }
}
