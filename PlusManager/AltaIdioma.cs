using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sistema;
using Idioma;

namespace PlusManager.UI
{
    public partial class AltaIdioma : Form, IObserver
    {
        private Servicios.GestorIdiomas _unIdiomaGestor;
        private Idioma.Idioma _unIdioma;
        

        public AltaIdioma()
        {
            InitializeComponent();
        }

        private void AltaIdioma_Load(object sender, EventArgs e)
        {
            _unIdiomaGestor = new Servicios.GestorIdiomas();
            _unIdioma = new Idioma.Idioma();
            DataRow row = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Etiqueta");
            dt.Columns.Add("Palabra");


            foreach (string etiqueta in _unIdiomaGestor.listarEtiquetas())
            {
                row = dt.NewRow();
                row["Etiqueta"] = etiqueta;
                row["Palabra"] = "";
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
           
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            Subject.AgregarObserver(this);
            _unIdioma = SessionManager.Instance._idiomaUsuario.idioma;
            CargarIdiomaForm(_unIdioma);
        }

        

        private void frmAltaIdioma_btn_CrearIdioma_Click(object sender, EventArgs e)
        { 

            Idioma.Idioma _idiomaAlta = new Idioma.Idioma();
            _idiomaAlta.Descripcion = textBox1.Text;
            Dictionary<string, string> listaEtiquetas = new Dictionary<string, string>();

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Cells["Palabra"].Value.ToString() == "")
                {
                    MessageBox.Show("Debe agregar una traducción para todas las etiquetas.");
                    return;
                }
                if (r.Cells["Etiqueta"] != null)
                    listaEtiquetas.Add(r.Cells["Etiqueta"].Value.ToString(), r.Cells["Palabra"].Value.ToString());

            }
            _idiomaAlta.Traducccion = listaEtiquetas;
            MessageBox.Show(_unIdiomaGestor.crearIdioma(_idiomaAlta));
            
        }

        private void CargarIdiomaForm(Idioma.Idioma _idiomaUdate)
        {
            this.Text = _idiomaUdate.Traducccion["frmGestionIdiomaTitulo"];
            frmAltaIdioma_gb_DatosIdioma.Text = _idiomaUdate.Traducccion["frmGestionIdiomaDatos"];
            frmAltaIdioma_lbl_NombreIdioma.Text = _idiomaUdate.Traducccion["frmGestionIdiomaNombreIdioma"];
            frmAltaIdioma_btn_CrearIdioma.Text = _idiomaUdate.Traducccion["frmGestionIdiomaCrearIdioma"];
        }

        //observer
        void IObserver.Update(Idioma.Idioma _idiomaUdate)
        {
            this.Text = _idiomaUdate.Traducccion["frmGestionIdiomaTitulo"];
            frmAltaIdioma_gb_DatosIdioma.Text = _idiomaUdate.Traducccion["frmGestionIdiomaDatos"];
            frmAltaIdioma_lbl_NombreIdioma.Text = _idiomaUdate.Traducccion["frmGestionIdiomaNombreIdioma"];
            frmAltaIdioma_btn_CrearIdioma.Text = _idiomaUdate.Traducccion["frmGestionIdiomaCrearIdioma"];
        }
    }
}
