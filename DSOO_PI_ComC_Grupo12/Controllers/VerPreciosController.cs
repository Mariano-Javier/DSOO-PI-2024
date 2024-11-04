using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using DSOO_PI_ComC_Grupo12.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class VerPreciosController
    {
        private readonly VerPrecios _view;
        private readonly ActividadRepository _actividadRepository;
        private readonly CuotaSocioRepository _cuotaSocioRepository;
        private readonly DescuentosRepository _descuentosRepository;

        public VerPreciosController(VerPrecios view)
        {
            _view = view;
            _actividadRepository = new ActividadRepository();
            _cuotaSocioRepository = new CuotaSocioRepository();
            _descuentosRepository = new DescuentosRepository();
        }

        public void Initialize()
        {
            CargarDatosActividades();
            CargarDatosCuotas();
            CargarDatosDescuentos();
        }

        public void CargarDatosActividades()
        {
            List<Actividad> actividades = _actividadRepository.ObtenerActividades();

            foreach (var actividad in actividades)
            {
                _view.dataGridActividades.Rows.Add(actividad.Id, actividad.Nombre, actividad.Precio);
            }
        }

        public void CargarDatosCuotas()
        {
            List<Cuota> preciosCuotas = _cuotaSocioRepository.ObtenerPreciosCuotas();

            foreach (var cuota in preciosCuotas)
            {
                _view.dataGridCuota.Rows.Add(cuota.Id, cuota.Descripcion, cuota.Monto);
            }
        }

        public void CargarDatosDescuentos()
        {
            List<Descuento> descuentos = _descuentosRepository.ObtenerDescuentos();

            foreach (var descuento in descuentos)
            {
                // Convertir el valor de descuento a porcentaje
                decimal porcentajeDescuento = descuento.ValorDescuento * 100;

                // Formatear el porcentaje para eliminar los ceros decimales
                string porcentajeFormateado = porcentajeDescuento.ToString("0.##") + "%";

                // Agregar los datos al DataGridView con el porcentaje formateado
                _view.dataGridDescuento.Rows.Add(descuento.Id, descuento.TipoPago, porcentajeFormateado);
            }
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            _view.Close();
        }
    }
}
