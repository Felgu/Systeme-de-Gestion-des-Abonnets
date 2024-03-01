<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        mnuService = New ToolStripMenuItem()
        mnuInstallation = New ToolStripMenuItem()
        mnuReparation = New ToolStripMenuItem()
        mnuProgrammation = New ToolStripMenuItem()
        mnuFormation = New ToolStripMenuItem()
        mnuAssistance = New ToolStripMenuItem()
        mnuImpression = New ToolStripMenuItem()
        mnuMateriel = New ToolStripMenuItem()
        mnuInternet = New ToolStripMenuItem()
        mnuServeur = New ToolStripMenuItem()
        mnuOffres = New ToolStripMenuItem()
        LiquidationToolStripMenuItem = New ToolStripMenuItem()
        FinDanneeToolStripMenuItem = New ToolStripMenuItem()
        NouveauClientToolStripMenuItem = New ToolStripMenuItem()
        mnuConsultation = New ToolStripMenuItem()
        PrixToolStripMenuItem = New ToolStripMenuItem()
        ModalitesToolStripMenuItem = New ToolStripMenuItem()
        mnuAide = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        AdministrateurToolStripMenuItem = New ToolStripMenuItem()
        ClientToolStripMenuItem = New ToolStripMenuItem()
        KToolStripMenuItem = New ToolStripMenuItem()
        MToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        LoginToolStripMenuItem1 = New ToolStripMenuItem()
        AadministrateurToolStripMenuItem = New ToolStripMenuItem()
        ClientToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        EntrToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlDark
        MenuStrip1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuService, mnuMateriel, mnuConsultation, mnuOffres, mnuAide, LoginToolStripMenuItem, KToolStripMenuItem, MToolStripMenuItem, ToolStripMenuItem2, ToolStripMenuItem1, LoginToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 3, 0, 3)
        MenuStrip1.Size = New Size(1143, 35)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuService
        ' 
        mnuService.DropDownItems.AddRange(New ToolStripItem() {mnuInstallation, mnuReparation, mnuProgrammation, mnuFormation, mnuAssistance, ToolStripMenuItem3, mnuImpression})
        mnuService.Name = "mnuService"
        mnuService.Size = New Size(86, 29)
        mnuService.Text = "&Service"
        ' 
        ' mnuInstallation
        ' 
        mnuInstallation.ForeColor = Color.DarkBlue
        mnuInstallation.Name = "mnuInstallation"
        mnuInstallation.Size = New Size(219, 30)
        mnuInstallation.Text = "&Installation"
        ' 
        ' mnuReparation
        ' 
        mnuReparation.ForeColor = Color.DarkBlue
        mnuReparation.Name = "mnuReparation"
        mnuReparation.Size = New Size(219, 30)
        mnuReparation.Text = "&Réparation"
        ' 
        ' mnuProgrammation
        ' 
        mnuProgrammation.ForeColor = Color.DarkBlue
        mnuProgrammation.Name = "mnuProgrammation"
        mnuProgrammation.Size = New Size(219, 30)
        mnuProgrammation.Text = "&Programmation"
        ' 
        ' mnuFormation
        ' 
        mnuFormation.ForeColor = Color.DarkBlue
        mnuFormation.Name = "mnuFormation"
        mnuFormation.Size = New Size(219, 30)
        mnuFormation.Text = "&Fromation"
        ' 
        ' mnuAssistance
        ' 
        mnuAssistance.ForeColor = Color.DarkSlateBlue
        mnuAssistance.Name = "mnuAssistance"
        mnuAssistance.Size = New Size(219, 30)
        mnuAssistance.Text = "Assistance"
        ' 
        ' mnuImpression
        ' 
        mnuImpression.Name = "mnuImpression"
        mnuImpression.Size = New Size(219, 30)
        mnuImpression.Text = "Impression"
        ' 
        ' mnuMateriel
        ' 
        mnuMateriel.DropDownItems.AddRange(New ToolStripItem() {mnuInternet, mnuServeur})
        mnuMateriel.Name = "mnuMateriel"
        mnuMateriel.Size = New Size(104, 29)
        mnuMateriel.Text = "&Materiels"
        ' 
        ' mnuInternet
        ' 
        mnuInternet.Name = "mnuInternet"
        mnuInternet.Size = New Size(180, 30)
        mnuInternet.Text = "Internet"
        ' 
        ' mnuServeur
        ' 
        mnuServeur.Name = "mnuServeur"
        mnuServeur.Size = New Size(180, 30)
        mnuServeur.Text = "Serveur"
        ' 
        ' mnuOffres
        ' 
        mnuOffres.DropDownItems.AddRange(New ToolStripItem() {LiquidationToolStripMenuItem, FinDanneeToolStripMenuItem, NouveauClientToolStripMenuItem, EntrToolStripMenuItem})
        mnuOffres.Name = "mnuOffres"
        mnuOffres.Size = New Size(77, 29)
        mnuOffres.Text = "&Offres"
        ' 
        ' LiquidationToolStripMenuItem
        ' 
        LiquidationToolStripMenuItem.Name = "LiquidationToolStripMenuItem"
        LiquidationToolStripMenuItem.Size = New Size(217, 30)
        LiquidationToolStripMenuItem.Text = "Liquidation"
        ' 
        ' FinDanneeToolStripMenuItem
        ' 
        FinDanneeToolStripMenuItem.Name = "FinDanneeToolStripMenuItem"
        FinDanneeToolStripMenuItem.Size = New Size(217, 30)
        FinDanneeToolStripMenuItem.Text = "Fin d'annee"
        ' 
        ' NouveauClientToolStripMenuItem
        ' 
        NouveauClientToolStripMenuItem.Name = "NouveauClientToolStripMenuItem"
        NouveauClientToolStripMenuItem.Size = New Size(217, 30)
        NouveauClientToolStripMenuItem.Text = "Nouveau Client"
        ' 
        ' mnuConsultation
        ' 
        mnuConsultation.DropDownItems.AddRange(New ToolStripItem() {PrixToolStripMenuItem, ModalitesToolStripMenuItem})
        mnuConsultation.Name = "mnuConsultation"
        mnuConsultation.Size = New Size(141, 29)
        mnuConsultation.Text = "&Consultations"
        ' 
        ' PrixToolStripMenuItem
        ' 
        PrixToolStripMenuItem.Name = "PrixToolStripMenuItem"
        PrixToolStripMenuItem.Size = New Size(180, 30)
        PrixToolStripMenuItem.Text = "Prix"
        ' 
        ' ModalitesToolStripMenuItem
        ' 
        ModalitesToolStripMenuItem.Name = "ModalitesToolStripMenuItem"
        ModalitesToolStripMenuItem.Size = New Size(180, 30)
        ModalitesToolStripMenuItem.Text = "Modalites"
        ' 
        ' mnuAide
        ' 
        mnuAide.Name = "mnuAide"
        mnuAide.Size = New Size(63, 29)
        mnuAide.Text = "&Aide"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdministrateurToolStripMenuItem, ClientToolStripMenuItem})
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(12, 29)
        ' 
        ' AdministrateurToolStripMenuItem
        ' 
        AdministrateurToolStripMenuItem.Name = "AdministrateurToolStripMenuItem"
        AdministrateurToolStripMenuItem.Size = New Size(213, 30)
        AdministrateurToolStripMenuItem.Text = "Administrateur"
        ' 
        ' ClientToolStripMenuItem
        ' 
        ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        ClientToolStripMenuItem.Size = New Size(213, 30)
        ClientToolStripMenuItem.Text = "Client"
        ' 
        ' KToolStripMenuItem
        ' 
        KToolStripMenuItem.Name = "KToolStripMenuItem"
        KToolStripMenuItem.Size = New Size(29, 29)
        KToolStripMenuItem.Text = "."
        ' 
        ' MToolStripMenuItem
        ' 
        MToolStripMenuItem.Name = "MToolStripMenuItem"
        MToolStripMenuItem.Size = New Size(29, 29)
        MToolStripMenuItem.Text = "."
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(29, 29)
        ToolStripMenuItem2.Text = "."
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(29, 29)
        ToolStripMenuItem1.Text = "."
        ' 
        ' LoginToolStripMenuItem1
        ' 
        LoginToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {AadministrateurToolStripMenuItem, ClientToolStripMenuItem1})
        LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        LoginToolStripMenuItem1.Size = New Size(71, 29)
        LoginToolStripMenuItem1.Text = "&Login"
        ' 
        ' AadministrateurToolStripMenuItem
        ' 
        AadministrateurToolStripMenuItem.Name = "AadministrateurToolStripMenuItem"
        AadministrateurToolStripMenuItem.Size = New Size(213, 30)
        AadministrateurToolStripMenuItem.Text = "Administrateur"
        ' 
        ' ClientToolStripMenuItem1
        ' 
        ClientToolStripMenuItem1.Name = "ClientToolStripMenuItem1"
        ClientToolStripMenuItem1.Size = New Size(213, 30)
        ClientToolStripMenuItem1.Text = "Client"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(216, 6)
        ' 
        ' EntrToolStripMenuItem
        ' 
        EntrToolStripMenuItem.Name = "EntrToolStripMenuItem"
        EntrToolStripMenuItem.Size = New Size(217, 30)
        EntrToolStripMenuItem.Text = "&Entreprise"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Abonnet Menu Pricipal"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuService As ToolStripMenuItem
    Friend WithEvents mnuMateriel As ToolStripMenuItem
    Friend WithEvents mnuOffres As ToolStripMenuItem
    Friend WithEvents mnuConsultation As ToolStripMenuItem
    Friend WithEvents mnuAide As ToolStripMenuItem
    Friend WithEvents mnuInstallation As ToolStripMenuItem
    Friend WithEvents mnuReparation As ToolStripMenuItem
    Friend WithEvents mnuProgrammation As ToolStripMenuItem
    Friend WithEvents mnuFormation As ToolStripMenuItem
    Friend WithEvents mnuAssistance As ToolStripMenuItem
    Friend WithEvents mnuImpression As ToolStripMenuItem
    Friend WithEvents mnuInternet As ToolStripMenuItem
    Friend WithEvents mnuServeur As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AadministrateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LiquidationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinDanneeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrixToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModalitesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents EntrToolStripMenuItem As ToolStripMenuItem

End Class
