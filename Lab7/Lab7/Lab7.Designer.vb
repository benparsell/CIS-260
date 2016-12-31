<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab7
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnTransactions = New System.Windows.Forms.Button()
        Me.btnSetInterestRate = New System.Windows.Forms.Button()
        Me.btnCalculateInterest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(47, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBalance
        '
        Me.btnBalance.Location = New System.Drawing.Point(169, 218)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(75, 23)
        Me.btnBalance.TabIndex = 3
        Me.btnBalance.Text = "Balance"
        Me.btnBalance.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(184, 35)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(75, 23)
        Me.btnWithdraw.TabIndex = 4
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(35, 35)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(75, 23)
        Me.btnDeposit.TabIndex = 0
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnTransactions
        '
        Me.btnTransactions.Location = New System.Drawing.Point(106, 147)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(75, 23)
        Me.btnTransactions.TabIndex = 5
        Me.btnTransactions.Text = "Transactions"
        Me.btnTransactions.UseVisualStyleBackColor = True
        '
        'btnSetInterestRate
        '
        Me.btnSetInterestRate.Location = New System.Drawing.Point(166, 90)
        Me.btnSetInterestRate.Name = "btnSetInterestRate"
        Me.btnSetInterestRate.Size = New System.Drawing.Size(102, 23)
        Me.btnSetInterestRate.TabIndex = 1
        Me.btnSetInterestRate.Text = "Set Interest Rate"
        Me.btnSetInterestRate.UseVisualStyleBackColor = True
        '
        'btnCalculateInterest
        '
        Me.btnCalculateInterest.Location = New System.Drawing.Point(22, 90)
        Me.btnCalculateInterest.Name = "btnCalculateInterest"
        Me.btnCalculateInterest.Size = New System.Drawing.Size(100, 23)
        Me.btnCalculateInterest.TabIndex = 2
        Me.btnCalculateInterest.Text = "Calculate Interest"
        Me.btnCalculateInterest.UseVisualStyleBackColor = True
        '
        'Lab7
        '
        Me.AcceptButton = Me.btnBalance
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalculateInterest)
        Me.Controls.Add(Me.btnSetInterestRate)
        Me.Controls.Add(Me.btnTransactions)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnBalance)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Lab7"
        Me.Text = "Bank Simulator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBalance As System.Windows.Forms.Button
    Friend WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents btnTransactions As System.Windows.Forms.Button
    Friend WithEvents btnSetInterestRate As System.Windows.Forms.Button
    Friend WithEvents btnCalculateInterest As System.Windows.Forms.Button

End Class
