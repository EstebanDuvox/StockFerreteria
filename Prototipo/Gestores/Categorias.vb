Imports SQL
Public Class Categorias

    Dim dt As DataTable

    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        If dg.Rows.Count = 0 Then
            btnB.Enabled = False
        Else
            btnB.Enabled = True
        End If
    End Sub

    Private Sub Categorias_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Productos.reccb()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        ingresar()
        mostrar()
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        buscar()
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        remover()
        mostrar()
    End Sub

    Private Sub mostrar()
        Dim f As New Categoria
        dt = f.Mostrar
        dg.DataSource() = dt
    End Sub

    Private Sub remover()
        Dim f As New Categoria
        Dim i As Integer = dg.CurrentCell.RowIndex
        Dim Res As String = f.Remover(dt.Rows(i).Item("id_categoria"))
    End Sub

    Private Sub buscar()
        Dim f As New Categoria
        dt = f.Buscar(txtB.Text)
        dg.DataSource = dt
    End Sub

    Private Sub ingresar()
        Dim f As New Categoria
        Dim res As String = f.Crear(txtC.Text)
        MsgBox(res)
    End Sub

End Class