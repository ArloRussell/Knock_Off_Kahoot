Public Class Form1
    Private timeBy As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeButtons()
        tmrLeft.Interval = 1000
        tmrLeft.Start()
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
    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick

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
