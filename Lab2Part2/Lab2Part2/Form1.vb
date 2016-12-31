'Author: Ben Parsell
'Date: 1/26/2016
'Project: Lab 2 Part 2
Public Class Form1
    Dim Speed As String = Nothing
    Dim Temp As String = Nothing
    Dim WindChill As Double
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Speed = Convert.ToInt32(mskWind.Text)
        Temp = Convert.ToInt32(mskTemp.Text)

        WindChill = 35.74 + 0.6215 * Temp - 35.75 * Speed ^ 0.16 + 0.4275 * Temp * Speed ^ 0.16
        WindChill = FormatNumber(Me.WindChill, 2)
        lblWind.Text = "Windchill = " & Convert.ToString(WindChill)
    End Sub
End Class
