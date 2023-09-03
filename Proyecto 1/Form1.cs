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
        List<Salsa> listaDeSalsas = new List<Salsa>();

        public Form1()
        {
            InitializeComponent();
            GridListaDeSalsas.Columns.Add("Nombre", "Nombre");
            GridListaDeSalsas.Columns.Add("Precio", "Precio");
        }

        private void crearSalsa() 
        {
            Salsa unObjetoSalsa = new Salsa(txtNombre.Text, Convert.ToDecimal(txtPrecio.Text));
            listaDeSalsas.Add(unObjetoSalsa);
        }

        private void crearAlimento()
        {
            Alimento unObjetoAlimento = new Alimento(txtNombre.Text,Convert.ToDecimal(txtPrecio.Text));
            GridListaDeSalsas.Rows.Add(unObjetoAlimento.NOMBRE, unObjetoAlimento.Precio);
        }
        
        private void btnCrearAlimento_Click(object sender, EventArgs e)
        {
            crearAlimento();

        }

        private void btnCrearSalsa_Click(object sender, EventArgs e)
        {
            crearSalsa();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTortilla_Click(object sender, EventArgs e)
        {

        }
    }
}
