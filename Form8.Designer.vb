<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
        textbox = New TextBox()
        ButtonRecherche = New Button()
        lsc = New ListBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' textbox
        ' 
        textbox.BackColor = SystemColors.ScrollBar
        textbox.Font = New Font("Times New Roman", 12F)
        textbox.Location = New Point(590, 45)
        textbox.Multiline = True
        textbox.Name = "textbox"
        textbox.Size = New Size(264, 41)
        textbox.TabIndex = 0
        ' 
        ' ButtonRecherche
        ' 
        ButtonRecherche.BackColor = SystemColors.ActiveCaption
        ButtonRecherche.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        ButtonRecherche.Location = New Point(439, 45)
        ButtonRecherche.Name = "ButtonRecherche"
        ButtonRecherche.Size = New Size(145, 45)
        ButtonRecherche.TabIndex = 1
        ButtonRecherche.Text = "Recherche"
        ButtonRecherche.UseVisualStyleBackColor = False
        ' 
        ' lsc
        ' 
        lsc.BackColor = SystemColors.AppWorkspace
        lsc.FormattingEnabled = True
        lsc.ItemHeight = 15
        lsc.Location = New Point(12, 109)
        lsc.Name = "lsc"
        lsc.Size = New Size(428, 334)
        lsc.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label1.Location = New Point(76, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 22)
        Label1.TabIndex = 2
        Label1.Text = "Liste des Clients "
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(905, 561)
        Controls.Add(Label1)
        Controls.Add(lsc)
        Controls.Add(ButtonRecherche)
        Controls.Add(textbox)
        Name = "Form8"
        Text = "Form8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textbox As TextBox
    Friend WithEvents ButtonRecherche As Button
    Friend WithEvents lsc As ListBox
    Friend WithEvents Label1 As Label

End Class
