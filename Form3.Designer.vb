<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        MenuStrip1 = New MenuStrip()
        ClientsToolStripMenuItem = New ToolStripMenuItem()
        NouveauToolStripMenuItem = New ToolStripMenuItem()
        ModifierToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        mnuContrat = New ToolStripMenuItem()
        NouveauToolStripMenuItem1 = New ToolStripMenuItem()
        mnuReouveller = New ToolStripMenuItem()
        mnuModificontrat = New ToolStripMenuItem()
        FacturesToolStripMenuItem = New ToolStripMenuItem()
        LocationToolStripMenuItem = New ToolStripMenuItem()
        AchatToolStripMenuItem = New ToolStripMenuItem()
        ImpotToolStripMenuItem = New ToolStripMenuItem()
        RapportToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlDark
        MenuStrip1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {ClientsToolStripMenuItem, mnuContrat, FacturesToolStripMenuItem, RapportToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 38)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ClientsToolStripMenuItem
        ' 
        ClientsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NouveauToolStripMenuItem, ModifierToolStripMenuItem, ToolStripMenuItem2})
        ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        ClientsToolStripMenuItem.Size = New Size(88, 34)
        ClientsToolStripMenuItem.Text = "&Clients"
        ' 
        ' NouveauToolStripMenuItem
        ' 
        NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        NouveauToolStripMenuItem.Size = New Size(186, 34)
        NouveauToolStripMenuItem.Text = "&Nouveau"
        ' 
        ' ModifierToolStripMenuItem
        ' 
        ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        ModifierToolStripMenuItem.Size = New Size(186, 34)
        ModifierToolStripMenuItem.Text = "&Modifier"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(186, 34)
        ToolStripMenuItem2.Text = "&Supprimer"
        ' 
        ' mnuContrat
        ' 
        mnuContrat.DropDownItems.AddRange(New ToolStripItem() {NouveauToolStripMenuItem1, mnuReouveller, mnuModificontrat})
        mnuContrat.Name = "mnuContrat"
        mnuContrat.Size = New Size(107, 34)
        mnuContrat.Text = "Contrats"
        ' 
        ' NouveauToolStripMenuItem1
        ' 
        NouveauToolStripMenuItem1.Name = "NouveauToolStripMenuItem1"
        NouveauToolStripMenuItem1.Size = New Size(239, 34)
        NouveauToolStripMenuItem1.Text = "Nouveau"
        ' 
        ' mnuReouveller
        ' 
        mnuReouveller.Name = "mnuReouveller"
        mnuReouveller.Size = New Size(239, 34)
        mnuReouveller.Text = "Renouvellement"
        ' 
        ' mnuModificontrat
        ' 
        mnuModificontrat.Name = "mnuModificontrat"
        mnuModificontrat.Size = New Size(239, 34)
        mnuModificontrat.Text = "Modification"
        ' 
        ' FacturesToolStripMenuItem
        ' 
        FacturesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LocationToolStripMenuItem, AchatToolStripMenuItem, ImpotToolStripMenuItem})
        FacturesToolStripMenuItem.Name = "FacturesToolStripMenuItem"
        FacturesToolStripMenuItem.Size = New Size(104, 34)
        FacturesToolStripMenuItem.Text = "&Factures"
        ' 
        ' LocationToolStripMenuItem
        ' 
        LocationToolStripMenuItem.Name = "LocationToolStripMenuItem"
        LocationToolStripMenuItem.Size = New Size(168, 34)
        LocationToolStripMenuItem.Text = "Location"
        ' 
        ' AchatToolStripMenuItem
        ' 
        AchatToolStripMenuItem.Name = "AchatToolStripMenuItem"
        AchatToolStripMenuItem.Size = New Size(168, 34)
        AchatToolStripMenuItem.Text = "Achat"
        ' 
        ' ImpotToolStripMenuItem
        ' 
        ImpotToolStripMenuItem.Name = "ImpotToolStripMenuItem"
        ImpotToolStripMenuItem.Size = New Size(168, 34)
        ImpotToolStripMenuItem.Text = "Impot"
        ' 
        ' RapportToolStripMenuItem
        ' 
        RapportToolStripMenuItem.Name = "RapportToolStripMenuItem"
        RapportToolStripMenuItem.Size = New Size(105, 34)
        RapportToolStripMenuItem.Text = "&Rapport"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form3"
        Text = "Page Administateur"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents mnuContrat As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuReouveller As ToolStripMenuItem
    Friend WithEvents mnuModificontrat As ToolStripMenuItem
    Friend WithEvents RapportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AchatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpotToolStripMenuItem As ToolStripMenuItem
End Class
