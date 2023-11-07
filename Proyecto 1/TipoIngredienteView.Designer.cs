namespace Proyecto_1
{
    partial class TipoIngredienteView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTipoIngredienteAgregar = new System.Windows.Forms.Button();
            this.lblTipoIngredienteTexto = new System.Windows.Forms.Label();
            this.DataGridTipoIngrediente = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTipoIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipoIngredienteAgregar
            // 
            this.btnTipoIngredienteAgregar.Location = new System.Drawing.Point(10, 102);
            this.btnTipoIngredienteAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnTipoIngredienteAgregar.Name = "btnTipoIngredienteAgregar";
            this.btnTipoIngredienteAgregar.Size = new System.Drawing.Size(137, 22);
            this.btnTipoIngredienteAgregar.TabIndex = 0;
            this.btnTipoIngredienteAgregar.Text = "Agregar Ingrediente";
            this.btnTipoIngredienteAgregar.UseVisualStyleBackColor = true;
            this.btnTipoIngredienteAgregar.Click += new System.EventHandler(this.btnTipoIngredienteAgregar_Click);
            // 
            // lblTipoIngredienteTexto
            // 
            this.lblTipoIngredienteTexto.AutoSize = true;
            this.lblTipoIngredienteTexto.Location = new System.Drawing.Point(7, 43);
            this.lblTipoIngredienteTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoIngredienteTexto.Name = "lblTipoIngredienteTexto";
            this.lblTipoIngredienteTexto.Size = new System.Drawing.Size(113, 13);
            this.lblTipoIngredienteTexto.TabIndex = 1;
            this.lblTipoIngredienteTexto.Text = "Detalle del Ingrediente";
            // 
            // DataGridTipoIngrediente
            // 
            this.DataGridTipoIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTipoIngrediente.Location = new System.Drawing.Point(252, 39);
            this.DataGridTipoIngrediente.Name = "DataGridTipoIngrediente";
            this.DataGridTipoIngrediente.Size = new System.Drawing.Size(176, 150);
            this.DataGridTipoIngrediente.TabIndex = 3;
            this.DataGridTipoIngrediente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTipoIngrediente_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(138, 66);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad Maxima";
            // 
            // TipoIngredienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGridTipoIngrediente);
            this.Controls.Add(this.lblTipoIngredienteTexto);
            this.Controls.Add(this.btnTipoIngredienteAgregar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TipoIngredienteView";
            this.Text = "IngredienteView";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTipoIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTipoIngredienteAgregar;
        private System.Windows.Forms.Label lblTipoIngredienteTexto;
        private System.Windows.Forms.DataGridView DataGridTipoIngrediente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}