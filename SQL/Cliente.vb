Imports MySql.Data.MySqlClient
Public Class Cliente

    Inherits Conexiones
    Sub Crear(Nom, Ap, Cuil, Dir, Tip, mail)
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Insert into clientes(Nombre_C,Apellido_C,Cuit,Direccion_C,Tipo_Con,eMail) values ('" & Nom & "','" & Ap & "','" & Cuil & "','" & Dir & "','" & Tip & "','" & mail & "')"
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            End If
            MsgBox("El cliente " & Ap & ", " & Nom & " fue ingresado con exito.", vbOK)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectado()
        End Try
    End Sub

    Sub Remover(Sel)
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Delete from clientes where Id_Cliente =" & Sel
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.DeleteCommand = cmd
            End If
            MsgBox("El cliente seleccionado ha sido retirado con éxito.", vbOK)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectado()
        End Try
    End Sub

    Function Mostrar() As DataTable
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Select * from clientes"
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
    Function Buscar(req, dato)
        Dim campo As String
        If req = "Apellido" Then
            campo = "Apellido_C"
        Else
            campo = "Cuil"
        End If

        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Select * from clientes where " & campo & "='" & dato & "';"
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

    Function buscaridcl(cuil)
        Try
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = cc
                .CommandText = "Select Id_Cliente from clientes where Cuit =" & cuil
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                dt.MinimumCapacity = 1
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows(0).Item("Id_Cliente") <> "" Then
                    Return dt.Rows(0).Item("Id_Cliente")
                Else
                    MsgBox("No se ha encontrado ningún cliente registrado con ese CUIL.", vbOK)
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Sub actualizar(Nom, Ap, Cuil, Dir, Tip, mail)
        Try
            Conectado()
            Dim cl As Integer = buscaridcl(Cuil)
            Dim sqlc As String = "Update clientes set Nombre_C ='" & Nom & "', Apellido_C ='" & Ap & "',Direccion_C = '" & Dir & "',Tipo_Con ='" & Tip & ",eMail ='" & mail & "' where Id_Cliente =" & cl
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = sqlc
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.UpdateCommand = cmd
                MsgBox("Datos actualizados con éxito", vbOK)
            Else
                MsgBox("No se pudieron actualizar los datos", vbOK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectado()
        End Try
    End Sub

End Class
