using DSOO_PI_ComC_Grupo12.Helpers;
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

        public List<(int Id, string Nombre, decimal Precio)> ObtenerPreciosActividades()
        {
            var precios = new List<(int Id, string Nombre, decimal Precio)>();
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
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            decimal precio = reader.GetDecimal(2);
                            precios.Add((id, nombre, precio));
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

        public List<string> ObtenerActividades()
        {
            var actividades = new List<string>();
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT nombre FROM actividad";

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            actividades.Add(reader.GetString(0));
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

        public void RegistrarActividad(string nombre, decimal precio)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "INSERT INTO actividad (nombre, precio) VALUES (@nombre, @precio)";
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@precio", precio);

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

        public void ActualizarActividad(int id, string nombre, decimal precio)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "UPDATE actividad SET nombre = @nombre, precio = @precio WHERE id = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@precio", precio);

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
