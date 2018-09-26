namespace PlusManager.UI
{
    partial class GestionPermisos
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
            this.frmGestionPermisos_gb_PermisosUsuario = new System.Windows.Forms.GroupBox();
            this.frmGestionPermisos_btn_Guardar = new System.Windows.Forms.Button();
            this.frmGestionPermisos_btn_Quuitar = new System.Windows.Forms.Button();
            this.frmGestionPermisos_btn_Agregar = new System.Windows.Forms.Button();
            this.treePermisosAll = new System.Windows.Forms.TreeView();
            this.treePermisosUsuario = new System.Windows.Forms.TreeView();
            this.frmGestionPermisos_btn_ConsultarUsuario = new System.Windows.Forms.Button();
            this.frmGestionPermisos_lbl_PermisosSistema = new System.Windows.Forms.Label();
            this.frmGestionPermisos_txt_Usuario = new System.Windows.Forms.Label();
            this.frmGestionPermisos_lbl_PermisosUsuario = new System.Windows.Forms.Label();
            this.frmGestionPermisos_cb_Usuario = new System.Windows.Forms.ComboBox();
            this.frmGestionPermisos_gb_PermisosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmGestionPermisos_gb_PermisosUsuario
            // 
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.frmGestionPermisos_cb_Usuario);
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.frmGestionPermisos_btn_Guardar);
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.frmGestionPermisos_btn_Quuitar);
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.frmGestionPermisos_btn_Agregar);
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.treePermisosAll);
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.treePermisosUsuario);
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.frmGestionPermisos_btn_ConsultarUsuario);
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.frmGestionPermisos_lbl_PermisosSistema);
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.frmGestionPermisos_txt_Usuario);
            this.frmGestionPermisos_gb_PermisosUsuario.Controls.Add(this.frmGestionPermisos_lbl_PermisosUsuario);
            this.frmGestionPermisos_gb_PermisosUsuario.Location = new System.Drawing.Point(21, 12);
            this.frmGestionPermisos_gb_PermisosUsuario.Name = "frmGestionPermisos_gb_PermisosUsuario";
            this.frmGestionPermisos_gb_PermisosUsuario.Size = new System.Drawing.Size(557, 360);
            this.frmGestionPermisos_gb_PermisosUsuario.TabIndex = 0;
            this.frmGestionPermisos_gb_PermisosUsuario.TabStop = false;
            this.frmGestionPermisos_gb_PermisosUsuario.Text = "Datos de Permisos";
            this.frmGestionPermisos_gb_PermisosUsuario.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmGestionPermisos_btn_Guardar
            // 
            this.frmGestionPermisos_btn_Guardar.Location = new System.Drawing.Point(466, 21);
            this.frmGestionPermisos_btn_Guardar.Name = "frmGestionPermisos_btn_Guardar";
            this.frmGestionPermisos_btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.frmGestionPermisos_btn_Guardar.TabIndex = 6;
            this.frmGestionPermisos_btn_Guardar.Text = "Guardar";
            this.frmGestionPermisos_btn_Guardar.UseVisualStyleBackColor = true;
            this.frmGestionPermisos_btn_Guardar.Click += new System.EventHandler(this.frmGestionPermisos_btn_Guardar_Click);
            // 
            // frmGestionPermisos_btn_Quuitar
            // 
            this.frmGestionPermisos_btn_Quuitar.Location = new System.Drawing.Point(246, 191);
            this.frmGestionPermisos_btn_Quuitar.Name = "frmGestionPermisos_btn_Quuitar";
            this.frmGestionPermisos_btn_Quuitar.Size = new System.Drawing.Size(63, 23);
            this.frmGestionPermisos_btn_Quuitar.TabIndex = 5;
            this.frmGestionPermisos_btn_Quuitar.Text = "Quitar";
            this.frmGestionPermisos_btn_Quuitar.UseVisualStyleBackColor = true;
            this.frmGestionPermisos_btn_Quuitar.Click += new System.EventHandler(this.frmGestionPermisos_btn_Quuitar_Click);
            // 
            // frmGestionPermisos_btn_Agregar
            // 
            this.frmGestionPermisos_btn_Agregar.Location = new System.Drawing.Point(246, 125);
            this.frmGestionPermisos_btn_Agregar.Name = "frmGestionPermisos_btn_Agregar";
            this.frmGestionPermisos_btn_Agregar.Size = new System.Drawing.Size(63, 23);
            this.frmGestionPermisos_btn_Agregar.TabIndex = 4;
            this.frmGestionPermisos_btn_Agregar.Text = "Agregar";
            this.frmGestionPermisos_btn_Agregar.UseVisualStyleBackColor = true;
            this.frmGestionPermisos_btn_Agregar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // treePermisosAll
            // 
            this.treePermisosAll.Location = new System.Drawing.Point(6, 72);
            this.treePermisosAll.Name = "treePermisosAll";
            this.treePermisosAll.Size = new System.Drawing.Size(234, 273);
            this.treePermisosAll.TabIndex = 3;
            // 
            // treePermisosUsuario
            // 
            this.treePermisosUsuario.Location = new System.Drawing.Point(315, 72);
            this.treePermisosUsuario.Name = "treePermisosUsuario";
            this.treePermisosUsuario.Size = new System.Drawing.Size(236, 273);
            this.treePermisosUsuario.TabIndex = 3;
            // 
            // frmGestionPermisos_btn_ConsultarUsuario
            // 
            this.frmGestionPermisos_btn_ConsultarUsuario.Location = new System.Drawing.Point(222, 21);
            this.frmGestionPermisos_btn_ConsultarUsuario.Name = "frmGestionPermisos_btn_ConsultarUsuario";
            this.frmGestionPermisos_btn_ConsultarUsuario.Size = new System.Drawing.Size(121, 23);
            this.frmGestionPermisos_btn_ConsultarUsuario.TabIndex = 2;
            this.frmGestionPermisos_btn_ConsultarUsuario.Text = "Consultar Permisos";
            this.frmGestionPermisos_btn_ConsultarUsuario.UseVisualStyleBackColor = true;
            this.frmGestionPermisos_btn_ConsultarUsuario.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmGestionPermisos_lbl_PermisosSistema
            // 
            this.frmGestionPermisos_lbl_PermisosSistema.AutoSize = true;
            this.frmGestionPermisos_lbl_PermisosSistema.Location = new System.Drawing.Point(6, 56);
            this.frmGestionPermisos_lbl_PermisosSistema.Name = "frmGestionPermisos_lbl_PermisosSistema";
            this.frmGestionPermisos_lbl_PermisosSistema.Size = new System.Drawing.Size(106, 13);
            this.frmGestionPermisos_lbl_PermisosSistema.TabIndex = 0;
            this.frmGestionPermisos_lbl_PermisosSistema.Text = "Permisos del Sistema";
            // 
            // frmGestionPermisos_txt_Usuario
            // 
            this.frmGestionPermisos_txt_Usuario.AutoSize = true;
            this.frmGestionPermisos_txt_Usuario.Location = new System.Drawing.Point(21, 29);
            this.frmGestionPermisos_txt_Usuario.Name = "frmGestionPermisos_txt_Usuario";
            this.frmGestionPermisos_txt_Usuario.Size = new System.Drawing.Size(43, 13);
            this.frmGestionPermisos_txt_Usuario.TabIndex = 0;
            this.frmGestionPermisos_txt_Usuario.Text = "Usuario";
            // 
            // frmGestionPermisos_lbl_PermisosUsuario
            // 
            this.frmGestionPermisos_lbl_PermisosUsuario.AutoSize = true;
            this.frmGestionPermisos_lbl_PermisosUsuario.Location = new System.Drawing.Point(312, 56);
            this.frmGestionPermisos_lbl_PermisosUsuario.Name = "frmGestionPermisos_lbl_PermisosUsuario";
            this.frmGestionPermisos_lbl_PermisosUsuario.Size = new System.Drawing.Size(151, 13);
            this.frmGestionPermisos_lbl_PermisosUsuario.TabIndex = 0;
            this.frmGestionPermisos_lbl_PermisosUsuario.Text = "Permisos Asignados al Usuario";
            // 
            // frmGestionPermisos_cb_Usuario
            // 
            this.frmGestionPermisos_cb_Usuario.FormattingEnabled = true;
            this.frmGestionPermisos_cb_Usuario.Location = new System.Drawing.Point(80, 23);
            this.frmGestionPermisos_cb_Usuario.Name = "frmGestionPermisos_cb_Usuario";
            this.frmGestionPermisos_cb_Usuario.Size = new System.Drawing.Size(121, 21);
            this.frmGestionPermisos_cb_Usuario.TabIndex = 7;
            // 
            // GestionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(590, 384);
            this.Controls.Add(this.frmGestionPermisos_gb_PermisosUsuario);
            this.Name = "GestionPermisos";
            this.Text = "GestionPermisos";
            this.Load += new System.EventHandler(this.GestionPermisos_Load);
            this.frmGestionPermisos_gb_PermisosUsuario.ResumeLayout(false);
            this.frmGestionPermisos_gb_PermisosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox frmGestionPermisos_gb_PermisosUsuario;
        private System.Windows.Forms.TreeView treePermisosUsuario;
        private System.Windows.Forms.Button frmGestionPermisos_btn_ConsultarUsuario;
        private System.Windows.Forms.Label frmGestionPermisos_lbl_PermisosUsuario;
        private System.Windows.Forms.Button frmGestionPermisos_btn_Guardar;
        private System.Windows.Forms.Button frmGestionPermisos_btn_Quuitar;
        private System.Windows.Forms.Button frmGestionPermisos_btn_Agregar;
        private System.Windows.Forms.TreeView treePermisosAll;
        private System.Windows.Forms.Label frmGestionPermisos_lbl_PermisosSistema;
        private System.Windows.Forms.Label frmGestionPermisos_txt_Usuario;
        private System.Windows.Forms.ComboBox frmGestionPermisos_cb_Usuario;
    }
}