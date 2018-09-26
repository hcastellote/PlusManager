namespace PlusManager.UI
{
    partial class ConfigurarIdioma
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
            this.frmConfigurarIdioma_gb_Idiomas = new System.Windows.Forms.GroupBox();
            this.frmConfigurarIdioma_btn_GuardarCambios = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.frmConfigurarIdioma_lbl_Idioma = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.frmConfigurarIdioma_gb_Idiomas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // frmConfigurarIdioma_gb_Idiomas
            // 
            this.frmConfigurarIdioma_gb_Idiomas.Controls.Add(this.frmConfigurarIdioma_btn_GuardarCambios);
            this.frmConfigurarIdioma_gb_Idiomas.Controls.Add(this.dataGridView1);
            this.frmConfigurarIdioma_gb_Idiomas.Controls.Add(this.frmConfigurarIdioma_lbl_Idioma);
            this.frmConfigurarIdioma_gb_Idiomas.Controls.Add(this.comboBox1);
            this.frmConfigurarIdioma_gb_Idiomas.Location = new System.Drawing.Point(12, 12);
            this.frmConfigurarIdioma_gb_Idiomas.Name = "frmConfigurarIdioma_gb_Idiomas";
            this.frmConfigurarIdioma_gb_Idiomas.Size = new System.Drawing.Size(578, 259);
            this.frmConfigurarIdioma_gb_Idiomas.TabIndex = 0;
            this.frmConfigurarIdioma_gb_Idiomas.TabStop = false;
            this.frmConfigurarIdioma_gb_Idiomas.Text = "Idiomas";
            // 
            // frmConfigurarIdioma_btn_GuardarCambios
            // 
            this.frmConfigurarIdioma_btn_GuardarCambios.Location = new System.Drawing.Point(179, 217);
            this.frmConfigurarIdioma_btn_GuardarCambios.Name = "frmConfigurarIdioma_btn_GuardarCambios";
            this.frmConfigurarIdioma_btn_GuardarCambios.Size = new System.Drawing.Size(224, 23);
            this.frmConfigurarIdioma_btn_GuardarCambios.TabIndex = 4;
            this.frmConfigurarIdioma_btn_GuardarCambios.Text = "Guardar Cambios";
            this.frmConfigurarIdioma_btn_GuardarCambios.UseVisualStyleBackColor = true;
            this.frmConfigurarIdioma_btn_GuardarCambios.Click += new System.EventHandler(this.frmConfigurarIdioma_btn_GuardarCambios_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 137);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmConfigurarIdioma_lbl_Idioma
            // 
            this.frmConfigurarIdioma_lbl_Idioma.AutoSize = true;
            this.frmConfigurarIdioma_lbl_Idioma.Location = new System.Drawing.Point(154, 24);
            this.frmConfigurarIdioma_lbl_Idioma.Name = "frmConfigurarIdioma_lbl_Idioma";
            this.frmConfigurarIdioma_lbl_Idioma.Size = new System.Drawing.Size(41, 13);
            this.frmConfigurarIdioma_lbl_Idioma.TabIndex = 2;
            this.frmConfigurarIdioma_lbl_Idioma.Text = "Idioma:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ConfigurarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(602, 283);
            this.Controls.Add(this.frmConfigurarIdioma_gb_Idiomas);
            this.Name = "ConfigurarIdioma";
            this.Text = "ConfigurarIdioma";
            this.Load += new System.EventHandler(this.ConfigurarIdioma_Load);
            this.frmConfigurarIdioma_gb_Idiomas.ResumeLayout(false);
            this.frmConfigurarIdioma_gb_Idiomas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox frmConfigurarIdioma_gb_Idiomas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label frmConfigurarIdioma_lbl_Idioma;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button frmConfigurarIdioma_btn_GuardarCambios;
    }
}