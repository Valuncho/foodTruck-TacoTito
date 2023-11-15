using Proyecto_1.DAO;
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
        private TipoIngredienteDAO tipoIngDao = TipoIngredienteDAO.getInstance();
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
            tipoIngDao.InsertarTipoIngrediente(tipoIngrediente);
            tipoIngredientes.Add(tipoIngrediente);
        }

        public void EliminarTipoIngrediente(TipoIngrediente tipoIngrediente)
        {
            if (tipoIngrediente != null)
            {
                tipoIngredientes.Remove(tipoIngrediente);
            }
        }

        public void ModificarTipoIngrediente(TipoIngrediente tipoIngrediente, string nuevoDetalle, int nuevaCantidadMax)
        {
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
