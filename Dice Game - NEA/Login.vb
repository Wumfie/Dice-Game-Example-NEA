Imports System.Xml
Imports System.IO
Public Class Login

    Dim playerID As Integer

    Public Sub logPlayerIn(player As Integer, register As Boolean)
        Me.playerID = player
        If register = True Then
            registerUsername.ReadOnly = False
            registerEmail.ReadOnly = False
            registerPassword.ReadOnly = False
            registerBtn.Enabled = True
        Else
            registerUsername.ReadOnly = True
            registerEmail.ReadOnly = True
            registerPassword.ReadOnly = True
            registerBtn.Enabled = False
        End If
        Me.Show()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If validateLogin(loginUsername.Text, loginPassword.Text) Then
            'Valid Login
            MsgBox("Valid Login!")
            Form1.playerLoggedInAs(loginUsername.Text, playerID)
            Me.Close()
        Else
            'Bad Login
            MsgBox("Incorrect Login!")
        End If
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        If String.IsNullOrEmpty(registerUsername.Text) Or String.IsNullOrEmpty(registerEmail.Text) Or String.IsNullOrEmpty(registerPassword.Text) Then
            MsgBox("Make sure you fill out all forms")
        Else
            Dim registerStatus As ArrayList = registerAccount(registerUsername.Text, registerEmail.Text, registerPassword.Text)
            If registerStatus.Contains(0) Then
                MsgBox("Registration Succeeded")
            End If
            If registerStatus.Contains(1) Then
                MsgBox("Username already Taken!")
            End If
            If registerStatus.Contains(2) Then
                MsgBox("Email already Taken!")
            End If
            If registerStatus.Contains(3) Then
                MsgBox("Password is weak. Requirements: 1+ Uppercase Character, 3+ Lowercase & 1+ Numbers.")
            End If
        End If
    End Sub

    Private Function validateLogin(username As String, password As String) As Boolean

        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode As XmlNodeList
        Dim i As Integer
        Dim str As String
        Dim fs As New FileStream(Form1.directory + "GameData.xml", FileMode.Open, FileAccess.Read)
        xmldoc.Load(fs)
        xmlnode = xmldoc.GetElementsByTagName("Account")

        'Variables to be compared
        Dim saltTarget As String
        Dim passwordHashSaltTarget As String

        Dim passwordHash As String
        Dim hashedAndSalted As String

        For i = 0 To xmlnode.Count - 1
            If username = xmlnode(i).ChildNodes.Item(0).InnerText.Trim() Then
                saltTarget = xmlnode(i).ChildNodes.Item(3).InnerText.Trim()
                passwordHashSaltTarget = xmlnode(i).ChildNodes.Item(2).InnerText.Trim()
                passwordHash = Encryption.HashString(password)
                hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", passwordHash, saltTarget))
            End If
        Next

        fs.Close()

        If passwordHashSaltTarget IsNot Nothing And hashedAndSalted IsNot Nothing Then
            If passwordHashSaltTarget = hashedAndSalted Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Function registerAccount(username As String, email As String, password As String) As ArrayList
        Dim returnReason As ArrayList = New ArrayList()

        Dim xmlDoc As XmlDocument = New XmlDocument()
        xmlDoc.Load(Form1.directory + "GameData.xml")
        Dim xmlnode As XmlNodeList

        xmlnode = xmlDoc.GetElementsByTagName("Account")
        For i = 0 To xmlnode.Count - 1 'Loop through existing users
            If username = xmlnode(i).ChildNodes.Item(0).InnerText.Trim() Then 'Check if user already exists
                returnReason.Add(1)
            End If
            If email = xmlnode(i).ChildNodes.Item(1).InnerText.Trim() Then 'Check if Email already exists
                returnReason.Add(2)
            End If
        Next

        If passwordStrength(password) = 0 Then 'Check if Password is weak
            returnReason.Add(3)
        End If

        If returnReason.Count = 0 Then
            'Add the user
            Dim passwordHash = Encryption.HashString(password)
            Dim salt = Encryption.GenerateSalt
            Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", passwordHash, salt))

            With xmlDoc.SelectSingleNode("/Users/Accounts").CreateNavigator().AppendChild()
                .WriteStartElement("Account")
                .WriteStartElement("Username")
                .WriteString(username)
                .WriteEndElement()
                .WriteStartElement("Email")
                .WriteString(email)
                .WriteEndElement()
                .WriteStartElement("Password")
                .WriteString(hashedAndSalted)
                .WriteEndElement()
                .WriteStartElement("Salt")
                .WriteString(salt)
                .WriteEndElement()
                .WriteEndElement()
                .Close()
            End With

            xmlDoc.Save(Form1.directory + "GameData.xml")

            returnReason.Add(0)
        End If

        Return returnReason
    End Function

    Private Function passwordStrength(password As String) As Integer
        Dim lowerCount As Integer = 0
        Dim upperCount As Integer = 0
        Dim numberCount As Integer = 0
        Dim specialCount As Integer = 0

        For i = 0 To password.Length - 1
            If Char.IsUpper(password(i)) Then
                upperCount += 1
            ElseIf Char.IsLower(password(i)) Then
                lowerCount += 1
            ElseIf Char.IsDigit(password(i)) Then
                numberCount += 1
            Else
                specialCount += 1
            End If
        Next

        If upperCount >= 1 And lowerCount >= 4 And numberCount >= 2 Then
            Return 2
        ElseIf upperCount >= 1 And lowerCount >= 3 And numberCount >= 1 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub registerPassword_TextChanged(sender As Object, e As EventArgs) Handles registerPassword.TextChanged
        If registerPassword.ReadOnly = False Then
            Dim strength = passwordStrength(registerPassword.Text)
            If strength = 0 Then
                registerPassword.BackColor = Color.Red
            ElseIf strength = 1 Then
                registerPassword.BackColor = Color.Orange
            ElseIf strength = 2 Then
                registerPassword.BackColor = Color.Green
            End If
        End If
    End Sub

    Private Sub txt_loginUsername_Enter(sender As Object, e As EventArgs) Handles loginUsername.Enter
        If loginUsername.Text = "User Name" Then
            loginUsername.ForeColor = Color.White
            loginUsername.Text = ""
        End If
    End Sub

    Private Sub txt_loginUsername_Leave(sender As Object, e As EventArgs) Handles loginUsername.Leave
        If loginUsername.Text.Length = 0 Then
            loginUsername.ForeColor = Color.FromArgb(187, 225, 250)
            loginUsername.Text = "User Name"
        End If
    End Sub

    Private Sub txt_loginPassword_Enter(sender As Object, e As EventArgs) Handles loginPassword.Enter
        If loginPassword.Text = "Password" Then
            loginPassword.ForeColor = Color.White
            loginPassword.Text = ""
            loginPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub txt_loginPassword_Leave(sender As Object, e As EventArgs) Handles loginPassword.Leave
        If loginPassword.Text.Length = 0 Then
            loginPassword.ForeColor = Color.FromArgb(187, 225, 250)
            loginPassword.Text = "Password"
            loginPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub txt_registerUsername_Enter(sender As Object, e As EventArgs) Handles registerUsername.Enter
        If registerUsername.Text = "User Name" And registerUsername.ReadOnly = False Then
            registerUsername.ForeColor = Color.White
            registerUsername.Text = ""
        End If
    End Sub

    Private Sub txt_registerUsername_Leave(sender As Object, e As EventArgs) Handles registerUsername.Leave
        If registerUsername.Text.Length = 0 And registerUsername.ReadOnly = False Then
            registerUsername.ForeColor = Color.FromArgb(187, 225, 250)
            registerUsername.Text = "User Name"
        End If
    End Sub

    Private Sub txt_registerEmail_Enter(sender As Object, e As EventArgs) Handles registerEmail.Enter
        If registerEmail.Text = "Email" And registerEmail.ReadOnly = False Then
            registerEmail.ForeColor = Color.White
            registerEmail.Text = ""
        End If
    End Sub

    Private Sub txt_registerEmail_Leave(sender As Object, e As EventArgs) Handles registerEmail.Leave
        If registerEmail.Text.Length = 0 And registerEmail.ReadOnly = False Then
            registerEmail.ForeColor = Color.FromArgb(187, 225, 250)
            registerEmail.Text = "Email"
        End If
    End Sub

    Private Sub txt_registerPassword_Enter(sender As Object, e As EventArgs) Handles registerPassword.Enter
        If registerPassword.Text = "Password" And registerPassword.ReadOnly = False Then
            registerPassword.ForeColor = Color.White
            registerPassword.Text = ""
            registerPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub txt_registerPassword_Leave(sender As Object, e As EventArgs) Handles registerPassword.Leave
        If registerPassword.Text.Length = 0 And registerPassword.ReadOnly = False Then
            registerPassword.ForeColor = Color.FromArgb(187, 225, 250)
            registerPassword.Text = "Password"
            registerPassword.PasswordChar = ""
        End If
    End Sub
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class