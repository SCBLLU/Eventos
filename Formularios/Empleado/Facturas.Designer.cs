namespace Eventos.Formularios.Empleado
{
    partial class Facturas
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
            txtBuscar = new TextBox();
            txtID = new TextBox();
            comboEvento = new ComboBox();
            comboCliente = new ComboBox();
            dateFecha = new DateTimePicker();
            inputMonto = new NumericUpDown();
            comboEstado = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnCrear = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputMonto).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(725, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 45);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un valor para filtrar...";
            txtBuscar.Size = new Size(196, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(637, 246);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 2;
            txtID.Visible = false;
            // 
            // comboEvento
            // 
            comboEvento.FormattingEnabled = true;
            comboEvento.Location = new Point(12, 268);
            comboEvento.Name = "comboEvento";
            comboEvento.Size = new Size(150, 23);
            comboEvento.TabIndex = 3;
            // 
            // comboCliente
            // 
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(12, 334);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(150, 23);
            comboCliente.TabIndex = 4;
            // 
            // dateFecha
            // 
            dateFecha.Location = new Point(205, 268);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(233, 23);
            dateFecha.TabIndex = 5;
            // 
            // inputMonto
            // 
            inputMonto.Location = new Point(12, 398);
            inputMonto.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            inputMonto.Name = "inputMonto";
            inputMonto.Size = new Size(149, 23);
            inputMonto.TabIndex = 6;
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Location = new Point(205, 334);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(141, 23);
            comboEstado.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 244);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 8;
            label1.Text = "Seleccione el Evento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 310);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 9;
            label2.Text = "Seleccione el Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 374);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 10;
            label3.Text = "Seleccione el Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(205, 244);
            label4.Name = "label4";
            label4.Size = new Size(141, 21);
            label4.TabIndex = 11;
            label4.Text = "Fecha de la Factura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(205, 310);
            label5.Name = "label5";
            label5.Size = new Size(149, 21);
            label5.TabIndex = 12;
            label5.Text = "Seleccione el Estado";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(625, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 42);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar Factura";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(625, 334);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 42);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar Factura";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(625, 276);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(112, 42);
            btnCrear.TabIndex = 15;
            btnCrear.Text = "Crear Factura";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(205, 30);
            label10.TabIndex = 94;
            label10.Text = "Gestionar Facturas";
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 455);
            Controls.Add(label10);
            Controls.Add(btnCrear);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboEstado);
            Controls.Add(inputMonto);
            Controls.Add(dateFecha);
            Controls.Add(comboCliente);
            Controls.Add(comboEvento);
            Controls.Add(txtID);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            Name = "Facturas";
            Text = "Facturas";
            Load += Facturas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private TextBox txtID;
        private ComboBox comboEvento;
        private ComboBox comboCliente;
        private DateTimePicker dateFecha;
        private NumericUpDown inputMonto;
        private ComboBox comboEstado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnCrear;
        private Label label10;
    }
}