using DSOO_PI_ComC_Grupo12.Controllers;
using DSOO_PI_ComC_Grupo12.Interfaces;
using DSOO_PI_ComC_Grupo12.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarPago : Form, IPago, ILimpiezaForm
    {
        private readonly RegistrarPagoController _controller;

        public Cliente? ClienteSeleccionado { get; set; }
        public string FormaPago = "Efectivo";
        public List<Form> ventanasAbiertas;
        public List<string> actividadesSeleccionadas;
        public Decimal TotalPagar;
        public bool EstadoPagado;

        public RegistrarPago()
        {
            InitializeComponent();
            _controller = new RegistrarPagoController(this);
            _controller.Initialize();
        }

        public void btnComprobante_Click(object sender, EventArgs e)
        {
            _controller.btnComprobante_Click(sender, e);
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            _controller.btnCerrar_Click(sender, e);
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            _controller.btnLimpiar_Click(sender, e);
        }

        public void btnPagar_Click(object sender, EventArgs e)
        {
            _controller.btnPagar_Click(sender, e);
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            _controller.btnCalcular_Click(sender, e);
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            _controller.btnBuscar_Click(sender, e);
        }

        public void radioEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            _controller.radioEfectivo_CheckedChanged(sender, e);
        }

        public void radioCuota3_CheckedChanged(object sender, EventArgs e)
        {
            _controller.radioCuota3_CheckedChanged(sender, e);
        }

        public void radioCuota6_CheckedChanged(object sender, EventArgs e)
        {
            _controller.radioCuota6_CheckedChanged(sender, e);
        }
    }
}
