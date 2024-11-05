using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using DSOO_PI_ComC_Grupo12.Utils;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class CarnetController
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly PagoRepository _pagoRepository;
        private readonly PrintUtility _printUtility;

        public CarnetController()
        {
            _clienteRepository = new ClienteRepository();
            _pagoRepository = new PagoRepository();
            _printUtility = new PrintUtility();
        }

        public void LimpiarCarnet(Panel panelCarnet, Label lblNombreApellidoCarnet, Label lblIdCarnet, Label lblDniCarnet, Label lblTelCarnet, Label lblEmailCarnet, Label lblVencimiento, Label lblEsApto, Button btnImprimir, Label lblEstadoCarnet)
        {
            panelCarnet.BackgroundImage = Properties.Resources.blank;
            lblNombreApellidoCarnet.ForeColor = Color.White;
            lblIdCarnet.ForeColor = Color.White;
            lblDniCarnet.ForeColor = Color.White;
            lblTelCarnet.ForeColor = Color.White;
            lblEmailCarnet.ForeColor = Color.White;
            lblVencimiento.ForeColor = Color.White;
            lblEsApto.ForeColor = Color.White;
            btnImprimir.Enabled = false;
            lblEstadoCarnet.Text = string.Empty;
        }

        public void CarnetSocio(Panel panelCarnet, Label lblNombreApellidoCarnet, Label lblIdCarnet, Label lblDniCarnet, Label lblTelCarnet, Label lblEmailCarnet, Label lblVencimiento, Label lblEsApto)
        {
            panelCarnet.BackgroundImage = Properties.Resources.BCSoc;
            lblNombreApellidoCarnet.ForeColor = Color.NavajoWhite;
            lblIdCarnet.ForeColor = Color.NavajoWhite;
            lblDniCarnet.ForeColor = Color.NavajoWhite;
            lblTelCarnet.ForeColor = Color.NavajoWhite;
            lblEmailCarnet.ForeColor = Color.NavajoWhite;
            lblVencimiento.ForeColor = Color.NavajoWhite;
            lblEsApto.ForeColor = Color.NavajoWhite;
        }

        public void CarnetComun(Panel panelCarnet, Label lblNombreApellidoCarnet, Label lblIdCarnet, Label lblDniCarnet, Label lblTelCarnet, Label lblEmailCarnet, Label lblEsApto)
        {
            panelCarnet.BackgroundImage = Properties.Resources.BSNOsocio;
            lblNombreApellidoCarnet.ForeColor = Color.Black;
            lblIdCarnet.ForeColor = Color.Black;
            lblDniCarnet.ForeColor = Color.Black;
            lblTelCarnet.ForeColor = Color.Black;
            lblEmailCarnet.ForeColor = Color.Black;
            lblEsApto.ForeColor = Color.Black;
        }

        public Cliente? BuscarCliente(string input, bool esId)
        {
            if (esId)
            {
                if (int.TryParse(input, out int clienteId))
                {
                    return _clienteRepository.BuscarClientePorId(clienteId);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return _clienteRepository.BuscarClientePorDni(input);
            }
        }

        public bool ClienteHaPagado(int clienteId)
        {
            return _pagoRepository.ClienteHaPagado(clienteId);
        }

        public DateTime? ObtenerPeriodoFin(int clienteId)
        {
            return _pagoRepository.ObtenerPeriodoFin(clienteId);
        }

        public void GenerarCarnet(Cliente cliente, DateTime fechaHoy, Panel panelCarnet, Label lblNombreApellidoCarnet, Label lblIdCarnet, Label lblDniCarnet, Label lblTelCarnet, Label lblEmailCarnet, Label lblVencimiento, Label lblEsApto, Button btnImprimir, Label lblEstadoCarnet)
        {
            DateTime? periodoFin = ObtenerPeriodoFin(cliente.Id);

            if (cliente.EsSocio)
            {
                // Generar tarjeta gold
                lblNombreApellidoCarnet.Text = cliente.Nombre + " " + cliente.Apellido;
                lblIdCarnet.Text = "ID: " + cliente.Id.ToString();
                lblDniCarnet.Text = "DNI: " + cliente.Dni;
                lblTelCarnet.Text = "Tel: " + cliente.Telefono;
                lblEmailCarnet.Text = cliente.Email;
                lblVencimiento.Text = periodoFin.HasValue ? "Vencimiento: " + periodoFin.Value.ToString("dd/MM/yyyy") : "Vencimiento: No disponible";

                if (cliente.EsApto)
                {
                    lblEsApto.Text = "Apto Físico: Si";
                }
                else
                {
                    lblEsApto.Text = "Apto Físico: No";
                }

                CarnetSocio(panelCarnet, lblNombreApellidoCarnet, lblIdCarnet, lblDniCarnet, lblTelCarnet, lblEmailCarnet, lblVencimiento, lblEsApto);
                btnImprimir.Enabled = true;

                if (periodoFin.HasValue && periodoFin.Value < fechaHoy)
                {
                    lblEstadoCarnet.Text = "CARNET VENCIDO";
                    lblEstadoCarnet.ForeColor = Color.Red;
                }
                else
                {
                    lblEstadoCarnet.Text = "CARNET ACTIVO";
                    lblEstadoCarnet.ForeColor = Color.Green;
                }
            }
            else
            {
                // Generar tarjeta común
                lblNombreApellidoCarnet.Text = cliente.Nombre + " " + cliente.Apellido;
                lblIdCarnet.Text = "ID: " + cliente.Id.ToString();
                lblDniCarnet.Text = "DNI: " + cliente.Dni;
                lblTelCarnet.Text = "Tel: " + cliente.Telefono;
                lblEmailCarnet.Text = cliente.Email;
                if (cliente.EsApto)
                {
                    lblEsApto.Text = "Apto Físico: Si";
                }
                else
                {
                    lblEsApto.Text = "Apto Físico: No";
                }
                CarnetComun(panelCarnet, lblNombreApellidoCarnet, lblIdCarnet, lblDniCarnet, lblTelCarnet, lblEmailCarnet, lblEsApto);
                btnImprimir.Enabled = true;
            }
        }

        public void ImprimirCarnet(Panel panelCarnet)
        {
            _printUtility.Imprimir(panelCarnet);
        }
        public PrintDocument GetPrintDocument()
        {
            return _printUtility.GetPrintDocument();
        }
    }
}
