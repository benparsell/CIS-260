'Author: Ben Parsell
'Project: Lab 10
'Date: 4/5/2016
Option Strict On
Public Class Manufacturer
    Inherits InvItem

    Public Property Manufacturer As String

    Public Sub New(itemNo As Integer, description As String, price As Decimal, manufacturer As String)
        MyBase.New(itemNo, description, price)
        Me.Manufacturer = manufacturer
    End Sub

    Public Overrides Function GetDisplayText() As String
        Return ItemNo & "    " & Manufacturer & "    " & Description & " (" & FormatCurrency(Price) & ")"
    End Function
End Class

