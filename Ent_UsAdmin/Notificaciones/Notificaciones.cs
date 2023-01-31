
namespace ConfiaAdmin
{
    public class Notificaciones
    {
        private int _id;
        private string _Tipo;
        private string _Usuario;
        private string _UsuarioDestino;
        private bool _Notificacion;
        private string _Valor;
        private string _Mensaje;
        private string _Comentario;
        private string _Fecha;
        private string _Hora;
        private string _HoraAplicacion;
        private string _FechaAplicacion;
        private string _Estado;
        private string _ComentarioUsuarioDestino;
        private string _Empresa;
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _Tipo;
            }
            set
            {
                _Tipo = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }
            set
            {
                _Usuario = value;

            }
        }

        public string UsuarioDestino
        {
            get
            {
                return _UsuarioDestino;
            }
            set
            {
                _UsuarioDestino = value;
            }
        }

        public bool Notificacion
        {
            get
            {
                return _Notificacion;
            }
            set
            {
                _Notificacion = value;
            }
        }

        public string Valor
        {
            get
            {
                return _Valor;
            }
            set
            {
                _Valor = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return _Mensaje;
            }
            set
            {
                _Mensaje = value;
            }
        }

        public string Comentario
        {
            get
            {
                return _Comentario;
            }
            set
            {
                _Comentario = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                _Fecha = value;
            }
        }

        public string Hora
        {
            get
            {
                return _Hora;
            }
            set
            {
                _Hora = value;
            }
        }


        public string FechaAplicacion
        {
            get
            {
                return _FechaAplicacion;
            }
            set
            {
                _FechaAplicacion = value;
            }
        }

        public string HoraAplicacion
        {
            get
            {
                return _HoraAplicacion;
            }
            set
            {
                _HoraAplicacion = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }
            set
            {
                _Estado = value;
            }
        }


        public string ComentarioUsuarioDestino
        {
            get
            {
                return _ComentarioUsuarioDestino;
            }
            set
            {
                _ComentarioUsuarioDestino = value;
            }
        }


        public string Empresa
        {
            get
            {
                return _Empresa;
            }
            set
            {
                _Empresa = value;
            }
        }

    }
}