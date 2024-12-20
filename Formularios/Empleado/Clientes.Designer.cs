﻿namespace Eventos.Formularios.Empleado
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
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(17, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Filtrar clientes...";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 47;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(406, 384);
            txtID.Name = "txtID";
            txtID.Size = new Size(52, 23);
            txtID.TabIndex = 46;
            txtID.Visible = false;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(406, 325);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese el direccion del cliente";
            txtDireccion.Size = new Size(175, 23);
            txtDireccion.TabIndex = 45;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(213, 384);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese el telefono del cliente";
            txtTelefono.Size = new Size(175, 23);
            txtTelefono.TabIndex = 44;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(213, 325);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese el correo del cliente";
            txtCorreo.Size = new Size(175, 23);
            txtCorreo.TabIndex = 43;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(18, 384);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese el apellido del cliente";
            txtApellido.Size = new Size(175, 23);
            txtApellido.TabIndex = 42;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 325);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre del cliente";
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(406, 301);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 40;
            label5.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(213, 360);
            label4.Name = "label4";
            label4.Size = new Size(141, 21);
            label4.TabIndex = 39;
            label4.Text = "Numero Telefonico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(213, 301);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 38;
            label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 360);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 37;
            label2.Text = "Apellido del cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 301);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 36;
            label1.Text = "Nombre del cliente";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(623, 344);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(114, 37);
            btnEditar.TabIndex = 35;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(623, 402);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 37);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(623, 286);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 37);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Crear";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 201);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(201, 30);
            label10.TabIndex = 94;
            label10.Text = "Gestionar Clientes";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 478);
            Controls.Add(label10);
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
            Text = "Clientes";
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
        private Label label10;
    }
}