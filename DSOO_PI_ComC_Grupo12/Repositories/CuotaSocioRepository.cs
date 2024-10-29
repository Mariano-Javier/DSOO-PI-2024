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
        public List<(int Id, string Descripcion, decimal Monto)> ObtenerPreciosCuotas()
        {
            List<(int Id, string Descripcion, decimal Monto)> precios = new List<(int Id, string Descripcion, decimal Monto)>();
            MySqlConnection? conexionDb = null;

            try
            {
                conexionDb = Conexion.getInstancia(
                    ConfiguracionBD.NombreBase,
                    ConfiguracionBD.Servidor,
                    ConfiguracionBD.Puerto,
                    ConfiguracionBD.Usuario,
                    ConfiguracionBD.Contrasenia).CrearConexion();
                conexionDb.Open();

                using (MySqlCommand comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT id, descripcion, monto FROM cuota_socio";

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string descripcion = reader.GetString(1);
                            decimal monto = reader.GetDecimal(2);
                            precios.Add((id, descripcion, monto));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener precios de cuotas: " + ex.Message);
            }
            finally
            {
                if (conexionDb != null && conexionDb.State == System.Data.ConnectionState.Open)
                {
                    conexionDb.Close();
                }
            }

            return precios;
        }
        public void ActualizarCuota(int id, string descripcion, decimal monto)
        {
            MySqlConnection? conexionDb = null;

            try
            {
                conexionDb = Conexion.getInstancia(
                    ConfiguracionBD.NombreBase,
                    ConfiguracionBD.Servidor,
                    ConfiguracionBD.Puerto,
                    ConfiguracionBD.Usuario,
                    ConfiguracionBD.Contrasenia).CrearConexion();
                conexionDb.Open();

                using (MySqlCommand comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "UPDATE cuota_socio SET descripcion = @descripcion, monto = @monto WHERE id = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@monto", monto);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la cuota: " + ex.Message);
            }
            finally
            {
                if (conexionDb != null && conexionDb.State == System.Data.ConnectionState.Open)
                {
                    conexionDb.Close();
                }
            }
        }

        public void EliminarCuota(int id)
        {
            MySqlConnection? conexionDb = null;

            try
            {
                conexionDb = Conexion.getInstancia(
                    ConfiguracionBD.NombreBase,
                    ConfiguracionBD.Servidor,
                    ConfiguracionBD.Puerto,
                    ConfiguracionBD.Usuario,
                    ConfiguracionBD.Contrasenia).CrearConexion();
                conexionDb.Open();

                using (MySqlCommand comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "DELETE FROM cuota_socio WHERE id = @id";
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la cuota: " + ex.Message);
            }
            finally
            {
                if (conexionDb != null && conexionDb.State == System.Data.ConnectionState.Open)
                {
                    conexionDb.Close();
                }
            }
        }
    }
}
