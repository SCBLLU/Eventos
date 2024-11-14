namespace Eventos.Formularios.Administrador
{
    partial class Salas
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
            label10 = new Label();
            txtBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtCaracteristicas = new TextBox();
            txtUbicacion = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            numCapacidad = new NumericUpDown();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnCrear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 295);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(171, 30);
            label10.TabIndex = 96;
            label10.Text = "Gestionar Salas";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 47);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Filtrar salas...";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 95;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(725, 213);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCaracteristicas);
            panel2.Controls.Add(txtUbicacion);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(numCapacidad);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 295);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 176);
            panel2.TabIndex = 1;
            // 
            // txtCaracteristicas
            // 
            txtCaracteristicas.Location = new Point(205, 108);
            txtCaracteristicas.Name = "txtCaracteristicas";
            txtCaracteristicas.PlaceholderText = "Ingrese la caracteristicas";
            txtCaracteristicas.Size = new Size(165, 23);
            txtCaracteristicas.TabIndex = 24;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(205, 39);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.PlaceholderText = "Ingrese la ubicacion de la sala";
            txtUbicacion.Size = new Size(165, 23);
            txtUbicacion.TabIndex = 23;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(466, 102);
            txtID.Name = "txtID";
            txtID.Size = new Size(41, 23);
            txtID.TabIndex = 22;
            txtID.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(205, 13);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 20;
            label2.Text = "Ubicacion";
            // 
            // numCapacidad
            // 
            numCapacidad.Location = new Point(12, 107);
            numCapacidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(165, 23);
            numCapacidad.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 18;
            label3.Text = "Capacidad :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre de la sala";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(205, 82);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 15;
            label4.Text = "Caracteristicas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 14;
            label1.Text = "Nombre :";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnCrear);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(531, 295);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 176);
            panel3.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Top;
            btnEliminar.Location = new Point(0, 100);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(218, 50);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Top;
            btnEditar.Location = new Point(0, 50);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(218, 50);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Dock = DockStyle.Top;
            btnCrear.Location = new Point(0, 0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(218, 50);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // Salas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 471);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salas";
            Text = "Salas";
            Load += Salas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtCaracteristicas;
        private TextBox txtUbicacion;
        private TextBox txtID;
        private Label label2;
        private NumericUpDown numCapacidad;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private Label label1;
        private Panel panel3;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnCrear;
        private TextBox txtBuscar;
        private Label label10;
    }
}