namespace Eventos.Formularios.Administrador
{
    partial class Clientes
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
            txtBuscar = new TextBox();
            txtID = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(14, 11);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Filtrar clientes...";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 63;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(411, 345);
            txtID.Name = "txtID";
            txtID.Size = new Size(47, 23);
            txtID.TabIndex = 62;
            txtID.Visible = false;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(411, 286);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese el direccion del cliente";
            txtDireccion.Size = new Size(170, 23);
            txtDireccion.TabIndex = 61;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(209, 345);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese el telefono del cliente";
            txtTelefono.Size = new Size(170, 23);
            txtTelefono.TabIndex = 60;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(209, 286);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese el correo del cliente";
            txtCorreo.Size = new Size(170, 23);
            txtCorreo.TabIndex = 59;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(15, 345);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese el apellido del cliente";
            txtApellido.Size = new Size(170, 23);
            txtApellido.TabIndex = 58;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 286);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre del cliente";
            txtNombre.Size = new Size(171, 23);
            txtNombre.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(411, 262);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 56;
            label5.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(209, 321);
            label4.Name = "label4";
            label4.Size = new Size(141, 21);
            label4.TabIndex = 55;
            label4.Text = "Numero Telefonico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(209, 262);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 54;
            label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 321);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 53;
            label2.Text = "Apellido del cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(14, 262);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 52;
            label1.Text = "Nombre del cliente";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(620, 305);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(114, 37);
            btnEditar.TabIndex = 51;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(620, 363);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 37);
            btnEliminar.TabIndex = 50;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(620, 247);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 37);
            btnAgregar.TabIndex = 49;
            btnAgregar.Text = "Crear";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 201);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 411);
            Controls.Add(txtBuscar);
            Controls.Add(txtID);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "Clientes";
            Text = "Clientes Administrador";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private TextBox txtID;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
    }
}