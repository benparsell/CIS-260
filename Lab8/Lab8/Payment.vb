'Author: Ben Parsell
'Project: Lab 8
'Date: 3/22/16

Option Strict On
Public Class Payment

    Public Sub New()

    End Sub

    Public Sub New(myDatePaid As DateTime, myPayee As String, myAmount As Decimal, myPaymentMethod As Char)
        datePaid = myDatePaid
        payee = myPayee
        amount = myAmount
        paymentMethod = myPaymentMethod
    End Sub


    Public Property datePaid As DateTime

    Public Property payee As String

    Public Property amount As Decimal

    Public Property paymentMethod As Char
End Class
