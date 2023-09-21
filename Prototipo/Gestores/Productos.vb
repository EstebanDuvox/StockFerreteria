Imports SQL
Public Class Productos

    Dim dt As DataTable

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        Facturacion.Show()
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reccb()
        mostrar()
        If Dglist.Rows.Count = 0 Then
            btnB.Enabled = False
        Else
            btnB.Enabled = True
        End If
    End Sub

    Private Sub btnCat_Click(sender As Object, e As EventArgs) Handles btnCat.Click
        Categorias.Show()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        nuevo()
        mostrar()
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Retirar()
        mostrar()
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        Marcas.Show()
    End Sub

    Private Sub mostrar()
        Dim f As New Producto
        dt = f.mostrar()
        Dglist.DataSource = dt
    End Sub

    Private Sub Retirar()
        Dim f As New Producto
        Dim i As Integer = Dglist.CurrentCell.RowIndex
        f.remover(i)
    End Sub

    Private Sub Buscar()
        Dim f As New Producto
        dt = f.buscar(txtbus.Text)
        Dglist.DataSource = dt
    End Sub

    Private Sub nuevo()
        Dim f As New Producto
        f.Crear(txtCod.Text, cbM.Text, txtmo.Text, txtpr.Text, txtcan.Text, cbC.Text, txtCMax.Text, txtCMin.Text, cbMK.Text, txtPS.Text, cbProv.Text)
    End Sub

    Public Sub reccb()
        Dim f As New Producto
        cbC.DataSource = f.listCat
        cbM.DataSource = f.listMarcas
        cbProv.DataSource = f.listProv
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Buscar()
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Dim f As New Producto
        f.actualizar(txtCod.Text, cbM.Text, txtmo.Text, txtpr.Text, txtcan.Text, cbC.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Producto
        f.agregar(txtCod.Text, txtcan.Text)
    End Sub
End Class