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
        private List<TipoIngrediente> tiposIngredientes;

        public TipoIngredienteController()
        {
            tiposIngredientes = new List<TipoIngrediente>();
        }

        public void CrearNuevoTipoIngrediente(int id, string detalle, int cantidadMax)
        {
            TipoIngrediente tipoIngrediente = new TipoIngrediente(id, detalle, cantidadMax);
            tiposIngredientes.Add(tipoIngrediente);
        }

        public void EliminarTipoIngrediente(int idTipoIngrediente)
        {
            TipoIngrediente tipoIngrediente = ObtenerTipoIngredientePorId(idTipoIngrediente);
            if (tipoIngrediente != null)
            {
                tiposIngredientes.Remove(tipoIngrediente);
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
            return tiposIngredientes.Find(ti => ti.IdTipoIngrediente == idTipoIngrediente);
        }
    }
}
