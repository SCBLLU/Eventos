namespace Eventos.Formularios.Empleado
{
    partial class Eventos
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
            dataGridView1 = new DataGridView();
            comboEstado = new ComboBox();
            label9 = new Label();
            comboEmpleadoID = new ComboBox();
            label8 = new Label();
            txtID = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            comboPaquetesID = new ComboBox();
            comboClienteID = new ComboBox();
            comboSalaID = new ComboBox();
            dateFin = new DateTimePicker();
            dateInicio = new DateTimePicker();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 57);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Filtrar eventos...";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 119;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(725, 150);
            dataGridView1.TabIndex = 118;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboEstado
            // 
            comboEstado.Cursor = Cursors.Hand;
            comboEstado.FormattingEnabled = true;
            comboEstado.Location = new Point(446, 372);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(121, 23);
            comboEstado.TabIndex = 116;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(446, 348);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 115;
            label9.Text = "Estado";
            // 
            // comboEmpleadoID
            // 
            comboEmpleadoID.Cursor = Cursors.Hand;
            comboEmpleadoID.Enabled = false;
            comboEmpleadoID.FormattingEnabled = true;
            comboEmpleadoID.Location = new Point(446, 321);
            comboEmpleadoID.Name = "comboEmpleadoID";
            comboEmpleadoID.Size = new Size(121, 23);
            comboEmpleadoID.TabIndex = 114;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(446, 297);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 113;
            label8.Text = "Empleado";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(573, 272);
            txtID.Name = "txtID";
            txtID.Size = new Size(40, 23);
            txtID.TabIndex = 112;
            txtID.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(628, 365);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 49);
            btnEliminar.TabIndex = 111;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(628, 310);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(106, 49);
            btnEditar.TabIndex = 110;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(628, 255);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 49);
            btnAgregar.TabIndex = 109;
            btnAgregar.Text = "Crear";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // comboPaquetesID
            // 
            comboPaquetesID.Cursor = Cursors.Hand;
            comboPaquetesID.FormattingEnabled = true;
            comboPaquetesID.Location = new Point(446, 272);
            comboPaquetesID.Name = "comboPaquetesID";
            comboPaquetesID.Size = new Size(121, 23);
            comboPaquetesID.TabIndex = 108;
            // 
            // comboClienteID
            // 
            comboClienteID.Cursor = Cursors.Hand;
            comboClienteID.FormattingEnabled = true;
            comboClienteID.Location = new Point(267, 372);
            comboClienteID.Name = "comboClienteID";
            comboClienteID.Size = new Size(154, 23);
            comboClienteID.TabIndex = 107;
            // 
            // comboSalaID
            // 
            comboSalaID.Cursor = Cursors.Hand;
            comboSalaID.FormattingEnabled = true;
            comboSalaID.Location = new Point(267, 322);
            comboSalaID.Name = "comboSalaID";
            comboSalaID.Size = new Size(154, 23);
            comboSalaID.TabIndex = 106;
            // 
            // dateFin
            // 
            dateFin.Location = new Point(12, 372);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(233, 23);
            dateFin.TabIndex = 105;
            dateFin.Value = new DateTime(2024, 11, 14, 18, 30, 0, 0);
            // 
            // dateInicio
            // 
            dateInicio.Location = new Point(12, 322);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(233, 23);
            dateInicio.TabIndex = 104;
            dateInicio.Value = new DateTime(2024, 11, 14, 14, 20, 0, 0);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 272);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre del evento";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 103;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(267, 272);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ingrese una descripcion";
            txtDescripcion.Size = new Size(154, 23);
            txtDescripcion.TabIndex = 102;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(446, 248);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 101;
            label7.Text = "Paquetes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(267, 348);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 100;
            label6.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(267, 298);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 99;
            label5.Text = "Sala";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(267, 248);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 98;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 348);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 97;
            label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 298);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 96;
            label2.Text = "Fecha Inicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 248);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 95;
            label1.Text = "Nombre del evento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(200, 30);
            label11.TabIndex = 120;
            label11.Text = "Gestionar Eventos";
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 453);
            Controls.Add(label11);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(comboEstado);
            Controls.Add(label9);
            Controls.Add(comboEmpleadoID);
            Controls.Add(label8);
            Controls.Add(txtID);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(comboPaquetesID);
            Controls.Add(comboClienteID);
            Controls.Add(comboSalaID);
            Controls.Add(dateFin);
            Controls.Add(dateInicio);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Eventos";
            Text = "Eventos Empleados";
            Load += Eventos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private DataGridView dataGridView1;
        private Label label10;
        private ComboBox comboEstado;
        private Label label9;
        private ComboBox comboEmpleadoID;
        private Label label8;
        private TextBox txtID;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private ComboBox comboPaquetesID;
        private ComboBox comboClienteID;
        private ComboBox comboSalaID;
        private DateTimePicker dateFin;
        private DateTimePicker dateInicio;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
    }
}