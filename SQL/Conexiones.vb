Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Conexiones
    Protected cc As New MySqlConnection
    Public Id_Usuario As Integer

    Public Function Conectado()
        Try
            Dim oPara As New Parametro()
            oPara.Conexion = ConfigurationManager.AppSettings("StringConexion")
            cc = New MySqlConnection(oPara.Conexion)
            cc.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconectado()
        Try
            If cc.State = ConnectionState.Open Then
                cc.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
