Imports System.Linq.Expressions
Imports System.Xml

Public Class Game_Window

    Shared random As New Random()

    Private player1 As String
    Private player2 As String

    Private currentPlayer As String
    Private currentPlayerID As Integer

    Private gameRunning As Boolean = False 'False Means Stopped, True Means running

    Private showSecondDice As Boolean = True

    Private round As Integer = 0

    Private p1Score As Integer = 0
    Private p2Score As Integer = 0

    Private playerRolling As Integer = 0 '0 = Nobody, 1 = Player 1, 2 = Player 2

    Private p1D1 As Integer = 0
    Private p1D2 As Integer = 0

    Private p2D1 As Integer = 0
    Private p2D2 As Integer = 0

    Private timerD1Num As Integer = 0

    Private timerRound As Integer = 0
    Private timerRounds As Integer = 1

    Private forcedraw As Boolean = False
    Private rounds As Integer = 5
    Public Sub startNewGame(player1 As String, player2 As String)
        If player1 IsNot "" Then
            Me.player1 = player1
            Me.player2 = player2

            'Update settings
            Me.timerRounds = Form1.rolltime
            Me.forcedraw = Form1.forcedraw
            Me.rounds = Form1.rounds

            round = 1
            roundLbl.Text = round

            p1Score = 0
            p2Score = 0
            p1ScoreLbl.Text = "Score: " + CStr(p1Score)
            p2ScoreLbl.Text = "Score: " + CStr(p2Score)

            If player1 = "" Then
                currentPlayer = "Player 1 Guest"
            Else
                currentPlayer = player1
            End If
            currentPlayerID = 1

            currentPlayerLbl.Text = currentPlayer

            diceRollBtn2.Enabled = False
            diceRollBtn2.Text = "Not your turn!"

            gameRunning = 1

            random.Next()

            Me.Show()
        Else
            MsgBox("At least one player must be logged in!")
        End If
    End Sub

    Private Sub finishGame()
        If forcedraw Then
            p1Score = p2Score
            forcedraw = False
        End If
        If p1Score > p2Score Then
            MsgBox("Player 1 Won with " + CStr(p1Score - p2Score) + " point difference")
            updateHighscores()
        ElseIf p2Score > p1Score Then
            MsgBox("Player 2 Won with " + CStr(p2Score - p1Score) + " point difference")
            updateHighscores()
        Else
            'Its a Draw
            MsgBox("Its a Draw!")
            switchPlayer(1)
            showSecondDice = False
        End If
    End Sub

    Private Sub updateScore(finalScore As Integer)
        'Update Score for Current Player
        Console.WriteLine("Updating Score For " + CStr(currentPlayerID) + " with final score: " + CStr(finalScore))
        Select Case currentPlayerID
            Case 1
                p1Score = finalScore
                p1ScoreLbl.Text = "Score: " + CStr(p1Score)
            Case 2
                p2Score = finalScore
                p2ScoreLbl.Text = "Score: " + CStr(p2Score)
        End Select
    End Sub
    Private Sub finishTurn()
        'Reset dice and switch current player
        Console.WriteLine("Finishing a turn for " + CStr(currentPlayerID))
        Select Case currentPlayerID
            Case 1
                p1D1 = 0
                p1D2 = 0
                switchPlayer(2)
            Case 2
                p2D1 = 0
                p2D2 = 0
                'Add 1 to rounds if player two rolls the dice
                round += 1
                roundLbl.Text = round
                'Check for round 5
                If round >= rounds Then
                    finishGame()
                Else
                    switchPlayer(1)
                End If
        End Select
    End Sub

    Private Sub switchPlayer(targetPlayer As Integer)
        Console.WriteLine("Switching player to: " + CStr(targetPlayer))
        Select Case targetPlayer
            Case 1
                If player1 = "" Then
                    currentPlayer = "Player 1 Guest"
                Else
                    currentPlayer = player1
                End If

                currentPlayerID = 1
                diceRollBtn1.Enabled = True
                diceRollBtn1.Text = "Roll Dice"
                diceRollBtn2.Enabled = False
                diceRollBtn2.Text = "Not your turn!"
            Case 2
                If player2 = "" Then
                    currentPlayer = "Player 2 Guest"
                Else
                    currentPlayer = player2
                End If
                currentPlayerID = 2
                diceRollBtn1.Enabled = False
                diceRollBtn1.Text = "Not your turn!"
                diceRollBtn2.Enabled = True
                diceRollBtn2.Text = "Roll Dice"
        End Select

        currentPlayerLbl.Text = currentPlayer
    End Sub

    Private Sub finishDiceRoll(secondRoll As Boolean)
        '--------Assign Variables--------
        Dim scoreTemp As Integer = 0
        Dim d1Temp As Integer = 0
        Dim d2Temp As Integer = 0
        'Work out the player that rolled
        If currentPlayerID = 1 Then
            'Player 1 Rolled
            scoreTemp = p1Score
            d1Temp = p1D1
            d2Temp = p1D2
        ElseIf currentPlayerID = 2 Then
            'Player 2 Rolled
            scoreTemp = p2Score
            d1Temp = p2D1
            d2Temp = p2D2
        End If
        Console.WriteLine("Calculating Dice Roll for player " + CStr(currentPlayerID))
        '--------START GAME LOGIC--------
        If secondRoll Then
            If round >= rounds Then
                Console.WriteLine("Calculating draw roll for: " + CStr(currentPlayerID))
                showSecondDice = False
                scoreTemp += d1Temp
                updateScore(scoreTemp)
                finishTurn()
            Else
                Console.WriteLine("Calculating second roll for: " + CStr(currentPlayerID))
                showSecondDice = True
                scoreTemp += d1Temp
                updateScore(scoreTemp)
                finishTurn()
            End If
        Else
            'Calculate total to make it more efficient
            Dim totalTemp = d1Temp + d2Temp
            'Add result of dice to players score
            scoreTemp = scoreTemp + totalTemp
            'Add 10 points if total is even, remove 5 if odd
            If totalTemp Mod 2 = 0 Then
                Console.WriteLine("Even, Adding 10 points to: " + CStr(currentPlayerID))
                scoreTemp += 10
            Else
                Console.WriteLine("Odd, Removing 5 points from: " + CStr(currentPlayerID))
                scoreTemp += -5
            End If
            'Check if score is below 0, set to 0 if it is
            If scoreTemp < 0 Then
                Console.WriteLine("Score below 0 for player: " + CStr(currentPlayerID))
                scoreTemp = 0
            End If
            'Check if player rolled a double, roll 1 more dice
            If d1Temp = d2Temp Then
                updateScore(scoreTemp)
                Console.WriteLine("Rolled a double for " + CStr(currentPlayerID) + " rolling again.")
                rollDice(currentPlayerID, True)
            Else
                updateScore(scoreTemp)
                finishTurn()
            End If
        End If
    End Sub

    Private Sub rollDice(playerID As Integer, secondRoll As Boolean)
        Dim dice1Number = random.Next(1, 6)
        Dim dice2Number = random.Next(1, 6)
        If secondRoll Then
            dice2Number = 0
            showSecondDice = False
        End If

        Console.WriteLine("Rolling Dice For: " + CStr(playerID) + ". With results: " + CStr(dice1Number) + " " + CStr(dice2Number))
        Select Case playerID
            Case 1
                'Player 1 Is Up
                diceRollBtn1.Enabled = False
                If secondRoll Then
                    If round >= rounds Then
                        diceRollBtn1.Text = "Draw Rolling"
                    Else
                        diceRollBtn1.Text = "Rolling Again"
                    End If

                Else
                    diceRollBtn1.Text = "Rolling"
                End If
                playerRolling = 1
                p1D1 = dice1Number
                p1D2 = dice2Number
                p2D1 = 0
                p2D2 = 0
                timerD1Num = 1
                timerRound = 0
            Case 2
                'Player 2 Is Up
                diceRollBtn2.Enabled = False
                If secondRoll Then
                    diceRollBtn1.Text = "Rolling Again"
                Else
                    diceRollBtn1.Text = "Rolling"
                End If
                playerRolling = 2
                p1D1 = 0
                p1D2 = 0
                p2D1 = dice1Number
                p2D2 = dice2Number
                timerD1Num = 1
                timerRound = 0
        End Select
    End Sub
    Private Sub diceRollBtn1_Click(sender As Object, e As EventArgs) Handles diceRollBtn1.Click
        If currentPlayerID = 1 Then
            If round >= rounds Then
                rollDice(1, True)
            Else
                rollDice(1, False)
            End If
        End If
    End Sub

    Private Sub diceRollBtn2_Click(sender As Object, e As EventArgs) Handles diceRollBtn2.Click
        If currentPlayerID = 2 Then
            If round >= rounds Then
                rollDice(2, True)
            Else
                rollDice(2, False)
            End If
        End If
    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        If playerRolling <> 0 Then
            If timerRound < timerRounds Then
                setPlayerDiceToNumber(0, timerD1Num, 1)
                setPlayerDiceToNumber(0, timerD1Num, 2)
                If timerD1Num >= 6 Then
                    timerD1Num = 0
                    timerRound += 1
                End If
                timerD1Num += 1
            ElseIf timerRound = timerRounds Then
                Select Case playerRolling
                    Case 1
                        setPlayerDiceToNumber(1, p1D1, 1)
                        setPlayerDiceToNumber(1, p1D2, 2)
                        Console.WriteLine("Finished player 1's dice roll with: " + CStr(p1D1) + " " + CStr(p1D2))
                    Case 2
                        setPlayerDiceToNumber(2, p2D1, 1)
                        setPlayerDiceToNumber(2, p2D2, 2)
                        Console.WriteLine("Finished player 2's dice roll with: " + CStr(p2D1) + " " + CStr(p2D2))
                End Select
                playerRolling = 0
                If showSecondDice Then
                    finishDiceRoll(False)
                Else
                    finishDiceRoll(True)
                End If
            End If
        End If

    End Sub

    Private Sub setPlayerDiceToNumber(playerID As Integer, number As Integer, diceID As Integer) 'If playerID is 0, do it from the current rolling player
        If playerID = 0 Then
            playerID = playerRolling
        End If
        Select Case playerID
            Case 1
                Select Case diceID
                    Case 1
                        p1Dice1PB.BackgroundImage = getDiceImageFromNumber(number)
                    Case 2
                        If showSecondDice Then
                            p1Dice2PB.BackgroundImage = getDiceImageFromNumber(number)
                        End If
                End Select
            Case 2
                Select Case diceID
                    Case 1
                        p2Dice1PB.BackgroundImage = getDiceImageFromNumber(number)
                    Case 2
                        If showSecondDice Then
                            p2Dice2PB.BackgroundImage = getDiceImageFromNumber(number)
                        End If
                End Select
        End Select
    End Sub

    Private Function getDiceImageFromNumber(diceNumber As Integer) As Image
        Dim diceImage As Image
        Select Case diceNumber
            Case 1
                diceImage = My.Resources.Dice
            Case 2
                diceImage = My.Resources.Dice2
            Case 3
                diceImage = My.Resources.Dice3
            Case 4
                diceImage = My.Resources.Dice4
            Case 5
                diceImage = My.Resources.Dice5
            Case 6
                diceImage = My.Resources.Dice6
            Case Else
                diceImage = My.Resources.DiceQuestion
        End Select
        Return diceImage
    End Function

    Public Function updateHighscores()
        Dim xmlDoc As XmlDocument = New XmlDocument()
        xmlDoc.Load(Form1.directory + "GameData.xml")

        Dim xmlnode As XmlNodeList = xmlDoc.GetElementsByTagName("Score")

        'Remove user's old highscore
        For i = 0 To xmlnode.Count - 1
            If player1 IsNot "" Then
                If player1 = xmlnode(i).ChildNodes.Item(0).InnerText.Trim() Then 'Is User 1
                    Dim scoreFound As String = xmlnode(i).ChildNodes.Item(1).InnerText.Trim()
                    If p1Score > scoreFound Then
                        xmlnode(i).ParentNode.RemoveChild(xmlnode(i))
                        With xmlDoc.SelectSingleNode("/Users/Scores").CreateNavigator().AppendChild()
                            .WriteStartElement("Score")
                            .WriteStartElement("Username")
                            .WriteString(player1)
                            .WriteEndElement()
                            .WriteStartElement("Highscore")
                            .WriteString(p1Score)
                            .WriteEndElement()
                            .WriteEndElement()
                            .Close()
                        End With
                        Exit For 'Avoid modification exception
                    End If
                End If
            End If
        Next
        For i = 0 To xmlnode.Count - 1
            If player2 IsNot "" Then
                If player2 = xmlnode(i).ChildNodes.Item(0).InnerText.Trim() Then 'Is User 2
                    Dim scoreFound As String = xmlnode(i).ChildNodes.Item(1).InnerText.Trim()
                    If p2Score > scoreFound Then
                        xmlnode(i).ParentNode.RemoveChild(xmlnode(i))
                        With xmlDoc.SelectSingleNode("/Users/Scores").CreateNavigator().AppendChild()
                            .WriteStartElement("Score")
                            .WriteStartElement("Username")
                            .WriteString(player2)
                            .WriteEndElement()
                            .WriteStartElement("Highscore")
                            .WriteString(p2Score)
                            .WriteEndElement()
                            .WriteEndElement()
                            .Close()
                        End With
                        Exit For 'Avoid modification exception
                    End If
                End If
            End If
        Next

        xmlDoc.Save(Form1.directory + "GameData.xml")
    End Function
End Class