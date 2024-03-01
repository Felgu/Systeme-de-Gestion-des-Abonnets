<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblUsername = New Label()
        lblPassword = New Label()
        btnLogin = New Button()
        btnExit = New Button()
        txtbxUsername = New TextBox()
        txtbxPassword = New TextBox()
        lblAdmin = New Label()
        lblErrAdmin = New Label()
        lblAvertAdmin = New Label()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.DarkGray
        lblUsername.Font = New Font("Californian FB", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        lblUsername.Location = New Point(73, 135)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(99, 24)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.DarkGray
        lblPassword.Font = New Font("Californian FB", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        lblPassword.Location = New Point(76, 209)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(96, 24)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.CornflowerBlue
        btnLogin.Font = New Font("Javanese Text", 15.75F, FontStyle.Italic)
        btnLogin.Location = New Point(276, 280)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(106, 51)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.DarkCyan
        btnExit.Font = New Font("Javanese Text", 15.75F, FontStyle.Italic)
        btnExit.Location = New Point(405, 280)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(106, 51)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.BackColor = Color.AliceBlue
        txtbxUsername.Location = New Point(276, 135)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Size(235, 23)
        txtbxUsername.TabIndex = 4
        ' 
        ' txtbxPassword
        ' 
        txtbxPassword.BackColor = Color.AliceBlue
        txtbxPassword.BorderStyle = BorderStyle.FixedSingle
        txtbxPassword.Location = New Point(276, 209)
        txtbxPassword.Name = "txtbxPassword"
        txtbxPassword.Size = New Size(235, 23)
        txtbxPassword.TabIndex = 5
        ' 
        ' lblAdmin
        ' 
        lblAdmin.AutoSize = True
        lblAdmin.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAdmin.Location = New Point(294, 28)
        lblAdmin.Name = "lblAdmin"
        lblAdmin.Size = New Size(156, 30)
        lblAdmin.TabIndex = 6
        lblAdmin.Text = "Administrateur"
        ' 
        ' lblErrAdmin
        ' 
        lblErrAdmin.AutoSize = True
        lblErrAdmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Italic)
        lblErrAdmin.Location = New Point(284, 364)
        lblErrAdmin.Name = "lblErrAdmin"
        lblErrAdmin.Size = New Size(16, 25)
        lblErrAdmin.TabIndex = 7
        lblErrAdmin.Text = "."
        lblErrAdmin.Visible = False
        ' 
        ' lblAvertAdmin
        ' 
        lblAvertAdmin.AutoSize = True
        lblAvertAdmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Italic)
        lblAvertAdmin.Location = New Point(280, 394)
        lblAvertAdmin.Name = "lblAvertAdmin"
        lblAvertAdmin.Size = New Size(16, 25)
        lblAvertAdmin.TabIndex = 8
        lblAvertAdmin.Text = "."
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblAvertAdmin)
        Controls.Add(lblErrAdmin)
        Controls.Add(lblAdmin)
        Controls.Add(txtbxPassword)
        Controls.Add(txtbxUsername)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form2"
        Text = "Administrateur Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtbxUsername As TextBox
    Friend WithEvents txtbxPassword As TextBox
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblErrAdmin As Label
    Friend WithEvents lblAvertAdmin As Label
End Class
