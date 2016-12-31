'Author: Ben Parsell
'Project: Lab 7
'Date: 3/15/2016

Option Strict On
Public Class Lab7
    Dim bankAccount As BankAccount = New BankAccount()
    Dim depositAmount As Decimal
    Dim withdrawAmount As Decimal
    Dim interestRate As Double
    Dim interest As Decimal
    Dim transactions As Integer

    Private Sub BankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        depositAmount = Convert.ToDecimal(InputBox("Enter Deposit Amount"))
        bankAccount.Deposit(depositAmount)
    End Sub


    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        MsgBox("Current Balance: " + FormatCurrency(bankAccount.Balance()))
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        withdrawAmount = Convert.ToDecimal(InputBox("Enter Withdraw Amount"))
        bankAccount.Withdraw(withdrawAmount)
    End Sub

    Private Sub btnSetInterestRate_Click(sender As Object, e As EventArgs) Handles btnSetInterestRate.Click
        bankAccount.InterestRate = Convert.ToDouble(InputBox("Set the Interest Rate"))
    End Sub

    Private Sub btnCalculateInterest_Click(sender As Object, e As EventArgs) Handles btnCalculateInterest.Click
        bankAccount.CalculateInterest()
        MsgBox("Total Interest is: " + FormatCurrency(bankAccount.Interest))
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        MsgBox("Total Transactions: " + Convert.ToString(bankAccount.Transactions))
    End Sub
End Class
