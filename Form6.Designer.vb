<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        lblNom = New Label()
        lblPrenom = New Label()
        lblAdresse = New Label()
        lblTelephone = New Label()
        txtbxNom = New TextBox()
        txtbxPrenom = New TextBox()
        txtbxTelepnone = New TextBox()
        txtbxAdresse = New TextBox()
        txtbxID = New TextBox()
        lblID = New Label()
        lblNewClient = New Label()
        btnSave = New Button()
        btnSupprimer = New Button()
        lblErrurNC = New Label()
        lblMsgNC = New Label()
        lblEmail = New Label()
        lblCompagnieNom = New Label()
        txtbxEmail = New TextBox()
        txtbxCompagnie = New TextBox()
        SuspendLayout()
        ' 
        ' lblNom
        ' 
        lblNom.AutoSize = True
        lblNom.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblNom.Location = New Point(37, 116)
        lblNom.Name = "lblNom"
        lblNom.Size = New Size(45, 21)
        lblNom.TabIndex = 1
        lblNom.Text = "Nom"
        ' 
        ' lblPrenom
        ' 
        lblPrenom.AutoSize = True
        lblPrenom.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblPrenom.Location = New Point(37, 168)
        lblPrenom.Name = "lblPrenom"
        lblPrenom.Size = New Size(66, 21)
        lblPrenom.TabIndex = 2
        lblPrenom.Text = "Prenom"
        ' 
        ' lblAdresse
        ' 
        lblAdresse.AutoSize = True
        lblAdresse.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblAdresse.Location = New Point(37, 348)
        lblAdresse.Name = "lblAdresse"
        lblAdresse.Size = New Size(66, 21)
        lblAdresse.TabIndex = 4
        lblAdresse.Text = "Adresse"
        ' 
        ' lblTelephone
        ' 
        lblTelephone.AutoSize = True
        lblTelephone.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblTelephone.Location = New Point(37, 216)
        lblTelephone.Name = "lblTelephone"
        lblTelephone.Size = New Size(84, 21)
        lblTelephone.TabIndex = 3
        lblTelephone.Text = "Téléphone"
        ' 
        ' txtbxNom
        ' 
        txtbxNom.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        txtbxNom.Location = New Point(227, 116)
        txtbxNom.Name = "txtbxNom"
        txtbxNom.Size = New Size(163, 29)
        txtbxNom.TabIndex = 8
        txtbxNom.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtbxPrenom
        ' 
        txtbxPrenom.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        txtbxPrenom.Location = New Point(227, 168)
        txtbxPrenom.Name = "txtbxPrenom"
        txtbxPrenom.Size = New Size(163, 29)
        txtbxPrenom.TabIndex = 9
        txtbxPrenom.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtbxTelepnone
        ' 
        txtbxTelepnone.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        txtbxTelepnone.Location = New Point(227, 216)
        txtbxTelepnone.Name = "txtbxTelepnone"
        txtbxTelepnone.Size = New Size(163, 29)
        txtbxTelepnone.TabIndex = 10
        txtbxTelepnone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtbxAdresse
        ' 
        txtbxAdresse.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        txtbxAdresse.Location = New Point(227, 351)
        txtbxAdresse.Multiline = True
        txtbxAdresse.Name = "txtbxAdresse"
        txtbxAdresse.Size = New Size(163, 79)
        txtbxAdresse.TabIndex = 11
        txtbxAdresse.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtbxID
        ' 
        txtbxID.Location = New Point(227, 75)
        txtbxID.Name = "txtbxID"
        txtbxID.Size = New Size(164, 23)
        txtbxID.TabIndex = 7
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(37, 77)
        lblID.Name = "lblID"
        lblID.Size = New Size(86, 21)
        lblID.TabIndex = 0
        lblID.Text = "Identifiant"
        ' 
        ' lblNewClient
        ' 
        lblNewClient.AutoSize = True
        lblNewClient.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNewClient.Location = New Point(144, 22)
        lblNewClient.Name = "lblNewClient"
        lblNewClient.Size = New Size(118, 21)
        lblNewClient.TabIndex = 10
        lblNewClient.Text = "Nouveau client"
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        btnSave.Location = New Point(119, 462)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(105, 34)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic)
        btnSupprimer.Location = New Point(251, 462)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(105, 34)
        btnSupprimer.TabIndex = 6
        btnSupprimer.Text = "Supprimer"
        btnSupprimer.UseVisualStyleBackColor = True
        ' 
        ' lblErrurNC
        ' 
        lblErrurNC.AutoSize = True
        lblErrurNC.Location = New Point(114, 519)
        lblErrurNC.Name = "lblErrurNC"
        lblErrurNC.Size = New Size(10, 15)
        lblErrurNC.TabIndex = 12
        lblErrurNC.Text = "."
        ' 
        ' lblMsgNC
        ' 
        lblMsgNC.AutoSize = True
        lblMsgNC.Location = New Point(114, 551)
        lblMsgNC.Name = "lblMsgNC"
        lblMsgNC.Size = New Size(10, 15)
        lblMsgNC.TabIndex = 13
        lblMsgNC.Text = "."
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblEmail.Location = New Point(37, 267)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(114, 21)
        lblEmail.TabIndex = 14
        lblEmail.Text = "Business Email"
        ' 
        ' lblCompagnieNom
        ' 
        lblCompagnieNom.AutoSize = True
        lblCompagnieNom.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblCompagnieNom.Location = New Point(37, 304)
        lblCompagnieNom.Name = "lblCompagnieNom"
        lblCompagnieNom.Size = New Size(134, 21)
        lblCompagnieNom.TabIndex = 15
        lblCompagnieNom.Text = "Nom Compagnie"
        ' 
        ' txtbxEmail
        ' 
        txtbxEmail.Font = New Font("Segoe UI", 12F)
        txtbxEmail.Location = New Point(227, 267)
        txtbxEmail.Name = "txtbxEmail"
        txtbxEmail.Size = New Size(164, 29)
        txtbxEmail.TabIndex = 16
        ' 
        ' txtbxCompagnie
        ' 
        txtbxCompagnie.Font = New Font("Segoe UI", 12F)
        txtbxCompagnie.Location = New Point(227, 306)
        txtbxCompagnie.Name = "txtbxCompagnie"
        txtbxCompagnie.Size = New Size(163, 29)
        txtbxCompagnie.TabIndex = 17
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(583, 639)
        Controls.Add(txtbxCompagnie)
        Controls.Add(txtbxEmail)
        Controls.Add(lblCompagnieNom)
        Controls.Add(lblEmail)
        Controls.Add(lblMsgNC)
        Controls.Add(lblErrurNC)
        Controls.Add(btnSupprimer)
        Controls.Add(btnSave)
        Controls.Add(lblNewClient)
        Controls.Add(lblID)
        Controls.Add(txtbxID)
        Controls.Add(txtbxAdresse)
        Controls.Add(txtbxTelepnone)
        Controls.Add(txtbxPrenom)
        Controls.Add(txtbxNom)
        Controls.Add(lblTelephone)
        Controls.Add(lblAdresse)
        Controls.Add(lblPrenom)
        Controls.Add(lblNom)
        Name = "Form6"
        Text = "Formulaire d'enregistrement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents txtbxNom As TextBox
    Friend WithEvents txtbxPrenom As TextBox
    Friend WithEvents txtbxTelepnone As TextBox
    Friend WithEvents txtbxAdresse As TextBox
    Friend WithEvents txtbxID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblNewClient As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents lblErrurNC As Label
    Friend WithEvents lblMsgNC As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblCompagnieNom As Label
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents txtbxCompagnie As TextBox
End Class
