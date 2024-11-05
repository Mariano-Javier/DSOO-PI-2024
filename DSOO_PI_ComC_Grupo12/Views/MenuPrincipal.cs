using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Controllers;
using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Interfaces;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class MenuPrincipal : Form
    {
        private readonly MenuPrincipalController _menuPrincipalController;

        public MenuPrincipal(Login login, string nombre, string apellido, string email, string rol)
        {
            InitializeComponent();
            _menuPrincipalController = new MenuPrincipalController(login, panelContenedor, panelRegistrosSM, panelConsultasSM, panelPagosSM, panelActualizarSM);
            _menuPrincipalController.Initialize(nombre, apellido, email, rol, lblNombreAdmin, lblMailAdmin, lblRol);
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleLogOut(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleClose();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleSubMenuClick(new Panel[] { panelConsultasSM, panelPagosSM, panelActualizarSM }, panelRegistrosSM);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleSubMenuClick(new Panel[] { panelRegistrosSM, panelPagosSM, panelActualizarSM }, panelConsultasSM);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleSubMenuClick(new Panel[] { panelRegistrosSM, panelConsultasSM, panelActualizarSM }, panelPagosSM);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleSubMenuClick(new Panel[] { panelRegistrosSM, panelConsultasSM, panelPagosSM }, panelActualizarSM);
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
            _menuPrincipalController.HandleButtonClick(new RegistrarCliente());
        }

        private void btnNoSocios_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleButtonClick(new RegistrarPago());
        }

        private void btnCuotaSocios_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleButtonClick(new RegistrarCuota());
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleButtonClick(new Carnet());
        }

        private void btnListarSocios_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleButtonClick(new ListarSocio());
        }

        private void lblPrecios_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleButtonClick(new VerPrecios());
        }

        private void btnRegistrarActividad_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleButtonClick(new RegistrarActividad());
        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleButtonClick(new ActualizarCliente());
        }

        private void btnActualizarActividades_Click(object sender, EventArgs e)
        {
            _menuPrincipalController.HandleButtonClick(new ActualizarActividades());
        }
    }
}
