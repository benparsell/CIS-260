'Author: Ben Parsell
'Project: Lab 10
'Date: 4/5/2016
Option Strict On
Public Class Plant
    Inherits InvItem

    Public Property Size As String

    Public Sub New(itemNo As Integer, description As String, price As Decimal, size As String)
        MyBase.New(itemNo, description, price)
        Me.Size = size
    End Sub

    Public Overrides Function GetDisplayText() As String
        Return ItemNo & "    " & Size & "    " & Description & " (" & FormatCurrency(Price) & ")"
    End Function
End Class
