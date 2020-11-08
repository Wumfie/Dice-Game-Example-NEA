Imports System.IO
Imports System.Xml

Public Class Leaderboard
    Public Sub showLeaderboards()
        Me.Show()
        orderHighscores()
    End Sub

    Private Sub orderHighscores()
        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode As XmlNodeList
        Dim i As Integer
        Dim str As String
        Dim fs As New FileStream(Form1.directory + "GameData.xml", FileMode.Open, FileAccess.Read)
        xmldoc.Load(fs)
        xmlnode = xmldoc.GetElementsByTagName("Score")

        Dim dtb As New System.Data.DataTable
        dtb.Columns.Add("Username")
        dtb.Columns.Add("Highscore", GetType(Integer))

        For i = 0 To xmlnode.Count - 1
            dtb.Rows.Add(xmlnode(i).ChildNodes.Item(0).InnerText.Trim(), xmlnode(i).ChildNodes.Item(1).InnerText.Trim())
        Next

        Dim dvw As DataView = dtb.DefaultView
        dvw.Sort = "Highscore DESC"
        Dim dtbSorted As DataTable = dvw.ToTable()
        DataGridView1.DataSource = dtbSorted

        fs.Close()
    End Sub

    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class