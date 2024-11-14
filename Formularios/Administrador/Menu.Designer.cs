﻿namespace Eventos.Formularios.Administrador
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
            panelsubmenureportes = new Panel();
            repoClientes = new Button();
            repoPaquetes = new Button();
            repoSalas = new Button();
            repoEmpleados = new Button();
            repoEventos = new Button();
            btnReportes = new Button();
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
            label1 = new Label();
            MenuLateral.SuspendLayout();
            panelsubmenureportes.SuspendLayout();
            Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuLateral
            // 
            MenuLateral.AutoScroll = true;
            MenuLateral.BackColor = Color.DarkGray;
            MenuLateral.Controls.Add(panelsubmenureportes);
            MenuLateral.Controls.Add(btnReportes);
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
            // panelsubmenureportes
            // 
            panelsubmenureportes.AutoScroll = true;
            panelsubmenureportes.BackColor = Color.Transparent;
            panelsubmenureportes.Controls.Add(repoClientes);
            panelsubmenureportes.Controls.Add(repoPaquetes);
            panelsubmenureportes.Controls.Add(repoSalas);
            panelsubmenureportes.Controls.Add(repoEmpleados);
            panelsubmenureportes.Controls.Add(repoEventos);
            panelsubmenureportes.Dock = DockStyle.Fill;
            panelsubmenureportes.Location = new Point(0, 377);
            panelsubmenureportes.Name = "panelsubmenureportes";
            panelsubmenureportes.Size = new Size(194, 94);
            panelsubmenureportes.TabIndex = 9;
            // 
            // repoClientes
            // 
            repoClientes.Dock = DockStyle.Top;
            repoClientes.Font = new Font("Segoe UI", 10F);
            repoClientes.Location = new Point(0, 128);
            repoClientes.Margin = new Padding(0);
            repoClientes.Name = "repoClientes";
            repoClientes.Padding = new Padding(30, 0, 0, 0);
            repoClientes.Size = new Size(177, 32);
            repoClientes.TabIndex = 4;
            repoClientes.Text = "Reportes Clientes";
            repoClientes.TextAlign = ContentAlignment.MiddleLeft;
            repoClientes.UseVisualStyleBackColor = true;
            repoClientes.Click += repoClientes_Click;
            // 
            // repoPaquetes
            // 
            repoPaquetes.Dock = DockStyle.Top;
            repoPaquetes.Font = new Font("Segoe UI", 10F);
            repoPaquetes.Location = new Point(0, 96);
            repoPaquetes.Margin = new Padding(0);
            repoPaquetes.Name = "repoPaquetes";
            repoPaquetes.Padding = new Padding(30, 0, 0, 0);
            repoPaquetes.Size = new Size(177, 32);
            repoPaquetes.TabIndex = 3;
            repoPaquetes.Text = "Reportes Paquetes";
            repoPaquetes.TextAlign = ContentAlignment.MiddleLeft;
            repoPaquetes.UseVisualStyleBackColor = true;
            repoPaquetes.Click += repoPaquetes_Click;
            // 
            // repoSalas
            // 
            repoSalas.Dock = DockStyle.Top;
            repoSalas.Font = new Font("Segoe UI", 10F);
            repoSalas.Location = new Point(0, 64);
            repoSalas.Margin = new Padding(0);
            repoSalas.Name = "repoSalas";
            repoSalas.Padding = new Padding(30, 0, 0, 0);
            repoSalas.Size = new Size(177, 32);
            repoSalas.TabIndex = 2;
            repoSalas.Text = "Reporte Salas";
            repoSalas.TextAlign = ContentAlignment.MiddleLeft;
            repoSalas.UseVisualStyleBackColor = true;
            repoSalas.Click += repoSalas_Click;
            // 
            // repoEmpleados
            // 
            repoEmpleados.Dock = DockStyle.Top;
            repoEmpleados.Font = new Font("Segoe UI", 10F);
            repoEmpleados.Location = new Point(0, 32);
            repoEmpleados.Margin = new Padding(0);
            repoEmpleados.Name = "repoEmpleados";
            repoEmpleados.Padding = new Padding(30, 0, 0, 0);
            repoEmpleados.Size = new Size(177, 32);
            repoEmpleados.TabIndex = 1;
            repoEmpleados.Text = "Reporte Empleados";
            repoEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            repoEmpleados.UseVisualStyleBackColor = true;
            repoEmpleados.Click += repoEmpleados_Click;
            // 
            // repoEventos
            // 
            repoEventos.Dock = DockStyle.Top;
            repoEventos.Font = new Font("Segoe UI", 10F);
            repoEventos.Location = new Point(0, 0);
            repoEventos.Margin = new Padding(0);
            repoEventos.Name = "repoEventos";
            repoEventos.Padding = new Padding(30, 0, 0, 0);
            repoEventos.Size = new Size(177, 32);
            repoEventos.TabIndex = 0;
            repoEventos.Text = "Reporte Eventos";
            repoEventos.TextAlign = ContentAlignment.MiddleLeft;
            repoEventos.UseVisualStyleBackColor = true;
            repoEventos.Click += repoEventos_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.White;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReportes.Location = new Point(0, 327);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(15, 0, 0, 0);
            btnReportes.Size = new Size(194, 50);
            btnReportes.TabIndex = 8;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            btnPaquetes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            btnSalas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            btnEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 45);
            label1.TabIndex = 0;
            label1.Text = "Gestor de Eventos";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 521);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(MenuLateral);
            MinimumSize = new Size(975, 560);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            MenuLateral.ResumeLayout(false);
            panelsubmenureportes.ResumeLayout(false);
            Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panelsubmenureportes;
        private Button btnReportes;
        private Button repoClientes;
        private Button repoPaquetes;
        private Button repoSalas;
        private Button repoEmpleados;
        private Button repoEventos;
        private Label label1;
    }
}