using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Helpers
{
    public static class FormHelper
    {
        public static Form activeForm = null;

        public static void OpenChildFormInPanel(Form childForm, Panel panelContenedor)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}