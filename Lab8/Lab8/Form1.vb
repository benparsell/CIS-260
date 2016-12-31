'Author: Ben Parsell
'Project: Lab 8
'Date: 3/22/16
Option Strict On
Imports System.IO
Public Class Lab8

    Dim textIn As New StreamReader(New FileStream("Payments.txt", FileMode.OpenOrCreate, FileAccess.Read))

    Dim myPaymentList As New List(Of Payment)

    Private Sub Lab8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        lstPayments.Items.Add("Date Paid" & "Payee".PadLeft(20) & "Amount".PadLeft(20) & "Method".PadLeft(20))
        lstPayments.Items.Add("--------------------------------------------------------------------")

        Dim totalSpent As Decimal

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            Dim myPayment As New Payment
            myPayment.datePaid = Convert.ToDateTime(columns(0))
            myPayment.payee = columns(1)
            myPayment.amount = Convert.ToDecimal(columns(2))
            myPayment.paymentMethod = Convert.ToChar(columns(3))
            myPaymentList.Add(myPayment)


            totalSpent += myPayment.amount


            Dim newPaymentMethod As String
            If (myPayment.paymentMethod = "C") Then
                newPaymentMethod = "Cash"
            ElseIf (myPayment.paymentMethod = "D") Then
                newPaymentMethod = "Debit"
            ElseIf (myPayment.paymentMethod = "R") Then
                newPaymentMethod = "Credit"
            ElseIf (myPayment.paymentMethod = "K") Then
                newPaymentMethod = "Check"
            ElseIf (myPayment.paymentMethod = "T") Then
                newPaymentMethod = "Transfer"
            Else
                newPaymentMethod = ""
            End If

            lstPayments.Items.Add(myPayment.datePaid & myPayment.payee.PadLeft(20) & FormatCurrency(myPayment.amount).PadLeft(20) & newPaymentMethod.PadLeft(20))

        Loop

        textIn.Close()
        lstPayments.Items.Add("--------------------------------------------------------------------")
        lstPayments.Items.Add("Total: ".PadLeft(30) & FormatCurrency(totalSpent).PadLeft(20))
        btnSearch.Enabled = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim localTotal As Decimal
        Dim userCategory As String
        Dim localPayee As String = Nothing
        userCategory = InputBox("Payee")
        For Each item In myPaymentList
            If (userCategory = item.payee) Then
                localTotal += item.amount
                localPayee = item.payee
            End If
        Next

        lstPayments.Items.Add(localPayee.PadLeft(22) & " Amount" & FormatCurrency(localTotal).PadLeft(20))

    End Sub
End Class
