using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Interfaces;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class MenuPrincipal : Form
    {
        private Login _login;

        public MenuPrincipal(Login login, string nombre, string apellido, string email, string rol)
        {
            InitializeComponent();
            _login = login; // Guardamos la referencia al login

            // Asignamos los datos a los labels
            lblNombreAdmin.Text = nombre + " " + apellido;
            lblMailAdmin.Text = email;
            lblRol.Text = rol;

            hideSubMenu(panelRegistrosSM);
            hideSubMenu(panelConsultasSM);
            hideSubMenu(panelPagosSM);
            hideSubMenu(panelActualizarSM);
        }

        //Oculto todos los sub-menu de la barra de menus izquierda
        private void hideSubMenu(Panel subPanel)
        {
            subPanel.Visible = false;
        }
        //fin oculto sub-menu

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            _login.Show();
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            if (FormHelper.activeForm != null)
            {
                FormHelper.activeForm.Close();
            }
            hideSubMenu(panelConsultasSM);
            hideSubMenu(panelPagosSM);
            hideSubMenu(panelActualizarSM);
            showSubMenu(panelRegistrosSM);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            if (FormHelper.activeForm != null)
            {
                FormHelper.activeForm.Close();
            }
            hideSubMenu(panelRegistrosSM);
            hideSubMenu(panelPagosSM);
            hideSubMenu(panelActualizarSM);
            showSubMenu(panelConsultasSM);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            if (FormHelper.activeForm != null)
            {
                FormHelper.activeForm.Close();
            }
            hideSubMenu(panelRegistrosSM);
            hideSubMenu(panelConsultasSM);
            hideSubMenu(panelActualizarSM);
            showSubMenu(panelPagosSM);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (FormHelper.activeForm != null)
            {
                FormHelper.activeForm.Close();
            }
            hideSubMenu(panelRegistrosSM);
            hideSubMenu(panelConsultasSM);
            hideSubMenu(panelPagosSM);
            showSubMenu(panelActualizarSM);
        }
        private void picLogOut_MouseLeave(object sender, EventArgs e)
        {
            picLogOut.Image = Properties.Resources.log_off40;
        }

        private void picLogOut_MouseHover(object sender, EventArgs e)
        {
            picLogOut.Image = Properties.Resources.log_off340;
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            IRegistrar formulario = new RegistrarCliente();
            FormHelper.OpenChildFormInPanel((Form)formulario, panelContenedor);
        }

        private void btnNoSocios_Click(object sender, EventArgs e)
        {
            FormHelper.OpenChildFormInPanel(new RegistrarPago(), panelContenedor);
        }

        private void btnCuotaSocios_Click(object sender, EventArgs e)
        {
            FormHelper.OpenChildFormInPanel(new RegistrarCuota(), panelContenedor);
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            FormHelper.OpenChildFormInPanel(new Carnet(), panelContenedor);
        }

        private void btnListarSocios_Click(object sender, EventArgs e)
        {
            FormHelper.OpenChildFormInPanel(new ListarSocio(), panelContenedor);
        }

        private void lblPrecios_Click(object sender, EventArgs e)
        {
            FormHelper.OpenChildFormInPanel(new VerPrecios(), panelContenedor);
        }

        private void btnRegistrarActividad_Click(object sender, EventArgs e)
        {
            FormHelper.OpenChildFormInPanel(new RegistrarActividad(), panelContenedor);
        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            FormHelper.OpenChildFormInPanel(new ActualizarCliente(), panelContenedor);
        }
    }
}
