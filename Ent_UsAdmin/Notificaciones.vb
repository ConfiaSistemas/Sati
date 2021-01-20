Public Class Notificaciones
    Private _id As Integer
    Private _Tipo As String
    Private _Usuario As String
    Private _UsuarioDestino As String
    Private _Notificacion As Boolean
    Private _Valor As String
    Private _Mensaje As String
    Private _Comentario As String
    Private _Fecha As String
    Private _Hora As String
    Private _HoraAplicacion As String
    Private _FechaAplicacion As String
    Private _Estado As String
    Private _ComentarioUsuarioDestino As String
    Private _Empresa As String
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value

        End Set
    End Property

    Public Property UsuarioDestino As String
        Get
            Return _UsuarioDestino
        End Get
        Set(value As String)
            _UsuarioDestino = value
        End Set
    End Property

    Public Property Notificacion As Boolean
        Get
            Return _Notificacion
        End Get
        Set(value As Boolean)
            _Notificacion = value
        End Set
    End Property

    Public Property Valor As String
        Get
            Return _Valor
        End Get
        Set(value As String)
            _Valor = value
        End Set
    End Property

    Public Property Mensaje As String
        Get
            Return _Mensaje
        End Get
        Set(value As String)
            _Mensaje = value
        End Set
    End Property

    Public Property Comentario As String
        Get
            Return _Comentario
        End Get
        Set(value As String)
            _Comentario = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Hora As String
        Get
            Return _Hora
        End Get
        Set(value As String)
            _Hora = value
        End Set
    End Property


    Public Property FechaAplicacion As String
        Get
            Return _FechaAplicacion
        End Get
        Set(value As String)
            _FechaAplicacion = value
        End Set
    End Property

    Public Property HoraAplicacion As String
        Get
            Return _HoraAplicacion
        End Get
        Set(value As String)
            _HoraAplicacion = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property


    Public Property ComentarioUsuarioDestino As String
        Get
            Return _ComentarioUsuarioDestino
        End Get
        Set(value As String)
            _ComentarioUsuarioDestino = value
        End Set
    End Property


    Public Property Empresa As String
        Get
            Return _Empresa
        End Get
        Set(value As String)
            _Empresa = value
        End Set
    End Property

End Class
