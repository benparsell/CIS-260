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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWind = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.numWind = New System.Windows.Forms.NumericUpDown()
        Me.numTemp = New System.Windows.Forms.NumericUpDown()
        CType(Me.numWind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Wind Speed (mph):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Temperature (F):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Wind Chill:"
        '
        'lblWind
        '
        Me.lblWind.AutoSize = True
        Me.lblWind.Location = New System.Drawing.Point(158, 131)
        Me.lblWind.Name = "lblWind"
        Me.lblWind.Size = New System.Drawing.Size(0, 13)
        Me.lblWind.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(38, 189)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(158, 189)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'numWind
        '
        Me.numWind.Location = New System.Drawing.Point(158, 43)
        Me.numWind.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numWind.Name = "numWind"
        Me.numWind.Size = New System.Drawing.Size(120, 20)
        Me.numWind.TabIndex = 0
        '
        'numTemp
        '
        Me.numTemp.Location = New System.Drawing.Point(158, 88)
        Me.numTemp.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.numTemp.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numTemp.Name = "numTemp"
        Me.numTemp.Size = New System.Drawing.Size(120, 20)
        Me.numTemp.TabIndex = 1
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.numTemp)
        Me.Controls.Add(Me.numWind)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblWind)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Wind Chill V3"
        CType(Me.numWind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblWind As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents numWind As System.Windows.Forms.NumericUpDown
    Friend WithEvents numTemp As System.Windows.Forms.NumericUpDown

End Class
