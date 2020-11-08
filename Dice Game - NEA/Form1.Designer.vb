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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.loginPlayer1 = New System.Windows.Forms.Button()
        Me.player1Lbl = New System.Windows.Forms.Label()
        Me.player2Lbl = New System.Windows.Forms.Label()
        Me.loginPlayer2 = New System.Windows.Forms.Button()
        Me.lblNewGame = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblLeaderboards = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'loginPlayer1
        '
        Me.loginPlayer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.loginPlayer1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.loginPlayer1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.loginPlayer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.loginPlayer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.loginPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginPlayer1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginPlayer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.loginPlayer1.Location = New System.Drawing.Point(12, 12)
        Me.loginPlayer1.Name = "loginPlayer1"
        Me.loginPlayer1.Size = New System.Drawing.Size(141, 49)
        Me.loginPlayer1.TabIndex = 0
        Me.loginPlayer1.Text = "Log In"
        Me.loginPlayer1.UseVisualStyleBackColor = False
        '
        'player1Lbl
        '
        Me.player1Lbl.AutoSize = True
        Me.player1Lbl.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.player1Lbl.Location = New System.Drawing.Point(156, 20)
        Me.player1Lbl.Name = "player1Lbl"
        Me.player1Lbl.Size = New System.Drawing.Size(216, 32)
        Me.player1Lbl.TabIndex = 1
        Me.player1Lbl.Text = "Player 1 - Guest"
        '
        'player2Lbl
        '
        Me.player2Lbl.AutoSize = True
        Me.player2Lbl.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.player2Lbl.Location = New System.Drawing.Point(420, 20)
        Me.player2Lbl.Name = "player2Lbl"
        Me.player2Lbl.Size = New System.Drawing.Size(216, 32)
        Me.player2Lbl.TabIndex = 3
        Me.player2Lbl.Text = "Player 2 - Guest"
        '
        'loginPlayer2
        '
        Me.loginPlayer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.loginPlayer2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.loginPlayer2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.loginPlayer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.loginPlayer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.loginPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginPlayer2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginPlayer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.loginPlayer2.Location = New System.Drawing.Point(642, 12)
        Me.loginPlayer2.Name = "loginPlayer2"
        Me.loginPlayer2.Size = New System.Drawing.Size(148, 49)
        Me.loginPlayer2.TabIndex = 2
        Me.loginPlayer2.Text = "Log In"
        Me.loginPlayer2.UseVisualStyleBackColor = False
        '
        'lblNewGame
        '
        Me.lblNewGame.AutoSize = True
        Me.lblNewGame.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblNewGame.Location = New System.Drawing.Point(86, 123)
        Me.lblNewGame.Name = "lblNewGame"
        Me.lblNewGame.Size = New System.Drawing.Size(131, 27)
        Me.lblNewGame.TabIndex = 4
        Me.lblNewGame.Text = "New Game"
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblSettings.Location = New System.Drawing.Point(86, 157)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(100, 27)
        Me.lblSettings.TabIndex = 5
        Me.lblSettings.Text = "Settings"
        '
        'lblLeaderboards
        '
        Me.lblLeaderboards.AutoSize = True
        Me.lblLeaderboards.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderboards.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblLeaderboards.Location = New System.Drawing.Point(86, 191)
        Me.lblLeaderboards.Name = "lblLeaderboards"
        Me.lblLeaderboards.Size = New System.Drawing.Size(148, 27)
        Me.lblLeaderboards.TabIndex = 7
        Me.lblLeaderboards.Text = "Leaderboard"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblExit.Location = New System.Drawing.Point(86, 225)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(123, 27)
        Me.lblExit.TabIndex = 6
        Me.lblExit.Text = "Exit Game"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.lblLeaderboards)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblNewGame)
        Me.Controls.Add(Me.player2Lbl)
        Me.Controls.Add(Me.loginPlayer2)
        Me.Controls.Add(Me.player1Lbl)
        Me.Controls.Add(Me.loginPlayer1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(812, 479)
        Me.Name = "Form1"
        Me.Text = "Dice Game Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents loginPlayer1 As Button
    Friend WithEvents player1Lbl As Label
    Friend WithEvents player2Lbl As Label
    Friend WithEvents loginPlayer2 As Button
    Friend WithEvents lblNewGame As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents lblLeaderboards As Label
    Friend WithEvents lblExit As Label
End Class
