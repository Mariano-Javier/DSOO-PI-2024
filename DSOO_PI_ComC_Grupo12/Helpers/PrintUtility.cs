using System;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Helpers
{
    public class PrintUtility
    {
        private PrintDocument printdoc1;
        private PrintPreviewDialog previewdlg;
        private Bitmap MemoryImage;

        public PrintUtility()
        {
            printdoc1 = new PrintDocument();
            previewdlg = new PrintPreviewDialog();

            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
        }

        public void Imprimir(Panel panel)
        {
            // captura el panel a imprimir
            GetPrintArea(panel);

            // Set up  preview dialog y lo muestra
            previewdlg.Document = printdoc1;
            // Centra el print dialog en la pantalla
            Form previewForm = (Form)previewdlg;
            previewForm.StartPosition = FormStartPosition.CenterScreen;
            // muestra el preview dialog
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

            // Centro la imagen horizontalmente en el medio de la pagina
            int x = (pageArea.Width / 2) - (MemoryImage.Width / 2);

            // Coloco la imagen en la parte superior de la hoja con un margen de 10 unidades
            int y = 10;

            e.Graphics.DrawImage(MemoryImage, x, y);
        }

        public PrintDocument GetPrintDocument()
        {
            return printdoc1;
        }
    }
}
