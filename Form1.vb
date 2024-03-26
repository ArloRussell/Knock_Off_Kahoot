Imports Newtonsoft.Json

Public Class Form1
    Private KahonkQuestions As New List(Of Questions)
    Private timeBy As Integer = 20
    Private Const strQUESTIONFILE As String = "vbchapter5kahoot.json"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopKahonkQuestions(strQUESTIONFILE)
        MakeButtons()
        tmrLeft.Interval = 1000
        tmrLeft.Start()
        lblTime.Text = timeBy
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
        KahonkQuestions = JsonConvert.DeserializeObject(Of List(Of Questions))(str)
        reader.Close()

    End Sub
End Class
Class Questions
    Private _question As String
    Private _answers As List(Of String)
    Private _time As Integer

    Public Property Question As String
        Get
            Return _question
        End Get
        Set(value As String)
            _question = value
        End Set
    End Property

    Public Property Answers As List(Of String)
        Get
            Return _answers
        End Get
        Set(value As List(Of String))
            _answers = value
        End Set
    End Property

    Public Property Time As Integer
        Get
            Return _time
        End Get
        Set(value As Integer)
            _time += value
        End Set
    End Property
End Class
