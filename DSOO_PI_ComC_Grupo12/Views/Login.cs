using DSOO_PI_ComC_Grupo12.Repositories;
using DSOO_PI_ComC_Grupo12.Helpers;
using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Interfaces;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class Login : Form
    {
        private readonly AutenticacionRepository _autenticacionRepository;

        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MenuPrincipal_KeyDown);
            _autenticacionRepository = new AutenticacionRepository();
        }

        // Este apartado es para que hacer click en enter simule el click del botón
        private void MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();  // Simula el click del botón
            }
        }

        //Cambiar  iconos
        private void btnConfigBD_MouseHover(object sender, EventArgs e)
        {
            btnConfigBD.Image = Properties.Resources.settingsV235g;
        }

        private void btnConfigBD_MouseLeave(object sender, EventArgs e)
        {
            btnConfigBD.Image = Properties.Resources.settingsV235;
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            btnInfo.Image = Properties.Resources.information35g;
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            btnInfo.Image = Properties.Resources.information35;
        }
        //Fin Cambiar  iconos

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Cambia la visibilidad de la contraseña al clickear la imagen del candado
        private void picContrasenia_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtContrasenia.UseSystemPasswordChar == true)
            {
                txtContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void btnConfigBD_Click(object sender, EventArgs e)
        {
            FormHelper.OpenChildFormInPanel(new ConfigurarBD(), panelLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, apellido, email, rol;
                if (_autenticacionRepository.AutenticarUsuario(txtUsuario.Text, txtContrasenia.Text, out nombre, out apellido, out email, out rol))
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal(this, nombre, apellido, email, rol);
                    menuPrincipal.Show();
                    this.Hide();
                    txtUsuario.Clear();
                    txtContrasenia.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                    txtUsuario.Clear();
                    txtContrasenia.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void linkNuevoRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IRegistrar formulario = new RegistrarEmpleado();
            FormHelper.OpenChildFormInPanel((Form)formulario, panelLogin);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormHelper.OpenChildFormInPanel(new About(), panelLogin);
        }
    }
}
