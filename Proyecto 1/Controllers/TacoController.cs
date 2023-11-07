using Proyecto_1.IngredienteController;
using System;
using System.Collections.Generic;
using Proyecto_1.Modelo;

namespace Proyecto_1.TacoController
{
    public class TacoController 
    {
        // static es para Singleton 
        //private static TacoController instance;  
        private List<Taco> listaTaco;
        private int numeroTaco;

        public TacoController()
        {
            
            listaTaco = new List<Taco>();
            numeroTaco = 0;
        }

        /*public static TacoController GetInstance()
        {
            return instance;
        }*/




    }
}

