Imports System.IO

Public Class Form6
    Dim clientFichier As StreamWriter



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtbxNom.Text = "" And txtbxTelepnone.Text = "" And txtbxID.Text = "" And txtbxTelepnone.Text = "" Then
            lblMsgNC.Text = "Veuillez remplir toutes les cases."
        Else

        End If
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        ClearDocument()
        Dim fichier As File
        '("C:\Users\izry\source\repos\Abonnet\listClient.txt")
    End Sub
    Sub ClearDocument()
        txtbxID.Clear()
        txtbxNom.Clear()
        txtbxPrenom.Clear()
        txtbxTelepnone.Clear()
        txtbxEmail.Clear()
        txtbxCompagnie.Clear()
        txtbxAdresse.Clear()

    End Sub
End Class