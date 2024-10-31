using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI_ComC_Grupo12.Interfaces
{
    internal interface IPago
    {
        void btnPagar_Click(object sender, EventArgs e);
        void btnComprobante_Click(object sender, EventArgs e);
        void btnCalcular_Click(object sender, EventArgs e);

    }
}
