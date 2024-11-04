using DSOO_PI_ComC_Grupo12.Controllers;
using DSOO_PI_ComC_Grupo12.Interfaces;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarEmpleado : Form, IRegistrar
    {
        private readonly RegistrarEmpleadoController _registrarEmpleadoController;

        public RegistrarEmpleado()
        {
            InitializeComponent();
            _registrarEmpleadoController = new RegistrarEmpleadoController();
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            _registrarEmpleadoController.Limpiar(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, dateFechaNac, txtUsuario, txtContrasenia, radioAdmin);
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos no esten vacios.
            if (!_registrarEmpleadoController.CamposValidos(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, txtUsuario, txtContrasenia))
            {
                return;
            }

            // Registra el empleado
            _registrarEmpleadoController.RegistrarEmpleado(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, dateFechaNac, txtUsuario, txtContrasenia, radioAdmin);
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdmin.Checked)
            {
                _registrarEmpleadoController.SetRol("administrador");
            }
        }

        private void RadioProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProfesor.Checked)
            {
                _registrarEmpleadoController.SetRol("profesor");
            }
        }
    }
}
