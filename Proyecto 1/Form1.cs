using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_1.Modelo;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {
        List<Pedido> listaDeSalsas = new List<Pedido>();

        public Form1()
        {
            InitializeComponent();
            GridDePedido.Columns.Add("Nombre", "Nombre");
            GridDePedido.Columns.Add("Precio", "Precio");
            GridDePedido.Columns.Add("Ingrediente", "Ingrediente");
        }
        // Borrar es viejo
        private void crearSalsa() 
        {
            //Pedido unObjetoSalsa = new Salsa(txtNombre.Text, Convert.ToDecimal(txtPrecio.Text));
            //listaDeSalsas.Add(unObjetoSalsa);
        }

        private void crearAlimento()
        {
            //Alimento unObjetoAlimento = new Alimento(txtNombre.Text,Convert.ToDecimal(txtPrecio.Text));
            //GridListaDeSalsas.Rows.Add(unObjetoAlimento.NOMBRE, unObjetoAlimento.Precio);
        }

        private void GridListaDeSalsas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
