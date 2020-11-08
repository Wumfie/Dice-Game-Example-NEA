Imports System.Xml
Imports System.IO
Imports Dice_Game___NEA.My

Public Class Form1

    Public directory As String

    Public rounds As Integer = 5
    Public rolltime As Integer = 1
    Public forcedraw As Boolean = False

    Private player1 As String = ""
    Private player2 As String = ""

    Public Sub playerLoggedInAs(player As String, ID As Integer)
        Select Case ID
            Case 1
                Me.player1 = player
                loginPlayer1.Text = "Log Out"
                player1Lbl.Text = "Player 1 - " + player
            Case 2
                Me.player2 = player
                loginPlayer2.Text = "Log Out"
                player2Lbl.Text = "Player 2 - " + player
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        directory = AppDomain.CurrentDomain.BaseDirectory
        startupStorageCheck()

        'If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
        ' directory = FolderBrowserDialog1.SelectedPath + "\DiceGameFiles\"
        ' Else
        ' Me.Close()
        ' End If
    End Sub

    Private Sub startupStorageCheck()
        If File.Exists(directory + "GameData.xml") = True Then 'File already exists - allow room for later expansion
            Console.WriteLine("Found Game Files!")
        Else 'Does not exist
            Console.WriteLine("Creating game files")
            'Make game directory
            If (Not System.IO.Directory.Exists(directory)) Then
                System.IO.Directory.CreateDirectory(directory)
            End If
            'Make XML File
            Dim writer As New XmlTextWriter(directory + "GameData.xml", System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("Users")
            writer.WriteStartElement("Accounts")
            writer.WriteEndElement()
            writer.WriteStartElement("Scores")
            writer.WriteEndElement()
            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Close()
        End If
    End Sub

    Private Sub loginPlayer1_Click(sender As Object, e As EventArgs) Handles loginPlayer1.Click
        If String.IsNullOrEmpty(player1) Then
            'Log player in
            Login.logPlayerIn(1, False)
        Else
            'Log player out
            player1 = ""
            loginPlayer1.Text = "Log In"
            player1Lbl.Text = "Player 1 - Guest"
        End If
    End Sub

    Private Sub loginPlayer2_Click(sender As Object, e As EventArgs) Handles loginPlayer2.Click
        If String.IsNullOrEmpty(player2) Then
            'Log player in
            If player1 = "TomEldon" Then
                Login.logPlayerIn(2, True)
            Else
                Login.logPlayerIn(2, False)
        End If
        Else
            'Log player out
            player2 = ""
            loginPlayer2.Text = "Log In"
            player2Lbl.Text = "Player 2 - Guest"
        End If
    End Sub

    Private Sub lblNewGame_Enter(sender As Object, e As EventArgs) Handles lblNewGame.MouseEnter
        lblNewGame.ForeColor = Color.FromArgb(141, 193, 227)
    End Sub

    Private Sub lblNewGame_Exit(sender As Object, e As EventArgs) Handles lblNewGame.MouseLeave
        lblNewGame.ForeColor = Color.FromArgb(187, 225, 250)
    End Sub

    Private Sub lblSettings_Enter(sender As Object, e As EventArgs) Handles lblSettings.MouseEnter
        lblSettings.ForeColor = Color.FromArgb(141, 193, 227)
    End Sub

    Private Sub lblSettings_Exit(sender As Object, e As EventArgs) Handles lblSettings.MouseLeave
        lblSettings.ForeColor = Color.FromArgb(187, 225, 250)
    End Sub

    Private Sub lblLeaderboards_Enter(sender As Object, e As EventArgs) Handles lblLeaderboards.MouseEnter
        lblLeaderboards.ForeColor = Color.FromArgb(141, 193, 227)
    End Sub

    Private Sub lblLeaderboards_Exit(sender As Object, e As EventArgs) Handles lblLeaderboards.MouseLeave
        lblLeaderboards.ForeColor = Color.FromArgb(187, 225, 250)
    End Sub

    Private Sub lblExit_Enter(sender As Object, e As EventArgs) Handles lblExit.MouseEnter
        lblExit.ForeColor = Color.FromArgb(141, 193, 227)
    End Sub

    Private Sub lblExit_Exit(sender As Object, e As EventArgs) Handles lblExit.MouseLeave
        lblExit.ForeColor = Color.FromArgb(187, 225, 250)
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub lblNewGame_Click(sender As Object, e As EventArgs) Handles lblNewGame.Click
        Game_Window.startNewGame(player1, player2)
    End Sub

    Private Sub lblLeaderboards_Click(sender As Object, e As EventArgs) Handles lblLeaderboards.Click
        Leaderboard.showLeaderboards()
    End Sub

    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblSettings.Click
        Settings.openSettings(player1, player2)
    End Sub
End Class
