using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    public class CuotaSocioRepository
    {
        private readonly Conexion _conexion;

        public CuotaSocioRepository()
        {
            _conexion = Conexion.getInstancia(
                ConfiguracionBD.NombreBase,
                ConfiguracionBD.Servidor,
                ConfiguracionBD.Puerto,
                ConfiguracionBD.Usuario,
                ConfiguracionBD.Contrasenia
            );
        }

        public (string, decimal) ObtenerCuotaPorId(int id)
        {
            using (var conexion = _conexion.CrearConexion())
            {
                conexion.Open();
                string query = "SELECT descripcion, monto FROM cuota_socio WHERE id = @id";
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string descripcion = reader.GetString("descripcion");
                            decimal monto = reader.GetDecimal("monto");
                            return (descripcion, monto);
                        }
                    }
                }
            }
            return (string.Empty, 0m); // Devolver un valor por defecto si no se encuentra la cuota
        }
    }
}
