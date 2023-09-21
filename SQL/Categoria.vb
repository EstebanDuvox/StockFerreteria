Imports MySql.Data.MySqlClient
Public Class Categoria

    Inherits Conexiones
    Function Crear(Nom)
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Insert into categorias_p(categoria) values ('" & Nom & "')"
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            End If
            Dim Res As String = "La categoria: " & Nom & " fue ingresada con éxito."
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
            sqlc = "Delete from categorias_p where id_categoria =" & Sel
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.DeleteCommand = cmd
            End If
            Dim Res As String = "La categoría seleccionado ha sido retirado con éxito."
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
            sqlc = "Select * from categorias_p"
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
            sqlc = "Select * from categorias_p where categoria='" & dato & "';"
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