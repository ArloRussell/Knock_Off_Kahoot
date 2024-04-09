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
        Dim btnHeight As Double
        Dim currentQ As Integer = 0
        Dim color As Color
        Dim question As String = "Placeholder"
        'For i As Integer = 0 To 1
        For j As Integer = 0 To KahonkQuestions(currentQ).answers.Count - 1
            Dim i As Integer = j Mod 2
            Dim ycoord As Integer = 0
            If j >= 2 Then
                ycoord = 1
            End If
            If KahonkQuestions(currentQ).answers.Count < 3 Then

                Select Case i
                    Case 0
                        Select Case j
                            Case 0
                                color = color.Red
                            Case 1
                                color = color.DarkBlue
                        End Select
                    Case 1
                        Select Case j
                            Case 0
                                color = color.DarkGray
                            Case 1
                                color = color.DarkGreen
                        End Select

                End Select
                btnHeight = PnlAnswers.Height / (KahonkQuestions(currentQ).answers.Count - 1)
                Dim btn As New Button With {
                    .Location = New Point(btnWidth * i, btnHeight * ycoord),
                    .Width = btnWidth,
                    .Height = btnHeight,
                    .BackColor = color,
                    .ForeColor = color.White,
                    .Text = KahonkQuestions(currentQ).answers(j),
                    .Font = New Font("Kristen ITC", 16),
                    .FlatStyle = FlatStyle.Flat
                }
                AddHandler btn.Click, AddressOf Me.btn_Click
                PnlAnswers.Controls.Add(btn)
            Else
                Select Case i
                    Case 0
                        Select Case j
                            Case 0
                                color = color.Red
                                question = KahonkQuestions(currentQ).answers(0)
                            Case 1
                                color = color.DarkBlue
                                question = KahonkQuestions(currentQ).answers(1)
                        End Select
                    Case 1
                        Select Case j
                            Case 2
                                color = color.DarkGray
                                question = KahonkQuestions(currentQ).answers(2)
                            Case 3
                                color = color.DarkGreen
                                question = KahonkQuestions(currentQ).answers(3)
                        End Select

                End Select

                btnHeight = PnlAnswers.Height / (KahonkQuestions(i).answers.Count / 2)
                Dim btn As New Button With {
                    .Location = New Point(btnWidth * i, btnHeight * j),
                    .Width = btnWidth,
                    .Height = btnHeight,
                    .BackColor = color,
                    .ForeColor = color.White,
                    .Text = question,
                    .Font = New Font("Kristen ITC", 16),
                    .FlatStyle = FlatStyle.Flat
                }
                AddHandler btn.Click, AddressOf Me.btn_Click
                PnlAnswers.Controls.Add(btn)
            End If
        Next
        timeBy = KahonkQuestions(i).time
        tmrLeft.Start()
        'Next
        LblQuest.Text = KahonkQuestions(0).question
    End Sub

    Private Sub btn_Click(sender As Button, e As EventArgs)
        Dim userChoice As Integer
        Static score As Integer
        tmrLeft.Stop()
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

            score += 1
            lblScore.Text = score
        Else
            MsgBox("bad choice buckaroo!")
        End If
        MsgBox(userChoice & "  " & correctQuestion)
        KahonkQuestions.RemoveAt(0)
        MakeButtons()

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


