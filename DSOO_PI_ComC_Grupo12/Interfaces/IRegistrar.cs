using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Interfaces
{
    public interface IRegistrar
    {
        void Limpiar();
        bool CamposVacios();
        bool CamposValidos();
        void btnCerrar_Click(object sender, EventArgs e);
        void btnLimpiar_Click(object sender, EventArgs e);
        void btnRegistrar_Click(object sender, EventArgs e);
    }
}
