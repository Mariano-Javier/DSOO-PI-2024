using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Services;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class ConfigurarBDController
    {
        public void Initialize(TextBox txtNombreBD, TextBox txtServidor, TextBox txtPuerto, TextBox txtUsuario, TextBox txtContrasenia)
        {
            // Cargar la configuración desde el archivo JSON
            ConfiguracionBD.CargarConfiguracion();

            // Devuelvo los valores de la clase ConfiguracionBD y los pongo en el formulario.
            txtNombreBD.Text = ConfiguracionBD.NombreBase;
            txtServidor.Text = ConfiguracionBD.Servidor;
            txtPuerto.Text = ConfiguracionBD.Puerto;
            txtUsuario.Text = ConfiguracionBD.Usuario;
            txtContrasenia.Text = ConfiguracionBD.Contrasenia;
        }

        public bool CamposVacios(TextBox txtNombreBD, TextBox txtServidor, TextBox txtPuerto, TextBox txtUsuario)
        {
            // Validamos cada campo y mostramos qué campo está vacío
            if (string.IsNullOrWhiteSpace(txtNombreBD.Text))
            {
                MessageBox.Show("El campo Base de Datos está vacío.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtServidor.Text))
            {
                MessageBox.Show("El campo Servidor está vacío.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtPuerto.Text))
            {
                MessageBox.Show("El campo Puerto está vacío.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo Usuario está vacío.");
                return true;
            }
            // No validamos si la contraseña está vacía porque se acepta que puede estar vacía
            return false; // Si todos los campos obligatorios están completos, devolvemos false
        }

        public void GuardarConfiguracion(TextBox txtNombreBD, TextBox txtServidor, TextBox txtPuerto, TextBox txtUsuario, TextBox txtContrasenia)
        {
            // Guardamos los datos de configuración en la clase estática ConfiguracionBD
            ConfiguracionBD.NombreBase = txtNombreBD.Text;
            ConfiguracionBD.Servidor = txtServidor.Text;
            ConfiguracionBD.Puerto = txtPuerto.Text;
            ConfiguracionBD.Usuario = txtUsuario.Text;
            ConfiguracionBD.Contrasenia = txtContrasenia.Text; // Si está vacío, se guarda como cadena vacía ("") y se acepta.

            // Guardamos la configuración en el archivo JSON
            ConfiguracionBD.GuardarConfiguracion();

            // Reiniciamos la instancia de Conexion para que tome los nuevos valores
            Conexion.ResetInstancia();

            MessageBox.Show("Configuración guardada exitosamente.");
        }
    }
}
