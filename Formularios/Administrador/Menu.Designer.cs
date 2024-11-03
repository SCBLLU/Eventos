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
            btnInformes = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // MenuLateral
            // 
            MenuLateral.AutoScroll = true;
            MenuLateral.BackColor = SystemColors.ActiveCaption;
            MenuLateral.Controls.Add(btnInformes);
            MenuLateral.Controls.Add(btnPaquetes);
            MenuLateral.Controls.Add(btnSalas);
            MenuLateral.Controls.Add(btnEmpleado);
            MenuLateral.Controls.Add(btnEventos);
            MenuLateral.Controls.Add(btnSalir);
            MenuLateral.Controls.Add(Logo);
            MenuLateral.Dock = DockStyle.Left;
            MenuLateral.Location = new Point(0, 0);
            MenuLateral.Name = "MenuLateral";
            MenuLateral.Size = new Size(194, 458);
            MenuLateral.TabIndex = 0;
            // 
            // btnInformes
            // 
            btnInformes.Dock = DockStyle.Top;
            btnInformes.Location = new Point(0, 301);
            btnInformes.Name = "btnInformes";
            btnInformes.Padding = new Padding(10, 0, 0, 0);
            btnInformes.Size = new Size(194, 56);
            btnInformes.TabIndex = 6;
            btnInformes.Text = "Informes";
            btnInformes.TextAlign = ContentAlignment.MiddleLeft;
            btnInformes.UseVisualStyleBackColor = true;
            // 
            // btnPaquetes
            // 
            btnPaquetes.Dock = DockStyle.Top;
            btnPaquetes.Location = new Point(0, 245);
            btnPaquetes.Name = "btnPaquetes";
            btnPaquetes.Padding = new Padding(10, 0, 0, 0);
            btnPaquetes.Size = new Size(194, 56);
            btnPaquetes.TabIndex = 5;
            btnPaquetes.Text = "Paquetes";
            btnPaquetes.TextAlign = ContentAlignment.MiddleLeft;
            btnPaquetes.UseVisualStyleBackColor = true;
            // 
            // btnSalas
            // 
            btnSalas.Dock = DockStyle.Top;
            btnSalas.Location = new Point(0, 189);
            btnSalas.Name = "btnSalas";
            btnSalas.Padding = new Padding(10, 0, 0, 0);
            btnSalas.Size = new Size(194, 56);
            btnSalas.TabIndex = 4;
            btnSalas.Text = "Salas";
            btnSalas.TextAlign = ContentAlignment.MiddleLeft;
            btnSalas.UseVisualStyleBackColor = true;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Dock = DockStyle.Top;
            btnEmpleado.Location = new Point(0, 133);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Padding = new Padding(10, 0, 0, 0);
            btnEmpleado.Size = new Size(194, 56);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnEventos
            // 
            btnEventos.Dock = DockStyle.Top;
            btnEventos.Location = new Point(0, 77);
            btnEventos.Name = "btnEventos";
            btnEventos.Padding = new Padding(10, 0, 0, 0);
            btnEventos.Size = new Size(194, 56);
            btnEventos.TabIndex = 2;
            btnEventos.Text = "Eventos";
            btnEventos.TextAlign = ContentAlignment.MiddleLeft;
            btnEventos.UseVisualStyleBackColor = true;
            btnEventos.Click += btnEventos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.Location = new Point(0, 408);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(194, 50);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Cerrar Sesión";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            Logo.BackColor = SystemColors.InactiveCaptionText;
            Logo.Dock = DockStyle.Top;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(194, 77);
            Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 261);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(194, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 74);
            panel1.TabIndex = 2;
            // 
            // Contenedor
            // 
            Contenedor.BackColor = Color.CornflowerBlue;
            Contenedor.Controls.Add(pictureBox1);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(194, 74);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(614, 384);
            Contenedor.TabIndex = 3;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 458);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(MenuLateral);
            MinimumSize = new Size(800, 460);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            MenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Contenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuLateral;
        private Button btnSalir;
        private Button btnPaquetes;
        private Button btnSalas;
        private Button btnEmpleado;
        private Button btnEventos;
        private Button btnInformes;
        private Panel Logo;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel Contenedor;
    }
}