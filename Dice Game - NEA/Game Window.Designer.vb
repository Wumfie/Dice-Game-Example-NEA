<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game_Window
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game_Window))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentPlayerLbl = New System.Windows.Forms.Label()
        Me.p1ScoreLbl = New System.Windows.Forms.Label()
        Me.p2ScoreLbl = New System.Windows.Forms.Label()
        Me.diceRollBtn1 = New System.Windows.Forms.Button()
        Me.diceRollBtn2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.roundLbl = New System.Windows.Forms.Label()
        Me.p1Dice1PB = New System.Windows.Forms.PictureBox()
        Me.p1Dice2PB = New System.Windows.Forms.PictureBox()
        Me.p2Dice2PB = New System.Windows.Forms.PictureBox()
        Me.p2Dice1PB = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.p1Dice1PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1Dice2PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2Dice2PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2Dice1PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dice Game"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(554, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current Player:"
        '
        'currentPlayerLbl
        '
        Me.currentPlayerLbl.AutoSize = True
        Me.currentPlayerLbl.Location = New System.Drawing.Point(571, 135)
        Me.currentPlayerLbl.Name = "currentPlayerLbl"
        Me.currentPlayerLbl.Size = New System.Drawing.Size(78, 27)
        Me.currentPlayerLbl.TabIndex = 2
        Me.currentPlayerLbl.Text = "player"
        '
        'p1ScoreLbl
        '
        Me.p1ScoreLbl.AutoSize = True
        Me.p1ScoreLbl.Location = New System.Drawing.Point(185, 327)
        Me.p1ScoreLbl.Name = "p1ScoreLbl"
        Me.p1ScoreLbl.Size = New System.Drawing.Size(101, 27)
        Me.p1ScoreLbl.TabIndex = 3
        Me.p1ScoreLbl.Text = "Score: 0"
        '
        'p2ScoreLbl
        '
        Me.p2ScoreLbl.AutoSize = True
        Me.p2ScoreLbl.Location = New System.Drawing.Point(950, 327)
        Me.p2ScoreLbl.Name = "p2ScoreLbl"
        Me.p2ScoreLbl.Size = New System.Drawing.Size(101, 27)
        Me.p2ScoreLbl.TabIndex = 4
        Me.p2ScoreLbl.Text = "Score: 0"
        '
        'diceRollBtn1
        '
        Me.diceRollBtn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.diceRollBtn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.diceRollBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.diceRollBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.diceRollBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.diceRollBtn1.Location = New System.Drawing.Point(171, 372)
        Me.diceRollBtn1.Name = "diceRollBtn1"
        Me.diceRollBtn1.Size = New System.Drawing.Size(134, 48)
        Me.diceRollBtn1.TabIndex = 5
        Me.diceRollBtn1.Text = "Roll Dice"
        Me.diceRollBtn1.UseVisualStyleBackColor = False
        '
        'diceRollBtn2
        '
        Me.diceRollBtn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.diceRollBtn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.diceRollBtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.diceRollBtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.diceRollBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.diceRollBtn2.Location = New System.Drawing.Point(936, 372)
        Me.diceRollBtn2.Name = "diceRollBtn2"
        Me.diceRollBtn2.Size = New System.Drawing.Size(134, 48)
        Me.diceRollBtn2.TabIndex = 6
        Me.diceRollBtn2.Text = "Roll Dice"
        Me.diceRollBtn2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(424, 404)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 132)
        Me.Panel1.TabIndex = 7
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(24, 55)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(354, 58)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "Stay two meters apart when playing with friends"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(167, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 27)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tip:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(571, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 27)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Round:"
        '
        'roundLbl
        '
        Me.roundLbl.AutoSize = True
        Me.roundLbl.Location = New System.Drawing.Point(604, 253)
        Me.roundLbl.Name = "roundLbl"
        Me.roundLbl.Size = New System.Drawing.Size(25, 27)
        Me.roundLbl.TabIndex = 9
        Me.roundLbl.Text = "0"
        '
        'p1Dice1PB
        '
        Me.p1Dice1PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.p1Dice1PB.BackgroundImage = CType(resources.GetObject("p1Dice1PB.BackgroundImage"), System.Drawing.Image)
        Me.p1Dice1PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.p1Dice1PB.Location = New System.Drawing.Point(28, 96)
        Me.p1Dice1PB.Name = "p1Dice1PB"
        Me.p1Dice1PB.Size = New System.Drawing.Size(200, 200)
        Me.p1Dice1PB.TabIndex = 12
        Me.p1Dice1PB.TabStop = False
        '
        'p1Dice2PB
        '
        Me.p1Dice2PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.p1Dice2PB.BackgroundImage = CType(resources.GetObject("p1Dice2PB.BackgroundImage"), System.Drawing.Image)
        Me.p1Dice2PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.p1Dice2PB.Location = New System.Drawing.Point(253, 96)
        Me.p1Dice2PB.Name = "p1Dice2PB"
        Me.p1Dice2PB.Size = New System.Drawing.Size(200, 200)
        Me.p1Dice2PB.TabIndex = 14
        Me.p1Dice2PB.TabStop = False
        '
        'p2Dice2PB
        '
        Me.p2Dice2PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.p2Dice2PB.BackgroundImage = CType(resources.GetObject("p2Dice2PB.BackgroundImage"), System.Drawing.Image)
        Me.p2Dice2PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.p2Dice2PB.Location = New System.Drawing.Point(1020, 96)
        Me.p2Dice2PB.Name = "p2Dice2PB"
        Me.p2Dice2PB.Size = New System.Drawing.Size(200, 200)
        Me.p2Dice2PB.TabIndex = 16
        Me.p2Dice2PB.TabStop = False
        '
        'p2Dice1PB
        '
        Me.p2Dice1PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.p2Dice1PB.BackgroundImage = CType(resources.GetObject("p2Dice1PB.BackgroundImage"), System.Drawing.Image)
        Me.p2Dice1PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.p2Dice1PB.Location = New System.Drawing.Point(795, 96)
        Me.p2Dice1PB.Name = "p2Dice1PB"
        Me.p2Dice1PB.Size = New System.Drawing.Size(200, 200)
        Me.p2Dice1PB.TabIndex = 15
        Me.p2Dice1PB.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(463, 230)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(772, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(463, 230)
        Me.Panel3.TabIndex = 9
        '
        'animationTimer
        '
        Me.animationTimer.Enabled = True
        Me.animationTimer.Interval = 10
        '
        'Game_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1244, 568)
        Me.Controls.Add(Me.p2Dice2PB)
        Me.Controls.Add(Me.p2Dice1PB)
        Me.Controls.Add(Me.p1Dice2PB)
        Me.Controls.Add(Me.p1Dice1PB)
        Me.Controls.Add(Me.roundLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.diceRollBtn2)
        Me.Controls.Add(Me.diceRollBtn1)
        Me.Controls.Add(Me.p2ScoreLbl)
        Me.Controls.Add(Me.p1ScoreLbl)
        Me.Controls.Add(Me.currentPlayerLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MinimumSize = New System.Drawing.Size(1260, 607)
        Me.Name = "Game_Window"
        Me.Text = "Dice Game"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.p1Dice1PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1Dice2PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2Dice2PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2Dice1PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents currentPlayerLbl As Label
    Friend WithEvents p1ScoreLbl As Label
    Friend WithEvents p2ScoreLbl As Label
    Friend WithEvents diceRollBtn1 As Button
    Friend WithEvents diceRollBtn2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents roundLbl As Label
    Friend WithEvents p1Dice1PB As PictureBox
    Friend WithEvents p1Dice2PB As PictureBox
    Friend WithEvents p2Dice2PB As PictureBox
    Friend WithEvents p2Dice1PB As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents animationTimer As Timer
End Class
