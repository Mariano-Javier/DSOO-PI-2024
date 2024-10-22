using DSOO_PI_ComC_Grupo12.Models;
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
    public partial class Comprobante : Form
    {
        private Cliente? Cliente { get; set; }
        private DateTime FechaPago { get; set; }
        public Comprobante(Cliente cliente, DateTime fechaPago,String FormaPago)
        {
            InitializeComponent();
            Cliente = cliente;
            FechaPago = fechaPago;
            lblNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
            lblDNI.Text = cliente.Dni;
            lblFechaPago.Text = fechaPago.ToString("dd/MM/yyyy");
            lblFormaPago.Text = FormaPago;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
