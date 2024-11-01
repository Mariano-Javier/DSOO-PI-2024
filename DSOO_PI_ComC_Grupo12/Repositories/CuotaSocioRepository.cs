using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    public class CuotaSocioRepository : BaseRepository
    {
        public Cuota ObtenerCuotaPorId(int id)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                string query = "SELECT id, descripcion, monto FROM cuota_socio WHERE id = @id";
                using (var comando = new MySqlCommand(query, conexionDb))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idCuota = reader.GetInt32("id");
                            string descripcion = reader.GetString("descripcion");
                            decimal monto = reader.GetDecimal("monto");
                            return new Cuota
                            {
                                Id = idCuota,
                                Descripcion = descripcion,
                                Monto = monto
                            };
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
            return null; // Valor por defecto si no se encuentra la cuota
        }

        public List<Cuota> ObtenerPreciosCuotas()
        {
            var precios = new List<Cuota>();
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
                            precios.Add(new Cuota
                            {
                                Id = id,
                                Descripcion = descripcion,
                                Monto = monto
                            });
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

        public void ActualizarCuota(Cuota cuota)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "UPDATE cuota_socio SET descripcion = @descripcion, monto = @monto WHERE id = @id";
                    comando.Parameters.AddWithValue("@id", cuota.Id);
                    comando.Parameters.AddWithValue("@descripcion", cuota.Descripcion);
                    comando.Parameters.AddWithValue("@monto", cuota.Monto);

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
    }
}
