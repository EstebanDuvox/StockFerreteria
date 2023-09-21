Imports MySql.Data.MySqlClient

Public Class Usuario

    Inherits Conexiones

    Function Ingresar(User As String, Pass As String) As DataTable
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Select * From usuarios Where Nom_U='" & User & "' or Con_U='" & Pass & "';"
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

    Function Crear(User As String, Pass As String, Type As String)
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Insert into usuarios(Nom_U,Con_U,Tipo_U) values ('" & User & "','" & Pass & "','" & Type & "')"
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            End If
            Dim Res As String = "El usuario: " & User & " fue creado con exito"
            Return Res
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

End Class
