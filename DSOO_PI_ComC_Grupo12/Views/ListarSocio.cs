using DSOO_PI_ComC_Grupo12.DTO;
using DSOO_PI_ComC_Grupo12.Repositories;
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
    public partial class ListarSocio : Form
    {
        private readonly ClienteRepository _clienteRepository;
        public ListarSocio()
        {
            InitializeComponent();
            _clienteRepository = new ClienteRepository();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTodos_MouseHover(object sender, EventArgs e)
        {
            toolTipListado.Show("Lista todos los socios registrados con al menos un pago.",btnTodos);
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
            try
            {
                var socios = _clienteRepository.ObtenerSociosConPagos();
                CargarDatosEnDataGrid(socios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los socios: " + ex.Message);
            }
        }

        private void btnProximosVen_Click(object sender, EventArgs e)
        {
            try
            {
                var socios = _clienteRepository.ObtenerSociosConCuotaVencidaHoy();
                CargarDatosEnDataGrid(socios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los socios con cuota vencida hoy: " + ex.Message);
            }
        }

        private void btnSinActividad_Click(object sender, EventArgs e)
        {
            try
            {
                var socios = _clienteRepository.ObtenerSociosConCuotaVencida();
                CargarDatosEnDataGrid(socios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los socios con cuota vencida: " + ex.Message);
            }
        }

        private void CargarDatosEnDataGrid(List<SocioConPagoDTO> socios)
        {
            dataGridResumen.Rows.Clear(); // Limpiar las filas existentes

            foreach (var socio in socios)
            {
                dataGridResumen.Rows.Add(
                    socio.Id,
                    socio.Nombre,
                    socio.Apellido,
                    socio.Email,
                    socio.Telefono,
                    socio.PeriodoFin?.ToString("yyyy-MM-dd") ?? string.Empty
                );
            }
        }
    }
}
