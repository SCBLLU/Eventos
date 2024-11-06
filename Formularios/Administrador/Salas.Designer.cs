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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtID = new TextBox();
            txtUbicacion = new RichTextBox();
            label2 = new Label();
            numCapacidad = new NumericUpDown();
            label3 = new Label();
            txtCaracteristicas = new RichTextBox();
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
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 255);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(749, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(txtUbicacion);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(numCapacidad);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCaracteristicas);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 255);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 156);
            panel2.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(493, 17);
            txtID.Name = "txtID";
            txtID.Size = new Size(41, 23);
            txtID.TabIndex = 13;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(12, 86);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(189, 52);
            txtUbicacion.TabIndex = 12;
            txtUbicacion.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 11;
            label2.Text = "Ubicacion";
            // 
            // numCapacidad
            // 
            numCapacidad.Location = new Point(304, 19);
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(100, 23);
            numCapacidad.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(215, 17);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 9;
            label3.Text = "Capacidad";
            // 
            // txtCaracteristicas
            // 
            txtCaracteristicas.Location = new Point(215, 86);
            txtCaracteristicas.Name = "txtCaracteristicas";
            txtCaracteristicas.Size = new Size(189, 52);
            txtCaracteristicas.TabIndex = 7;
            txtCaracteristicas.Text = "";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(215, 62);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 3;
            label4.Text = "Caracteristicas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnCrear);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(557, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 156);
            panel3.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(0, 96);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(192, 48);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(0, 48);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(192, 48);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(0, 0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(192, 48);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // Salas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salas";
            Text = "Salas";
            Load += Salas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnCrear;
        private Button btnEliminar;
        private Button btnEditar;
        private RichTextBox txtCaracteristicas;
        private Label label4;
        private Label label1;
        private RichTextBox txtUbicacion;
        private Label label2;
        private NumericUpDown numCapacidad;
        private Label label3;
        private TextBox txtNombre;
        private DataGridView dataGridView1;
        private TextBox txtID;
    }
}