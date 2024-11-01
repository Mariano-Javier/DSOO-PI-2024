using System;
using DSOO_PI_ComC_Grupo12.Config;

namespace DSOO_PI_ComC_Grupo12.Utils
{
    public static class DescuentoUtils
    {
        public static (decimal TotalConDescuento, decimal MontoDescuento) TotalDescuento(decimal Total, string FormaPago)
        {
            decimal TotalConDescuento = Total;
            decimal MontoDescuento = 0m;

            // Calcula el descuento según el tipo de forma de pago
            if (FormaPago == "Tarjeta en 3 cuotas")
            {
                MontoDescuento = Math.Round(Total * ConfiguracionDescuentos.Tarjeta3Cuotas, 2);
                TotalConDescuento = Math.Round(Total - MontoDescuento, 2);
            }
            else if (FormaPago == "Tarjeta en 6 cuotas")
            {
                MontoDescuento = Math.Round(Total * ConfiguracionDescuentos.Tarjeta6Cuotas, 2);
                TotalConDescuento = Math.Round(Total - MontoDescuento, 2);
            }
            else if (FormaPago == "Efectivo")
            {
                MontoDescuento = Math.Round(Total * ConfiguracionDescuentos.Efectivo, 2);
                TotalConDescuento = Math.Round(Total - MontoDescuento, 2);
            }
            else
            {
                throw new ArgumentException("Forma de pago no reconocida");
            }

            return (TotalConDescuento, MontoDescuento);
        }
    }
}
