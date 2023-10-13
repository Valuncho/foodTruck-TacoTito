using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Modelo
{
    public class TipoIngrediente
    {
        public int IdTipoIngrediente { get; set; }
        public string Detalle { get; set; }
        public int CantidadMax { get; set; }

        public TipoIngrediente(int IdTipoIngrediente, string Detalle, int CantidadMax)
        {
            this.IdTipoIngrediente = IdTipoIngrediente;
            this.Detalle = Detalle;
            this.CantidadMax = CantidadMax;
        }

        public override string ToString()
        {
            return $"Tipo de Ingrediente #{IdTipoIngrediente} - Detalle: {Detalle} - Cantidad Máxima: {CantidadMax}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false; // El objeto no es de la misma clase
            }

            TipoIngrediente otroTipoIngrediente = (TipoIngrediente)obj;

            // Comparamos los IdTipoIngrediente para determinar si son iguales
            return this.IdTipoIngrediente == otroTipoIngrediente.IdTipoIngrediente;
        }
    }
}
