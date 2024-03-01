<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        lblContrat = New Label()
        lblNom = New Label()
        lblPrenom = New Label()
        lblTelephone = New Label()
        lblEmail = New Label()
        lblAdresse = New Label()
        dtmgridCalendrier = New DateTimePicker()
        txtbxNom = New TextBox()
        txtbxPrenom = New TextBox()
        txtbxPhone = New TextBox()
        txtbxEmail = New TextBox()
        txtbxAdresse = New TextBox()
        lblDateDebut = New Label()
        lblPeriode = New Label()
        btnSave = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' lblContrat
        ' 
        lblContrat.AutoSize = True
        lblContrat.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblContrat.Location = New Point(188, 29)
        lblContrat.Name = "lblContrat"
        lblContrat.Size = New Size(162, 25)
        lblContrat.TabIndex = 0
        lblContrat.Text = "Nouveau Contrat"
        ' 
        ' lblNom
        ' 
        lblNom.AutoSize = True
        lblNom.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        lblNom.Location = New Point(27, 99)
        lblNom.Name = "lblNom"
        lblNom.Size = New Size(55, 25)
        lblNom.TabIndex = 1
        lblNom.Text = "Nom"
        ' 
        ' lblPrenom
        ' 
        lblPrenom.AutoSize = True
        lblPrenom.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        lblPrenom.Location = New Point(27, 134)
        lblPrenom.Name = "lblPrenom"
        lblPrenom.Size = New Size(79, 25)
        lblPrenom.TabIndex = 2
        lblPrenom.Text = "Prenom"
        ' 
        ' lblTelephone
        ' 
        lblTelephone.AutoSize = True
        lblTelephone.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        lblTelephone.Location = New Point(27, 172)
        lblTelephone.Name = "lblTelephone"
        lblTelephone.Size = New Size(102, 25)
        lblTelephone.TabIndex = 3
        lblTelephone.Text = "Telephone"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        lblEmail.Location = New Point(27, 217)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(60, 25)
        lblEmail.TabIndex = 4
        lblEmail.Text = "Email"
        ' 
        ' lblAdresse
        ' 
        lblAdresse.AutoSize = True
        lblAdresse.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        lblAdresse.Location = New Point(22, 251)
        lblAdresse.Name = "lblAdresse"
        lblAdresse.Size = New Size(79, 25)
        lblAdresse.TabIndex = 5
        lblAdresse.Text = "Adresse"
        ' 
        ' dtmgridCalendrier
        ' 
        dtmgridCalendrier.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        dtmgridCalendrier.Location = New Point(214, 384)
        dtmgridCalendrier.Name = "dtmgridCalendrier"
        dtmgridCalendrier.Size = New Size(93, 33)
        dtmgridCalendrier.TabIndex = 6
        ' 
        ' txtbxNom
        ' 
        txtbxNom.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        txtbxNom.Location = New Point(214, 92)
        txtbxNom.Name = "txtbxNom"
        txtbxNom.Size = New Size(216, 33)
        txtbxNom.TabIndex = 7
        ' 
        ' txtbxPrenom
        ' 
        txtbxPrenom.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        txtbxPrenom.Location = New Point(214, 131)
        txtbxPrenom.Name = "txtbxPrenom"
        txtbxPrenom.Size = New Size(216, 33)
        txtbxPrenom.TabIndex = 8
        ' 
        ' txtbxPhone
        ' 
        txtbxPhone.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        txtbxPhone.Location = New Point(214, 172)
        txtbxPhone.Name = "txtbxPhone"
        txtbxPhone.Size = New Size(216, 33)
        txtbxPhone.TabIndex = 9
        ' 
        ' txtbxEmail
        ' 
        txtbxEmail.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        txtbxEmail.Location = New Point(214, 214)
        txtbxEmail.Name = "txtbxEmail"
        txtbxEmail.Size = New Size(216, 33)
        txtbxEmail.TabIndex = 10
        ' 
        ' txtbxAdresse
        ' 
        txtbxAdresse.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        txtbxAdresse.Location = New Point(213, 260)
        txtbxAdresse.Multiline = True
        txtbxAdresse.Name = "txtbxAdresse"
        txtbxAdresse.Size = New Size(217, 107)
        txtbxAdresse.TabIndex = 11
        ' 
        ' lblDateDebut
        ' 
        lblDateDebut.AutoSize = True
        lblDateDebut.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        lblDateDebut.Location = New Point(27, 390)
        lblDateDebut.Name = "lblDateDebut"
        lblDateDebut.Size = New Size(112, 25)
        lblDateDebut.TabIndex = 12
        lblDateDebut.Text = "Date Debut"
        ' 
        ' lblPeriode
        ' 
        lblPeriode.AutoSize = True
        lblPeriode.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        lblPeriode.Location = New Point(27, 438)
        lblPeriode.Name = "lblPeriode"
        lblPeriode.Size = New Size(77, 25)
        lblPeriode.TabIndex = 13
        lblPeriode.Text = "Periode"
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        btnSave.Location = New Point(214, 541)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(81, 38)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        btnClear.Location = New Point(353, 541)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(77, 38)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 709)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(lblPeriode)
        Controls.Add(lblDateDebut)
        Controls.Add(txtbxAdresse)
        Controls.Add(txtbxEmail)
        Controls.Add(txtbxPhone)
        Controls.Add(txtbxPrenom)
        Controls.Add(txtbxNom)
        Controls.Add(dtmgridCalendrier)
        Controls.Add(lblAdresse)
        Controls.Add(lblEmail)
        Controls.Add(lblTelephone)
        Controls.Add(lblPrenom)
        Controls.Add(lblNom)
        Controls.Add(lblContrat)
        Name = "Form7"
        Text = "Contrat d'Abonnement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblContrat As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents dtmgridCalendrier As DateTimePicker
    Friend WithEvents txtbxNom As TextBox
    Friend WithEvents txtbxPrenom As TextBox
    Friend WithEvents txtbxPhone As TextBox
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents txtbxAdresse As TextBox
    Friend WithEvents lblDateDebut As Label
    Friend WithEvents lblPeriode As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
End Class
