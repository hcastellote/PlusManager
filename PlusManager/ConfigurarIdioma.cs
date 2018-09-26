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
    public partial class ConfigurarIdioma : Form, IObserver
    {
        private Servicios.GestorIdiomas _unIdiomaGestor;
        private Idioma.Idioma _unIdioma;

        public ConfigurarIdioma()
        {
            InitializeComponent();
        }

        private void ConfigurarIdioma_Load(object sender, EventArgs e)
        {
            _unIdiomaGestor = new Servicios.GestorIdiomas();
            _unIdioma = new Idioma.Idioma();
            CargarDatos();
            CargarTraducciones();
            Subject.AgregarObserver(this);

            _unIdioma = SessionManager.Instance._idiomaUsuario.idioma;
            CargarIdiomaForm(_unIdioma);
        }

        private void CargarTraducciones()
        {
            DataRow row = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Etiqueta");
            dt.Columns.Add("Palabra");

            foreach (KeyValuePair<string, string> etiqueta in _unIdiomaGestor.listarTraducciones(comboBox1.SelectedItem.ToString()))
            {
                row = dt.NewRow();
                row["Etiqueta"] = etiqueta.Key;
                row["Palabra"] = etiqueta.Value;
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void CargarDatos()
        {
            foreach (Idioma.Idioma idioma in _unIdiomaGestor.listarIdiomas())
            {
                comboBox1.Items.Add(idioma.Descripcion);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void CargarIdiomaForm(Idioma.Idioma _idiomaUdate)
        {
            this.Text = _idiomaUdate.Traducccion["frmConfigurarIdiomaTitulo"];
            frmConfigurarIdioma_gb_Idiomas.Text = _idiomaUdate.Traducccion["frmConfigurarIdiomaDatos"];
            frmConfigurarIdioma_lbl_Idioma.Text = _idiomaUdate.Traducccion["frmConfigurarIdiomaIdioma"];
            frmConfigurarIdioma_btn_GuardarCambios.Text = _idiomaUdate.Traducccion["frmConfigurarIdiomaGuardarCambios"];
        }

        //observer
        void IObserver.Update(Idioma.Idioma _idiomaUdate)
        {
            this.Text = _idiomaUdate.Traducccion["frmConfigurarIdiomaTitulo"];
            frmConfigurarIdioma_gb_Idiomas.Text = _idiomaUdate.Traducccion["frmConfigurarIdiomaDatos"];
            frmConfigurarIdioma_lbl_Idioma.Text = _idiomaUdate.Traducccion["frmConfigurarIdiomaIdioma"];
            frmConfigurarIdioma_btn_GuardarCambios.Text = _idiomaUdate.Traducccion["frmConfigurarIdiomaGuardarCambios"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTraducciones();
        }

        private void frmConfigurarIdioma_btn_GuardarCambios_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un Idioma de la lista.");
                return;
            }

            Idioma.Idioma _idiomaAlta = new Idioma.Idioma();
            _idiomaAlta.Descripcion = comboBox1.SelectedItem.ToString();
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
            MessageBox.Show(_unIdiomaGestor.ActualizarIdioma(_idiomaAlta));
        }
    }
}
