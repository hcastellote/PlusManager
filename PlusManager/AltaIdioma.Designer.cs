namespace PlusManager.UI
{
    partial class AltaIdioma
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
            this.frmAltaIdioma_lbl_NombreIdioma = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.frmAltaIdioma_btn_CrearIdioma = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.frmAltaIdioma_gb_DatosIdioma = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.frmAltaIdioma_gb_DatosIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmAltaIdioma_lbl_NombreIdioma
            // 
            this.frmAltaIdioma_lbl_NombreIdioma.AutoSize = true;
            this.frmAltaIdioma_lbl_NombreIdioma.Location = new System.Drawing.Point(60, 22);
            this.frmAltaIdioma_lbl_NombreIdioma.Name = "frmAltaIdioma_lbl_NombreIdioma";
            this.frmAltaIdioma_lbl_NombreIdioma.Size = new System.Drawing.Size(81, 13);
            this.frmAltaIdioma_lbl_NombreIdioma.TabIndex = 2;
            this.frmAltaIdioma_lbl_NombreIdioma.Text = "Nombre Idioma:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 265);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmAltaIdioma_btn_CrearIdioma
            // 
            this.frmAltaIdioma_btn_CrearIdioma.Location = new System.Drawing.Point(206, 338);
            this.frmAltaIdioma_btn_CrearIdioma.Name = "frmAltaIdioma_btn_CrearIdioma";
            this.frmAltaIdioma_btn_CrearIdioma.Size = new System.Drawing.Size(101, 23);
            this.frmAltaIdioma_btn_CrearIdioma.TabIndex = 4;
            this.frmAltaIdioma_btn_CrearIdioma.Text = "Crear Idioma";
            this.frmAltaIdioma_btn_CrearIdioma.UseVisualStyleBackColor = true;
            this.frmAltaIdioma_btn_CrearIdioma.Click += new System.EventHandler(this.frmAltaIdioma_btn_CrearIdioma_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 5;
            // 
            // frmAltaIdioma_gb_DatosIdioma
            // 
            this.frmAltaIdioma_gb_DatosIdioma.Controls.Add(this.textBox1);
            this.frmAltaIdioma_gb_DatosIdioma.Controls.Add(this.frmAltaIdioma_btn_CrearIdioma);
            this.frmAltaIdioma_gb_DatosIdioma.Controls.Add(this.dataGridView1);
            this.frmAltaIdioma_gb_DatosIdioma.Controls.Add(this.frmAltaIdioma_lbl_NombreIdioma);
            this.frmAltaIdioma_gb_DatosIdioma.Location = new System.Drawing.Point(12, 12);
            this.frmAltaIdioma_gb_DatosIdioma.Name = "frmAltaIdioma_gb_DatosIdioma";
            this.frmAltaIdioma_gb_DatosIdioma.Size = new System.Drawing.Size(537, 367);
            this.frmAltaIdioma_gb_DatosIdioma.TabIndex = 1;
            this.frmAltaIdioma_gb_DatosIdioma.TabStop = false;
            this.frmAltaIdioma_gb_DatosIdioma.Text = "Idiomas";
            // 
            // AltaIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(561, 393);
            this.Controls.Add(this.frmAltaIdioma_gb_DatosIdioma);
            this.Name = "AltaIdioma";
            this.Text = "AltaIdioma";
            this.Load += new System.EventHandler(this.AltaIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.frmAltaIdioma_gb_DatosIdioma.ResumeLayout(false);
            this.frmAltaIdioma_gb_DatosIdioma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label frmAltaIdioma_lbl_NombreIdioma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button frmAltaIdioma_btn_CrearIdioma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox frmAltaIdioma_gb_DatosIdioma;
    }
}