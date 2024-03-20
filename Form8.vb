Imports System.Collections
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form8

    Structure client
        Dim nom As String
        Dim contact As String
        Dim addresse As String
        Dim service As String
        Dim dateDebut As Date
        Dim montant As Decimal
        Dim dateFin As Date
    End Structure
    Dim villes() As String = {"riopn", "Gatineau", "montrreal", "Ottawa"}
    Dim vservices() As String = {"connnexion", "telephonie", "cablage", "netflix"}
    Dim collectionsClients As New Collection
    Dim clients As client
    Dim f As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listeNom() As String = {"Gilbert " & vbTab & vbTab & "Rayan", "Mary " & vbTab & vbTab & "Lorde", "Guy " & vbTab & vbTab & "Parfait", "BRYAn " & vbTab & vbTab & "DUalla", "Alice " & vbTab & vbTab & "Benjo", "Jean pierre " & vbTab & vbTab & "Petit", "Rose " & vbTab & vbTab & "Monde"}
        lsc.Items.Add("NOM" & vbTab & vbTab & "PRENOM")
        Dim i As String
        For Each i In listeNom
            lsc.Items.Add(i)
            With clients
                .nom = i
                .contact = "8855256147"
                .addresse = "14 de la sud " & villes(f Mod 4)
                .service = vservices(f Mod 4)
                .dateDebut = TimeOfDay
                .dateFin = Date.Now
                .montant = 250 + f
                f += 1
            End With

            collectionsClients.Add(clients, i)
        Next

    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsc.SelectedIndexChanged

    End Sub

    Private Sub ListBox_DoubleClick(sender As Object, e As EventArgs) Handles lsc.DoubleClick
        If lsc.SelectedIndex > -1 Then
            Dim sindex As Integer
            sindex = lsc.SelectedIndex
            Dim sitem As String
            sitem = lsc.SelectedItem
            Dim conteneur As client = collectionsClients.Item(sitem)


            Form9.lblNPrenom.Text = conteneur.nom
            Form9.lblAdr.Text = conteneur.addresse
            Form9.lblContat.Text = conteneur.contact
            Form9.lblServ.Text = conteneur.service
            Form9.lblDatD.Text = conteneur.dateDebut.ToString
            Form9.lblDatF.Text = conteneur.dateFin.ToString
            Form9.lblMont.Text = conteneur.montant.ToString & "$"
            Form9.Show()


        End If


    End Sub
End Class
