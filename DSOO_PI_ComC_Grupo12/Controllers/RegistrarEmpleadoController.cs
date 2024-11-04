using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class RegistrarEmpleadoController
    {
        private readonly EmpleadoRepository _empleadoRepository;
        private string _rol = "administrador";

        public RegistrarEmpleadoController()
        {
            _empleadoRepository = new EmpleadoRepository();
        }

        public void Limpiar(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono, DateTimePicker dateFechaNac, TextBox txtUsuario, TextBox txtContrasenia, RadioButton radioAdmin)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dateFechaNac.Value = DateTime.Now;
            txtUsuario.Clear();
            txtContrasenia.Clear();
            ResetearRadioButtons(radioAdmin);
        }

        private void ResetearRadioButtons(RadioButton radioAdmin)
        {
            // Restablecer el estado del botón de "Socio" a marcado
            radioAdmin.Checked = true;

            // Restablecer el valor de la variable esSocio a su valor original
            _rol = "administrador";
        }

        public bool CamposVacios(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono, TextBox txtUsuario, TextBox txtContrasenia)
        {
            // Lista de controles a validar
            string[] campos = { txtNombre.Text, txtApellido.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text, txtUsuario.Text, txtContrasenia.Text };

            // Verifica si algún campo está vacío o con espacios
            return Validaciones.CamposVacios(campos);
        }

        public bool CamposValidos(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono, TextBox txtUsuario, TextBox txtContrasenia)
        {
            if (CamposVacios(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, txtUsuario, txtContrasenia))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            if (!Validaciones.EmailValido(txtEmail.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.");
                return false;
            }
            return true;
        }

        public void RegistrarEmpleado(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono, DateTimePicker dateFechaNac, TextBox txtUsuario, TextBox txtContrasenia, RadioButton radioAdmin)
        {
            // Creamos un objeto Empleado con los datos del formulario
            Empleado nuevoEmpleado = new Empleado(
                id: 0,
                nombre: txtNombre.Text,
                apellido: txtApellido.Text,
                dni: txtDNI.Text,
                mail: txtEmail.Text,
                telefono: txtTelefono.Text,
                fechaNacimiento: dateFechaNac.Value,
                rol: _rol,
                usuario: txtUsuario.Text,
                contrasenia: txtContrasenia.Text
            );

            try
            {
                // Verifica si ya existe el usuario
                if (_empleadoRepository.ExisteUsuario(nuevoEmpleado.Usuario))
                {
                    MessageBox.Show("Ya existe ese nombre de usuario registrado.");
                    return;
                }

                // Registra el empleado
                long ultimoId = _empleadoRepository.RegistrarEmpleado(nuevoEmpleado);
                if (ultimoId > 0)
                {
                    MessageBox.Show($"Empleado registrado exitosamente. El ID del empleado es {ultimoId}.");
                    Limpiar(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, dateFechaNac, txtUsuario, txtContrasenia, radioAdmin);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el empleado: " + ex.Message);
            }
        }

        public void SetRol(string rol)
        {
            _rol = rol;
        }
    }
}
