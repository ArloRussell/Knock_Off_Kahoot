Imports System.Web.Helpers
Imports Newtonsoft.Json

Public Class Form1
    Private KahonkQuestions As New List(Of Question)
    Private timeBy As Integer = 20
    Private Const strQUESTIONFILE As String = "vbchapter5kahoot.json"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopKahonkQuestions(strQUESTIONFILE)
        MakeButtons()
        tmrLeft.Interval = 1000Dd
        tmrLeft.Start()
        lblTime.Text = timeBy
        'For i As Integer = 0 To KahonkQuestions.Count - 1
        '    MsgBox(KahonkQuestions(i).answers(KahonkQuestions(i).correct).ToString())
        '    'For j As Integer = 0 To KahonkQuestions(i).answers.Count - 1
        '    'MsgBox(KahonkQuestions(i).answers(j).ToString())
        '    '
        '    ' Next
        'Next
    End Sub

    Private Sub PopKahonkQuestions(filepath)
        If IO.File.Exists(filepath) Then
            LoadQuestionsFromFile(filepath)
        Else
            MsgBox("There was an error in your file")
        End If
    End Sub
    Private Sub MakeButtons()
        PnlAnswers.Controls.Clear()
        Dim btnWidth As Double = PnlAnswers.Width / 2
        Dim btnHeight As Double = PnlAnswers.Height / 2 'num of answers / 2

        For i As Integer = 0 To 1
            'If num of answers = 3
            'Else
            For j As Integer = 0 To 1
                Dim btn As New Button With {
                    .Location = New Point(btnWidth * i, btnHeight * j),
                    .Width = btnWidth,
                    .Height = btnHeight,
                    .BackColor = Color.DarkBlue,
                    .ForeColor = Color.White,
                    .Text = "Possible Answer",
                    .Font = New Font("Kristen ITC", 16),
                    .FlatStyle = FlatStyle.Flat
                }
                PnlAnswers.Controls.Add(btn)

                AddHandler btn.Click, AddressOf Me.btn_Click
            Next
        Next
    End Sub

    Private Sub btn_Click(sender As Button, e As EventArgs)
        tmrLeft.Stop()
        MsgBox("Yep. That's a button.")

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

    Private Sub PnlAnswers_Paint(sender As Object, e As PaintEventArgs) Handles PnlAnswers.Paint

    End Sub
End Class



Public Class Question
    Public Property question As String
    Public Property answers As List(Of String)
    Public Property time As Integer
    Public Property correct As Integer
End Class


