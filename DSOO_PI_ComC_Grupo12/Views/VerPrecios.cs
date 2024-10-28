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

        public VerPrecios()
        {
            InitializeComponent();
            actividadRepository = new ActividadRepository();
            cuotaSocioRepository = new CuotaSocioRepository();
        }


        private void CargarDatosActividades()
        {
            List<(int Id, string Nombre, decimal Precio)> preciosActividades = actividadRepository.ObtenerPreciosActividades();

            foreach (var actividad in preciosActividades)
            {
                dataGridActividades.Rows.Add(actividad.Id, actividad.Nombre, actividad.Precio);
            }
        }

        private void CargarDatosCuotas()
        {
            List<(int Id, string Descripcion, decimal Monto)> preciosCuotas = cuotaSocioRepository.ObtenerPreciosCuotas();

            foreach (var cuota in preciosCuotas)
            {
                dataGridCuota.Rows.Add(cuota.Id, cuota.Descripcion, cuota.Monto);
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
        }
    }
}
