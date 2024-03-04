Imports System.IO

Public Class Form7

    Dim contratFichier As StreamWriter

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxNom.TextChanged


    End Sub

    Sub ClearDocument()

        txtbxID.Clear()
        txtbxNom.Clear()
        txtbxPrenom.Clear()
        txtbxTelephone.Clear()
        txtbxEmail.Clear()
        txtbxAdresse.Clear()

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
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearDocument()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contratFichier = New StreamWriter("C:\Users\izry\source\repos\Abonnet\listContrat.txt", True)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateData() Then
            Try
                Dim optionContrat As String
                If chkbxAnnee.Checked Then
                    optionContrat = chkbxAnnee.Text
                ElseIf chkbx2Ans.Checked Then
                    optionContrat = chkbx2Ans.Text
                Else
                    optionContrat = ""
                End If

                Dim contenu As String = $"{txtbxID.Text},{vbTab}{txtbxNom.Text},{vbTab}{txtbxPrenom.Text},{vbTab}{txtbxTelephone.Text},{vbTab}{txtbxEmail.Text},{vbTab}{txtbxAdresse.Text},{vbTab}{txtbxDate.Text},{vbTab}{optionContrat}"
                contratFichier.WriteLine(contenu)

                MessageBox.Show("Données enregistrées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données: " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If contratFichier IsNot Nothing Then
            contratFichier.Close()
        End If
    End Sub
End Class