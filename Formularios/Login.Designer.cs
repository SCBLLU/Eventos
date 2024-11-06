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
            label1 = new Label();
            label2 = new Label();
            InputUser = new TextBox();
            InputPassword = new TextBox();
            btnInicio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 116);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 185);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // InputUser
            // 
            InputUser.Location = new Point(292, 134);
            InputUser.Name = "InputUser";
            InputUser.Size = new Size(177, 23);
            InputUser.TabIndex = 2;
            // 
            // InputPassword
            // 
            InputPassword.Location = new Point(292, 203);
            InputPassword.Name = "InputPassword";
            InputPassword.Size = new Size(177, 23);
            InputPassword.TabIndex = 3;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(292, 288);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(177, 32);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "Iniciar Sesion";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 411);
            Controls.Add(btnInicio);
            Controls.Add(InputPassword);
            Controls.Add(InputUser);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}