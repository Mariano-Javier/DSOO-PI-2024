using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using DSOO_PI_ComC_Grupo12.Helpers;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    public class CuotaSocioRepository : BaseRepository
    {
        public (string Descripcion, decimal Monto) ObtenerCuotaPorId(int id)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                string query = "SELECT descripcion, monto FROM cuota_socio WHERE id = @id";
                using (var comando = new MySqlCommand(query, conexionDb))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
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
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la cuota por ID: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
            return (string.Empty, 0m); // Valor por defecto si no se encuentra la cuota
        }

        public List<(int Id, string Descripcion, decimal Monto)> ObtenerPreciosCuotas()
        {
            var precios = new List<(int Id, string Descripcion, decimal Monto)>();
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT id, descripcion, monto FROM cuota_socio";

                    using (var reader = comando.ExecuteReader())
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
                CerrarConexion(conexionDb);
            }

            return precios;
        }

        public void ActualizarCuota(int id, string descripcion, decimal monto)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
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
                CerrarConexion(conexionDb);
            }
        }

        public void EliminarCuota(int id)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
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
                CerrarConexion(conexionDb);
            }
        }
    }
}
