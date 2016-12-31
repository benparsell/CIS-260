<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homework5
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
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtWithdraw = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.lstTransactionReceipts = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(167, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBalance
        '
        Me.btnBalance.Location = New System.Drawing.Point(167, 220)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(75, 23)
        Me.btnBalance.TabIndex = 8
        Me.btnBalance.Text = "Balance"
        Me.btnBalance.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(167, 54)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(75, 22)
        Me.btnWithdraw.TabIndex = 3
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(167, 11)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(75, 23)
        Me.btnDeposit.TabIndex = 1
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnTransactions
        '
        Me.btnTransactions.Location = New System.Drawing.Point(167, 177)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(75, 23)
        Me.btnTransactions.TabIndex = 7
        Me.btnTransactions.Text = "Transactions"
        Me.btnTransactions.UseVisualStyleBackColor = True
        '
        'btnSetInterestRate
        '
        Me.btnSetInterestRate.Location = New System.Drawing.Point(155, 95)
        Me.btnSetInterestRate.Name = "btnSetInterestRate"
        Me.btnSetInterestRate.Size = New System.Drawing.Size(102, 23)
        Me.btnSetInterestRate.TabIndex = 5
        Me.btnSetInterestRate.Text = "Set Interest Rate"
        Me.btnSetInterestRate.UseVisualStyleBackColor = True
        '
        'btnCalculateInterest
        '
        Me.btnCalculateInterest.Location = New System.Drawing.Point(157, 136)
        Me.btnCalculateInterest.Name = "btnCalculateInterest"
        Me.btnCalculateInterest.Size = New System.Drawing.Size(100, 23)
        Me.btnCalculateInterest.TabIndex = 6
        Me.btnCalculateInterest.Text = "Calculate Interest"
        Me.btnCalculateInterest.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(14, 14)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 20)
        Me.txtDeposit.TabIndex = 0
        Me.txtDeposit.Tag = "Deposit"
        '
        'txtWithdraw
        '
        Me.txtWithdraw.Location = New System.Drawing.Point(14, 56)
        Me.txtWithdraw.Name = "txtWithdraw"
        Me.txtWithdraw.Size = New System.Drawing.Size(100, 20)
        Me.txtWithdraw.TabIndex = 2
        Me.txtWithdraw.Tag = "Withdraw"
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(14, 99)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(100, 20)
        Me.txtInterest.TabIndex = 4
        Me.txtInterest.Tag = "Interest Rate"
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(167, 264)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(79, 23)
        Me.btnPrintReceipt.TabIndex = 9
        Me.btnPrintReceipt.Text = "Print Receipt"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'lstTransactionReceipts
        '
        Me.lstTransactionReceipts.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTransactionReceipts.FormattingEnabled = True
        Me.lstTransactionReceipts.ItemHeight = 14
        Me.lstTransactionReceipts.Location = New System.Drawing.Point(273, 12)
        Me.lstTransactionReceipts.Name = "lstTransactionReceipts"
        Me.lstTransactionReceipts.Size = New System.Drawing.Size(396, 88)
        Me.lstTransactionReceipts.TabIndex = 10
        Me.lstTransactionReceipts.TabStop = False
        Me.lstTransactionReceipts.Visible = False
        '
        'Homework5
        '
        Me.AcceptButton = Me.btnBalance
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(681, 363)
        Me.Controls.Add(Me.lstTransactionReceipts)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtWithdraw)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.btnCalculateInterest)
        Me.Controls.Add(Me.btnSetInterestRate)
        Me.Controls.Add(Me.btnTransactions)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnBalance)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Homework5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBalance As System.Windows.Forms.Button
    Friend WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents btnTransactions As System.Windows.Forms.Button
    Friend WithEvents btnSetInterestRate As System.Windows.Forms.Button
    Friend WithEvents btnCalculateInterest As System.Windows.Forms.Button
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents txtWithdraw As System.Windows.Forms.TextBox
    Friend WithEvents txtInterest As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents lstTransactionReceipts As System.Windows.Forms.ListBox

End Class
