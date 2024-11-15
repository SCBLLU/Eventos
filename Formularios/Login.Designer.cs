namespace Eventos.Formularios
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            InputUser = new TextBox();
            InputPassword = new TextBox();
            btnInicio = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(292, 141);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(292, 200);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // InputUser
            // 
            InputUser.Location = new Point(292, 165);
            InputUser.Name = "InputUser";
            InputUser.PlaceholderText = "Ingrese su usuario";
            InputUser.Size = new Size(180, 23);
            InputUser.TabIndex = 2;
            // 
            // InputPassword
            // 
            InputPassword.Location = new Point(292, 224);
            InputPassword.Name = "InputPassword";
            InputPassword.PlaceholderText = "Ingrese la contraseña";
            InputPassword.Size = new Size(180, 23);
            InputPassword.TabIndex = 3;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInicio.Location = new Point(292, 276);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(180, 46);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "Ingresar";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label3.Location = new Point(247, 64);
            label3.Name = "label3";
            label3.Size = new Size(250, 45);
            label3.TabIndex = 5;
            label3.Text = "Inicio de sesión\r\n";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 411);
            Controls.Add(label3);
            Controls.Add(btnInicio);
            Controls.Add(InputPassword);
            Controls.Add(InputUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox InputUser;
        private TextBox InputPassword;
        private Button btnInicio;
        private Label label3;
    }
}