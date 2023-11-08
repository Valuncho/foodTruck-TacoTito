using Proyecto_1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.IngredienteController
{
    public class TipoIngredienteController
    {
        private List<TipoIngrediente> tipoIngredientes = new List<TipoIngrediente>();
        private static TipoIngredienteController instancia;

        private TipoIngredienteController()
        {

        }
        public static TipoIngredienteController GetInstance()
        {
            if (instancia == null)
            {
                instancia = new TipoIngredienteController();
            }
            return instancia;
        }

        public void CrearNuevoTipoIngrediente(string detalle, int cantidadMax)
        {
            TipoIngrediente tipoIngrediente = new TipoIngrediente(detalle, cantidadMax);
            tipoIngredientes.Add(tipoIngrediente);
        }

        public void EliminarTipoIngrediente(int idTipoIngrediente)
        {
            TipoIngrediente tipoIngrediente = ObtenerTipoIngredientePorId(idTipoIngrediente);
            if (tipoIngrediente != null)
            {
                tipoIngredientes.Remove(tipoIngrediente);
            }
        }

        public void ModificarTipoIngrediente(int idTipoIngrediente, string nuevoDetalle, int nuevaCantidadMax)
        {
            TipoIngrediente tipoIngrediente = ObtenerTipoIngredientePorId(idTipoIngrediente);
            if (tipoIngrediente != null)
            {
                tipoIngrediente.Detalle = nuevoDetalle;
                tipoIngrediente.CantidadMax = nuevaCantidadMax;
            }
        }
        public TipoIngrediente ObtenerTipoIngredientePorId(int idTipoIngrediente)
        {
            return tipoIngredientes.Find(ti => ti.IdTipoIngrediente == idTipoIngrediente);
        }
        public List<TipoIngrediente> ObtenerTiposIngredientes()
        {
            return tipoIngredientes;
        }

    }
}
