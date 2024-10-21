using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Interfaces;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarEmpleado : Form, IRegistrar
    {
        public string rol = "administrador";
        private readonly EmpleadoRepository _empleadoRepository;

        public RegistrarEmpleado()
        {
            InitializeComponent();
            _empleadoRepository = new EmpleadoRepository();
        }

        //Metodos de ayuda
        public void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dateFechaNac.Value = DateTime.Now;
            txtUsuario.Clear();
            txtContrasenia.Clear();
            ResetearRadioButtons();
        }

        private void ResetearRadioButtons()
        {
            // Restablecer el estado del botón de "Socio" a marcado
            radioAdmin.Checked = true;

            // Restablecer el valor de la variable esSocio a su valor original
            rol = "administrador";
        }

        // Verifica si hay campos vacíos
        public bool CamposVacios()
        {
            // Lista de controles a validar
            string[] campos = { txtNombre.Text, txtApellido.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text, txtUsuario.Text, txtContrasenia.Text };

            // Verifica si algún campo está vacío o con espacios
            return Validaciones.CamposVacios(campos);
        }

        // Valida todos los campos
        public bool CamposValidos()
        {
            if (CamposVacios())
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

        //fin metodos de ayuda

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos no esten vacios.
            if (!CamposValidos())
            {
                return;
            }

            // Creamos un objeto Empleado con los datos del formulario
            Empleado nuevoEmpleado = new Empleado(
                id: 0,
                nombre: txtNombre.Text,
                apellido: txtApellido.Text,
                dni: txtDNI.Text,
                mail: txtEmail.Text,
                telefono: txtTelefono.Text,
                fechaNacimiento: dateFechaNac.Value,
                rol: rol,
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
                    Limpiar();
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

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdmin.Checked)
            {
                rol = "administrador";
            }
        }

        private void RadioProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProfesor.Checked)
            {
                rol = "profesor";
            }
        }
    }
}
