using Proyecto_1.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_1.DAO
{
    public class TipoIngredienteDAO
    {

        protected static TipoIngredienteDAO instance;
        private string ConexionDataBase = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

        public TipoIngredienteDAO()
        {
            //ConexionDataBase = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        }

        public static TipoIngredienteDAO getInstance()
        {
            if (instance == null) 
            { 
                instance = new TipoIngredienteDAO();
            }
            return instance;
        }

        public void InsertarTipoIngrediente(TipoIngrediente tipoIngrediente)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "INSERT INTO TipoIngrediente (IdTipoIngrediente, Detalle, CantidadMax) " +
                                  "VALUES (@IdTipoIngrediente, @Detalle, @CantidadMax)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdTipoIngrediente", tipoIngrediente.IdTipoIngrediente);
                    comando.Parameters.AddWithValue("@Detalle", tipoIngrediente.Detalle);
                    comando.Parameters.AddWithValue("@CantidadMax", tipoIngrediente.CantidadMax);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("SI SE PUDO AJAJAJAJA");
                } 
            }
        }

        public void ActualizarTipoIngrediente(TipoIngrediente tipoIngrediente)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "UPDATE TipoIngrediente " +
                                  "SET Detalle = @Detalle, CantidadMax = @CantidadMax " +
                                  "WHERE IdTipoIngrediente = @IdTipoIngrediente";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdTipoIngrediente", tipoIngrediente.IdTipoIngrediente);
                    comando.Parameters.AddWithValue("@Detalle", tipoIngrediente.Detalle);
                    comando.Parameters.AddWithValue("@CantidadMax", tipoIngrediente.CantidadMax);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("SI SE PUDO AJAJAJAJA");
                }
            }
        }

        public void EliminarTipoIngrediente(int idTipoIngrediente)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "DELETE FROM TipoIngrediente WHERE IdTipoIngrediente = @IdTipoIngrediente";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdTipoIngrediente", idTipoIngrediente);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("SI SE PUDO AJAJAJAJA");
                }
            }
        }

        public List<TipoIngrediente> TraerTiposDeIngredientes()
        {
            List<TipoIngrediente> tiposIngredientes = new List<TipoIngrediente>();

            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "SELECT * FROM TipoIngrediente";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Detalle = reader["Detalle"].ToString();
                            int CantidadMax = Convert.ToInt32(reader["CantidadMax"]);
                            TipoIngrediente tipoIngrediente = new TipoIngrediente(Detalle,CantidadMax);
                            tiposIngredientes.Add(tipoIngrediente);
                        }
                    }
                }
            }

            return tiposIngredientes;
        }
    }
}
