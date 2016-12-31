'Author: Ben Parsell
'Project: Homework 6
'Date: 4/9/2016

Option Strict On
Imports System.IO
Public Class Homework6Part2

    Private Sub Homework6Part2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pathName As String = InputBox("Enter the name of the File to use", "Enter Filename")

        Dim binaryIn As New BinaryReader(New FileStream(pathName, FileMode.OpenOrCreate, FileAccess.Read))


        Dim mySavedTransactions As New List(Of SavedTransactions)
        Do While binaryIn.PeekChar <> -1
            Dim transactions As New SavedTransactions
            transactions.CustomerID = binaryIn.ReadString
            transactions.TransactionNumber = binaryIn.ReadInt32
            transactions.TransactionType = binaryIn.ReadChar
            transactions.TransactionAmount = binaryIn.ReadDecimal
            mySavedTransactions.Add(transactions)
        Loop

        Dim transactionsList =
            From myTransactions In mySavedTransactions
            Order By myTransactions.CustomerID




        Dim i As Integer = 0
        Dim custID As String = ""
        Dim checkID As String = ""
        Dim totalBalance As Decimal
        For Each transactions In transactionsList

            If transactions.CustomerID <> custID Then
                lvAudit.Items.Add(transactions.CustomerID)
                custID = transactions.CustomerID
            Else
                lvAudit.Items.Add("")
            End If

            If checkID = transactions.CustomerID Then
                If transactions.TransactionType = "D"c Then
                    totalBalance += transactions.TransactionAmount
                ElseIf transactions.TransactionType = "W"c Then
                    totalBalance -= transactions.TransactionAmount
                ElseIf transactions.TransactionType = "I"c Then
                    totalBalance += transactions.TransactionAmount
                ElseIf transactions.TransactionType = "B"c Then
                    totalBalance += transactions.TransactionAmount
                End If
            Else
                'lvAudit.Items.Add("Total")
                'lvAudit.Items.Add(FormatCurrency(totalBalacne))
                'Couldn't get totals to come out perfect..
                totalBalance = 0
                totalBalance += transactions.TransactionAmount
            End If

            If custID = transactions.CustomerID Then
                lvAudit.Items(i).SubItems.Add(transactions.TransactionNumber.ToString)
                lvAudit.Items(i).SubItems.Add(transactions.TransactionType.ToString)
                lvAudit.Items(i).SubItems.Add(FormatCurrency(transactions.TransactionAmount))
                lvAudit.Items(i).SubItems.Add(FormatCurrency(totalBalance))
                i += 1
            End If
            checkID = transactions.CustomerID
        Next

        lvAudit.Items.Add("** End Of Report **")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
