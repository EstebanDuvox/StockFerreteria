Imports MySql.Data.MySqlClient
Public Class Marca

    Inherits Conexiones
    Function Crear(Nom)
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Insert into marcas_p(Marca) values ('" & Nom & "')"
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            End If
            Dim Res As String = "La marca: " & Nom & " fue ingresada con éxito."
            Return Res
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

    Function Remover(Sel)
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Delete from marcas_p where id_Marca =" & Sel
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.DeleteCommand = cmd
            End If
            Dim Res As String = "La marca seleccionada ha sido retirada con éxito."
            Return Res
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

    Function Mostrar() As DataTable
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Select * from marcas_p"
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

    Function Buscar(dato)

        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Select * from marcas_p where Marca='" & dato & "';"
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

End Class