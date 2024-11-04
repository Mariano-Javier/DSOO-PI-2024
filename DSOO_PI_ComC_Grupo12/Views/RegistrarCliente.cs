using DSOO_PI_ComC_Grupo12.Controllers;
using DSOO_PI_ComC_Grupo12.Interfaces;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarCliente : Form, IRegistrar
    {
        private readonly RegistrarClienteController _registrarClienteController;

        public RegistrarCliente()
        {
            InitializeComponent();
            _registrarClienteController = new RegistrarClienteController();
            dateFechaNac.Value = DateTime.Now;
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            _registrarClienteController.Limpiar(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, dateFechaNac, radioSocio, radioAptoFisicoSi);
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos no esten vacios.
            if (!_registrarClienteController.CamposValidos(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono))
            {
                return;
            }

            // Registra el cliente
            _registrarClienteController.RegistrarCliente(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, dateFechaNac, radioSocio, radioAptoFisicoSi);
        }

        private void radioSocio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSocio.Checked)
            {
                _registrarClienteController.SetEsSocio(true);
            }
        }

        private void Radio_no_socio_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_no_socio.Checked)
            {
                _registrarClienteController.SetEsSocio(false);
            }
        }

        private void radioAptoFisicoSi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAptoFisicoSi.Checked)
            {
                _registrarClienteController.SetEsApto(true);
            }
        }

        private void radioAptoFisicoNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAptoFisicoNo.Checked)
            {
                _registrarClienteController.SetEsApto(false);
            }
        }
    }
}
