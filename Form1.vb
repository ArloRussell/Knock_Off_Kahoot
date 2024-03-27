Imports System.Web.Helpers
Imports Newtonsoft.Json

Public Class Form1
    Private KahonkQuestions As New List(Of Questions)
    Private timeBy As Integer = 20
    Private Const strQUESTIONFILE As String = "C:\Users\CMP_AnSpencer\source\repos\ArloRussell\Knock_Off_Kahoot\bin\Debug\vbchapter5kahoot.json"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopKahonkQuestions(strQUESTIONFILE)
        MakeButtons()
        tmrLeft.Interval = 1000
        tmrLeft.Start()
        lblTime.Text = timeBy
        For i As Integer = 0 To KahonkQuestions.Count - 1
            MsgBox(KahonkQuestions(i))
        Next
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
            Next
        Next
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
        Dim reader As New IO.StreamReader(strQUESTIONFILE)
        Dim str As String = reader.ReadToEnd
        Dim result As Questions = JsonConvert.DeserializeObject(Of Questions)(str)
        MsgBox(filepath)
        reader.Close()
    End Sub
End Class
Class Questions

    Public Class Rootobject
        Public Property Property1() As Class1
    End Class

    Public Class Class1
        Public Property question As String
        Public Property answers() As String
        Public Property time As String
        Public Property correct As Integer

    End Class

End Class

