using System.Data.OleDb;

namespace ConfiaAdmin
{

    public class EmpresaConectada
    {
        private bool _Conectada;
        private OleDbConnection _ConexionEmpresaConectada;
        public bool Conectada
        {
            get
            {
                return _Conectada;

            }
            set
            {
                _Conectada = value;
            }
        }
        public OleDbConnection ConexionEmpresaConectada
        {
            get
            {
                return _ConexionEmpresaConectada;
            }
            set
            {
                _ConexionEmpresaConectada = value;
            }
        }

    }
}