Imports MySql.Data.MySqlClient
Public Class Producto

    Inherits Conexiones

    Function listProv()
        Try
            Conectado()
            Dim sqlc = "select Empresa_P from proveedores"
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                Dim dl As New List(Of String)
                da.SelectCommand = cmd
                da.Fill(dt)
                dl = (From i In dt.AsEnumerable() Select i.Field(Of String)(0)).ToList()
                Return dl
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

    Function listMarcas()
        Try
            Conectado()
            Dim sqlc As String = "select Marca from marcas_p"
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = sqlc
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dl As New List(Of String)
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                dl = (From i In dt.AsEnumerable() Select i.Field(Of String)(0)).ToList()
                Return dl
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

    Function listCat()
        Try
            Conectado()
            Dim sqlc As String = "select categoria from categorias_p"
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = sqlc
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dl As New List(Of String)
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                dl = (From i In dt.AsEnumerable() Select i.Field(Of String)(0)).ToList()
                Return dl
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

    Function buscaridMarca(mar)
        Try
            Dim sqlc As String = "select id_Marca from marcas_p where Marca='" & mar & "'"
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = sqlc
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                Dim res As String = dt.Rows(0).Item("id_Marca")
                If res <> "" Then
                    Return res
                Else
                    MsgBox("No se pudo encontrar esa marca")
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

    Function buscaridCatergorias(cat)
        Try
            Dim sqlc As String = "select id_categoria from categorias_p where categoria='" & cat & "'"
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = sqlc
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                dt.MinimumCapacity = 1
                Dim res As String = dt.Rows(0).Item("id_categoria")
                If res <> "" Then
                    Return res
                Else
                    MsgBox("No se pudo encontrar esa categoría")
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

    Function buscaridcab(cod)
        Try
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = "Select Id_cabKardex From cabecera_kardex where Codigo_P = " & cod
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                dt.MinimumCapacity = 1
                da.SelectCommand = cmd
                da.Fill(dt)
                Return dt.Rows(0).Item("Id_cabKardex")
            Else
                MsgBox("Error")
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function busstock(cod)
        Try
            Dim id As Integer = buscaridcab(cod)
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = cc
                .CommandText = "Select id_detKardex, Cant_Total From detalles_kardex where detalles_kardex.id_cabKardex = cabecera_kardex.id_cabKardex Order by desc"
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                Return dt.Rows(0).Item("Cant_Total")
            Else
                MsgBox("Error", vbOK)
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Sub detkar(cod, nom, model, cant, val)
        Try
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = "Insert into detalles_Kardex(Id_cabKardex,Fecha_K,cant,Movimiento,Cant_Total) values('" & cod & "','" & System.DateTime.Today & "','" & cant & "','Entrada','" & cant & "')"
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            Else
                MsgBox("Hubo un error a la hora de crear el producto.", vbOK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Crear(cod, mar, mode, pr, exis, cat, canma, canmi, met, por, prov)
        Try
            Conectado()
            mar = buscaridMarca(mar)
            cat = buscaridCatergorias(cat)
            Dim sqlc As String = "insert into productos(Codigo_P,id_Marca,Modelo,Precio_E,Precio_S,id_categoria,prov) values('" & cod & "','" & mar & "','" & mode & "','" & pr & "','" & por & "','" & cat & "','" & prov & "')"
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = sqlc
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            End If
            MsgBox("Producto ingresado con éxito", vbOK)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim sqlc As String = "Insert into cabecera_kardex(Cant_Max,Cant_Min,Metodo,Codigo_P) values('" & canma & "','" & canmi & "','" & met & "','" & cod & "')"
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = sqlc
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            End If
            detkar(cod, mar, mode, exis, pr)
            Desconectado()
        End Try
    End Sub

    Function mostrar() As DataTable
        Try
            Conectado()
            Dim sqlc As String = "Select productos.Codigo_P,marcas_p.Marca,productos.Modelo,productos.Precio_E,productos.Precio_S,categorias_p.categoria,proveedores.Id_Proveedores from productos,marcas_P,categorias_p,proveedores where productos.Id_Marca = marcas_p.id_Marca and productos.Id_categoria = categorias_p.id_categoria and productos.Id_Proveedores = proveedores.Id_Proveedores"
            Dim cmd As New MySqlCommand
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

    Sub agregar(cod, cant)
        Try
            Conectado()
            Dim cmd As New MySqlCommand
            Dim cante As Integer = busstock(cod)
            Dim id As Integer = buscaridcab(cod)
            With cmd
                .Connection = cc
                .CommandText = "Insert into detalles_kardex(Id_cabKardex,Fecha_K,cant,Movimiento,Cant_Total) values('" & id & "','" & System.DateTime.Today & "','" & cant & "','Entrada','" & cante + cant & "')"
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectado()
        End Try
    End Sub

    Sub remover(cat)
        Conectado()
        Try
            Dim sqlc As String = "Delete from productos where Codigo_P=" & cat
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = cc
                .CommandText = sqlc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.DeleteCommand = cmd
                MsgBox("Producto retirado con éxito", vbOK)
            Else
                MsgBox("No se ha podido retirar el producto", vbOK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectado()
        End Try
    End Sub

    Function buscar(cam) As DataTable
        Conectado()
        If cam = "Codigo" Then
            cam = "Codigo_P"
        ElseIf cam = "Marca" Then
            cam = "Id_marca"
        Else
            cam = "Modelo"
        End If

        Try
            Dim sqlc As String = "Select * from productos where Codigo_P='" & cam & "'"
            Dim cmd As New MySqlCommand
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

    Sub actualizar(cod, mar, mode, por, cat, prov)
        Try
            Conectado()
            mar = buscaridMarca(mar)
            cat = buscaridCatergorias(cat)
            Dim sqlc As String = "Update productos set Id_Marca ='" & mar & "',Modelo = '" & mode & "',Precio_S ='" & por & "',Id_Categoria = '" & cat & ",Id_Proveedores =" & prov & "' where Codigo_P =" & cod
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