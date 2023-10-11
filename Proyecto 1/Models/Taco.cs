using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Proyecto_1.Modelo;

namespace Proyecto_1.Modelo
{
    internal class Taco
    {
        private int NumeroTaco { get; set; }
        private List<Ingrediente> Ingredientes { get; set; }
        private int PrecioTotal { get;set; }

        public Taco() {
            Ingredientes = new List<Ingrediente>();
        }






    }
}
