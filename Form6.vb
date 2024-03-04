Imports System.IO

Public Class Form6
    Dim clientFichier As StreamWriter

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If ValidateData() Then
            Try
                'clientFichier.WriteLine("ID: " & txtbxID.Text)
                'clientFichier.WriteLine("Nom: " & txtbxNom.Text)
                'clientFichier.WriteLine("Prénom: " & txtbxPrenom.Text)
                'clientFichier.WriteLine("Téléphone: " & txtbxTelepnone.Text)
                'clientFichier.WriteLine("Email: " & txtbxEmail.Text)
                'clientFichier.WriteLine("Compagnie: " & txtbxCompagnie.Text)
                'clientFichier.WriteLine("Adresse: " & txtbxAdresse.Text)
                'clientFichier.WriteLine() ' Ajoute une ligne vide pour séparer les enregistrements

                Dim contenu As String = $"{txtbxID.Text},{vbTab}{txtbxNom.Text},{vbTab}{txtbxPrenom.Text},{vbTab}{txtbxTelephone.Text},{vbTab}{txtbxEmail.Text},{vbTab}{txtbxCompagnie.Text},{vbTab}{txtbxAdresse.Text}"
                clientFichier.WriteLine(contenu)

                MessageBox.Show("Données enregistrées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données: " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        ClearDocument()

    End Sub


    Private Function ValidateData() As Boolean
        If txtbxNom.Text = "" Or txtbxPrenom.Text = "" Or txtbxTelephone.Text = "" Or txtbxEmail.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not IsValidEmail(txtbxEmail.Text) Then
            MessageBox.Show("Le format de l'email est invalide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not IsValidPhoneNumber(txtbxTelephone.Text) Then
            MessageBox.Show("Le format du numéro de téléphone est invalide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function IsValidEmail(email As String) As Boolean

        Return True
    End Function

    Private Function IsValidPhoneNumber(phoneNumber As String) As Boolean

        Return True
    End Function

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientFichier = New StreamWriter("C:\Users\izry\source\repos\Abonnet\listClient.txt", True)

    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If clientFichier IsNot Nothing Then
            clientFichier.Close()
        End If
    End Sub

    Sub ClearDocument()
        txtbxID.Clear()
        txtbxNom.Clear()
        txtbxPrenom.Clear()
        txtbxTelephone.Clear()
        txtbxEmail.Clear()
        txtbxCompagnie.Clear()
        txtbxAdresse.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class