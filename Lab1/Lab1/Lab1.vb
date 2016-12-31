'Author: Ben Parsell
'Date: Jan 19, 2016
'Assignment: Lab 1
Option Strict On
Public Class Lab1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If txtLength.Text = "" Then
            MsgBox("Length cannot be empty", , "Error")
            txtLength.Focus()
        ElseIf txtDiameter.Text = "" Then
            MsgBox("Diameter cannot be empty", , "Error")
            txtDiameter.Focus()
        Else
            Me.txtVolume.Text = Convert.ToString((Math.PI * ((Convert.ToDouble(Me.txtDiameter.Text) / 2) ^ 2) * (Convert.ToDouble(Me.txtLength.Text)) + ((4 / 3) * (Math.PI) * ((Convert.ToDouble(Me.txtDiameter.Text) / 2) ^ 3))))
            Me.txtVolume.Text = FormatNumber(Me.txtVolume.Text, 2)
            btnClear.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtVolume.Text = ""
        Me.txtLength.Text = ""
        Me.txtDiameter.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
