using DSOO_PI_ComC_Grupo12.Controllers;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class ConfigurarBD : Form
    {
        private readonly ConfigurarBDController _configurarBDController;

        public ConfigurarBD()
        {
            InitializeComponent();
            _configurarBDController = new ConfigurarBDController();
            _configurarBDController.Initialize(txtNombreBD, txtServidor, txtPuerto, txtUsuario, txtContrasenia);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreBD.Clear();
            txtServidor.Clear();
            txtPuerto.Clear();
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verifica que no haya campos vacíos en los campos obligatorios
            if (_configurarBDController.CamposVacios(txtNombreBD, txtServidor, txtPuerto, txtUsuario))
            {
                return; // Si hay un campo vacío, mostramos el mensaje y detenemos la ejecución
            }

            // Guardamos los datos de configuración
            _configurarBDController.GuardarConfiguracion(txtNombreBD, txtServidor, txtPuerto, txtUsuario, txtContrasenia);

            this.Close(); // Cierra el formulario después de guardar los cambios
        }
    }
}
