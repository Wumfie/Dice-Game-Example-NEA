<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.loginUsername = New System.Windows.Forms.TextBox()
        Me.loginPassword = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.registerBtn = New System.Windows.Forms.Button()
        Me.registerPassword = New System.Windows.Forms.TextBox()
        Me.registerEmail = New System.Windows.Forms.TextBox()
        Me.registerUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'loginUsername
        '
        Me.loginUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.loginUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loginUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.loginUsername.Location = New System.Drawing.Point(51, 114)
        Me.loginUsername.Name = "loginUsername"
        Me.loginUsername.Size = New System.Drawing.Size(132, 26)
        Me.loginUsername.TabIndex = 1
        Me.loginUsername.Text = "User Name"
        '
        'loginPassword
        '
        Me.loginPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loginPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.loginPassword.Location = New System.Drawing.Point(51, 162)
        Me.loginPassword.Name = "loginPassword"
        Me.loginPassword.Size = New System.Drawing.Size(132, 26)
        Me.loginPassword.TabIndex = 2
        Me.loginPassword.Text = "Password"
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.loginBtn.Location = New System.Drawing.Point(51, 206)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(134, 35)
        Me.loginBtn.TabIndex = 3
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'registerBtn
        '
        Me.registerBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.registerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.registerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.registerBtn.Location = New System.Drawing.Point(252, 260)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.Size = New System.Drawing.Size(142, 35)
        Me.registerBtn.TabIndex = 7
        Me.registerBtn.Text = "Create Account"
        Me.registerBtn.UseVisualStyleBackColor = False
        '
        'registerPassword
        '
        Me.registerPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.registerPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.registerPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.registerPassword.Location = New System.Drawing.Point(252, 209)
        Me.registerPassword.Name = "registerPassword"
        Me.registerPassword.ReadOnly = True
        Me.registerPassword.Size = New System.Drawing.Size(142, 26)
        Me.registerPassword.TabIndex = 6
        Me.registerPassword.Text = "Password"
        '
        'registerEmail
        '
        Me.registerEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.registerEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.registerEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.registerEmail.Location = New System.Drawing.Point(252, 163)
        Me.registerEmail.Name = "registerEmail"
        Me.registerEmail.ReadOnly = True
        Me.registerEmail.Size = New System.Drawing.Size(142, 26)
        Me.registerEmail.TabIndex = 5
        Me.registerEmail.Text = "Email"
        '
        'registerUsername
        '
        Me.registerUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.registerUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.registerUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.registerUsername.Location = New System.Drawing.Point(252, 114)
        Me.registerUsername.Name = "registerUsername"
        Me.registerUsername.ReadOnly = True
        Me.registerUsername.Size = New System.Drawing.Size(142, 26)
        Me.registerUsername.TabIndex = 4
        Me.registerUsername.Tag = ""
        Me.registerUsername.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(244, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 46)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Register"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(66, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 46)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Login"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(32, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 168)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(232, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 226)
        Me.Panel2.TabIndex = 11
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.backBtn.Location = New System.Drawing.Point(12, 325)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(134, 35)
        Me.backBtn.TabIndex = 8
        Me.backBtn.Text = "Go Back"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.CancelButton = Me.backBtn
        Me.ClientSize = New System.Drawing.Size(454, 372)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.registerUsername)
        Me.Controls.Add(Me.registerPassword)
        Me.Controls.Add(Me.registerEmail)
        Me.Controls.Add(Me.registerBtn)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.loginPassword)
        Me.Controls.Add(Me.loginUsername)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginUsername As TextBox
    Friend WithEvents loginPassword As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents registerBtn As Button
    Friend WithEvents registerPassword As TextBox
    Friend WithEvents registerEmail As TextBox
    Friend WithEvents registerUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents backBtn As Button
End Class
