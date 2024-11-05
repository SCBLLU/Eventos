namespace Eventos.Formularios.Administrador
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
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
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(708, 149);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(comboPaquetesID);
            groupBox1.Controls.Add(comboClienteID);
            groupBox1.Controls.Add(comboSalaID);
            groupBox1.Controls.Add(dateFin);
            groupBox1.Controls.Add(dateInicio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 381);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Eventos";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(611, 318);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 49);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(611, 257);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(106, 49);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(611, 189);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 49);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Crear";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // comboPaquetesID
            // 
            comboPaquetesID.FormattingEnabled = true;
            comboPaquetesID.Location = new Point(410, 215);
            comboPaquetesID.Name = "comboPaquetesID";
            comboPaquetesID.Size = new Size(121, 23);
            comboPaquetesID.TabIndex = 14;
            // 
            // comboClienteID
            // 
            comboClienteID.FormattingEnabled = true;
            comboClienteID.Location = new Point(250, 332);
            comboClienteID.Name = "comboClienteID";
            comboClienteID.Size = new Size(154, 23);
            comboClienteID.TabIndex = 13;
            // 
            // comboSalaID
            // 
            comboSalaID.FormattingEnabled = true;
            comboSalaID.Location = new Point(250, 268);
            comboSalaID.Name = "comboSalaID";
            comboSalaID.Size = new Size(154, 23);
            comboSalaID.TabIndex = 12;
            // 
            // dateFin
            // 
            dateFin.Location = new Point(9, 332);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(233, 23);
            dateFin.TabIndex = 11;
            // 
            // dateInicio
            // 
            dateInicio.Location = new Point(9, 268);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(233, 23);
            dateInicio.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(9, 215);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(250, 215);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(154, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(410, 189);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 7;
            label7.Text = "Paquetes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(250, 308);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 6;
            label6.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(250, 244);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 5;
            label5.Text = "Sala";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(250, 189);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 4;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(9, 308);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 3;
            label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 244);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "Fecha Inicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(9, 189);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre del evento";
            // 
            // txtID
            // 
            txtID.Location = new Point(410, 268);
            txtID.Name = "txtID";
            txtID.Size = new Size(121, 23);
            txtID.TabIndex = 18;
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 405);
            Controls.Add(groupBox1);
            Name = "Eventos";
            Text = "Eventos";
            Load += Eventos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
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
        private ComboBox comboPaquetesID;
        private ComboBox comboClienteID;
        private ComboBox comboSalaID;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox txtID;
    }
}