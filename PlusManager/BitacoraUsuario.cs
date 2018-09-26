using BE;
using Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Idioma;

namespace PlusManager
{
    public partial class BitacoraUsuario : Form, IObserver
    {
        private Servicios.GestorIdiomas _unIdiomaGestor;
        private Idioma.Idioma _unIdioma;
        public BitacoraUsuario()
        {
            InitializeComponent();
        }

        private void frmConsultaBitacoraErrores_btn_Consultar_Click(object sender, EventArgs e)
        {
            GestionBitacora _bitacora = new GestionBitacora();
            DataTable dt = new DataTable();
            DataRow dr = null;
            string UsuarioModificado = frmConsultaBitacoraUsuario_combo_UsuarioModificado.Text;
            string UsuarioModificador = frmConsultaBitacoraUsuario_combo_UsuarioModificador.Text;
            DateTime FechaDesde = Convert.ToDateTime(frmConsultaBitacoraUsuario_date_Desde.Text);
            DateTime FechaHasta = Convert.ToDateTime(frmConsultaBitacoraUsuario_date_Hasta.Text);
            dt.Columns.Add("Usuario Modificador");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Tabla Afectada");
            dt.Columns.Add("Columna Afectada");
            dt.Columns.Add("Nuevo Valor");
            dt.Columns.Add("Valor Anterior");
            dt.Columns.Add("Tipo de Dato");
            dt.Columns.Add("Usuario Modificado");

            if ((!System.Text.RegularExpressions.Regex.IsMatch(frmConsultaBitacoraUsuario_combo_UsuarioModificado.Text, "^[a-zA-Z]") && !String.IsNullOrEmpty(frmConsultaBitacoraUsuario_combo_UsuarioModificado.Text))
                || (!System.Text.RegularExpressions.Regex.IsMatch(frmConsultaBitacoraUsuario_combo_UsuarioModificador.Text, "^[a-zA-Z]") && !String.IsNullOrEmpty(frmConsultaBitacoraUsuario_combo_UsuarioModificador.Text)))
            { 
                MessageBox.Show("Si desea filtrar por usuario, debe ingresar un código. De lo contrario, destilde la opción de filtro por Usuario");
                return;

            }

            List<BE.BitacoraUsuario> unaLista = new List<BE.BitacoraUsuario>();


                unaLista = _bitacora.ListarTodosBitacoraUsuario(UsuarioModificado, UsuarioModificador, FechaDesde, FechaHasta);


            if (unaLista.Count >0)
            {
                foreach (BE.BitacoraUsuario miBitacora in unaLista)
                {
                    dr = dt.NewRow();
                    dr[0] = miBitacora.CodigoUsuarioModificador;
                    dr[1] = miBitacora.fecha;
                    dr[2] = miBitacora.Descripcion;
                    dr[3] = miBitacora.TablaAfectada;
                    dr[4] = miBitacora.ColumnaAfectada;
                    dr[5] = miBitacora.NuevoValor;
                    dr[6] = miBitacora.ValorAnterior;
                    dr[7] = miBitacora.TipoDato;
                    dr[8] = miBitacora.CodigoUsuarioModificado;
                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontraron datos para su búsqueda. Por favor intente nuevamente!");
            }
        }

        private void BitacoraUsuario_Load(object sender, EventArgs e)
        {
            _unIdiomaGestor = new Servicios.GestorIdiomas();
            _unIdioma = new Idioma.Idioma();
            _unIdioma = SessionManager.Instance._idiomaUsuario.idioma;
            CargarIdiomaForm(_unIdioma);
            Subject.AgregarObserver(this);
        }

        private void CargarIdiomaForm(Idioma.Idioma unIdioma)
        {
            frmConsultaBitacora_lbl_UsuarioModificado.Text = unIdioma.Traducccion["UsuarioModificadoTxt"];
            frmConsultaBitacora_lbl_UsuarioModificador.Text = unIdioma.Traducccion["UsuarioModificadorTxt"];
            frmConsultaBitacoraErrores_btn_Consultar.Text = unIdioma.Traducccion["BuscarBoton"];
            frmConsultaBitacoraUsuario_gb_DatosBitacora.Text = unIdioma.Traducccion["ConsultaBitacoraTitulo"];
            this.Text = unIdioma.Traducccion["frmBitacoraUsuarioTitulo"];
            frmConsultaBitacora_lbl_Fechas.Text = unIdioma.Traducccion["frmBitacoraUsuarioTitulo"];
            frmConsultaBitacora_chk_FechaDesde.Text = unIdioma.Traducccion["FechaDesde"];
            frmConsultaBitacora_chk_FechaHasta.Text = unIdioma.Traducccion["FechaHasta"];
            frmConsultaBitacora_lbl_Fechas.Text = unIdioma.Traducccion["Fechas"];
        }

        //observer
        void IObserver.Update(Idioma.Idioma _idiomaUdate)
        {
            frmConsultaBitacora_lbl_UsuarioModificado.Text = _idiomaUdate.Traducccion["UsuarioModificadoTxt"];
            frmConsultaBitacora_lbl_UsuarioModificador.Text = _idiomaUdate.Traducccion["UsuarioModificadorTxt"];
            frmConsultaBitacoraErrores_btn_Consultar.Text = _idiomaUdate.Traducccion["BuscarBoton"];
            frmConsultaBitacoraUsuario_gb_DatosBitacora.Text = _idiomaUdate.Traducccion["ConsultaBitacoraTitulo"];
            this.Text = _idiomaUdate.Traducccion["frmBitacoraUsuarioTitulo"];
            frmConsultaBitacora_lbl_Fechas.Text = _idiomaUdate.Traducccion["frmBitacoraUsuarioTitulo"];
            frmConsultaBitacora_chk_FechaDesde.Text = _idiomaUdate.Traducccion["FechaDesde"];
            frmConsultaBitacora_chk_FechaHasta.Text = _idiomaUdate.Traducccion["FechaHasta"];
            frmConsultaBitacora_lbl_Fechas.Text = _idiomaUdate.Traducccion["Fechas"];

        }
    }
}
