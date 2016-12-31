'Author: Ben Parsell
'Project: Lab 7
'Date: 3/15/2016

Option Strict On
Public Class Homework5
    Dim bankAccount As BankAccount = New BankAccount()
    Dim depositAmount As Decimal
    Dim withdrawAmount As Decimal
    Dim interestRate As Double
    Dim interest As Decimal
    Dim transactions As Integer = 0
    Dim customerID As String
    Dim password As String
    Dim transactionType As String = Nothing
    Dim mySavedTransactions As New List(Of SavedTransactions)


    Private Sub BankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customerID = InputBox("Please Enter Your Customer ID")
        password = InputBox("Please Enter Your Password")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        If (Validator.IsPresent(txtDeposit) = False) Then
            txtDeposit.Focus()
            txtDeposit.SelectAll()
        ElseIf (Validator.IsDecimal(txtDeposit) = False) Then
            txtDeposit.Focus()
            txtDeposit.SelectAll()
        ElseIf (Validator.IsWithinRange(txtDeposit, 0, 10000) = False) Then
            txtDeposit.Focus()
            txtDeposit.SelectAll()
        Else
            depositAmount = Convert.ToDecimal(txtDeposit.Text)
            bankAccount.Deposit(depositAmount)
            transactions += 1
            transactionType = "D"c
            mySavedTransactions.Add(New SavedTransactions(customerID, transactions, "D"c, depositAmount))
            txtDeposit.Text = ""
        End If

    End Sub


    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        MsgBox("Current Balance: " + FormatCurrency(bankAccount.Balance()))
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        If (Validator.IsPresent(txtWithdraw) = False) Then
            txtWithdraw.Focus()
            txtWithdraw.SelectAll()
        ElseIf (Validator.IsDecimal(txtWithdraw) = False) Then
            txtWithdraw.Focus()
            txtWithdraw.SelectAll()
        ElseIf (Validator.IsWithinRange(txtWithdraw, 0, 10000) = False) Then
            txtWithdraw.Focus()
            txtWithdraw.SelectAll()
        Else

            withdrawAmount = Convert.ToDecimal(txtWithdraw.Text)
            transactions += 1
            bankAccount.Withdraw(withdrawAmount)
            mySavedTransactions.Add(New SavedTransactions(customerID, transactions, "W"c, withdrawAmount))
            txtWithdraw.Text = ""
        End If
    End Sub

    Private Sub btnSetInterestRate_Click(sender As Object, e As EventArgs) Handles btnSetInterestRate.Click
        If (Validator.IsPresent(txtInterest) = False) Then
            txtInterest.Focus()
            txtInterest.SelectAll()
        ElseIf (Validator.IsDouble(txtInterest) = False) Then
            txtInterest.Focus()
            txtInterest.SelectAll()
        ElseIf (Validator.IsWithinRange(txtInterest, 0, 10) = False) Then
            txtInterest.Focus()
            txtInterest.SelectAll()
        Else
            bankAccount.InterestRate = Convert.ToDouble(txtInterest.Text)
            transactions += 1
            txtInterest.Text = ""
        End If
    End Sub

    Private Sub btnCalculateInterest_Click(sender As Object, e As EventArgs) Handles btnCalculateInterest.Click
        bankAccount.CalculateInterest()
        MsgBox("Total Interest is: " + FormatCurrency(bankAccount.Interest))
        interest = bankAccount.Interest
        mySavedTransactions.Add(New SavedTransactions(customerID, transactions, "I"c, interest))
        transactions += 1
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        MsgBox("Total Transactions: " + Convert.ToString(bankAccount.Transactions))
    End Sub

    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        lstTransactionReceipts.Visible() = True
        lstTransactionReceipts.Items.Add("Main Street Bank".PadLeft(0) & customerID.PadLeft(15) & DateTime.Now.ToShortDateString.PadLeft(18))
        lstTransactionReceipts.Items.Add("==============================================================")
        For Each item As SavedTransactions In mySavedTransactions
            If (item.TransactionType = "D"c) Then
                transactionType = "Deposit"
            ElseIf (item.TransactionType = "W"c) Then
                transactionType = "Withdraw"
            ElseIf (item.TransactionType = "I"c) Then
                transactionType = "Interest"
            End If
            lstTransactionReceipts.Items.Add("Transaction: " & item.TransactionNumber.ToString.PadLeft(0) & transactionType.PadLeft(15) & FormatCurrency(item.TransactionAmount).PadLeft(20))
            
        Next
    End Sub
End Class
