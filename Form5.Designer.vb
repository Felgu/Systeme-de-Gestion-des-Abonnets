<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        btnLogin = New Button()
        btnExit = New Button()
        lblUsername = New Label()
        lblPassword = New Label()
        txtbxUsername = New TextBox()
        txtbxPassword = New TextBox()
        lblclient = New Label()
        lblMsgErr = New Label()
        lblRappel = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        btnLogin.Location = New Point(85, 219)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(169, 65)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        btnExit.Location = New Point(311, 219)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(165, 65)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblUsername.Location = New Point(26, 69)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(109, 30)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblPassword.Location = New Point(26, 126)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(103, 30)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password"
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        txtbxUsername.Location = New Point(187, 69)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Size(289, 35)
        txtbxUsername.TabIndex = 4
        ' 
        ' txtbxPassword
        ' 
        txtbxPassword.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        txtbxPassword.Location = New Point(187, 121)
        txtbxPassword.Name = "txtbxPassword"
        txtbxPassword.Size = New Size(289, 35)
        txtbxPassword.TabIndex = 5
        ' 
        ' lblclient
        ' 
        lblclient.AutoSize = True
        lblclient.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblclient.Location = New Point(244, 9)
        lblclient.Name = "lblclient"
        lblclient.Size = New Size(67, 30)
        lblclient.TabIndex = 6
        lblclient.Text = "Client"
        ' 
        ' lblMsgErr
        ' 
        lblMsgErr.AutoSize = True
        lblMsgErr.Font = New Font("Segoe UI", 14.25F, FontStyle.Italic)
        lblMsgErr.Location = New Point(149, 316)
        lblMsgErr.Name = "lblMsgErr"
        lblMsgErr.Size = New Size(16, 25)
        lblMsgErr.TabIndex = 7
        lblMsgErr.Text = "."
        lblMsgErr.Visible = False
        ' 
        ' lblRappel
        ' 
        lblRappel.AutoSize = True
        lblRappel.Font = New Font("Segoe UI", 14.25F, FontStyle.Italic)
        lblRappel.Location = New Point(149, 351)
        lblRappel.Name = "lblRappel"
        lblRappel.Size = New Size(16, 25)
        lblRappel.TabIndex = 8
        lblRappel.Text = "."
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(599, 450)
        Controls.Add(lblRappel)
        Controls.Add(lblMsgErr)
        Controls.Add(lblclient)
        Controls.Add(txtbxPassword)
        Controls.Add(txtbxUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Name = "Form5"
        Text = "Page Authentification Client"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtbxUsername As TextBox
    Friend WithEvents txtbxPassword As TextBox
    Friend WithEvents lblclient As Label
    Friend WithEvents lblMsgErr As Label
    Friend WithEvents lblRappel As Label
End Class
