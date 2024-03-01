<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        ContratToolStripMenuItem = New ToolStripMenuItem()
        LocationToolStripMenuItem = New ToolStripMenuItem()
        AbonnementToolStripMenuItem = New ToolStripMenuItem()
        ConsultationToolStripMenuItem = New ToolStripMenuItem()
        FactureToolStripMenuItem = New ToolStripMenuItem()
        ImpotToolStripMenuItem = New ToolStripMenuItem()
        AideToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlDark
        MenuStrip1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {ContratToolStripMenuItem, ConsultationToolStripMenuItem, AideToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ContratToolStripMenuItem
        ' 
        ContratToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LocationToolStripMenuItem, AbonnementToolStripMenuItem})
        ContratToolStripMenuItem.Name = "ContratToolStripMenuItem"
        ContratToolStripMenuItem.Size = New Size(90, 29)
        ContratToolStripMenuItem.Text = "&Contrat"
        ' 
        ' LocationToolStripMenuItem
        ' 
        LocationToolStripMenuItem.Name = "LocationToolStripMenuItem"
        LocationToolStripMenuItem.Size = New Size(196, 30)
        LocationToolStripMenuItem.Text = "&Location"
        ' 
        ' AbonnementToolStripMenuItem
        ' 
        AbonnementToolStripMenuItem.Name = "AbonnementToolStripMenuItem"
        AbonnementToolStripMenuItem.Size = New Size(196, 30)
        AbonnementToolStripMenuItem.Text = "Abonnement"
        ' 
        ' ConsultationToolStripMenuItem
        ' 
        ConsultationToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FactureToolStripMenuItem, ImpotToolStripMenuItem})
        ConsultationToolStripMenuItem.Name = "ConsultationToolStripMenuItem"
        ConsultationToolStripMenuItem.Size = New Size(134, 29)
        ConsultationToolStripMenuItem.Text = "Consultation"
        ' 
        ' FactureToolStripMenuItem
        ' 
        FactureToolStripMenuItem.Name = "FactureToolStripMenuItem"
        FactureToolStripMenuItem.Size = New Size(149, 30)
        FactureToolStripMenuItem.Text = "&Facture"
        ' 
        ' ImpotToolStripMenuItem
        ' 
        ImpotToolStripMenuItem.Name = "ImpotToolStripMenuItem"
        ImpotToolStripMenuItem.Size = New Size(149, 30)
        ImpotToolStripMenuItem.Text = "&Impot"
        ' 
        ' AideToolStripMenuItem
        ' 
        AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        AideToolStripMenuItem.Size = New Size(63, 29)
        AideToolStripMenuItem.Text = "Aide"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form4"
        Text = "Page Client"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContratToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FactureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpotToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbonnementToolStripMenuItem As ToolStripMenuItem
End Class
