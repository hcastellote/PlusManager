using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Windows.Forms;

namespace Servicios
{
    
    public class GestorPermisos
    {
        private DAL_Permisos _miListaPermisos = new DAL_Permisos();
        private DAL_Permisos _miListaPermisosUsuario = new DAL_Permisos();
        private List<string> listaPermisos;
        public Componente ObternerPermisos() {
            return _miListaPermisos.GetListPermisos();
        }

        public Componente GetListPermisosUsuario(string usuarioCodigo) {
            return _miListaPermisosUsuario.GetListPermisosUsuario(usuarioCodigo);
        }

        public string ActualizarPermisosUsuario(TreeNodeCollection arbolPermisos, string miUsuario)
        {
            listaPermisos = new List<string>();
            llenarListaPermisosString(arbolPermisos);
            return _miListaPermisosUsuario.ActualizarPermisosUsuario(listaPermisos,miUsuario);
        }

        private void llenarListaPermisosString(TreeNodeCollection arbolPermisos)
        {
            string codigoPermiso = "";
            foreach (TreeNode miPermiso in arbolPermisos)
            {
                codigoPermiso = miPermiso.Text.Substring(0, miPermiso.Text.IndexOf("-") - 1);
                listaPermisos.Add(codigoPermiso);
                if (miPermiso.Nodes.Count > 0)
                    llenarListaPermisosHijosString(miPermiso);

            }
        }

        private void llenarListaPermisosHijosString(TreeNode arbolPermisos)
        {
            string codigoPermiso = "";
            foreach (TreeNode miPermiso in arbolPermisos.Nodes)
            {
                codigoPermiso = miPermiso.Text.Substring(0, miPermiso.Text.IndexOf("-") - 1);
                listaPermisos.Add(codigoPermiso);
                if (miPermiso.Nodes.Count > 0)
                    llenarListaPermisosHijosString(miPermiso);
            }
        }


    }
}
