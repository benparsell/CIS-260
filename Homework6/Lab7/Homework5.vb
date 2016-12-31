'Author: Ben Parsell
'Project: Homework 6
'Date: 4/2/2016

Option Strict On
Imports System.IO
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


    Dim binaryOut As New BinaryWriter(New FileStream("Transactions" & MonthName(Now.Month, ) & Now.Year & ".dat", FileMode.Append, FileAccess.Write))
    Dim accounts(5, 2) As String
    Dim i As Integer



    Private Sub BankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textIn As New StreamReader(New FileStream("Users.txt", FileMode.OpenOrCreate, FileAccess.Read))
        Dim x As Integer = 0
        Dim attempts As Integer = 3
        Dim match = False

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            accounts(x, 0) = columns(0)
            accounts(x, 1) = columns(1)
            accounts(x, 2) = columns(2)
            x += 1
        Loop
        textIn.Close()



        customerID = InputBox("Please Enter Your Customer ID")
        For i = 0 To accounts.GetLength(0) - 1

            If customerID = accounts(i, 0) Then
                For j = 0 To 2
                    password = InputBox("Please Enter Your Password")
                    If password = accounts(i, 1) Then
                        match = True
                        bankAccount.Balance = Convert.ToDecimal(accounts(i, 2))
                        mySavedTransactions.Add(New SavedTransactions(customerID, 0, "B"c, Convert.ToDecimal(accounts(i, 2))))
                        Return
                    Else
                        MsgBox("CustomerID incorrect.", , "Incorrect Login")
                    End If
                Next
                MsgBox("No attempts remaining. Program now exiting.", , "No Password Attempts Remaining")
                Me.Close()
            End If
            i += 1
        Next
    End Sub

    Private Sub btnExit_Clifick(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim textOut As New StreamWriter(New FileStream("Users.txt", FileMode.OpenOrCreate, FileAccess.Write))
        accounts(i, 2) = Convert.ToString(bankAccount.Balance)
        For x As Integer = 0 To 5
            textOut.Write(accounts(x, 0) & "|")
            textOut.Write(accounts(x, 1) & "|")
            textOut.WriteLine(accounts(x, 2))
        Next
        textOut.Close()


        For Each transaction As SavedTransactions In mySavedTransactions
            binaryOut.Write(transaction.CustomerID)
            binaryOut.Write(transaction.TransactionNumber)
            binaryOut.Write(transaction.TransactionType)
            binaryOut.Write(transaction.TransactionAmount)
        Next
        binaryOut.Close()
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
