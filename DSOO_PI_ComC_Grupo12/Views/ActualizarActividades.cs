using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Controllers;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class ActualizarActividades : Form
    {
        private ActividadesController controller;

        public ActualizarActividades()
        {
            InitializeComponent();
            controller = new ActividadesController();
            controller.ConfigurarDataGridView(dataGridActividades, dataGridCuota, dataGridDescuentos);
            controller.CargarActividadesEnDataGrid(dataGridActividades);
            controller.CargarCuotasEnDataGrid(dataGridCuota);
            controller.CargarDescuentosEnDataGrid(dataGridDescuentos);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
