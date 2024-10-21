using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DSOO_PI_ComC_Grupo12.Services
{
    internal class Conexion
    {
        // Declaramos las variables
        private string nombreBase;
        private string servidor;
        private string puerto;
        private string usuario;
        private string contrasenia;
        private static Conexion? con = null;

        // Constructor con parámetros para asignar datos dinámicamente
        public Conexion(string nombreBase, string servidor, string puerto, string usuario, string contrasenia)
        {
            this.nombreBase = nombreBase;
            this.servidor = servidor;
            this.puerto = puerto;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }
        // Método para crear la conexión
        public MySqlConnection CrearConexion()
        {
            // Creamos la conexión
            MySqlConnection? conexion = new MySqlConnection();
            try
            {
                // Establecemos la cadena que va a realizar la conexion
                conexion.ConnectionString = "datasource=" + this.servidor +
                    ";port=" + this.puerto +
                    ";username=" + this.usuario +
                    ";password=" + this.contrasenia +
                    ";Database=" + this.nombreBase;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la conexión: " + ex.Message);
                conexion = null;
                throw;
            }
            return conexion;
        }
        public static Conexion getInstancia(string nombreBase, string servidor, string puerto, string usuario, string contrasenia)
        {
            // Si ya existe una instancia, se sobreescribe con los nuevos valores
            if (con == null)
            {
                con = new Conexion(nombreBase, servidor, puerto, usuario, contrasenia);
            }
            else
            {
                con.nombreBase = nombreBase;
                con.servidor = servidor;
                con.puerto = puerto;
                con.usuario = usuario;
                con.contrasenia = contrasenia;
            }
            return con;
        }
        // Método para reiniciar la instancia (se llama desde frmConfigurar)
        public static void ResetInstancia()
        {
            con = null; // Destruye la instancia actual para que se cree una nueva
        }
    }
}
