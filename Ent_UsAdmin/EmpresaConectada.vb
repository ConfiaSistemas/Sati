Imports System.Data.OleDb

Public Class EmpresaConectada
    Private _Conectada As Boolean
    Private _ConexionEmpresaConectada As OleDbConnection
    Public Property Conectada As Boolean
        Get
            Return _Conectada

        End Get
        Set(value As Boolean)
            _Conectada = value
        End Set
    End Property
    Public Property ConexionEmpresaConectada As OleDbConnection
        Get
            Return _ConexionEmpresaConectada
        End Get
        Set(value As OleDbConnection)
            _ConexionEmpresaConectada = value
        End Set
    End Property

End Class
