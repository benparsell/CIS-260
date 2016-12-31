'Author: Ben Parsell
'Date: 2/23/2016
'Project: Lab 6
Option Strict On
Public Class Lab6
    Dim operand1 As Decimal
    Dim operator1 As String
    Dim operand2 As Decimal
    Dim Result As Decimal

    Private Function IsPresent(textbox As TextBox, name As String) As Boolean
        If textbox.Text = "" Then
            MessageBox.Show(name & " is a requried field.", "Entry Error")
            textbox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function IsDecimal(textBox As TextBox, name As String) As Boolean
        Dim number As Decimal = 0
        If Decimal.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be a decimal value.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    Private Function IsWithinRange(textBox As TextBox, name As String, min As Decimal, max As Decimal) As Boolean
        Dim number As Decimal = Convert.ToDecimal(textBox.Text)
        If number < min OrElse number > max Then
            MessageBox.Show(name & " must be between " & min & "and " & max & ".", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function IsOperator(textBox As TextBox, name As String) As Boolean
        Dim operator1 As String = textBox.Text
        If operator1 = "*" Or operator1 = "+" Or operator1 = "-" Or operator1 = "/" Or operator1 = "^" Then
            Return True
        Else
            MessageBox.Show(name & " must be an operator.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    Private Function IsValidData() As Boolean
        Return _
            IsPresent(txtOperand1, "Operand 1") AndAlso
            IsDecimal(txtOperand1, "Operand 1") AndAlso
            IsWithinRange(txtOperand1, "Operand 1", 1, 1000000) AndAlso
            IsPresent(txtOperator, "Operator") AndAlso
            IsOperator(txtOperator, "Operator") AndAlso
            IsPresent(txtOperand2, "Operand 2") AndAlso
            IsDecimal(txtOperand2, "Operand 2") AndAlso
            IsWithinRange(txtOperand2, "Operand 2", 1, 1000000)

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Calculate(operand1 As Decimal, operator1 As String, operand2 As Decimal, ByRef Result As Decimal)
        If operator1 = "*" Then
            Result = operand1 * operand2
        ElseIf operator1 = "+" Then
            Result = operand1 + operand2
        ElseIf operator1 = "-" Then
            Result = operand1 - operand2
        ElseIf operator1 = "/" Then
            Result = operand1 / operand2
        ElseIf operator1 = "^" Then
            Result = Convert.ToDecimal(operand1 ^ operand2)
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If IsValidData() = True Then

            operand1 = Convert.ToDecimal(txtOperand1.Text)
            operand2 = Convert.ToDecimal(txtOperand2.Text)
            operator1 = txtOperator.Text

            Call Calculate(operand1, operator1, operand2, Result)
            txtResult.Text = Convert.ToString(Math.Round(Result, 4))
        End If
    End Sub


    Private Sub ClearFutureValue(sender As Object, e As EventArgs) Handles txtOperand1.TextChanged, txtOperand2.TextChanged, txtOperator.TextChanged
       
        txtResult.Clear()
    End Sub
End Class
