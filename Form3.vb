Public Class Form3
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click
        Form6.Show()

    End Sub

    Private Sub NouveauToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem1.Click
        Form7.Show()

    End Sub

    Private Sub mnuListeClients_Click(sender As Object, e As EventArgs) Handles mnuListeClients.Click
        Form8.Show()
    End Sub
End Class