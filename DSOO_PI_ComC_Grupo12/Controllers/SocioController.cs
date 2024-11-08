using DSOO_PI_ComC_Grupo12.DTO;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class SocioController
    {
        private readonly ClienteRepository _clienteRepository;

        public SocioController()
        {
            _clienteRepository = new ClienteRepository();
        }

        public List<SocioConPagoDTO> ObtenerSociosConPagos()
        {
            return _clienteRepository.ObtenerSociosConPagos();
        }

        public List<SocioConPagoDTO> ObtenerSociosConCuotaVencidaHoy()
        {
            return _clienteRepository.ObtenerSociosConCuotaVencidaHoy();
        }

        public List<SocioConPagoDTO> ObtenerSociosConCuotaVencida()
        {
            return _clienteRepository.ObtenerSociosConCuotaVencida();
        }

        public void CargarSocios(Func<List<SocioConPagoDTO>> obtenerSocios, DataGridView dataGrid)
        {
            try
            {
                var socios = obtenerSocios();
                CargarDatosEnDataGrid(socios, dataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los socios: " + ex.Message);
            }
        }

        public void CargarDatosEnDataGrid(List<SocioConPagoDTO> socios, DataGridView dataGrid)
        {
            dataGrid.Rows.Clear(); // Limpiar las filas existentes

            foreach (var socio in socios)
            {
                dataGrid.Rows.Add(
                    socio.Id,
                    socio.Nombre,
                    socio.Apellido,
                    socio.Email,
                    socio.Telefono,
                    socio.PeriodoFin?.ToString("dd-MM-yyyy") ?? string.Empty
                );
            }
        }
    }
}
