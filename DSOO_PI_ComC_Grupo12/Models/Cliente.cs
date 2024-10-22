using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI_ComC_Grupo12.Models
{
    public class Cliente : Persona
    {
        // Atributo adicional
        public bool EsSocio { get; set; }
        public bool EsApto { get; set; }

        // Constructor con parámetros
        public Cliente(int id, string nombre, string apellido, string dni, string mail, string telefono, DateTime fechaNacimiento, bool esSocio, bool esApto)
            : base(id, nombre, apellido, dni, mail, telefono, fechaNacimiento)
        {
            EsSocio = esSocio;
            EsApto = esApto;
        }
    }
}
