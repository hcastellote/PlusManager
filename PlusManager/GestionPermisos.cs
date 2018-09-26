using Servicios;
using BE;
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
using BLL;

namespace PlusManager.UI
{
    public partial class GestionPermisos : Form, IObserver
    {
        BLLUsuario _usuarioBLL;
        private Servicios.GestorIdiomas _unIdiomaGestor;
        private Idioma.Idioma _unIdioma;
        private GestorPermisos _miGestorPermisos = new GestorPermisos();
        private Componente _miComponenteTodosLosPermisos = new Familia();
        private Componente _miComponenteUsuario = new Familia();
        private TreeNodeCollection nodoPermisosUsuarios = null;
        private BE.Usuario miUsuario = new Usuario();


        bool esUsuario = false;
        private bool permisoEncontrado = false;

        public GestionPermisos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _miComponenteTodosLosPermisos = _miGestorPermisos.ObternerPermisos();
            _miComponenteUsuario = _miGestorPermisos.GetListPermisosUsuario(frmGestionPermisos_cb_Usuario.Text);
            treePermisosAll.Nodes.Clear();
            treePermisosUsuario.Nodes.Clear();
            esUsuario = false;
            LlenarListaPersmisos(_miComponenteTodosLosPermisos, null);
            esUsuario = true;
            LlenarListaPersmisosUsuario(_miComponenteUsuario);

        }

