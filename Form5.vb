Imports System.Diagnostics.Eventing.Reader

Public Class Form5
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtbxUsername.Text = "" And txtbxPassword.Text = "" Then
            lblRappel.Text = "Assurez-vous d'entrer un nom et un mot de passe."

        Else
            Form4.Show()
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub


End Class