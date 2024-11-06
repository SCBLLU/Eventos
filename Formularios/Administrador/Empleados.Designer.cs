namespace Eventos.Formularios.Administrador
{
    partial class Empleados
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
            btbAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            panel3 = new Panel();
            txtContraseña = new TextBox();
            label7 = new Label();
            txtUsuario = new TextBox();
            label6 = new Label();
            txtID = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            cmbRol = new ComboBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 411);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(383, 411);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btbAgregar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnEliminar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(383, 350);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 61);
            panel2.TabIndex = 1;
            // 
            // btbAgregar
            // 
            btbAgregar.Anchor = AnchorStyles.None;
            btbAgregar.Location = new Point(9, 5);
            btbAgregar.Margin = new Padding(5);
            btbAgregar.Name = "btbAgregar";
            btbAgregar.Padding = new Padding(5);
            btbAgregar.Size = new Size(92, 48);
            btbAgregar.TabIndex = 4;
            btbAgregar.Text = "Agregar";
            btbAgregar.UseVisualStyleBackColor = true;
            btbAgregar.Click += btbAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.Location = new Point(140, 5);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(92, 48);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Location = new Point(268, 5);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(5);
            btnEliminar.Size = new Size(92, 48);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtContraseña);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtUsuario);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(txtTelefono);
            panel3.Controls.Add(txtCorreo);
            panel3.Controls.Add(cmbRol);
            panel3.Controls.Add(txtApellido);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(383, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 350);
            panel3.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(82, 265);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(160, 23);
            txtContraseña.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(8, 267);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 15;
            label7.Text = "Clave";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(82, 222);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(160, 23);
            txtUsuario.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(8, 224);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 12;
            label6.Text = "Usuario";
            // 
            // txtID
            // 
            txtID.Location = new Point(308, 19);
            txtID.Name = "txtID";
            txtID.Size = new Size(44, 23);
            txtID.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(82, 179);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(160, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(82, 137);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(160, 23);
            txtCorreo.TabIndex = 9;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(82, 99);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(160, 23);
            cmbRol.TabIndex = 8;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(82, 58);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(160, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 177);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 135);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 97);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 2;
            label3.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Empleados";
            Text = "Empleados";
            Load += Empleados_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private ComboBox cmbRol;
        private Button btbAgregar;
        private Button btnEditar;
        private TextBox txtID;
        private Label label6;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label7;
    }
}