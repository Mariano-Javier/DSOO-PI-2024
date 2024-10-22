using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI_ComC_Grupo12.Models
{
    public class Empleado : Persona
    {
        // Atributo adicional
        public String Rol { get; set; }
        public String Usuario { get; set; }
        public String Contrasenia { get; set; }
        public Empleado(int id, string nombre, string apellido, string dni, string mail, string telefono, DateTime fechaNacimiento, string rol, string usuario, string contrasenia) : base(id, nombre, apellido, dni, mail, telefono, fechaNacimiento)
        {
            Rol = rol;
            Usuario = usuario;
            Contrasenia = contrasenia;
        }
    }
}
