using DSOO_PI_ComC_Grupo12.Controllers;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarActividad : Form
    {
        private readonly RegistrarActividadController _registrarActividadController;

        public RegistrarActividad()
        {
            InitializeComponent();
            _registrarActividadController = new RegistrarActividadController();
            _registrarActividadController.CargarActividadesEnDataGrid(dataGridActividades);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            _registrarActividadController.RegistrarActividad(txtNombre, txtPrecio, dataGridActividades);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _registrarActividadController.Limpiar(txtNombre, txtPrecio);
        }
    }
}
