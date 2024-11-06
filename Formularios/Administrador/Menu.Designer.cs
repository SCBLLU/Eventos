namespace Eventos.Formularios.Administrador
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
            btnClientes = new Button();
            btnPaquetes = new Button();
            btnSalas = new Button();
            btnEmpleado = new Button();
            btnEventos = new Button();
            btnSalir = new Button();
            Logo = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Contenedor = new Panel();
            MenuLateral.SuspendLayout();
            Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuLateral
            // 
            MenuLateral.AutoScroll = true;
            MenuLateral.BackColor = Color.DarkGray;
            MenuLateral.Controls.Add(btnClientes);
            MenuLateral.Controls.Add(btnPaquetes);
            MenuLateral.Controls.Add(btnSalas);
            MenuLateral.Controls.Add(btnEmpleado);
            MenuLateral.Controls.Add(btnEventos);
            MenuLateral.Controls.Add(btnSalir);
            MenuLateral.Controls.Add(Logo);
            MenuLateral.Dock = DockStyle.Left;
            MenuLateral.Location = new Point(0, 0);
            MenuLateral.Name = "MenuLateral";
            MenuLateral.Size = new Size(194, 521);
            MenuLateral.TabIndex = 0;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F);
            btnClientes.Location = new Point(0, 277);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(15, 0, 0, 0);
            btnClientes.Size = new Size(194, 50);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnPaquetes
            // 
            btnPaquetes.BackColor = Color.White;
            btnPaquetes.Dock = DockStyle.Top;
            btnPaquetes.FlatStyle = FlatStyle.Flat;
            btnPaquetes.Font = new Font("Segoe UI", 12F);
            btnPaquetes.Location = new Point(0, 227);
            btnPaquetes.Name = "btnPaquetes";
            btnPaquetes.Padding = new Padding(15, 0, 0, 0);
            btnPaquetes.Size = new Size(194, 50);
            btnPaquetes.TabIndex = 5;
            btnPaquetes.Text = "Paquetes";
            btnPaquetes.TextAlign = ContentAlignment.MiddleLeft;
            btnPaquetes.UseVisualStyleBackColor = false;
            btnPaquetes.Click += btnPaquetes_Click;
            // 
            // btnSalas
            // 
            btnSalas.BackColor = Color.White;
            btnSalas.Dock = DockStyle.Top;
            btnSalas.FlatStyle = FlatStyle.Flat;
            btnSalas.Font = new Font("Segoe UI", 12F);
            btnSalas.Location = new Point(0, 177);
            btnSalas.Name = "btnSalas";
            btnSalas.Padding = new Padding(15, 0, 0, 0);
            btnSalas.Size = new Size(194, 50);
            btnSalas.TabIndex = 4;
            btnSalas.Text = "Salas";
            btnSalas.TextAlign = ContentAlignment.MiddleLeft;
            btnSalas.UseVisualStyleBackColor = false;
            btnSalas.Click += btnSalas_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.White;
            btnEmpleado.Dock = DockStyle.Top;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Segoe UI", 12F);
            btnEmpleado.Location = new Point(0, 127);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Padding = new Padding(15, 0, 0, 0);
            btnEmpleado.Size = new Size(194, 50);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnEventos
            // 
            btnEventos.BackColor = Color.White;
            btnEventos.Dock = DockStyle.Top;
            btnEventos.FlatStyle = FlatStyle.Flat;
            btnEventos.Font = new Font("Segoe UI", 12F);
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
            btnSalir.Font = new Font("Segoe UI", 12F);
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
            panel1.BackColor = Color.Silver;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(194, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 71);
            panel1.TabIndex = 2;
            // 
            // Contenedor
            // 
            Contenedor.BackColor = Color.LightGray;
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(194, 71);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(765, 450);
            Contenedor.TabIndex = 3;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 521);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(MenuLateral);
            MinimumSize = new Size(800, 460);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            MenuLateral.ResumeLayout(false);
            Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuLateral;
        private Button btnSalir;
        private Button btnPaquetes;
        private Button btnSalas;
        private Button btnEmpleado;
        private Button btnEventos;
        private Panel Logo;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel Contenedor;
        private Button btnClientes;
    }
}