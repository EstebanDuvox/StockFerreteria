Imports SQL
Public Class Proveedores

    Dim dt As DataTable

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        If dgList.Rows.Count = 0 Then
            btnB.Enabled = False
        Else
            btnB.Enabled = True
        End If
    End Sub

    Private Sub btN_Click(sender As Object, e As EventArgs) Handles btN.Click
        añadir()
        mostrar()
    End Sub

    Private Sub btE_Click(sender As Object, e As EventArgs) Handles btE.Click
        quitar()
        mostrar()
    End Sub

    Private Sub mostrar()
        Dim x As New Proveedor
        dt = x.Mostrar()
        dgList.DataSource() = dt
    End Sub

    Private Sub añadir()
        Dim x As New Proveedor
        Dim res As String = x.Crear(txtE.Text, txtC.Text, txtD.Text, txtT.Text)
        MsgBox(res)
    End Sub

    Private Sub quitar()
        Dim x As New Proveedor
        Dim i As Integer = dgList.CurrentCell.RowIndex
        Dim res As String = x.Remover(dt.Rows(i).Item("Id_Proveedores"))
        MsgBox(res)
    End Sub

    Private Sub bus()
        Dim x As New Proveedor
        dt = x.Buscar(ComboBox1.Text, txtB.Text)
        dgList.DataSource = dt
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        bus()
    End Sub

End Class