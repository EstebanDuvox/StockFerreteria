Public Class Parametro
    Private _conexion As String

    Public Property Conexion() As String
        Get
            Return _conexion
        End Get
        Set(value As String)
            _conexion = value
        End Set
    End Property
End Class
