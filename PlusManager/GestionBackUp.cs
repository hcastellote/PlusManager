using Idioma;
using Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlusManager.UI
{
    public partial class GestionBackUp : Form, IObserver
    {
        private Servicios.GestorIdiomas _unIdiomaGestor;
        private Idioma.Idioma _unIdioma;
        private Sistema.GestorBackUp _unBackUpGestor;
        public GestionBackUp()
        {
            InitializeComponent();
        }

        private void GestionBackUp_Load(object sender, EventArgs e)
        {
            _unIdiomaGestor = new Servicios.GestorIdiomas();
            _unIdioma = new Idioma.Idioma();
            _unIdioma = SessionManager.Instance._idiomaUsuario.idioma;
            CargarIdiomaForm(_unIdioma);
            Subject.AgregarObserver(this);
        }

        private void CargarIdiomaForm(Idioma.Idioma _idiomaUdate)
        {
            this.Text = _idiomaUdate.Traducccion["frmGestionBackUpTitulo"];
            frmGestionBackUp_gb_GestionBKP.Text = _idiomaUdate.Traducccion["frmGestionBackUpDatos"];
            frmGestionBackUp_btn_Buscar.Text = _idiomaUdate.Traducccion["BuscarBoton"];
            frmGestionBackUp_lbl_NombreBKP.Text = _idiomaUdate.Traducccion["frmGestionBackNombreBkp"];
            frmGestionBackUp_lbl_RutaBKP.Text = _idiomaUdate.Traducccion["frmGestionBackRutaBkp"];
            frmGestionBackUp_btn_RealizarBKP.Text = _idiomaUdate.Traducccion["frmGestionBackBtnRealizarBkp"];
            frmGestionBackUp_btn_RestaurarBKP.Text = _idiomaUdate.Traducccion["frmGestionBackBtnRestaurarBkp"];
            frmGestionBackUp_lbl_ListadoBKP.Text = _idiomaUdate.Traducccion["frmGestionBackListadoBkp"];
        }
        //observer
        void IObserver.Update(Idioma.Idioma _idiomaUdate)
        {
            this.Text = _idiomaUdate.Traducccion["frmGestionBackUpTitulo"];
            frmGestionBackUp_gb_GestionBKP.Text = _idiomaUdate.Traducccion["frmGestionBackUpDatos"];
            frmGestionBackUp_btn_Buscar.Text = _idiomaUdate.Traducccion["BuscarBoton"];
            frmGestionBackUp_lbl_NombreBKP.Text = _idiomaUdate.Traducccion["frmGestionBackNombreBkp"];
            frmGestionBackUp_lbl_RutaBKP.Text = _idiomaUdate.Traducccion["frmGestionBackRutaBkp"];
            frmGestionBackUp_btn_RealizarBKP.Text = _idiomaUdate.Traducccion["frmGestionBackBtnRealizarBkp"];
            frmGestionBackUp_btn_RestaurarBKP.Text = _idiomaUdate.Traducccion["frmGestionBackBtnRestaurarBkp"];
            frmGestionBackUp_lbl_ListadoBKP.Text = _idiomaUdate.Traducccion["frmGestionBackListadoBkp"];
            
        }

        private void frmGestionBackUp_btn_Buscar_Click(object sender, EventArgs e)
        {
            _unBackUpGestor = new GestorBackUp();
            DataRow row = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Path");
            foreach (BE.BackUp unBackUp in _unBackUpGestor.listarBackUp())
            {
                row = dt.NewRow();
                row["Descripcion"] = unBackUp.descripcion;
                row["Fecha"] = unBackUp.fecha;
                row["Path"] = unBackUp.path; 
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1 || e.RowIndex == -1)
            { }
            else
            {
                frmGestionBackUp_txt_Nombre.Text = dataGridView1.SelectedCells[0].Value.ToString();
                frmGestionBackUp_txt_Ruta.Text = dataGridView1.SelectedCells[2].Value.ToString();
            }
        }

        private void frmGestionBackUp_btn_RealizarBKP_Click(object sender, EventArgs e)
        {
            _unBackUpGestor = new GestorBackUp();
            if (String.IsNullOrEmpty(frmGestionBackUp_txt_Nombre.Text))
            {
                MessageBox.Show("Debe ingresar una descripción para el backup.");
            }
            else
            MessageBox.Show(_unBackUpGestor.realizarBackUp(frmGestionBackUp_txt_Nombre.Text));
        }

        private void frmGestionBackUp_btn_RestaurarBKP_Click(object sender, EventArgs e)
        {
            _unBackUpGestor = new GestorBackUp();
            if (String.IsNullOrEmpty(frmGestionBackUp_txt_Ruta.Text))
            {
                MessageBox.Show("Para realizar un BackUp, primero debe seleccionar uno de la lista!.");
            }
            else
                MessageBox.Show(_unBackUpGestor.restaurarBackUp(frmGestionBackUp_txt_Ruta.Text));
        }
    }

}
