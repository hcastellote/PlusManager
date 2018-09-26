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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace PlusManager.UI
{
    public partial class frmGestionUsuarios : Form, IObserver
    {
        private Servicios.GestorIdiomas _unIdiomaGestor;
        private Idioma.Idioma _unIdioma;
        private BE.Usuario _unUsuario;
        private BLL.BLLUsuario _unUsuarioGestor;
        public frmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = "";

            resultado = validarInputs();
          

            if (resultado != "")
                MessageBox.Show(resultado);
            else
            {
                _unUsuario = new BE.Usuario();

                _unUsuario.nombre = frmGestionUsuario_txt_Nombre.Text;
                _unUsuario.apellido = frmGestionUsuario_txt_Apellido.Text;
                _unUsuario.codigo = frmGestionUsuario_txt_CodigoUsuario.Text;
                _unUsuario.email = frmGestionUsuario_txt_Email.Text;
                _unUsuario.DNI = Convert.ToInt32(frmGestionUsuario_txt_DNI.Text);
                _unUsuario.fechaNacimiento = Convert.ToDateTime(frmGestionUsuario_dt_FechaNacimiento.Text);
                _unUsuario.password = frmGestionUsuario_txt_Password.Text;
                _unUsuario.habilitado = frmGestionUsuario_chk_Habilitado.Checked;
                _unUsuario.fechaAlta = DateTime.Today;
                foreach (Idioma.Idioma idioma in _unIdiomaGestor.listarIdiomas())
                {
                    if (idioma.Descripcion == frmGestionUsuario_cb_Idiomas.SelectedItem.ToString())
                    {
                        _unUsuario.idiomaId = idioma.Id;
                        break;
                    }
                }

                
                _unUsuarioGestor = new BLL.BLLUsuario();
               resultado =  _unUsuarioGestor.crearUsuario(_unUsuario, SessionManager.Instance.Usuario.codigo);

                if (resultado.IndexOf(',') != -1)
                {
                    string[] resultadoAltaOk = resultado.Split(',');
                    resultado = resultadoAltaOk[0];
                    frmGestionUsuario_txt_Id.Text = resultadoAltaOk[1];
                    frmGestionUsuario_txt_FechaAlta.Text = resultadoAltaOk[2];
                }
                MessageBox.Show(resultado);
            }


        }



        private void frmGestionUsuario_btn_ListarUsuario_Click(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            _unIdiomaGestor = new Servicios.GestorIdiomas();
            frmGestionUsuario_cb_Idiomas.DisplayMember = "Value";
            foreach (Idioma.Idioma idioma in _unIdiomaGestor.listarIdiomas())
            {
                frmGestionUsuario_cb_Idiomas.Items.Add(idioma.Descripcion);
            }
            frmGestionUsuario_cb_Idiomas.SelectedIndex = 0;

            _unIdioma = new Idioma.Idioma();
            Subject.AgregarObserver(this);
            _unIdioma = SessionManager.Instance._idiomaUsuario.idioma;
            CargarIdiomaForm(_unIdioma);
        }

        private void ListarUsuarios() {
            _unUsuarioGestor = new BLL.BLLUsuario();
            dataGridView1.DataSource = _unUsuarioGestor.ListarUsuarios(SessionManager.Instance.Usuario.codigo);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[12].Visible = false;
        }

        private void frmGestionUsuario_btn_ModificarUsuario_Click(object sender, EventArgs e)
        {
            string resultado = "";

            resultado = validarInputs();

            if (resultado != "")
                MessageBox.Show(resultado);
            else
            {
                _unUsuario = new BE.Usuario();
                _unUsuario.Id = Convert.ToInt32(frmGestionUsuario_txt_Id.Text);
                _unUsuario.nombre = frmGestionUsuario_txt_Nombre.Text;
                _unUsuario.apellido = frmGestionUsuario_txt_Apellido.Text;
                _unUsuario.codigo = frmGestionUsuario_txt_CodigoUsuario.Text;
                _unUsuario.email = frmGestionUsuario_txt_Email.Text;
                _unUsuario.DNI = Convert.ToInt32(frmGestionUsuario_txt_DNI.Text);
                _unUsuario.fechaAlta = Convert.ToDateTime(frmGestionUsuario_txt_FechaAlta.Text);
                _unUsuario.fechaNacimiento = Convert.ToDateTime(frmGestionUsuario_dt_FechaNacimiento.Text);
                _unUsuario.password = frmGestionUsuario_txt_Password.Text;
                _unUsuario.habilitado = frmGestionUsuario_chk_Habilitado.Checked;

                foreach (Idioma.Idioma idioma in _unIdiomaGestor.listarIdiomas())
                {
                    if (idioma.Descripcion == frmGestionUsuario_cb_Idiomas.SelectedItem.ToString())
                    {
                        _unUsuario.idiomaId = idioma.Id;
                        break;
                    }
                }

                _unUsuarioGestor = new BLL.BLLUsuario();
                resultado = _unUsuarioGestor.ActualizarUsuario(_unUsuario, SessionManager.Instance.Usuario.codigo);
                ListarUsuarios();
                MessageBox.Show(resultado);
            }
        }

        private void CargarIdiomaForm(Idioma.Idioma _idiomaUdate)
        {
            this.Text = _idiomaUdate.Traducccion["frmGestionUsuariosTitulo"];
            frmGestionUsuario_gb_DatosUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioDatos"];
            frmGestionUsuario_lbl_Nombre.Text = _idiomaUdate.Traducccion["frmGestionUsuarioNombre"];
            frmGestionUsuario_lbl_Apellido.Text = _idiomaUdate.Traducccion["frmGestionUsuarioApellido"];
            frmGestionUsuario_lbl_Email.Text = _idiomaUdate.Traducccion["frmGestionUsuarioEmail"];
            frmGestionUsuario_lbl_FechaNacimiento.Text = _idiomaUdate.Traducccion["frmGestionUsuarioFechaNacimiento"];
            frmGestionUsuario_lbl_Estado.Text = _idiomaUdate.Traducccion["frmGestionUsuarioEstado"];
            frmGestionUsuario_btn_CrearUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioCrearUsuario"];
            frmGestionUsuario_btn_ModificarUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioModificarUsuario"];
            frmGestionUsuario_gb_ListadoUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioListado"];
            frmGestionUsuario_btn_ListarUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioListar"];
            frmGestionUsuario_chk_Habilitado.Text = _idiomaUdate.Traducccion["frmGestionUsuarioHabilitado"];
        }


        //observer
        void IObserver.Update(Idioma.Idioma _idiomaUdate)
        {
            this.Text = _idiomaUdate.Traducccion["frmGestionUsuariosTitulo"];
            frmGestionUsuario_gb_DatosUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioDatos"];
            frmGestionUsuario_lbl_Nombre.Text = _idiomaUdate.Traducccion["frmGestionUsuarioNombre"];
            frmGestionUsuario_lbl_Apellido.Text = _idiomaUdate.Traducccion["frmGestionUsuarioApellido"];
            frmGestionUsuario_lbl_Email.Text = _idiomaUdate.Traducccion["frmGestionUsuarioEmail"];
            frmGestionUsuario_lbl_FechaNacimiento.Text = _idiomaUdate.Traducccion["frmGestionUsuarioFechaNacimiento"];
            frmGestionUsuario_lbl_Estado.Text = _idiomaUdate.Traducccion["frmGestionUsuarioEstado"];
            frmGestionUsuario_btn_CrearUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioCrearUsuario"];
            frmGestionUsuario_btn_ModificarUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioModificarUsuario"];
            frmGestionUsuario_gb_ListadoUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioListado"];
            frmGestionUsuario_btn_ListarUsuario.Text = _idiomaUdate.Traducccion["frmGestionUsuarioListar"];
            frmGestionUsuario_chk_Habilitado.Text = _idiomaUdate.Traducccion["frmGestionUsuarioHabilitado"];

        }

        private string validarInputs()
        {
            string resultado = "";
            if (!chequearContenido(frmGestionUsuario_txt_Nombre.Text) || !chequearSoloTexto(frmGestionUsuario_txt_Nombre.Text))
                resultado += "El Nombre no puede estar vacío y sólo debe contener letras. " + Environment.NewLine;

            if (!chequearContenido(frmGestionUsuario_txt_Apellido.Text) || !chequearSoloTexto(frmGestionUsuario_txt_Apellido.Text))
                resultado += "El Apellido no puede estar vacío y sólo debe contener letras. " + Environment.NewLine;

            if (!chequearContenido(frmGestionUsuario_txt_CodigoUsuario.Text) || !chequearSoloTexto(frmGestionUsuario_txt_CodigoUsuario.Text))
                resultado += "El Código de Usuario no puede estar vacío y sólo debe contener letras." + Environment.NewLine;

            if (!chequearContenido(frmGestionUsuario_txt_Email.Text) || !chequearMailValido(frmGestionUsuario_txt_Email.Text))
                resultado += "El Email de Usuario no puede estar vacío y debe ser válido. " + Environment.NewLine;

            if (!chequearContenido(frmGestionUsuario_txt_DNI.Text) || !chequearSoloNumerico(frmGestionUsuario_txt_DNI.Text))
                resultado += "El DNI no puede estar vacío y sólo debe contener números. " + Environment.NewLine;

            if (!chequearContenido(frmGestionUsuario_dt_FechaNacimiento.Text) || !chequearFechaValida(frmGestionUsuario_dt_FechaNacimiento.Text))
                resultado += "La Fecha de Nacimiento no puede estar vacío y el formato debe ser válido. " + Environment.NewLine;

            if (!chequearContenido(frmGestionUsuario_txt_Password.Text) || frmGestionUsuario_txt_Password.Text.Length < 6)
                resultado += "La Contraseña debe contener al menos 6 caracteres. " + Environment.NewLine;

            return resultado;
        }

        public bool chequearContenido(string unTexto)
        {

            if (!string.IsNullOrEmpty(unTexto))
                return true;

            return false;

        }


        public bool chequearMailValido(string unTexto)
        {


            string MatchEmailPattern =
             @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex mailValido = new Regex(MatchEmailPattern);
            if (mailValido.IsMatch(unTexto))
            {
                //sólo números
                return true;
            }
            return false;

        }

        public bool chequearFechaValida(string unTexto)
        {
            try
            {
                DateTime fecha = Convert.ToDateTime(unTexto);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }

        public bool chequearSoloNumerico(string unTexto)
        {
            Regex soloNumerico = new Regex(@"^[0-9]+$");
            if (soloNumerico.IsMatch(unTexto))
            {
                //sólo números
                return true;
            }

            return false;

        }

        public bool chequearSoloTexto(string unTexto)
        {
            Regex soloTexto = new Regex(@"^[a-zA-Z]+$");
            if (soloTexto.IsMatch(unTexto))
            {
                //sólo números
                return true;
            }

            return false;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            



        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1 || e.RowIndex == -1)
            { }
            else
            {
                frmGestionUsuario_txt_Id.Text = dataGridView1.SelectedCells[0].Value.ToString();
                frmGestionUsuario_txt_CodigoUsuario.Text = dataGridView1.SelectedCells[1].Value.ToString();
                frmGestionUsuario_txt_Password.Text = dataGridView1.SelectedCells[2].Value.ToString();
                frmGestionUsuario_txt_Nombre.Text = dataGridView1.SelectedCells[3].Value.ToString();
                frmGestionUsuario_txt_Apellido.Text = dataGridView1.SelectedCells[4].Value.ToString();
                frmGestionUsuario_txt_Email.Text = dataGridView1.SelectedCells[5].Value.ToString();
                frmGestionUsuario_dt_FechaNacimiento.Value = Convert.ToDateTime(dataGridView1.SelectedCells[6].Value);
                frmGestionUsuario_txt_FechaAlta.Text = Convert.ToDateTime(dataGridView1.SelectedCells[7].Value).ToString();
                frmGestionUsuario_txt_DNI.Text = dataGridView1.SelectedCells[8].Value.ToString();
                frmGestionUsuario_chk_Habilitado.Checked = Convert.ToBoolean(dataGridView1.SelectedCells[9].Value);

            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
