using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class VerPrecios : Form
    {
        private ActividadRepository actividadRepository;
        private CuotaSocioRepository cuotaSocioRepository;
        private DescuentosRepository descuentosRepository;

        public VerPrecios()
        {
            InitializeComponent();
            actividadRepository = new ActividadRepository();
            cuotaSocioRepository = new CuotaSocioRepository();
            descuentosRepository = new DescuentosRepository();
        }

        private void CargarDatosActividades()
        {
            List<Actividad> actividades = actividadRepository.ObtenerActividades();

            foreach (var actividad in actividades)
            {
                dataGridActividades.Rows.Add(actividad.Id, actividad.Nombre, actividad.Precio);
            }
        }

        private void CargarDatosCuotas()
        {
            List<Cuota> preciosCuotas = cuotaSocioRepository.ObtenerPreciosCuotas();

            foreach (var cuota in preciosCuotas)
            {
                dataGridCuota.Rows.Add(cuota.Id, cuota.Descripcion, cuota.Monto);
            }
        }

        private void CargarDatosDescuentos()
        {
            List<Descuento> descuentos = descuentosRepository.ObtenerDescuentos();

            foreach (var descuento in descuentos)
            {
                // Convertir el valor de descuento a porcentaje
                decimal porcentajeDescuento = descuento.ValorDescuento * 100;

                // Formatear el porcentaje para eliminar los ceros decimales
                string porcentajeFormateado = porcentajeDescuento.ToString("0.##") + "%";

                // Agregar los datos al DataGridView con el porcentaje formateado
                dataGridDescuento.Rows.Add(descuento.Id, descuento.TipoPago, porcentajeFormateado);
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VerPrecios_Load(object sender, EventArgs e)
        {
            CargarDatosActividades();
            CargarDatosCuotas();
            CargarDatosDescuentos();
        }
    }
}
