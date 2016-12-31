'Author: Ben Parsell
'Project: Homework 6
'Date: 4/2/2016

Option Strict On
Public Class Accounts

    Public Sub New()

    End Sub

    Public Sub New(customerId As String, password As String, balance As Decimal)
        Me.CustomerId = customerId
        Me.Password = password
        Me.Balance = balance
    End Sub

    Public Property CustomerId As String
    Public Property Password As String
    Public Property Balance As Decimal

End Class
