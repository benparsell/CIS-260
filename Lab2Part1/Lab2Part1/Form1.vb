'Author: Ben Parsell
'Date: Jan 26, 2016
'Assignment: Lab 2 Part 1
Public Class Form1
    Dim WindChill As Double
    Dim Speed As String = Nothing
    Dim Temp As String = Nothing
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Speed = Convert.ToInt32(InputBox("Enter speed: ", "Speed", XPos:=950, YPos:=600))
        Temp = Convert.ToInt32(InputBox("Enter Temperature: ", "Temperature", XPos:=950, YPos:=600))

        WindChill = 35.74 + 0.6215 * Temp - 35.75 * Speed ^ 0.16 + 0.4275 * Temp * Speed ^ 0.16
        WindChill = FormatNumber(Me.WindChill, 2)
        lblWind.Text = "Windchill = " & Convert.ToString(WindChill)
    End Sub
End Class
