using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Idioma;

namespace PlusManager.UI
{
    public partial class Login : Form , IObserver
    {
        private Servicios.GestorIdiomas _unIdiomaGestor;
        private Idioma.Idioma _unIdioma;
        public Login()
        {
            InitializeComponent();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _unIdiomaGestor = new Servicios.GestorIdiomas();
            _unIdioma = new Idioma.Idioma();
            Subject.AgregarObserver(this);
            
            foreach (Idioma.Idioma _idioma in _unIdiomaGestor.listarIdiomas()) {
                comboBox1.Items.Add(_idioma.Descripcion);
            }
            _unIdioma = _unIdiomaGestor.seleccionarIdioma(1);
            Sistema.SessionManager.Instance._idiomaUsuario.idioma = _unIdioma;
        }

        private void frmLogin_Btn_Login_Click(object sender, EventArgs e)
        {
            BLL.BLLUsuario _usuarioBLL = new BLL.BLLUsuario();
            //MessageBox.Show(_usuarioBLL.LogIn(frmLogin_txt_Usuario.Text, frmLogin_txt_Password.Text));
            string texto = "";
            int resultado = _usuarioBLL.LogIn(frmLogin_txt_Usuario.Text, frmLogin_txt_Password.Text);
            if (resultado == 0)
            {
                Principal _frmPrincipal = new Principal();
                _frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                if (resultado == 1)
                    texto = "No se ha encontrado el usuario, por favor intente nuevamente.";

                if (resultado == 2)
                    texto = "Su usuario se encuentra bloqueado, por favor comuníquese con el administrador";


                if (resultado == 3)
                    texto = "Su contraseña es Incorrecta";

                if (resultado == 4)
                    texto = "Error de Integridad de Usuario, por favor comuníquese con el adminsitrador";

                if (resultado == 5)
                    texto = "Error de Integridad de Datos. Por favor comuníquese con un administrador.";

                MessageBox.Show(texto);
            }
            
        }

        void IObserver.Update(Idioma.Idioma _idiomaUdate)
        {
            frmLogin_Btn_Login.Text = _idiomaUdate.Traducccion["IniciarSesion"];
            frmLogin_lbl_Idioma.Text = _idiomaUdate.Traducccion["IdiomaTxt"];
            frmLogin_lbl_Password.Text  = _idiomaUdate.Traducccion["PasswordTxt"];
            frmLogin_lbl_Usuario.Text  = _idiomaUdate.Traducccion["UsuarioTxt"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) {
                _unIdiomaGestor = new Servicios.GestorIdiomas();
                _unIdioma = new Idioma.Idioma();
                _unIdioma = _unIdiomaGestor.seleccionarIdioma(comboBox1.SelectedIndex  + 1);
                Sistema.SessionManager.Instance._idiomaUsuario.idioma = _unIdioma;
            }
        }

        //    Public Sub Update(idioma As Idioma) Implements IObserver.Update
        //    If idioma.Idioma = IdiomaEnum.Español Then
        //        Me.Text = "Bienvenidos"
        //    Else
        //        Me.Text = "Welcome"
        //    End If
        //End Sub
    }
}
