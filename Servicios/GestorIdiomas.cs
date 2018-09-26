using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idioma;
using DAL;

namespace Servicios
{
    public class GestorIdiomas
    {
        private Idioma.Idioma _unIdioma;
        private DAL_Idioma _unIdiomaDAL;

        public GestorIdiomas() {
            _unIdioma = new Idioma.Idioma();
            _unIdiomaDAL = new DAL_Idioma();
        }

        public GestorIdiomas(string descripcion, Dictionary<string,string> traducciones) {
            _unIdioma = new Idioma.Idioma();
            _unIdiomaDAL = new DAL_Idioma();
        }

        public Idioma.Idioma seleccionarIdioma(int IdiomaID) {
            return _unIdioma = _unIdiomaDAL.cambiarIdioma(IdiomaID);
        }

        public List<Idioma.Idioma> listarIdiomas()
        {
            return _unIdiomaDAL.listarIdiomas();
        }

        public List<string> listarEtiquetas()
        {
            return _unIdiomaDAL.listarEtiquetas();
        }

        public Dictionary<string,string> listarTraducciones(string codigoIdioma)
        {
            return _unIdiomaDAL.listarTraducciones(codigoIdioma);
        }

        public string crearIdioma(Idioma.Idioma _unIdioma) {
            return _unIdiomaDAL.crearIdioma(_unIdioma);
        }

        public string ActualizarIdioma(Idioma.Idioma _unIdioma)
        {
            return _unIdiomaDAL.ActualizarIdioma(_unIdioma);
        }
    }

}
