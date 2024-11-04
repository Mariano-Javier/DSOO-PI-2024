using DSOO_PI_ComC_Grupo12.Controllers;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class ListarSocio : Form
    {
        private readonly SocioController _socioController;

        public ListarSocio()
        {
            InitializeComponent();
            _socioController = new SocioController();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTodos_MouseHover(object sender, EventArgs e)
        {
            toolTipListado.Show("Lista todos los socios registrados con al menos un pago.", btnTodos);
        }

        private void btnProximosVen_MouseHover(object sender, EventArgs e)
        {
            toolTipListado.Show("Lista a los socios a quienes les vence la cuota en la fecha de hoy.", btnProximosVen);
        }

        private void btnSinActividad_MouseHover(object sender, EventArgs e)
        {
            toolTipListado.Show("Lista a los socios que, a la fecha de hoy, ya tienen la cuota vencida.", btnSinActividad);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            _socioController.CargarSocios(_socioController.ObtenerSociosConPagos, dataGridResumen);
        }

        private void btnProximosVen_Click(object sender, EventArgs e)
        {
            _socioController.CargarSocios(_socioController.ObtenerSociosConCuotaVencidaHoy, dataGridResumen);
        }

        private void btnSinActividad_Click(object sender, EventArgs e)
        {
            _socioController.CargarSocios(_socioController.ObtenerSociosConCuotaVencida, dataGridResumen);
        }
    }
}
