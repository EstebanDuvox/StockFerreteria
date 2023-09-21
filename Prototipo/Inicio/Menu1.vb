Public Class Menu1

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Clientes.Show()
    End Sub

    Private Sub btnProv_Click(sender As Object, e As EventArgs) Handles btnProv.Click
        Proveedores.Show()
    End Sub

    Private Sub btnProd_Click(sender As Object, e As EventArgs) Handles btnProd.Click
        Productos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub btnCU_Click(sender As Object, e As EventArgs) Handles btnCU.Click
        Form1.Show()
    End Sub

End Class