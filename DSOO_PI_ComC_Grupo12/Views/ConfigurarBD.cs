using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Services;
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
    public partial class ConfigurarBD : Form
    {
        public ConfigurarBD()
        {
            InitializeComponent();
            //Devuelvo los valores de la clase ConfiguracionBD y los pongo en el formulario.
            txtNombreBD.Text = ConfiguracionBD.NombreBase;
            txtServidor.Text = ConfiguracionBD.Servidor;
            txtPuerto.Text = ConfiguracionBD.Puerto;
            txtUsuario.Text = ConfiguracionBD.Usuario;
            txtContrasenia.Text = ConfiguracionBD.Contrasenia;
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

        private bool CamposVacios()
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verifica que no haya campos vacíos en los campos obligatorios
            if (CamposVacios())
            {
                return; // Si hay un campo vacío, mostramos el mensaje y detenemos la ejecución
            }

            // Guardamos los datos de configuración en la clase estática ConfiguracionBD
            ConfiguracionBD.NombreBase = txtNombreBD.Text;
            ConfiguracionBD.Servidor = txtServidor.Text;
            ConfiguracionBD.Puerto = txtPuerto.Text;
            ConfiguracionBD.Usuario = txtUsuario.Text;
            ConfiguracionBD.Contrasenia = txtContrasenia.Text; // Si está vacío, se guarda como cadena vacía ("") y se acepta.

            // Reiniciamos la instancia de Conexion para que tome los nuevos valores
            Conexion.ResetInstancia();

            MessageBox.Show("Configuración guardada exitosamente.");
            this.Close(); // Cierra el formulario después de guardar los cambios
        }
    }
}
