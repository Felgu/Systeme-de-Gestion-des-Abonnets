Public Class Form2
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtbxUsername.Text = "" And txtbxPassword.Text = "" Then
            lblAvertAdmin.Text = "Veuillez taper un nom utilisateur et son mot de passe."
        Else
            Form3.Show()
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class