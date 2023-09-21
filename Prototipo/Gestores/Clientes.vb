Imports SQL

Public Class Clientes

    Dim dt As DataTable

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        If Dglist.Rows.Count = 0 Then
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
        Dim f1 As New Cliente
        dt = f1.Mostrar
        Dglist.DataSource() = dt
    End Sub

    Private Sub añadir()
        Dim f2 As New Cliente
        Dim res As String = f2.Crear(txtN.Text, txtA.Text, txtC.Text, txtD.Text, cbtc.Text)
        MsgBox(res)
    End Sub

    Private Sub quitar()
        Dim f3 As New Cliente
        Dim i As Integer = Dglist.CurrentCell.RowIndex
        Dim res As String = f3.Remover(dt.Rows(i).Item("Id_Cliente"))
        MsgBox(res)
    End Sub

    Private Sub bus()
        Dim f4 As New Cliente
        dt = f4.Buscar(cbb.Text, txtB.Text)
        Dglist.DataSource() = dt
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        bus()
    End Sub

End Class