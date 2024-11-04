using DSOO_PI_ComC_Grupo12.Controllers;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class VerPrecios : Form
    {
        private readonly VerPreciosController _controller;

        public VerPrecios()
        {
            InitializeComponent();
            _controller = new VerPreciosController(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            _controller.btnCerrar_Click(sender, e);
        }

        private void VerPrecios_Load(object sender, EventArgs e)
        {
            _controller.Initialize();
        }
    }
}
