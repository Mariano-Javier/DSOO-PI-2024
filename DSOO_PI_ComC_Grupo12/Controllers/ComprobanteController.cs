using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Utils;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class ComprobanteController
    {
        private readonly PrintUtility _printUtility;

        public ComprobanteController()
        {
            _printUtility = new PrintUtility();
        }

        public void CargarDataGridViewNS(List<Actividad> actividades, DataGridView dataGridResumen, DataGridView dataGridFechas, DateTime fechaInicio)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridResumen.Rows.Clear();
            dataGridFechas.Rows.Clear();

            // Iterar a través de la lista de actividades y agregar filas al DataGridView
            foreach (var actividad in actividades)
            {
                dataGridResumen.Rows.Add(actividad.Nombre, actividad.Precio);
            }

            dataGridFechas.Rows.Add(fechaInicio.ToString("dd/MM/yyyy"), "Válido solo por el día abonado");
        }

        public void CargarDataGridViewS(List<Actividad> actividades, DataGridView dataGridResumen, DataGridView dataGridFechas, DateTime fechaInicio, DateTime fechaFin)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridResumen.Rows.Clear();
            dataGridFechas.Rows.Clear();

            // Iterar a través de la lista de actividades y agregar filas al DataGridView
            foreach (var actividad in actividades)
            {
                dataGridResumen.Rows.Add(actividad.Nombre, actividad.Precio);
            }

            dataGridFechas.Rows.Add(fechaInicio.ToString("dd/MM/yyyy"), fechaFin.ToString("dd/MM/yyyy"));
        }

        public void ImprimirComprobante(Panel panelComprobante)
        {
            _printUtility.Imprimir(panelComprobante);
        }

        public PrintDocument GetPrintDocument()
        {
            return _printUtility.GetPrintDocument();
        }
    }
}
