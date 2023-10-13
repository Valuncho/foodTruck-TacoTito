using Proyecto_1.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Proyecto_1.DAO
{
    public class TacoDAO
    {
        private string ConexionDataBase;

        public TacoDAO()
        {
            ConexionDataBase = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        }

        public void InsertarTaco(Taco taco)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "INSERT INTO Tacos (NumeroTaco, PrecioTotal) VALUES (@NumeroTaco, @PrecioTotal)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NumeroTaco", taco.NumeroTaco);
                    comando.Parameters.AddWithValue("@PrecioTotal", taco.PrecioTotal);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarTaco(Taco taco)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "UPDATE Tacos SET PrecioTotal = @PrecioTotal WHERE NumeroTaco = @NumeroTaco";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NumeroTaco", taco.NumeroTaco);
                    comando.Parameters.AddWithValue("@PrecioTotal", taco.PrecioTotal);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarTaco(int numeroTaco)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "DELETE FROM Tacos WHERE NumeroTaco = @NumeroTaco";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NumeroTaco", numeroTaco);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Taco ObtenerTacoPorNumero(int numeroTaco)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "SELECT NumeroTaco, PrecioTotal FROM Tacos WHERE NumeroTaco = @NumeroTaco";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NumeroTaco", numeroTaco);
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            Taco taco = new Taco
                            {
                                NumeroTaco = lector.GetInt32(0),
                                PrecioTotal = lector.GetInt32(1)
                            };
                            return taco;
                        }
                        else
                        {
                            return null; // El taco no se encontro
                        }
                    }
                }
            }
        }
    }
}
