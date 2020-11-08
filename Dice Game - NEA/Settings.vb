Public Class Settings

    Public Sub openSettings(player1 As String, player2 As String)
        If player1 = "TomEldon" Then
            TrackBar2.Enabled = True
            NumericUpDown2.Enabled = True
            CheckBox1.Enabled = True
            Label2.Text = "Admin"
        Else
            TrackBar2.Enabled = False
            NumericUpDown2.Enabled = False
            CheckBox1.Enabled = False
            Label2.Text = "Admin (Disabled)"
        End If
        TrackBar1.Value = Form1.rolltime
        TrackBar2.Value = Form1.rounds
        CheckBox1.Checked = Form1.forcedraw
        NumericUpDown1.Value = Form1.rolltime
        NumericUpDown2.Value = Form1.rounds
        Me.Show()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        NumericUpDown1.Value = TrackBar1.Value
        Form1.rolltime = TrackBar1.Value
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        NumericUpDown2.Value = TrackBar2.Value
        Form1.rounds = TrackBar2.Value
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value <= 50 Then
            TrackBar1.Value = NumericUpDown1.Value
        End If
        Form1.rolltime = NumericUpDown1.Value
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value <= 50 Then
            TrackBar2.Value = NumericUpDown2.Value
        End If
        Form1.rounds = NumericUpDown2.Value
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Form1.forcedraw = True
    End Sub
End Class