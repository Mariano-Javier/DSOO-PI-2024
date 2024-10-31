using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI_ComC_Grupo12.Helpers
{
    public abstract class BaseRepository
    {
        protected MySqlConnection ObtenerConexion()
        {
            var conexion = Conexion.getInstancia(
                ConfiguracionBD.NombreBase,
                ConfiguracionBD.Servidor,
                ConfiguracionBD.Puerto,
                ConfiguracionBD.Usuario,
                ConfiguracionBD.Contrasenia).CrearConexion();
            conexion.Open();
            return conexion;
        }

        protected void CerrarConexion(MySqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }

}
