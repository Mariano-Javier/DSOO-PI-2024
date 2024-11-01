using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI_ComC_Grupo12.Config
{
    public static class ConfiguracionDescuentos
    {
        public static decimal Tarjeta3Cuotas { get; set; } = 0.10m;  // 10% por defecto
        public static decimal Tarjeta6Cuotas { get; set; } = 0.05m;  // 5% por defecto
        public static decimal Efectivo { get; set; } = 0.20m;        // 20% por defecto
    }
}
