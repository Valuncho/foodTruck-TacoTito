using Proyecto_1.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace Proyecto_1.DAO
{
    public class TipoIngredienteDAO
    {
        private string ConexionDataBase;

        public TipoIngredienteDAO()
        {
            ConexionDataBase = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        }

        public void InsertarTipoIngrediente(TipoIngrediente tipoIngrediente)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "INSERT INTO TipoIngredientes (IdTipoIngrediente, Detalle, CantidadMax) " +
                                  "VALUES (@IdTipoIngrediente, @Detalle, @CantidadMax)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdTipoIngrediente", tipoIngrediente.IdTipoIngrediente);
                    comando.Parameters.AddWithValue("@Detalle", tipoIngrediente.Detalle);
                    comando.Parameters.AddWithValue("@CantidadMax", tipoIngrediente.CantidadMax);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarTipoIngrediente(TipoIngrediente tipoIngrediente)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "UPDATE TipoIngredientes " +
                                  "SET Detalle = @Detalle, CantidadMax = @CantidadMax " +
                                  "WHERE IdTipoIngrediente = @IdTipoIngrediente";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdTipoIngrediente", tipoIngrediente.IdTipoIngrediente);
                    comando.Parameters.AddWithValue("@Detalle", tipoIngrediente.Detalle);
                    comando.Parameters.AddWithValue("@CantidadMax", tipoIngrediente.CantidadMax);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarTipoIngrediente(int idTipoIngrediente)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "DELETE FROM TipoIngredientes WHERE IdTipoIngrediente = @IdTipoIngrediente";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdTipoIngrediente", idTipoIngrediente);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
