<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab3
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
        Me.txtTestScore = New System.Windows.Forms.TextBox()
        Me.txtNumScores = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBestScore = New System.Windows.Forms.TextBox()
        Me.txtWorstScore = New System.Windows.Forms.TextBox()
        Me.txtAverageScore = New System.Windows.Forms.TextBox()
        Me.txtLetterGrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test Score:"
        '
        'txtTestScore
        '
        Me.txtTestScore.Location = New System.Drawing.Point(125, 17)
        Me.txtTestScore.Name = "txtTestScore"
        Me.txtTestScore.Size = New System.Drawing.Size(74, 20)
        Me.txtTestScore.TabIndex = 0
        '
        'txtNumScores
        '
        Me.txtNumScores.Location = New System.Drawing.Point(125, 50)
        Me.txtNumScores.Name = "txtNumScores"
        Me.txtNumScores.ReadOnly = True
        Me.txtNumScores.Size = New System.Drawing.Size(74, 20)
        Me.txtNumScores.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of scores"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 226)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(56, 23)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(81, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(56, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(149, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Best Score"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Worst Score"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Average Score"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Letter Grade"
        '
        'txtBestScore
        '
        Me.txtBestScore.Location = New System.Drawing.Point(125, 86)
        Me.txtBestScore.Name = "txtBestScore"
        Me.txtBestScore.ReadOnly = True
        Me.txtBestScore.Size = New System.Drawing.Size(74, 20)
        Me.txtBestScore.TabIndex = 4
        '
        'txtWorstScore
        '
        Me.txtWorstScore.Location = New System.Drawing.Point(125, 122)
        Me.txtWorstScore.Name = "txtWorstScore"
        Me.txtWorstScore.ReadOnly = True
        Me.txtWorstScore.Size = New System.Drawing.Size(74, 20)
        Me.txtWorstScore.TabIndex = 12
        '
        'txtAverageScore
        '
        Me.txtAverageScore.Location = New System.Drawing.Point(125, 155)
        Me.txtAverageScore.Name = "txtAverageScore"
        Me.txtAverageScore.ReadOnly = True
        Me.txtAverageScore.Size = New System.Drawing.Size(74, 20)
        Me.txtAverageScore.TabIndex = 13
        '
        'txtLetterGrade
        '
        Me.txtLetterGrade.Location = New System.Drawing.Point(125, 190)
        Me.txtLetterGrade.Name = "txtLetterGrade"
        Me.txtLetterGrade.ReadOnly = True
        Me.txtLetterGrade.Size = New System.Drawing.Size(45, 20)
        Me.txtLetterGrade.TabIndex = 14
        '
        'Lab3
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(211, 261)
        Me.Controls.Add(Me.txtLetterGrade)
        Me.Controls.Add(Me.txtAverageScore)
        Me.Controls.Add(Me.txtWorstScore)
        Me.Controls.Add(Me.txtBestScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumScores)
        Me.Controls.Add(Me.txtTestScore)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Lab3"
        Me.Text = "Test Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTestScore As System.Windows.Forms.TextBox
    Friend WithEvents txtNumScores As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBestScore As System.Windows.Forms.TextBox
    Friend WithEvents txtWorstScore As System.Windows.Forms.TextBox
    Friend WithEvents txtAverageScore As System.Windows.Forms.TextBox
    Friend WithEvents txtLetterGrade As System.Windows.Forms.TextBox

End Class
