Imports SQL
Public Class LoginForm1
    Private dt As DataTable
    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        verificar()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        End
    End Sub

    Private Sub verificar()
        Dim funcion As New Usuario
        Dim user, pass, tu As String
        dt = funcion.Ingresar(txtU.Text, txtC.Text)
        dt.MinimumCapacity = 0
        user = dt.Rows(0).Item("Nom_U")
        pass = dt.Rows(0).Item("Con_U")
        tu = dt.Rows(0).Item("Tipo_U")
        If txtU.Text = user And txtC.Text = pass Then
            If tu = "Personal" Then
                Menu1.btnProv.Visible = False
                Menu1.btnCU.Visible = False
            End If
            AyC()

        ElseIf txtU.Text <> user Or txtC.Text <> pass Then
            MsgBox("Usuario y/o Contraseña no valido")
        End If
    End Sub

    Private Sub AyC()
        Menu1.Show()
        Me.Close()
        txtU.Clear()
        txtC.Clear()
    End Sub

End Class
