Imports MySql.Data.MySqlClient
Public Class Facturas

    Inherits Conexiones

    Function busidc(cuit)
        Try
            Dim sqlc As String = "select Id_Cliente where Cuit =" & cuit
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
                Return dt.Rows(0).Item("Id_Cliente")
            Else
                MsgBox("No hay ningún cliente registrado con ese CUIL")
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Sub modkar(cod, cant)
        Dim f As New Producto
        Dim idkar As Integer = f.buscaridcab(cod)
        Dim stock As Integer = f.busstock(cod)
        Try
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = "Insert into detalles_kardex(Id_cabKardex,Fecha_K,Cant,Movimiento,Cant_Total) values ('" & idkar & "','" & System.DateTime.Today & "','" & cant & "','Salida','" & stock - cant & "')"
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function prc(cod)
        Try
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = cc
                .CommandText = "Select Precio_S from productos where Codigo_P = " & cod
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                da.Fill(dt)
                Return dt.Rows(0).Item("Precio_S")
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Sub crearfac(cuil, cod, cant, fac, iva)
        Try
            Conectado()
            Dim ven As Date = Date.Now
            ven = ven.AddMonths(0.5#)
            Dim pr As Integer = prc(cod)
            Dim st As Integer = pr * cant
            Dim id As Integer = busidc(cuil)
            Dim CAE As Integer = Int((99999999 * Rnd()) + 1)
            Dim sqlc As String = "Insert into cabecera_facturas(Id_Cliente,TipoFac_Ca,CAE,FechaVen_CAE) values ('" & id & "','" & fac & "','" & CAE & "','" & ven & "')"
            Dim cmd As New MySqlCommand
            With cmd
                .CommandText = sqlc
                .Connection = cc
            End With
            If cmd.ExecuteNonQuery Then
                Dim da As New MySqlDataAdapter
                da.InsertCommand = cmd
            Else
                MsgBox("No se pudo facturar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = cc
                .CommandText = ""
            End With
            Desconectado()
        End Try
    End Sub

End Class