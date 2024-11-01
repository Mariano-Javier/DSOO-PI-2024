using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI_ComC_Grupo12.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public decimal Monto { get; set; }
        public string MedioDePago { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime PeriodoInicio { get; set; }
        public DateTime? PeriodoFin { get; set; } // Nullable para permitir valores nulos
        public bool SocioAlPagar { get; set; }
        public int? IdCuota { get; set; } // Nullable ya que puede no tener valor

        public Pago(int idCliente, decimal monto, string medioDePago, DateTime fechaPago,
                    DateTime periodoInicio, DateTime? periodoFin, bool socioAlPagar, int? idCuota = null)
        {
            IdCliente = idCliente;
            Monto = monto;
            MedioDePago = medioDePago;
            FechaPago = fechaPago;
            PeriodoInicio = periodoInicio;
            PeriodoFin = periodoFin;
            SocioAlPagar = socioAlPagar;
            IdCuota = idCuota;
        }

    }
}
