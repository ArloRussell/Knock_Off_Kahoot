<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PnlAnswers = New System.Windows.Forms.Panel()
        Me.LblQuest = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlAnswers
        '
        Me.PnlAnswers.Location = New System.Drawing.Point(12, 309)
        Me.PnlAnswers.Name = "PnlAnswers"
        Me.PnlAnswers.Size = New System.Drawing.Size(776, 129)
        Me.PnlAnswers.TabIndex = 0
        '
        'LblQuest
        '
        Me.LblQuest.BackColor = System.Drawing.Color.DarkBlue
        Me.LblQuest.Font = New System.Drawing.Font("Kristen ITC", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuest.ForeColor = System.Drawing.Color.White
        Me.LblQuest.Location = New System.Drawing.Point(-1, -4)
        Me.LblQuest.Name = "LblQuest"
        Me.LblQuest.Size = New System.Drawing.Size(808, 99)
        Me.LblQuest.TabIndex = 1
        Me.LblQuest.Text = "Insert Question Here"
        Me.LblQuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.DarkBlue
        Me.lblTime.Font = New System.Drawing.Font("Kristen ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(12, 149)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 100)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(164, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(472, 149)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'tmrLeft
        '
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.DarkBlue
        Me.lblScore.Font = New System.Drawing.Font("Kristen ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(655, 162)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(125, 75)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "Score"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.LblQuest)
        Me.Controls.Add(Me.PnlAnswers)
        Me.Name = "Form1"
        Me.Text = "Score"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlAnswers As Panel
    Friend WithEvents LblQuest As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents lblScore As Label
End Class
