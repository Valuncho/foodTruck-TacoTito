using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Proyecto_1.Modelo;

namespace Proyecto_1.Modelo
{
    public class Taco
    {
        private int NumeroTaco { get; set; }
        private List<Ingrediente> Ingredientes { get; set; }
        private int PrecioTotal { get; set; }

        public Taco()
        {
            Ingredientes = new List<Ingrediente>();
        }

        public override string ToString()
        {
            return $"Taco #{NumeroTaco} - Precio: {PrecioTotal} - Ingredientes: {Ingredientes.Count}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false; // El objeto no es de la misma clase
            }

            Taco otroTaco = (Taco)obj;

            // Comparamos los numeros de taco para determinar si son iguales
            return this.NumeroTaco == otroTaco.NumeroTaco;
        }
    }
}
