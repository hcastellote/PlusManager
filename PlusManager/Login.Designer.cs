namespace PlusManager.UI
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
            this.frmLogin_Btn_Login = new System.Windows.Forms.Button();
            this.frmLogin_txt_Usuario = new System.Windows.Forms.TextBox();
            this.frmLogin_txt_Password = new System.Windows.Forms.TextBox();
            this.frmLogin_lbl_Usuario = new System.Windows.Forms.Label();
            this.frmLogin_lbl_Password = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.frmLogin_lbl_Idioma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmLogin_Btn_Login
            // 
            this.frmLogin_Btn_Login.Location = new System.Drawing.Point(322, 132);
            this.frmLogin_Btn_Login.Name = "frmLogin_Btn_Login";
            this.frmLogin_Btn_Login.Size = new System.Drawing.Size(110, 23);
            this.frmLogin_Btn_Login.TabIndex = 0;
            this.frmLogin_Btn_Login.Text = "Iniciar Sesión";
            this.frmLogin_Btn_Login.UseVisualStyleBackColor = true;
            this.frmLogin_Btn_Login.Click += new System.EventHandler(this.frmLogin_Btn_Login_Click);
            // 
            // frmLogin_txt_Usuario
            // 
            this.frmLogin_txt_Usuario.Location = new System.Drawing.Point(312, 25);
            this.frmLogin_txt_Usuario.Name = "frmLogin_txt_Usuario";
            this.frmLogin_txt_Usuario.Size = new System.Drawing.Size(129, 20);
            this.frmLogin_txt_Usuario.TabIndex = 1;
            // 
            // frmLogin_txt_Password
            // 
            this.frmLogin_txt_Password.Location = new System.Drawing.Point(312, 64);
            this.frmLogin_txt_Password.Name = "frmLogin_txt_Password";
            this.frmLogin_txt_Password.Size = new System.Drawing.Size(129, 20);
            this.frmLogin_txt_Password.TabIndex = 2;
            // 
            // frmLogin_lbl_Usuario
            // 
            this.frmLogin_lbl_Usuario.AutoSize = true;
            this.frmLogin_lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.frmLogin_lbl_Usuario.Location = new System.Drawing.Point(356, 9);
            this.frmLogin_lbl_Usuario.Name = "frmLogin_lbl_Usuario";
            this.frmLogin_lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.frmLogin_lbl_Usuario.TabIndex = 3;
            this.frmLogin_lbl_Usuario.Text = "Usuario";
            // 
            // frmLogin_lbl_Password
            // 
            this.frmLogin_lbl_Password.AutoSize = true;
            this.frmLogin_lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.frmLogin_lbl_Password.Location = new System.Drawing.Point(347, 48);
            this.frmLogin_lbl_Password.Name = "frmLogin_lbl_Password";
            this.frmLogin_lbl_Password.Size = new System.Drawing.Size(61, 13);
            this.frmLogin_lbl_Password.TabIndex = 4;
            this.frmLogin_lbl_Password.Text = "Contraseña";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(312, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmLogin_lbl_Idioma
            // 
            this.frmLogin_lbl_Idioma.AutoSize = true;
            this.frmLogin_lbl_Idioma.BackColor = System.Drawing.Color.Transparent;
            this.frmLogin_lbl_Idioma.Location = new System.Drawing.Point(356, 87);
            this.frmLogin_lbl_Idioma.Name = "frmLogin_lbl_Idioma";
            this.frmLogin_lbl_Idioma.Size = new System.Drawing.Size(38, 13);
            this.frmLogin_lbl_Idioma.TabIndex = 6;
            this.frmLogin_lbl_Idioma.Text = "Idioma";
            // 
            // Login
            // 
            this.BackgroundImage = global::PlusManager.Properties.Resources.logo_login;
            this.ClientSize = new System.Drawing.Size(472, 167);
            this.Controls.Add(this.frmLogin_lbl_Idioma);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.frmLogin_lbl_Password);
            this.Controls.Add(this.frmLogin_lbl_Usuario);
            this.Controls.Add(this.frmLogin_txt_Password);
            this.Controls.Add(this.frmLogin_txt_Usuario);
            this.Controls.Add(this.frmLogin_Btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button frmLogin_Btn_Login;
        private System.Windows.Forms.TextBox frmLogin_txt_Usuario;
        private System.Windows.Forms.TextBox frmLogin_txt_Password;
        private System.Windows.Forms.Label frmLogin_lbl_Usuario;
        private System.Windows.Forms.Label frmLogin_lbl_Password;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label frmLogin_lbl_Idioma;
    }
}