<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboard
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(42, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(432, 266)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(85, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Leaderboard"
        '
        'Leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(508, 434)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Leaderboard"
        Me.Text = "Leaderboard"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
End Class
