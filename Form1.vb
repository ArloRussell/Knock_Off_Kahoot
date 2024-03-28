Imports System.ComponentModel.Design
Imports System.Web.Helpers
Imports Newtonsoft.Json

Public Class Form1
    Private KahonkQuestions As New List(Of Question)
    Private timeBy As Integer = 20
    Private Const strQUESTIONFILE As String = "vbchapter5kahoot.json"
    Private correctQuestion As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("You Have 20 second to find your file.")
        tmrLeft.Interval = 1000
        tmrLeft.Start()
        lblTime.Text = timeBy
        For i As Integer = 0 To KahonkQuestions.Count - 1
            LblQuest.Text = KahonkQuestions(i).question
            MakeButtons()
        Next
    End Sub

    Private Sub MakeButtons()
        PnlAnswers.Controls.Clear()
        Dim btnWidth As Double = PnlAnswers.Width / 2

        For i As Integer = 0 To 1
            For j As Integer = 0 To KahonkQuestions(i).answers.Count - 1
                Dim btnHeight As Double = PnlAnswers.Height / (KahonkQuestions(i).answers.Count - 1)
                Dim btn As New Button With {
                    .Location = New Point(btnWidth * i, btnHeight * j),
                    .Width = btnWidth,
                    .Height = btnHeight,
                    .BackColor = Color.DarkBlue,
                    .ForeColor = Color.White,
                    .Text = KahonkQuestions(i).answers(i),
                    .Font = New Font("Kristen ITC", 16),
                    .FlatStyle = FlatStyle.Flat
                }
                AddHandler btn.Click, AddressOf Me.btn_Click
                PnlAnswers.Controls.Add(btn)

            Next
        Next
        LblQuest.Text = KahonkQuestions(0).question
    End Sub

    Private Sub btn_Click(sender As Button, e As EventArgs)
        Dim userChoice As Integer
        Static score As Integer

        'WORKS LIKE A CHARM
        If sender.Text = "true" OrElse sender.Text = "false" Then
            If KahonkQuestions(0).correct = 0 Then
                correctQuestion = 0
            Else
                correctQuestion = 1
            End If
        Else
            correctQuestion = KahonkQuestions(0).correct
        End If

        'WORKS LIKE A COAL MINER
        If sender.Text = "true" Then
            userChoice = 0
        ElseIf sender.Text = "false" Then
            userChoice = 1
        End If

        'Problem is here >>
        If userChoice = correctQuestion Then
            MsgBox(userChoice)
            score += 1
            lblScore.Text = score
        Else
            MsgBox("bad choice buckaroo!")
        End If
        KahonkQuestions.RemoveAt(0)
        MakeButtons()
        tmrLeft.Stop()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        lblTime.Text = "20"
        MakeButtons()
        timeBy = 20
        tmrLeft.Interval = 1000
        tmrLeft.Start()
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        timeBy -= 1
        lblTime.Text = timeBy.ToString()
        If timeBy = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub LoadQuestionsFromFile(filepath As String)
        Dim reader As New IO.StreamReader(filepath)
        Dim str As String = reader.ReadToEnd
        Try
            KahonkQuestions = JsonConvert.DeserializeObject(Of List(Of Question))(str)
        Catch ex As Exception
            Process.Start($"https://www.google.com/search?q={ex.Message}")
        Finally
            reader.Close()
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenQuestionJSON.DefaultExt = "json"
        OpenQuestionJSON.Filter = "json files|*.json|All files|*.*"
        OpenQuestionJSON.Title = "Select your question JSON"
        If OpenQuestionJSON.ShowDialog = DialogResult.OK Then
            'MsgBox(OpenQuestionJSON.FileName)
            LoadQuestionsFromFile(OpenQuestionJSON.FileName)
            MakeButtons()
        End If
    End Sub
End Class



Public Class Question
    Public Property question As String
    Public Property answers As List(Of String)
    Public Property time As Integer
    Public Property correct As Integer
End Class


