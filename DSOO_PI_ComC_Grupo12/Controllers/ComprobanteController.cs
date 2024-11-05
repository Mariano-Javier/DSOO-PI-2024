using DSOO_PI_ComC_Grupo12.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class ComprobanteController
    {

        private PrintDocument printdoc1;
        private PrintPreviewDialog previewdlg;
        private Bitmap MemoryImage;

        public ComprobanteController()
        {
            printdoc1 = new PrintDocument();
            previewdlg = new PrintPreviewDialog();

            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
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
            // captura el panel a imprimir
            GetPrintArea(panelComprobante);

            // Set up  preview dialog y lo muestra
            previewdlg.Document = printdoc1;
            previewdlg.ShowDialog();
        }
        private void GetPrintArea(Panel panel)
        {
            MemoryImage = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(MemoryImage, new Rectangle(0, 0, panel.Width, panel.Height));
        }
        private void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;

            // Centro la imagen en el medio de la pagina
            int x = (pageArea.Width / 2) - (MemoryImage.Width / 2);
            int y = (pageArea.Height / 2) - (MemoryImage.Height / 2);

            e.Graphics.DrawImage(MemoryImage, x, y);
        }

        public PrintDocument GetPrintDocument()
        {
            return printdoc1;
        }
    }
}
