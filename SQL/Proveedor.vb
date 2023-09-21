Imports MySql.Data.MySqlClient
Public Class Proveedor

    Inherits Conexiones

    Sub Crear(Nom, Cuil, Dir, Tel, mail)
        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Insert into proveedores(Empresa_P,Cuit_P,Direccion_P,Telefono_P,eMail) values ('" & Nom & "','" & Cuil & "','" & Dir & "','" & Tel & "','" & mail & "')"
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            End If
            MsgBox("El proveedor:" & Nom & " fue ingresado con éxito.", vbOK)
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
            sqlc = "Delete from proveedores where Id_Proveedores =" & Sel
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.DeleteCommand = cmd
            End If
            MsgBox("El proveedor seleccionado ha sido retirado con éxito.", vbOK)
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
            sqlc = "Select * from proveedores"
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
        If req = "Empresa" Then
            campo = "Empresa_P"
        ElseIf req = "CUIT" Then
            campo = "Cuit_P"
        Else
            campo = "Telefono_P"
        End If

        Try
            Conectado()
            Dim sqlc As String
            Dim cmd As New MySqlCommand
            sqlc = "Select * from proveedores where " & campo & "='" & dato & "';"
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

    Function buscaridprov(cuit)
        Try
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = cc
                .CommandText = "Select Id_Proveedores from proveedores where Cuit_P =" & cuit
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                dt.MinimumCapacity = 1
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows(0).Item("Id_Proveedores") <> "" Then
                    Return dt.Rows(0)
                Else
                    MsgBox("No se ha encontrado ningún proveedor registrado con ese CUIT", vbOK)
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

    Sub actualizar(Nom, Cuit, Dir, Tel, mail)
        Try
            Conectado()
            Dim prov As Integer = buscaridprov(Cuit)
            Dim sqlc As String = "Update proveedores set Empresa_P ='" & Nom & "',Direccion_P = '" & Dir & "',Telefono_P ='" & Tel & ",eMail='" & mail & "' where Id_proveedores =" & prov
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