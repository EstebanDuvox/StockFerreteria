Imports SQL
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu1.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtcc.UseSystemPasswordChar = False
        Else
            txtcc.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub txtcnu_GotFocus(sender As Object, e As EventArgs) Handles txtcnu.GotFocus
        txtcnu.Clear()
        txtcnu.Font = New Font(txtcnu.Font, FontStyle.Regular)
        txtcnu.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sen As New Usuario
        Dim tipo As String = ""
        If rbp.Checked Then
            tipo = "Personal"
        ElseIf rbg.Checked Then
            tipo = "Gerente"
        ElseIf rba.Checked Then
            tipo = "Administrador"
        Else
            MsgBox("Seleccione un tipo de usuario.")
        End If
        If tipo <> "" Then
            Dim msg As String = sen.Crear(txtcnu.Text, txtcc.Text, tipo)
            MsgBox(msg)
        End If

    End Sub

End Class