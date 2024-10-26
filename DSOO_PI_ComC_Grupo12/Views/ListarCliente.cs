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
    public partial class ListarCliente : Form
    {
        public ListarCliente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTodos_MouseHover(object sender, EventArgs e)
        {
            toolTipListado.Show("Lista todos los socios registrados.",btnTodos);
        }

        private void btnProximosVen_MouseHover(object sender, EventArgs e)
        {
            toolTipListado.Show("Lista a los socios a quienes les vence la cuota en la fecha de hoy.", btnProximosVen);
        }

        private void btnSinActividad_MouseHover(object sender, EventArgs e)
        {
            toolTipListado.Show("Lista a los socios que, a la fecha de hoy, ya tienen la cuota vencida.", btnSinActividad);
        }
    }
}
