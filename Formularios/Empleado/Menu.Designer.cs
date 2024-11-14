namespace Eventos.Formularios.Empleado
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            MenuLateral = new Panel();
            btnFacturas = new Button();
            btnClientes = new Button();
            btnEventos = new Button();
            btnSalir = new Button();
            Logo = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Contenedor = new Panel();
            label1 = new Label();
            MenuLateral.SuspendLayout();
            Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuLateral
            // 
            MenuLateral.AutoScroll = true;
            MenuLateral.BackColor = Color.DarkGray;
            MenuLateral.Controls.Add(btnFacturas);
            MenuLateral.Controls.Add(btnClientes);
            MenuLateral.Controls.Add(btnEventos);
            MenuLateral.Controls.Add(btnSalir);
            MenuLateral.Controls.Add(Logo);
            MenuLateral.Dock = DockStyle.Left;
            MenuLateral.Location = new Point(0, 0);
            MenuLateral.Name = "MenuLateral";
            MenuLateral.Size = new Size(194, 521);
            MenuLateral.TabIndex = 1;
            // 
            // btnFacturas
            // 
            btnFacturas.BackColor = Color.White;
            btnFacturas.Dock = DockStyle.Top;
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFacturas.Location = new Point(0, 177);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Padding = new Padding(15, 0, 0, 0);
            btnFacturas.Size = new Size(194, 50);
            btnFacturas.TabIndex = 8;
            btnFacturas.Text = "Facturas";
            btnFacturas.TextAlign = ContentAlignment.MiddleLeft;
            btnFacturas.UseVisualStyleBackColor = false;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClientes.Location = new Point(0, 127);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(15, 0, 0, 0);
            btnClientes.Size = new Size(194, 50);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnEventos
            // 
            btnEventos.BackColor = Color.White;
            btnEventos.Dock = DockStyle.Top;
            btnEventos.FlatStyle = FlatStyle.Flat;
            btnEventos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEventos.Location = new Point(0, 77);
            btnEventos.Name = "btnEventos";
            btnEventos.Padding = new Padding(15, 0, 0, 0);
            btnEventos.Size = new Size(194, 50);
            btnEventos.TabIndex = 2;
            btnEventos.Text = "Eventos";
            btnEventos.TextAlign = ContentAlignment.MiddleLeft;
            btnEventos.UseVisualStyleBackColor = false;
            btnEventos.Click += btnEventos_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(0, 471);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(15, 0, 0, 0);
            btnSalir.Size = new Size(194, 50);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Cerrar Sesión";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Gray;
            Logo.Controls.Add(pictureBox1);
            Logo.Dock = DockStyle.Top;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(194, 77);
            Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(194, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 71);
            panel1.TabIndex = 3;
            // 
            // Contenedor
            // 
            Contenedor.BackColor = Color.LightGray;
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(194, 71);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(760, 450);
            Contenedor.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 45);
            label1.TabIndex = 5;
            label1.Text = "Gestor de Eventos";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 521);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(MenuLateral);
            MinimumSize = new Size(970, 560);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            MenuLateral.ResumeLayout(false);
            Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuLateral;
        private Button btnClientes;
        private Button btnEventos;
        private Button btnSalir;
        private Panel Logo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel Contenedor;
        private Button btnFacturas;
        private Label label1;
    }
}