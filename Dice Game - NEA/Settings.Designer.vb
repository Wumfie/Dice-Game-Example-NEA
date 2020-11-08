<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 43)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Settings"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(76, 84)
        Me.TrackBar1.Maximum = 50
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 69)
        Me.TrackBar1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "RollTime"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(220, -9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(14, 448)
        Me.Panel1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(244, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Rounds"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(301, 84)
        Me.TrackBar2.Maximum = 50
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(104, 69)
        Me.TrackBar2.TabIndex = 12
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(247, 124)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(161, 31)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Force Draw"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(174, 84)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(42, 35)
        Me.NumericUpDown1.TabIndex = 18
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(402, 84)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(42, 35)
        Me.NumericUpDown2.TabIndex = 19
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 412)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
End Class
