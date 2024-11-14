namespace Eventos.Formularios.Administrador
{
    partial class Paquetes
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            panel3 = new Panel();
            txtBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            txtID = new TextBox();
            txtArticulos = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtArticulos);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 411);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnAgregar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(239, 347);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 64);
            panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(373, 14);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 38);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Paquete";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(195, 14);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 38);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar Paquete";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(19, 14);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 38);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Paquete";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtBuscar);
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(239, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(510, 347);
            panel3.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(6, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Filtrar paquetes...";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 95;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(498, 291);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(12, 382);
            txtID.Name = "txtID";
            txtID.Size = new Size(41, 23);
            txtID.TabIndex = 13;
            txtID.Visible = false;
            // 
            // txtArticulos
            // 
            txtArticulos.Location = new Point(12, 310);
            txtArticulos.Name = "txtArticulos";
            txtArticulos.PlaceholderText = "Ingrese que contiene el paquete";
            txtArticulos.Size = new Size(199, 23);
            txtArticulos.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 217);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ingrese una descripcion corta";
            txtDescripcion.Size = new Size(199, 23);
            txtDescripcion.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre del paquete";
            txtNombre.Size = new Size(199, 23);
            txtNombre.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 265);
            label3.Name = "label3";
            label3.Size = new Size(155, 21);
            label3.TabIndex = 9;
            label3.Text = "Articulos del Paquete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 8;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 7;
            label1.Text = "Nombre del Paquete";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.Location = new Point(12, 12);
            label10.Name = "label10";
            label10.Size = new Size(214, 30);
            label10.TabIndex = 94;
            label10.Text = "Gestionar Paquetes";
            // 
            // Paquetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Paquetes";
            Text = "Paquetes";
            Load += Paquetes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private TextBox txtID;
        private TextBox txtArticulos;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
    }
}