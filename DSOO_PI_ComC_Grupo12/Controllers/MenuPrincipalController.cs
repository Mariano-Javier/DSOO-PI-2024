using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Interfaces;
using DSOO_PI_ComC_Grupo12.Views;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class MenuPrincipalController
    {
        private readonly Login _login;
        private readonly Panel _panelContenedor;
        private readonly Panel _panelRegistrosSM;
        private readonly Panel _panelConsultasSM;
        private readonly Panel _panelPagosSM;
        private readonly Panel _panelActualizarSM;

        public MenuPrincipalController(Login login, Panel panelContenedor, Panel panelRegistrosSM, Panel panelConsultasSM, Panel panelPagosSM, Panel panelActualizarSM)
        {
            _login = login;
            _panelContenedor = panelContenedor;
            _panelRegistrosSM = panelRegistrosSM;
            _panelConsultasSM = panelConsultasSM;
            _panelPagosSM = panelPagosSM;
            _panelActualizarSM = panelActualizarSM;
        }

        public void Initialize(string nombre, string apellido, string email, string rol, Label lblNombreAdmin, Label lblMailAdmin, Label lblRol)
        {
            lblNombreAdmin.Text = nombre + " " + apellido;
            lblMailAdmin.Text = email;
            lblRol.Text = rol;

            hideSubMenu(_panelRegistrosSM);
            hideSubMenu(_panelConsultasSM);
            hideSubMenu(_panelPagosSM);
            hideSubMenu(_panelActualizarSM);
        }

        public void HandleLogOut(Form menuPrincipal)
        {
            _login.Show();
            menuPrincipal.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void HandleClose()
        {
            Application.Exit();
        }

        public void HandleSubMenuClick(Panel[] panelsToHide, Panel panelToShow)
        {
            if (FormHelper.activeForm != null)
            {
                FormHelper.activeForm.Close();
            }

            foreach (var panel in panelsToHide)
            {
                hideSubMenu(panel);
            }

            showSubMenu(panelToShow);
        }

        public void HandleButtonClick(object formulario)
        {
            if (formulario is IRegistrar registrarForm)
            {
                FormHelper.OpenChildFormInPanel((Form)registrarForm, _panelContenedor);
            }
            else if (formulario is Form form)
            {
                FormHelper.OpenChildFormInPanel(form, _panelContenedor);
            }
            else
            {
                throw new ArgumentException("El formulario debe implementar IRegistrar o ser de tipo Form");
            }
        }

        private void hideSubMenu(Panel subPanel)
        {
            subPanel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
    }
}
