using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sistema;
using BE;
using BLL;
using Idioma;

namespace PlusManager.UI
{
    public partial class ConsultaBitacora : Form, IObserver
    {
        private Servicios.GestorIdiomas _unIdiomaGestor;
        private Idioma.Idioma _unIdioma;
        BLLUsuario _usuarioBLL;
        public ConsultaBitacora()
        {
            InitializeComponent();
            LlenarDropUsuarios();
        }

       
        private void Button1_Click(object sender, EventArgs e)
        {
            GestionBitacora _bitacora = new GestionBitacora();
            DataTable dt = new DataTable();
            DataRow dr = null;
            string Usuario = frmConsultaBitacoraErrores_txt_Usuario.Text;
            DateTime FechaDesde = Convert.ToDateTime(frmConsultaBitacoraErrores_date_Desde.Text);
            DateTime FechaHasta = Convert.ToDateTime(frmConsultaBitacoraErrores_date_Hasta.Text);
            dt.Columns.Add("Fecha Creacion");
            dt.Columns.Add("Mensaje");
            dt.Columns.Add("Usuario Codigo");
            dt.Columns.Add("Codigo Error");
            dt.Columns.Add("Criticidad");

            //if (!System.Text.RegularExpressions.Regex.IsMatch(frmConsultaBitacoraErrores_txt_Usuario.Text, "^[a-zA-Z ]"))
            //{
            //    MessageBox.Show("Por favor, seleccione un usuario de la lista.");
            //    return;

            //}

            List<BitacoraErrores> unaLista = new List<BitacoraErrores>();
            
              unaLista = _bitacora.ListarTodosBitacoraErrores(Usuario, FechaDesde, FechaHasta);
            

            foreach (BitacoraErrores miBitacora in unaLista)
            {
                dr = dt.NewRow();
                dr[0] = miBitacora.fechaCreacion;
                dr[1] = miBitacora.mensaje;
                dr[2] = miBitacora.UsuarioCodigo;
                dr[3] = miBitacora.CodigoError.descripcion;
                dr[4] = miBitacora.Criticidad.descripcion;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void LlenarDropUsuarios()
        {
            _usuarioBLL = new BLLUsuario();

            foreach (BE.Usuario unUsuario in _usuarioBLL.ListarUsuarios("LlenarDropUsuarios")) {
                frmConsultaBitacoraErrores_txt_Usuario.Items.Add(unUsuario.codigo);
            }
        }

        private void frmConsultaBitacora_gb_DatosBitacora_Enter(object sender, EventArgs e)
        {

        }

        private void ConsultaBitacora_Load(object sender, EventArgs e)
        {
            _unIdiomaGestor = new Servicios.GestorIdiomas();
            _unIdioma = new Idioma.Idioma();
            _unIdioma = SessionManager.Instance._idiomaUsuario.idioma;
            CargarIdiomaForm(_unIdioma);
            Subject.AgregarObserver(this);
        }

        private void CargarIdiomaForm(Idioma.Idioma unIdioma)
        {
            frmConsultaBitacora_lbl_Usuario.Text = unIdioma.Traducccion["UsuarioTxt"];
            frmConsultaBitacoraErrores_btn_Consultar.Text = unIdioma.Traducccion["BuscarBoton"];
            this.Text = unIdioma.Traducccion["frmBitacoraErroresTitulo"];
            frmConsultaBitacora_lbl_Fechas.Text = unIdioma.Traducccion["frmBitacoraUsuarioTitulo"];
            frmConsultaBitacora_chk_FechaDesde.Text = unIdioma.Traducccion["FechaDesde"];
            frmConsultaBitacora_chk_FechaHasta.Text = unIdioma.Traducccion["FechaHasta"];
            frmConsultaBitacora_lbl_Fechas.Text = unIdioma.Traducccion["Fechas"];
            frmConsultaBitacora_gb_DatosBitacora.Text = unIdioma.Traducccion["ConsultaBitacoraTitulo"];
        }

        //observer
        void IObserver.Update(Idioma.Idioma _idiomaUdate)
        {
            frmConsultaBitacora_lbl_Usuario.Text = _idiomaUdate.Traducccion["UsuarioTxt"];
            frmConsultaBitacoraErrores_btn_Consultar.Text = _idiomaUdate.Traducccion["BuscarBoton"];
            this.Text = _idiomaUdate.Traducccion["frmBitacoraErroresTitulo"];
            frmConsultaBitacora_lbl_Fechas.Text = _idiomaUdate.Traducccion["frmBitacoraUsuarioTitulo"];
            frmConsultaBitacora_chk_FechaDesde.Text = _idiomaUdate.Traducccion["FechaDesde"];
            frmConsultaBitacora_chk_FechaHasta.Text = _idiomaUdate.Traducccion["FechaHasta"];
            frmConsultaBitacora_lbl_Fechas.Text = _idiomaUdate.Traducccion["Fechas"];
            frmConsultaBitacora_gb_DatosBitacora.Text = _idiomaUdate.Traducccion["ConsultaBitacoraTitulo"];
        }
    }
}