        private void LlenarListaPersmisosUsuario(Componente miComponenteUsuario)
        {
            foreach (Componente miComponente in miComponenteUsuario.ObtenerPermisos())
            {
                treePermisosUsuario.Nodes.Add(miComponente.codigo + " - " + miComponente.descripcion);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TreeNode miNodoNuevo = treePermisosAll.SelectedNode;
            if (miNodoNuevo == null)
            {
                MessageBox.Show("Debe selecionar un item por favor.");
            }
            else
            {

                nodoPermisosUsuarios = treePermisosUsuario.Nodes;
                //AgregarPermisoUsuario(miNodoNuevo);
                //if (!permisoEncontrado)
                    CreatePath(nodoPermisosUsuarios, miNodoNuevo.FullPath);
                ////treePermisosUsuario.Nodes.Add((TreeNode)miNodoNuevo.Clone());
                ///
                elinimarNodosHijos(nodoPermisosUsuarios, miNodoNuevo);

            }
        }

        private void elinimarNodosHijos(TreeNodeCollection nodeList, TreeNode unNodo) {
            foreach (TreeNode _otroNodo in unNodo.Nodes) {
                foreach (TreeNode item in nodeList)
                {
                    if (item != null)
                        if(_otroNodo.Text == item.Text)
                            nodeList.Remove(item);
                    if (_otroNodo.Nodes.Count > 0)
                        elinimarNodosHijos(nodeList, _otroNodo);
                }
            }
        }
        private void CreatePath(TreeNodeCollection nodeList, string path)
        {
            TreeNode node = null;
            string folder = string.Empty;

            int p = path.IndexOf('\\');

            if (p == -1)
            {
                folder = path;
                path = "";
            }
            else
            {
                folder = path.Substring(0, p);
                path = path.Substring(p + 1, path.Length - (p + 1));
            }

            node = null;

            foreach (TreeNode item in nodeList)
            {
                if (item.Text == folder)
                {
                    //node = item;
                    return;
                }
            }

            if (node == null)
            {
                node = new TreeNode(folder);
                if (path == "")
                    treePermisosUsuario.Nodes.Add(node);
            }

            if (path != "")
            {
                CreatePath(node.Nodes, path);
            }
        }

      

        private void LlenarListaPersmisos(Componente _ComponentePermisosCompleto, TreeNode miNodo = null)
        {
            TreeNode unNodoHijo = null;
            foreach (Componente miComponente in _ComponentePermisosCompleto.ObtenerPermisos())
            {
                if (miComponente is Familia)
                {
                    unNodoHijo = new TreeNode(miComponente.codigo + " - " + miComponente.descripcion);
                    LlenarListaPersmisos(miComponente, unNodoHijo);

                    if (miNodo != null)
                        miNodo.Nodes.Add(unNodoHijo);
                    else
                        if (esUsuario)
                        treePermisosUsuario.Nodes.Add(unNodoHijo);
                    else
                        treePermisosAll.Nodes.Add(unNodoHijo);


                }
                else if (miComponente is Patente)
                {
                    //otro codigo
                    miNodo.Nodes.Add(miComponente.codigo + " - " + miComponente.descripcion);
                }

            }

        }

        
       private void frmGestionPermisos_btn_Quuitar_Click(object sender, EventArgs e)
        {
            DialogResult  resultado = MessageBox.Show("¿Está seguro que desea quitar el permiso del usuario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
               treePermisosUsuario.SelectedNode.Remove();
            }
            else if (resultado == DialogResult.No)
            {
                
            }

        }

        private void frmGestionPermisos_btn_Guardar_Click(object sender, EventArgs e)
        {
            TreeNodeCollection permisosUsuario = treePermisosUsuario.Nodes;
            string resultado = _miGestorPermisos.ActualizarPermisosUsuario(permisosUsuario, frmGestionPermisos_cb_Usuario.Text);

            MessageBox.Show(resultado);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GestionPermisos_Load(object sender, EventArgs e)
        {
            _usuarioBLL = new BLLUsuario();

            foreach (BE.Usuario unUsuario in _usuarioBLL.ListarUsuarios("GestionPermisos"))
            {
                frmGestionPermisos_cb_Usuario.Items.Add(unUsuario.codigo);
            }

            _unIdiomaGestor = new Servicios.GestorIdiomas();
            _unIdioma = new Idioma.Idioma();
            Subject.AgregarObserver(this);
            _unIdioma = SessionManager.Instance._idiomaUsuario.idioma;
            CargarIdiomaForm(_unIdioma);
            
        }

        private void CargarIdiomaForm(Idioma.Idioma unIdioma)
        {
            this.Text = unIdioma.Traducccion["frmPermisosTitulo"];
            frmGestionPermisos_gb_PermisosUsuario.Text = unIdioma.Traducccion["frmPermisosDatos"];
            frmGestionPermisos_lbl_PermisosSistema.Text = unIdioma.Traducccion["frmPermisosPermisosSistema"];
            frmGestionPermisos_lbl_PermisosUsuario.Text = unIdioma.Traducccion["frmPermisosPermisosUsuario"];
            frmGestionPermisos_btn_Agregar.Text = unIdioma.Traducccion["AgregarBoton"];
            frmGestionPermisos_btn_Quuitar.Text = unIdioma.Traducccion["QuitarBoton"];
            frmGestionPermisos_btn_Guardar.Text = unIdioma.Traducccion["GuardarBoton"];
            frmGestionPermisos_btn_ConsultarUsuario.Text = unIdioma.Traducccion["ConsultarBoton"];
            frmGestionPermisos_txt_Usuario.Text = unIdioma.Traducccion["UsuarioTxt"];
        }

        //observer
        void IObserver.Update(Idioma.Idioma _idiomaUdate)
        {
           
            frmGestionPermisos_gb_PermisosUsuario.Text = _idiomaUdate.Traducccion["frmPermisosDatos"];
            frmGestionPermisos_lbl_PermisosSistema.Text = _idiomaUdate.Traducccion["frmPermisosPermisosSistema"];
            frmGestionPermisos_lbl_PermisosUsuario.Text = _idiomaUdate.Traducccion["frmPermisosPermisosUsuario"];
            frmGestionPermisos_btn_Agregar.Text = _idiomaUdate.Traducccion["AgregarBoton"];
            frmGestionPermisos_btn_Quuitar.Text = _idiomaUdate.Traducccion["QuitarBoton"];
            frmGestionPermisos_btn_Guardar.Text = _idiomaUdate.Traducccion["GuardarBoton"];
            frmGestionPermisos_btn_ConsultarUsuario.Text = _idiomaUdate.Traducccion["ConsultarBoton"];
            frmGestionPermisos_txt_Usuario.Text = _idiomaUdate.Traducccion["UsuarioTxt"];
            this.Text = _idiomaUdate.Traducccion["frmPermisosTitulo"];

        }
    }
}
