Public Class Form7
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxNom.TextChanged


    End Sub

    Sub ClearDocument()
        txtbxNom.Clear()
        txtbxPrenom.Clear()
        txtbxPhone.Clear()
        txtbxEmail.Clear()
        txtbxAdresse.Clear()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearDocument()
    End Sub

End Class