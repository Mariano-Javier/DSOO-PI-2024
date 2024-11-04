using DSOO_PI_ComC_Grupo12.Controllers;
using DSOO_PI_ComC_Grupo12.Interfaces;
using DSOO_PI_ComC_Grupo12.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarCuota : Form, IPago, ILimpiezaForm
    {
        private readonly RegistrarCuotaController _controller;

        public Cliente? ClienteSeleccionado { get; set; }
        public string FormaPago = "Efectivo";
        public Decimal TotalPagar;
        public int TipoCuota;
        public List<Actividad> actividades;
        public List<Form> ventanasAbiertas;
        public DateTime CantidadMesesPagos;
        public int MesesSeleccionados;

        public RegistrarCuota()
        {
            InitializeComponent();
            _controller = new RegistrarCuotaController(this);
            dateFechaPago.Value = DateTime.Now;
            dateDiaInicio.Value = DateTime.Now;
            CantidadMesesPagos = dateDiaInicio.Value.AddMonths(1);
            btnPagar.Enabled = false;
            btnComprobante.Enabled = false;
            btnCalcular.Enabled = false;
            TotalPagar = 0;
            comboBoxTipoSocio.SelectedIndex = 0;
            TipoCuota = 1;
            actividades = new List<Actividad>();
            ventanasAbiertas = new List<Form>();
            comboBoxMesSus.SelectedIndex = 0;
            MesesSeleccionados = 1;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            _controller.btnBuscar_Click(sender, e);
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            _controller.btnLimpiar_Click(sender, e);
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            _controller.btnCalcular_Click(sender, e);
        }

        public void btnPagar_Click(object sender, EventArgs e)
        {
            _controller.btnPagar_Click(sender, e);
        }

        public void btnComprobante_Click(object sender, EventArgs e)
        {
            _controller.btnComprobante_Click(sender, e);
        }

        public void comboBoxTipoSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.comboBoxTipoSocio_SelectedIndexChanged(sender, e);
        }

        public void comboBoxMesSus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.comboBoxMesSus_SelectedIndexChanged(sender, e);
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
