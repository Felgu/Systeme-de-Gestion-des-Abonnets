Public Class Form6
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtbxNom.Text = "" And txtbxTelepnone.Text = "" And txtbxID.Text = "" And txtbxTelepnone.Text = "" Then
            lblMsgNC.Text = "Veuillez remplir toutes les cases."
        Else

        End If
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click

    End Sub
End Class