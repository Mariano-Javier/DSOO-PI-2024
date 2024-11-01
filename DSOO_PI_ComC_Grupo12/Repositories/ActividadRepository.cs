using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class ActividadRepository : BaseRepository
    {
        public Dictionary<string, decimal> ObtenerPreciosActividades(List<string> actividades)
        {
            var precios = new Dictionary<string, decimal>();
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT nombre, precio FROM actividad WHERE nombre IN (@actividades)";

                    string parametros = string.Join(",", actividades.ConvertAll(a => $"'{a}'"));
                    comando.CommandText = comando.CommandText.Replace("@actividades", parametros);

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader.GetString(0);
                            decimal precio = reader.GetDecimal(1);
                            precios[nombre] = precio;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener precios de actividades: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }

            return precios;
        }

        public List<Actividad> ObtenerActividades()
        {
            var actividades = new List<Actividad>();
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT id, nombre, precio FROM actividad";

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var actividad = new Actividad
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Precio = reader.GetDecimal(2)
                            };
                            actividades.Add(actividad);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener actividades: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }

            return actividades;
        }

        public void RegistrarActividad(Actividad actividad)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "INSERT INTO actividad (nombre, precio) VALUES (@nombre, @precio)";
                    comando.Parameters.AddWithValue("@nombre", actividad.Nombre);
                    comando.Parameters.AddWithValue("@precio", actividad.Precio);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la actividad: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }

        public void ActualizarActividad(Actividad actividad)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "UPDATE actividad SET nombre = @nombre, precio = @precio WHERE id = @id";
                    comando.Parameters.AddWithValue("@id", actividad.Id);
                    comando.Parameters.AddWithValue("@nombre", actividad.Nombre);
                    comando.Parameters.AddWithValue("@precio", actividad.Precio);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la actividad: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }

        public void EliminarActividad(int id)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "DELETE FROM actividad WHERE id = @id";
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la actividad: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }
    }
}
