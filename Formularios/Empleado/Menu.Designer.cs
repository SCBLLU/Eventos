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
            btnClientes = new Button();
            btnEventos = new Button();
            btnSalir = new Button();
            Logo = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Contenedor = new Panel();
            MenuLateral.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuLateral
            // 
            MenuLateral.AutoScroll = true;
            MenuLateral.BackColor = SystemColors.ActiveCaption;
            MenuLateral.Controls.Add(btnClientes);
            MenuLateral.Controls.Add(btnEventos);
            MenuLateral.Controls.Add(btnSalir);
            MenuLateral.Controls.Add(Logo);
            MenuLateral.Dock = DockStyle.Left;
            MenuLateral.Location = new Point(0, 0);
            MenuLateral.Name = "MenuLateral";
            MenuLateral.Size = new Size(194, 518);
            MenuLateral.TabIndex = 1;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.Location = new Point(0, 133);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(10, 0, 0, 0);
            btnClientes.Size = new Size(194, 56);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
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
            btnSalir.Location = new Point(0, 468);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(194, 50);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Cerrar Sesión";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(194, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 74);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Contenedor
            // 
            Contenedor.BackColor = Color.CornflowerBlue;
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(194, 74);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(763, 444);
            Contenedor.TabIndex = 4;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 518);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(MenuLateral);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            MenuLateral.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}