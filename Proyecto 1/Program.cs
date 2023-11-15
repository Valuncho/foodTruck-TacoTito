using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string connectionString = "Data Source=LAPTOP-5V5GHNNN;Initial Catalog=TacoTitoDB;User ID=sa;Password=1234";
            Application.Run(new TipoIngredienteView());
        }
    }
}
