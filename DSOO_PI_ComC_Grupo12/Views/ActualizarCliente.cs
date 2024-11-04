using DSOO_PI_ComC_Grupo12.Controllers;
using DSOO_PI_ComC_Grupo12.Models;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class ActualizarCliente : Form
    {
        public bool esSocio = true;
        public bool esApto = true;
        public Cliente? ClienteSeleccionado { get; set; }
        private readonly ActualizarClienteController _actualizarClienteController;

        public ActualizarCliente()
        {
            InitializeComponent();
            _actualizarClienteController = new ActualizarClienteController();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioSocio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSocio.Checked)
            {
                esSocio = true;
            }
        }

        private void Radio_no_socio_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_no_socio.Checked)
            {
                esSocio = false;
            }
        }

        private void radioAptoFisicoSi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAptoFisicoSi.Checked)
            {
                esApto = true;
            }
        }

        private void radioAptoFisicoNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAptoFisicoNo.Checked)
            {
                esApto = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!_actualizarClienteController.CamposValidos(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono))
            {
                return;
            }

            if (ClienteSeleccionado == null)
            {
                MessageBox.Show("No hay cliente seleccionado para actualizar.");
                return;
            }

            Cliente clienteActualizado = new Cliente(
                ClienteSeleccionado.Id,
                txtNombre.Text,
                txtApellido.Text,
                txtDNI.Text,
                txtEmail.Text,
                txtTelefono.Text,
                dateFechaNac.Value,
                esSocio,
                esApto
            );

            bool actualizado = _actualizarClienteController.ActualizarCliente(clienteActualizado);

            if (actualizado)
            {
                MessageBox.Show("Cliente actualizado correctamente.");
                _actualizarClienteController.Limpiar(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, dateFechaNac, txtClienteIDoDNI, radioSocio, radioAptoFisicoSi);
            }
            else
            {
                MessageBox.Show("Error al actualizar el cliente.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteSeleccionado = null;
            string input = txtClienteIDoDNI.Text;

            Cliente? cliente = _actualizarClienteController.BuscarCliente(input, radioID.Checked);
            if (cliente != null)
            {
                ClienteSeleccionado = cliente;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDNI.Text = cliente.Dni;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;
                dateFechaNac.Value = cliente.FechaNacimiento;

                radioSocio.Checked = cliente.EsSocio;
                Radio_no_socio.Checked = !cliente.EsSocio;
                radioAptoFisicoSi.Checked = cliente.EsApto;
                radioAptoFisicoNo.Checked = !cliente.EsApto;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _actualizarClienteController.Limpiar(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, dateFechaNac, txtClienteIDoDNI, radioSocio, radioAptoFisicoSi);
        }
    }
}
