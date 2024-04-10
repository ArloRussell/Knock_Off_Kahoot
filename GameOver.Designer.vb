<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOver
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkBlue
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 114)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game Over"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(84, 190)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(125, 35)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(84, 148)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(125, 35)
        Me.btnRestart.TabIndex = 2
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 114)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Game Over"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 249)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "GameOver"
        Me.Text = "GameOver"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents Label2 As Label
End Class
