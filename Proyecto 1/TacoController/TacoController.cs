using Proyecto_1.IngredienteController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Modelo;

namespace Proyecto_1.TacoController
{
    internal class TacoController 
    {
        private static TacoController instance;
        IngredienteController ingredienteController;   
        private List<Taco> listaTaco;
        private int numeroTaco;

        public TacoController()
        {
            ingredienteController = IngredienteController.GetInstance();
            listaTaco = new List<Taco>();
            numeroTaco = 0;
        }

        public static TacoController getInstance()
        {
            return instance;
        }




    }
}

