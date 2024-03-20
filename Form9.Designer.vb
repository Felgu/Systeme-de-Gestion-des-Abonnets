<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitreClient = New Label()
        lblNomPrenom = New Label()
        lblAdresse = New Label()
        lblContact = New Label()
        lblContratClient = New Label()
        lblService = New Label()
        lblMontnt = New Label()
        lblDateDebut = New Label()
        lblDateFin = New Label()
        btnModifier = New Button()
        btnSupprimer = New Button()
        lblNPrenom = New Label()
        lblAdr = New Label()
        lblContat = New Label()
        lblServ = New Label()
        lblMont = New Label()
        lblDatD = New Label()
        lblDatF = New Label()
        SuspendLayout()
        ' 
        ' lblTitreClient
        ' 
        lblTitreClient.AutoSize = True
        lblTitreClient.BackColor = SystemColors.ActiveCaption
        lblTitreClient.Font = New Font("Times New Roman", 15.75F, FontStyle.Italic)
        lblTitreClient.Location = New Point(280, 19)
        lblTitreClient.Name = "lblTitreClient"
        lblTitreClient.Size = New Size(143, 23)
        lblTitreClient.TabIndex = 0
        lblTitreClient.Text = "Profil du Client"
        ' 
        ' lblNomPrenom
        ' 
        lblNomPrenom.AutoSize = True
        lblNomPrenom.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lblNomPrenom.Location = New Point(45, 65)
        lblNomPrenom.Name = "lblNomPrenom"
        lblNomPrenom.Size = New Size(127, 25)
        lblNomPrenom.TabIndex = 1
        lblNomPrenom.Text = "Nom Prenom"
        ' 
        ' lblAdresse
        ' 
        lblAdresse.AutoSize = True
        lblAdresse.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lblAdresse.Location = New Point(93, 120)
        lblAdresse.Name = "lblAdresse"
        lblAdresse.Size = New Size(79, 25)
        lblAdresse.TabIndex = 2
        lblAdresse.Text = "Adresse"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lblContact.Location = New Point(93, 175)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(79, 25)
        lblContact.TabIndex = 3
        lblContact.Text = "Contact"
        ' 
        ' lblContratClient
        ' 
        lblContratClient.AutoSize = True
        lblContratClient.BackColor = SystemColors.ActiveCaption
        lblContratClient.Font = New Font("Times New Roman", 15.75F, FontStyle.Italic)
        lblContratClient.Location = New Point(280, 228)
        lblContratClient.Name = "lblContratClient"
        lblContratClient.Size = New Size(161, 23)
        lblContratClient.TabIndex = 4
        lblContratClient.Text = "Contrat du Client"
        ' 
        ' lblService
        ' 
        lblService.AutoSize = True
        lblService.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lblService.Location = New Point(98, 268)
        lblService.Name = "lblService"
        lblService.Size = New Size(74, 25)
        lblService.TabIndex = 5
        lblService.Text = "Service"
        ' 
        ' lblMontnt
        ' 
        lblMontnt.AutoSize = True
        lblMontnt.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lblMontnt.Location = New Point(85, 323)
        lblMontnt.Name = "lblMontnt"
        lblMontnt.Size = New Size(87, 25)
        lblMontnt.TabIndex = 6
        lblMontnt.Text = "Montant"
        ' 
        ' lblDateDebut
        ' 
        lblDateDebut.AutoSize = True
        lblDateDebut.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lblDateDebut.Location = New Point(61, 378)
        lblDateDebut.Name = "lblDateDebut"
        lblDateDebut.Size = New Size(111, 25)
        lblDateDebut.TabIndex = 7
        lblDateDebut.Text = "Date Debut"
        ' 
        ' lblDateFin
        ' 
        lblDateFin.AutoSize = True
        lblDateFin.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lblDateFin.Location = New Point(88, 433)
        lblDateFin.Name = "lblDateFin"
        lblDateFin.Size = New Size(84, 25)
        lblDateFin.TabIndex = 8
        lblDateFin.Text = "Date Fin"
        ' 
        ' btnModifier
        ' 
        btnModifier.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        btnModifier.Location = New Point(153, 508)
        btnModifier.Name = "btnModifier"
        btnModifier.Size = New Size(109, 39)
        btnModifier.TabIndex = 9
        btnModifier.Text = "Modifier"
        btnModifier.UseVisualStyleBackColor = True
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSupprimer.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        btnSupprimer.Location = New Point(341, 508)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(109, 39)
        btnSupprimer.TabIndex = 10
        btnSupprimer.Text = "Supprimer"
        btnSupprimer.UseVisualStyleBackColor = True
        ' 
        ' lblNPrenom
        ' 
        lblNPrenom.AutoSize = True
        lblNPrenom.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        lblNPrenom.Location = New Point(262, 68)
        lblNPrenom.Name = "lblNPrenom"
        lblNPrenom.Size = New Size(0, 22)
        lblNPrenom.TabIndex = 11
        ' 
        ' lblAdr
        ' 
        lblAdr.AutoSize = True
        lblAdr.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        lblAdr.Location = New Point(262, 134)
        lblAdr.Name = "lblAdr"
        lblAdr.Size = New Size(0, 22)
        lblAdr.TabIndex = 12
        ' 
        ' lblContat
        ' 
        lblContat.AutoSize = True
        lblContat.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        lblContat.Location = New Point(262, 178)
        lblContat.Name = "lblContat"
        lblContat.Size = New Size(0, 22)
        lblContat.TabIndex = 13
        ' 
        ' lblServ
        ' 
        lblServ.AutoSize = True
        lblServ.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        lblServ.Location = New Point(262, 271)
        lblServ.Name = "lblServ"
        lblServ.Size = New Size(0, 22)
        lblServ.TabIndex = 14
        ' 
        ' lblMont
        ' 
        lblMont.AutoSize = True
        lblMont.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        lblMont.Location = New Point(262, 326)
        lblMont.Name = "lblMont"
        lblMont.Size = New Size(0, 22)
        lblMont.TabIndex = 15
        ' 
        ' lblDatD
        ' 
        lblDatD.AutoSize = True
        lblDatD.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        lblDatD.Location = New Point(262, 381)
        lblDatD.Name = "lblDatD"
        lblDatD.Size = New Size(0, 22)
        lblDatD.TabIndex = 16
        ' 
        ' lblDatF
        ' 
        lblDatF.AutoSize = True
        lblDatF.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        lblDatF.Location = New Point(262, 436)
        lblDatF.Name = "lblDatF"
        lblDatF.Size = New Size(0, 22)
        lblDatF.TabIndex = 17
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(831, 560)
        Controls.Add(lblDatF)
        Controls.Add(lblDatD)
        Controls.Add(lblMont)
        Controls.Add(lblServ)
        Controls.Add(lblContat)
        Controls.Add(lblAdr)
        Controls.Add(lblNPrenom)
        Controls.Add(btnSupprimer)
        Controls.Add(btnModifier)
        Controls.Add(lblDateFin)
        Controls.Add(lblDateDebut)
        Controls.Add(lblMontnt)
        Controls.Add(lblService)
        Controls.Add(lblContratClient)
        Controls.Add(lblContact)
        Controls.Add(lblAdresse)
        Controls.Add(lblNomPrenom)
        Controls.Add(lblTitreClient)
        Name = "Form9"
        Text = "Form9"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitreClient As Label
    Friend WithEvents lblNomPrenom As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblContratClient As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblMontnt As Label
    Friend WithEvents lblDateDebut As Label
    Friend WithEvents lblDateFin As Label
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents lblNPrenom As Label
    Friend WithEvents lblAdr As Label
    Friend WithEvents lblContat As Label
    Friend WithEvents lblServ As Label
    Friend WithEvents lblMont As Label
    Friend WithEvents lblDatD As Label
    Friend WithEvents lblDatF As Label
End Class
