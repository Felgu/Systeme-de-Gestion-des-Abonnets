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
        mnuModemInstall = New ToolStripMenuItem()
        mnuServeurInstall = New ToolStripMenuItem()
        mnuReparation = New ToolStripMenuItem()
        OrdinateurToolStripMenuItem = New ToolStripMenuItem()
        ModemToolStripMenuItem1 = New ToolStripMenuItem()
        ServeurToolStripMenuItem = New ToolStripMenuItem()
        mnuProgrammation = New ToolStripMenuItem()
        mnuWebPages = New ToolStripMenuItem()
        mnuFormation = New ToolStripMenuItem()
        mnuPersonnel = New ToolStripMenuItem()
        mnuAssistance = New ToolStripMenuItem()
        TelephoniqueToolStripMenuItem = New ToolStripMenuItem()
        IchatToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        mnuImpression = New ToolStripMenuItem()
        mnuRapport = New ToolStripMenuItem()
        mnuStats = New ToolStripMenuItem()
        ServiceToolStripMenuItem = New ToolStripMenuItem()
        mnuMateriel = New ToolStripMenuItem()
        mnuInternet = New ToolStripMenuItem()
        mnuServeur = New ToolStripMenuItem()
        mnuOrdinateur = New ToolStripMenuItem()
        mnuModem = New ToolStripMenuItem()
        mnuConsultation = New ToolStripMenuItem()
        mnuPrix = New ToolStripMenuItem()
        mnuModalite = New ToolStripMenuItem()
        mnuOffres = New ToolStripMenuItem()
        mnuLiquidation = New ToolStripMenuItem()
        mnuFinAnnee = New ToolStripMenuItem()
        mnuNewClient = New ToolStripMenuItem()
        mnuEntreprise = New ToolStripMenuItem()
        mnuAide = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        AdministrateurToolStripMenuItem = New ToolStripMenuItem()
        ClientToolStripMenuItem = New ToolStripMenuItem()
        KToolStripMenuItem = New ToolStripMenuItem()
        MToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        mnuLogin = New ToolStripMenuItem()
        mnuAdmin = New ToolStripMenuItem()
        mnuClient = New ToolStripMenuItem()
        l = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlDark
        MenuStrip1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuService, mnuMateriel, mnuConsultation, mnuOffres, mnuAide, LoginToolStripMenuItem, KToolStripMenuItem, MToolStripMenuItem, ToolStripMenuItem2, ToolStripMenuItem1, mnuLogin})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 3, 0, 3)
        MenuStrip1.Size = New Size(692, 35)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuService
        ' 
        mnuService.DropDownItems.AddRange(New ToolStripItem() {mnuInstallation, mnuReparation, mnuProgrammation, mnuFormation, mnuAssistance, ToolStripMenuItem3, mnuImpression, ServiceToolStripMenuItem})
        mnuService.Name = "mnuService"
        mnuService.Size = New Size(86, 29)
        mnuService.Text = "&Service"
        ' 
        ' mnuInstallation
        ' 
        mnuInstallation.DropDownItems.AddRange(New ToolStripItem() {mnuModemInstall, mnuServeurInstall})
        mnuInstallation.ForeColor = Color.DarkBlue
        mnuInstallation.Name = "mnuInstallation"
        mnuInstallation.Size = New Size(219, 30)
        mnuInstallation.Text = "&Installation"
        ' 
        ' mnuModemInstall
        ' 
        mnuModemInstall.Name = "mnuModemInstall"
        mnuModemInstall.Size = New Size(151, 30)
        mnuModemInstall.Text = "Modem"
        ' 
        ' mnuServeurInstall
        ' 
        mnuServeurInstall.Name = "mnuServeurInstall"
        mnuServeurInstall.Size = New Size(151, 30)
        mnuServeurInstall.Text = "Serveur"
        ' 
        ' mnuReparation
        ' 
        mnuReparation.DropDownItems.AddRange(New ToolStripItem() {OrdinateurToolStripMenuItem, ModemToolStripMenuItem1, ServeurToolStripMenuItem})
        mnuReparation.ForeColor = Color.DarkBlue
        mnuReparation.Name = "mnuReparation"
        mnuReparation.Size = New Size(219, 30)
        mnuReparation.Text = "&Réparation"
        ' 
        ' OrdinateurToolStripMenuItem
        ' 
        OrdinateurToolStripMenuItem.Name = "OrdinateurToolStripMenuItem"
        OrdinateurToolStripMenuItem.Size = New Size(177, 30)
        OrdinateurToolStripMenuItem.Text = "Ordinateur"
        ' 
        ' ModemToolStripMenuItem1
        ' 
        ModemToolStripMenuItem1.Name = "ModemToolStripMenuItem1"
        ModemToolStripMenuItem1.Size = New Size(177, 30)
        ModemToolStripMenuItem1.Text = "Modem"
        ' 
        ' ServeurToolStripMenuItem
        ' 
        ServeurToolStripMenuItem.Name = "ServeurToolStripMenuItem"
        ServeurToolStripMenuItem.Size = New Size(177, 30)
        ServeurToolStripMenuItem.Text = "Serveur"
        ' 
        ' mnuProgrammation
        ' 
        mnuProgrammation.DropDownItems.AddRange(New ToolStripItem() {mnuWebPages})
        mnuProgrammation.ForeColor = Color.DarkBlue
        mnuProgrammation.Name = "mnuProgrammation"
        mnuProgrammation.Size = New Size(219, 30)
        mnuProgrammation.Text = "&Programmation"
        ' 
        ' mnuWebPages
        ' 
        mnuWebPages.Name = "mnuWebPages"
        mnuWebPages.Size = New Size(177, 30)
        mnuWebPages.Text = "&Pages Web"
        ' 
        ' mnuFormation
        ' 
        mnuFormation.DropDownItems.AddRange(New ToolStripItem() {mnuPersonnel})
        mnuFormation.ForeColor = Color.DarkBlue
        mnuFormation.Name = "mnuFormation"
        mnuFormation.Size = New Size(219, 30)
        mnuFormation.Text = "&Formation"
        ' 
        ' mnuPersonnel
        ' 
        mnuPersonnel.Name = "mnuPersonnel"
        mnuPersonnel.Size = New Size(167, 30)
        mnuPersonnel.Text = "Personnel"
        ' 
        ' mnuAssistance
        ' 
        mnuAssistance.DropDownItems.AddRange(New ToolStripItem() {TelephoniqueToolStripMenuItem, IchatToolStripMenuItem})
        mnuAssistance.ForeColor = Color.DarkSlateBlue
        mnuAssistance.Name = "mnuAssistance"
        mnuAssistance.Size = New Size(219, 30)
        mnuAssistance.Text = "Assistance"
        ' 
        ' TelephoniqueToolStripMenuItem
        ' 
        TelephoniqueToolStripMenuItem.Name = "TelephoniqueToolStripMenuItem"
        TelephoniqueToolStripMenuItem.Size = New Size(198, 30)
        TelephoniqueToolStripMenuItem.Text = "&Telephonique"
        ' 
        ' IchatToolStripMenuItem
        ' 
        IchatToolStripMenuItem.Name = "IchatToolStripMenuItem"
        IchatToolStripMenuItem.Size = New Size(198, 30)
        IchatToolStripMenuItem.Text = "&Ichat"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(216, 6)
        ' 
        ' mnuImpression
        ' 
        mnuImpression.DropDownItems.AddRange(New ToolStripItem() {mnuRapport, mnuStats})
        mnuImpression.Name = "mnuImpression"
        mnuImpression.Size = New Size(219, 30)
        mnuImpression.Text = "Impression"
        ' 
        ' mnuRapport
        ' 
        mnuRapport.Name = "mnuRapport"
        mnuRapport.Size = New Size(182, 30)
        mnuRapport.Text = "Rapports"
        ' 
        ' mnuStats
        ' 
        mnuStats.Name = "mnuStats"
        mnuStats.Size = New Size(182, 30)
        mnuStats.Text = "Statistiques"
        ' 
        ' ServiceToolStripMenuItem
        ' 
        ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
        ServiceToolStripMenuItem.Size = New Size(219, 30)
        ' 
        ' mnuMateriel
        ' 
        mnuMateriel.DropDownItems.AddRange(New ToolStripItem() {mnuInternet, mnuServeur, mnuOrdinateur, mnuModem})
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
        ' mnuOrdinateur
        ' 
        mnuOrdinateur.Name = "mnuOrdinateur"
        mnuOrdinateur.Size = New Size(180, 30)
        mnuOrdinateur.Text = "&Ordinateur"
        ' 
        ' mnuModem
        ' 
        mnuModem.Name = "mnuModem"
        mnuModem.Size = New Size(180, 30)
        mnuModem.Text = "&Modem"
        ' 
        ' mnuConsultation
        ' 
        mnuConsultation.DropDownItems.AddRange(New ToolStripItem() {mnuPrix, mnuModalite})
        mnuConsultation.Name = "mnuConsultation"
        mnuConsultation.Size = New Size(141, 29)
        mnuConsultation.Text = "&Consultations"
        ' 
        ' mnuPrix
        ' 
        mnuPrix.Name = "mnuPrix"
        mnuPrix.Size = New Size(180, 30)
        mnuPrix.Text = "Prix"
        ' 
        ' mnuModalite
        ' 
        mnuModalite.Name = "mnuModalite"
        mnuModalite.Size = New Size(180, 30)
        mnuModalite.Text = "Modalites"
        ' 
        ' mnuOffres
        ' 
        mnuOffres.DropDownItems.AddRange(New ToolStripItem() {mnuLiquidation, mnuFinAnnee, mnuNewClient, mnuEntreprise})
        mnuOffres.Name = "mnuOffres"
        mnuOffres.Size = New Size(77, 29)
        mnuOffres.Text = "&Offres"
        ' 
        ' mnuLiquidation
        ' 
        mnuLiquidation.Name = "mnuLiquidation"
        mnuLiquidation.Size = New Size(217, 30)
        mnuLiquidation.Text = "Liquidation"
        ' 
        ' mnuFinAnnee
        ' 
        mnuFinAnnee.Name = "mnuFinAnnee"
        mnuFinAnnee.Size = New Size(217, 30)
        mnuFinAnnee.Text = "Fin d'annee"
        ' 
        ' mnuNewClient
        ' 
        mnuNewClient.Name = "mnuNewClient"
        mnuNewClient.Size = New Size(217, 30)
        mnuNewClient.Text = "Nouveau Client"
        ' 
        ' mnuEntreprise
        ' 
        mnuEntreprise.Name = "mnuEntreprise"
        mnuEntreprise.Size = New Size(217, 30)
        mnuEntreprise.Text = "&Entreprise"
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
        ' mnuLogin
        ' 
        mnuLogin.DropDownItems.AddRange(New ToolStripItem() {mnuAdmin, mnuClient, l})
        mnuLogin.ForeColor = Color.DarkSlateBlue
        mnuLogin.Name = "mnuLogin"
        mnuLogin.Size = New Size(71, 29)
        mnuLogin.Text = "&Login"
        ' 
        ' mnuAdmin
        ' 
        mnuAdmin.Name = "mnuAdmin"
        mnuAdmin.Size = New Size(213, 30)
        mnuAdmin.Text = "Administrateur"
        ' 
        ' mnuClient
        ' 
        mnuClient.Name = "mnuClient"
        mnuClient.Size = New Size(213, 30)
        mnuClient.Text = "Client"
        ' 
        ' l
        ' 
        l.Name = "l"
        l.Size = New Size(213, 30)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(692, 597)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.DarkOrchid
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
    Friend WithEvents mnuLogin As ToolStripMenuItem
    Friend WithEvents mnuAdmin As ToolStripMenuItem
    Friend WithEvents mnuClient As ToolStripMenuItem
    Friend WithEvents mnuLiquidation As ToolStripMenuItem
    Friend WithEvents mnuFinAnnee As ToolStripMenuItem
    Friend WithEvents mnuNewClient As ToolStripMenuItem
    Friend WithEvents mnuPrix As ToolStripMenuItem
    Friend WithEvents mnuModalite As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents mnuEntreprise As ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents l As ToolStripMenuItem
    Friend WithEvents mnuModemInstall As ToolStripMenuItem
    Friend WithEvents mnuOrdinateur As ToolStripMenuItem
    Friend WithEvents mnuModem As ToolStripMenuItem
    Friend WithEvents mnuServeurInstall As ToolStripMenuItem
    Friend WithEvents OrdinateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ServeurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuWebPages As ToolStripMenuItem
    Friend WithEvents TelephoniqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IchatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuRapport As ToolStripMenuItem
    Friend WithEvents mnuStats As ToolStripMenuItem
    Friend WithEvents mnuPersonnel As ToolStripMenuItem

End Class
