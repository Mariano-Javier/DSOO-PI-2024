using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI_ComC_Grupo12.Models
{
    public class Persona
    {
        // Atributos de la clase
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // Constructor con parámetros
        public Persona(int id, string nombre, string apellido, string dni, string mail, string telefono, DateTime fechaNacimiento)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Email = mail;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
