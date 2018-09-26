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
    public partial class Principal : Form, IObserver
    {
        private Servicios.GestorIdiomas _unIdiomaGestor;
        private Idioma.Idioma _unIdioma;
        public Principal()
        {
            InitializeComponent();
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
        private void altaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPermisos _frmGestionPermisos = new GestionPermisos();
            _frmGestionPermisos.MdiParent = this;
            _frmGestionPermisos.MdiParent.Width = _frmGestionPermisos.Width + 50;
            _frmGestionPermisos.MdiParent.Height = _frmGestionPermisos.Height + 50;
            _frmGestionPermisos.WindowState = FormWindowState.Maximized;
            if (_frmGestionPermisos.MdiParent.ActiveMdiChild != null)
                _frmGestionPermisos.MdiParent.ActiveMdiChild.Close(); 
            _frmGestionPermisos.Show();
        }


        private void bitácoraDeErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaBitacora _frmConsultaBitacora = new ConsultaBitacora();
            _frmConsultaBitacora.MdiParent = this;
            _frmConsultaBitacora.MdiParent.Width = _frmConsultaBitacora.Width + 50;
            _frmConsultaBitacora.MdiParent.Height = _frmConsultaBitacora.Height + 50;
            _frmConsultaBitacora.WindowState = FormWindowState.Maximized;
            if (_frmConsultaBitacora.MdiParent.ActiveMdiChild != null)
                _frmConsultaBitacora.MdiParent.ActiveMdiChild.Close();
            _frmConsultaBitacora.Show();
        }

        private void bitácoraDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitacoraUsuario _frmConsultaBitacoraUsuario = new BitacoraUsuario();
            _frmConsultaBitacoraUsuario.MdiParent = this;
            _frmConsultaBitacoraUsuario.MdiParent.Width = _frmConsultaBitacoraUsuario.Width + 50;
            _frmConsultaBitacoraUsuario.MdiParent.Height = _frmConsultaBitacoraUsuario.Height + 50;
            _frmConsultaBitacoraUsuario.WindowState = FormWindowState.Maximized;
            if (_frmConsultaBitacoraUsuario.MdiParent.ActiveMdiChild != null)
                _frmConsultaBitacoraUsuario.MdiParent.ActiveMdiChild.Close();
            _frmConsultaBitacoraUsuario.Show();
        }

        //inicializo el combobox de Idiomas para cambiarlo ya habiendo iniciado sesión
        private void Principal_Load(object sender, EventArgs e)
        {
            _unIdiomaGestor = new Servicios.GestorIdiomas();
            _unIdioma = new Idioma.Idioma();
            Subject.AgregarObserver(this);

            foreach (Idioma.Idioma _idioma in _unIdiomaGestor.listarIdiomas())
            {
                toolStripComboBox1.Items.Add(_idioma.Descripcion);
            }
            _unIdioma = SessionManager.Instance._idiomaUsuario.idioma;
            CargarIdiomaForm(_unIdioma);

        }

        private void CargarIdiomaForm(Idioma.Idioma _idiomaUdate)
        {
            loginToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuInicio"];
            recepcionToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcion"];
            administrativoToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuAdministrativo"];
            idiomaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIdioma"];
            mantenimientoToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimiento"];
            ayudaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuAyuda"];
            iniciarSesiónToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuInicioIniciarSesion"];
            cerrarSesiónToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIniciarCerrarSesion"];
            cerrarToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIniciarCerrar"];
            altaDeClienteToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionAltaCliente"];
            altaDeToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionAltaReserva"];
            altaDeToolStripMenuItem1.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionAsignarOferta"];
            cargaDePaquetesToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionCargarPaquete"];
            canjeDePuntosToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionCanjearPuntos"];
            altaDeOfertaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuAdministrativoGestionarOferta"];
            cargaDeCatálogoDeCanjesToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuAdministrativoCatalogoCanjes"];
            altaIdiomaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIdiomaConfigurarIdioma"];
            cargarIdiomaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIdiomaCargarIdioma"];
            cambiarIdiomaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIdiomaCambiarIdioma"];
            gestiónDeBackUpToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoBackup"];
            gestiónDeBitácoraToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoBitacora"];
            bitácoraDeUsuarioToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoBitacoraUsuario"];
            bitácoraDeErroresToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoBitacoraErrores"];
            gestiónDeUsuariosToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoUsuarios"];
            gestionDePermisosToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoPermisos"];
        }
        //observer
        void IObserver.Update(Idioma.Idioma _idiomaUdate)
        {
            loginToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuInicio"];
            recepcionToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcion"];
            administrativoToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuAdministrativo"];
            idiomaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIdioma"];
            mantenimientoToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimiento"];
            ayudaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuAyuda"];
            iniciarSesiónToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuInicioIniciarSesion"];
            cerrarSesiónToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIniciarCerrarSesion"];
            cerrarToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIniciarCerrar"];
            altaDeClienteToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionAltaCliente"];
            altaDeToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionAltaReserva"];
            altaDeToolStripMenuItem1.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionAsignarOferta"];
            cargaDePaquetesToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionCargarPaquete"];
            canjeDePuntosToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuRecepcionCanjearPuntos"];
            altaDeOfertaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuAdministrativoGestionarOferta"];
            cargaDeCatálogoDeCanjesToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuAdministrativoCatalogoCanjes"];
            altaIdiomaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIdiomaConfigurarIdioma"];
            cargarIdiomaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIdiomaCargarIdioma"];
            cambiarIdiomaToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuIdiomaCambiarIdioma"];
            gestiónDeBackUpToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoBackup"];
            gestiónDeBitácoraToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoBitacora"];
            bitácoraDeUsuarioToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoBitacoraUsuario"];
            bitácoraDeErroresToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoBitacoraErrores"];
            gestiónDeUsuariosToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoUsuarios"];
            gestionDePermisosToolStripMenuItem.Text = _idiomaUdate.Traducccion["PrincipalMenuMantenimientoPermisos"];
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex != -1)
            {
                _unIdiomaGestor = new Servicios.GestorIdiomas();
                _unIdioma = new Idioma.Idioma();
                _unIdioma = _unIdiomaGestor.seleccionarIdioma(toolStripComboBox1.SelectedIndex + 1);
                Sistema.SessionManager.Instance._idiomaUsuario.idioma = _unIdioma;
            }
        }

        private void gestiónDeBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBackUp _frmConsultaGestionBackUp = new GestionBackUp();
            _frmConsultaGestionBackUp.MdiParent = this;
            _frmConsultaGestionBackUp.MdiParent.Width = _frmConsultaGestionBackUp.Width + 50;
            _frmConsultaGestionBackUp.MdiParent.Height = _frmConsultaGestionBackUp.Height + 50;
            _frmConsultaGestionBackUp.WindowState = FormWindowState.Maximized;
            if (_frmConsultaGestionBackUp.MdiParent.ActiveMdiChild != null)
                _frmConsultaGestionBackUp.MdiParent.ActiveMdiChild.Close();
            _frmConsultaGestionBackUp.Show();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmGestionUsuarios _frmGestionUsuarios = new frmGestionUsuarios();
            _frmGestionUsuarios.MdiParent = this;
            _frmGestionUsuarios.MdiParent.Width = _frmGestionUsuarios.Width + 50;
            _frmGestionUsuarios.MdiParent.Height = _frmGestionUsuarios.Height + 50;
            _frmGestionUsuarios.WindowState = FormWindowState.Maximized;
            if (_frmGestionUsuarios.MdiParent.ActiveMdiChild != null)
                _frmGestionUsuarios.MdiParent.ActiveMdiChild.Close();
            _frmGestionUsuarios.Show();
        }

        private void cargarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaIdioma _frmAltaIdioma = new AltaIdioma();
            _frmAltaIdioma.MdiParent = this;
            _frmAltaIdioma.MdiParent.Width = _frmAltaIdioma.Width + 50;
            _frmAltaIdioma.MdiParent.Height = _frmAltaIdioma.Height + 50;
            _frmAltaIdioma.WindowState = FormWindowState.Maximized;
            if (_frmAltaIdioma.MdiParent.ActiveMdiChild != null)
                _frmAltaIdioma.MdiParent.ActiveMdiChild.Close();
            _frmAltaIdioma.Show();
        }

        private void altaIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarIdioma _frmConfigurarIdioma = new ConfigurarIdioma();
            _frmConfigurarIdioma.MdiParent = this;
            _frmConfigurarIdioma.MdiParent.Width = _frmConfigurarIdioma.Width + 50;
            _frmConfigurarIdioma.MdiParent.Height = _frmConfigurarIdioma.Height + 50;
            _frmConfigurarIdioma.WindowState = FormWindowState.Maximized;
            if (_frmConfigurarIdioma.MdiParent.ActiveMdiChild != null)
                _frmConfigurarIdioma.MdiParent.ActiveMdiChild.Close();
            _frmConfigurarIdioma.Show();
        }
    }
}
