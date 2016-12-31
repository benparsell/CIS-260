'Author: Ben Parsell
'Date: 2/9/16
'Project: Lab 4 Projections
Option Strict On
Public Class Lab4
    Dim Sales As Decimal
    Dim Profit As Decimal
    Dim percentLoss As Decimal
    Dim Year As Integer = 1
    Dim profitPercent As Decimal
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim totalSales As Decimal = Sales
        Dim totalProfit As Decimal = Profit

        Sales = Convert.ToDecimal(InputBox("Enter Sales", "Sales"))
        profitPercent = Convert.ToDecimal(InputBox("Enter Percent Profit as Decimal", "Percent Profit"))
        percentLoss = Convert.ToDecimal(InputBox("Enter Percent Loss as Decimal", "Percent Loss"))



        Profit = Sales * profitPercent
        totalProfit += Profit
        totalSales = Sales

        rtbDisplay.Text = ControlChars.Tab + "Sales and Profit Projection"
        rtbDisplay.Text &= ControlChars.NewLine + "Year" + ControlChars.Tab + "Expected Sales" + ControlChars.Tab + "Projected Profit" + ControlChars.NewLine

        'For Me.Year = 1 To 10 Step 1


        '    rtbDisplay.Text &= Convert.ToString(Year) + ControlChars.Tab + Convert.ToString(FormatCurrency(Sales, 0)) + ControlChars.Tab + Convert.ToString(FormatCurrency(Profit, 0)) + ControlChars.NewLine

        '    Sales = Sales * (1 - percentLoss)
        '    Profit = Convert.ToDecimal(Sales * profitPercent)

        '    totalSales += Sales
        '    totalProfit += Profit

        '    If Year = 10 Then
        '        rtbDisplay.Text &= "Totals:" + ControlChars.Tab + Convert.ToString(FormatCurrency(totalSales, 0)) + ControlChars.Tab + Convert.ToString(FormatCurrency(totalProfit, 0))
        '    End If

        'Next Year


        Do While Year < 11
            rtbDisplay.Text &= Convert.ToString(Year) + ControlChars.Tab + Convert.ToString(FormatCurrency(Sales, 0)) + ControlChars.Tab + Convert.ToString(FormatCurrency(Profit, 0)) + ControlChars.NewLine

            Sales = Sales * (1 - percentLoss)
            Profit = Convert.ToDecimal(Sales * profitPercent)

            totalSales += Sales
            totalProfit += Profit

            If Year = 10 Then
                rtbDisplay.Text &= "Totals:" + ControlChars.Tab + Convert.ToString(FormatCurrency(totalSales, 0)) + ControlChars.Tab + Convert.ToString(FormatCurrency(totalProfit, 0))
            End If
            Year += 1
        Loop

        Year = 1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rtbDisplay.Clear()
        Profit = Convert.ToDecimal(0.0)
        Sales = Convert.ToDecimal(0.0)

        btnExit.Focus()
    End Sub
End Class
