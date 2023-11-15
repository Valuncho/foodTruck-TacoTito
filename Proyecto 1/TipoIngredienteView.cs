using Proyecto_1.IngredienteController;
using Proyecto_1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_1
{
    public partial class TipoIngredienteView : Form
    {
        TipoIngredienteController TipoIngredienteCtr = TipoIngredienteController.GetInstance();
        public TipoIngredienteView()
        {
            InitializeComponent();
            DataGridTipoIngrediente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridTipoIngrediente.Columns.Add("Detalle", "Detalle");
            DataGridTipoIngrediente.Columns.Add("CantidadMax", "Cantidad Máxima");
        }

        private void btnTipoIngredienteAgregar_Click(object sender, EventArgs e)
        {
            string detalle = textBox1.Text; // Obtiene el detalle del TextBox
            
            if (!string.IsNullOrEmpty(detalle))
            {                
                int cantidadMaxima = (int)numericUpDown1.Value;
                // Llama al método de la controladora para agregar el nuevo tipo de ingrediente
                TipoIngredienteCtr.CrearNuevoTipoIngrediente(detalle, cantidadMaxima);  
                textBox1.Text = string.Empty;
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un detalle válido para el tipo de ingrediente.");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void DataGridTipoIngrediente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ActualizarDataGridView()
        {
            // Limpia el DataGridView
            DataGridTipoIngrediente.Rows.Clear();

            // Obtén la lista de tipos de ingredientes desde la controladora
            List<TipoIngrediente> tiposIngredientes = TipoIngredienteCtr.ObtenerTiposIngredientes();

            // Recorre la lista y agrega cada tipo de ingrediente al DataGridView
            foreach (TipoIngrediente tipoIngrediente in tiposIngredientes)
            {
                DataGridViewRow fila = new DataGridViewRow();

                // Agrega cada propiedad del tipo de ingrediente como una celda en la fila
                //fila.Cells.Add(new DataGridViewTextBoxCell { Value = tipoIngrediente.IdTipoIngrediente });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = tipoIngrediente.Detalle });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = tipoIngrediente.CantidadMax });

                // Agrega la fila al DataGridView
                DataGridTipoIngrediente.Rows.Add(fila);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataGridTipoIngrediente.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = DataGridTipoIngrediente.SelectedRows[0].Index;

                TipoIngrediente tipoIngredienteAEliminar = (TipoIngrediente)DataGridTipoIngrediente.SelectedRows[0].DataBoundItem;

                // Eliminar el TipoIngrediente
                TipoIngredienteCtr.EliminarTipoIngrediente(tipoIngredienteAEliminar);

                // Actualizar la vista, por ejemplo, recargando los datos en un DataGridView
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }
    }
}
