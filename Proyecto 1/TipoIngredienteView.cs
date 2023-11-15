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
            DataGridTipoIngrediente.RowHeadersVisible = false;
            DataGridTipoIngrediente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridTipoIngrediente.Columns.Add("Id", "Id");
            DataGridTipoIngrediente.Columns["Id"].Visible = false;
            DataGridTipoIngrediente.Columns.Add("Detalle", "Detalle");
            DataGridTipoIngrediente.Columns.Add("CantidadMax", "Cantidad Máxima");
            DataGridTipoIngrediente.Columns["Detalle"].Width = 105;
            DataGridTipoIngrediente.Columns["CantidadMax"].Width = 104;
            ActualizarDataGridView();
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
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = tipoIngrediente.IdTipoIngrediente });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = tipoIngrediente.Detalle });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = tipoIngrediente.CantidadMax });

                // Agrega la fila al DataGridView
                DataGridTipoIngrediente.Rows.Add(fila);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardarCambios.Visible = true;
            lbId.Visible = true;
            tbId.Visible = true;
            if (DataGridTipoIngrediente.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DataGridTipoIngrediente.SelectedRows[0];
                /*int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string detalle = filaSeleccionada.Cells["Detalle"].Value.ToString();
                int cantidadMaxima = Convert.ToInt32(filaSeleccionada.Cells["CantidadMaxima"].Value);

                TipoIngrediente tipoIngredienteAModificar = TipoIngredienteCtr.ObtenerTipoIngredientePorId(tipoIngredienteEnDgv.IdTipoIngrediente);*/
                tbId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
                textBox1.Text = filaSeleccionada.Cells["Detalle"].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(filaSeleccionada.Cells["CantidadMax"].Value);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.");
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string Detalle = textBox1.Text;
            int CantidadMaxima = (int)numericUpDown1.Value;
            int idTipoIngrediente = Convert.ToInt32(tbId.Text);
            TipoIngrediente tipoIngredienteAModificar = new TipoIngrediente(idTipoIngrediente, Detalle, CantidadMaxima);
            TipoIngredienteCtr.ModificarTipoIngrediente(tipoIngredienteAModificar);
            ActualizarDataGridView();
            btnGuardarCambios.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGridTipoIngrediente.SelectedRows.Count > 0)
            {
                int rowIndex = DataGridTipoIngrediente.SelectedRows[0].Index;
                TipoIngrediente tipoIngredienteAEliminar = (TipoIngrediente)DataGridTipoIngrediente.SelectedRows[0].DataBoundItem;
                TipoIngredienteCtr.EliminarTipoIngrediente(tipoIngredienteAEliminar);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }
    }
}
