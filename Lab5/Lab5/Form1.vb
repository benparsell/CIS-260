'Author: Ben Parsell
'Date: 2/16/2016
'Project: Lab 5
Option Strict On
Public Class Lab5
    Dim employeeName As String
    Dim hoursWorked As Decimal
    Dim payRate As Decimal
    Dim ytdSalary As Decimal
    Dim dependents As Integer

    Const michiganTaxRate As Decimal = 0.0425D
    Const ssTax As Decimal = 0.062D
    Const medicareTaxRate As Decimal = 0.0145D

    Dim newGrossPay As Decimal
    Dim totalSocialSecurityTax As Decimal
    Dim totalMichiganTax As Decimal
    Dim totalMedicareTax As Decimal
    Dim netTotal As Decimal

    Private Function GrossPay(ByVal hoursWorked As Decimal, ByVal payRate As Decimal) As Decimal
        Dim overTimeHours As Decimal
        Dim overTimePayRate As Decimal
        If (hoursWorked > 40) Then
            overTimeHours = hoursWorked - 40
            overTimePayRate = payRate * 1.5D
            Return (payRate * 40) + (overTimeHours * overTimePayRate)
        Else
            Return hoursWorked * payRate
        End If

    End Function

    Private Sub displayOutput(ByVal employeeName As String, ByVal hoursWorked As Decimal)
        MsgBox("Name: " + employeeName + ControlChars.NewLine + "Hours Worked: " + Convert.ToString(hoursWorked) + ControlChars.NewLine + "Gross Pay: " + FormatCurrency(newGrossPay) + ControlChars.NewLine + "Net Pay: " + FormatCurrency(totalMichiganTax) + ControlChars.NewLine + "Soc: " + FormatCurrency(totalSocialSecurityTax) + ControlChars.NewLine + "Medicare: " + FormatCurrency(totalMedicareTax) + ControlChars.NewLine + "Net Pay: " + FormatCurrency(netTotal))
    End Sub

    

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If (txtEmployee.Text = "") Then
            MsgBox("Employee Name cannot be empty", , "Error")
            txtEmployee.Focus()
        ElseIf (txtHours.Text = "") Then
            MsgBox("Hours Worked cannot be empty", , "Error")
            txtHours.Focus()
        ElseIf (txtPayRate.Text = "") Then
            MsgBox("Pay Rate cannot be empty", , "Error")
            txtPayRate.Focus()
        ElseIf (txtAmountEarned.Text = "") Then
            MsgBox("YTD cannot be empty", , "Error")
            txtAmountEarned.Focus()
        ElseIf (txtDependents.Text = "") Then
            MsgBox("Dependents cannot be empty", , "Error")
            txtDependents.Focus()
        Else

            employeeName = txtEmployee.Text
            hoursWorked = Convert.ToDecimal(txtHours.Text)
            payRate = Convert.ToDecimal(txtPayRate.Text)
            ytdSalary = Convert.ToDecimal(txtAmountEarned.Text)
            dependents = Convert.ToInt32(txtDependents.Text)



            newGrossPay = GrossPay(hoursWorked, payRate)
            totalSocialSecurityTax = SocialSecurityTax(ssTax, ytdSalary)
            totalMichiganTax = MichiganTax(michiganTaxRate, newGrossPay)
            totalMedicareTax = MedicareTax(medicareTaxRate)
            netTotal = netPay(totalMichiganTax, totalSocialSecurityTax, totalMedicareTax, newGrossPay)

            displayOutput(txtEmployee.Text, hoursWorked)

            btnExit.Focus()
        End If
    End Sub

    Private Function MichiganTax(ByVal michiganTaxRate As Decimal, ByVal newGrossPay As Decimal) As Decimal
        Dim michiganTaxTotal As Decimal
        michiganTaxTotal = newGrossPay * michiganTaxRate
        Return michiganTaxTotal
    End Function

    Private Function SocialSecurityTax(ByVal ssTax As Decimal, ByVal ytdSalary As Decimal) As Decimal
        Dim GrossPayment As Decimal
        Dim ssTaxTotal As Decimal
        GrossPayment = GrossPay(hoursWorked, payRate)
        If (ytdSalary > 118500) Then
            ssTaxTotal = 0
            Return ssTaxTotal
        ElseIf (ytdSalary + GrossPayment < 118500) Then
            ssTaxTotal = GrossPayment * ssTax
            Return ssTaxTotal
        ElseIf (ytdSalary + GrossPayment >= 118500) Then
            ssTaxTotal = (118500 - ytdSalary) * ssTax
            Return ssTaxTotal
        Else
            Return -1
        End If
    End Function

    Private Function MedicareTax(ByVal medicareTaxRate As Decimal) As Decimal
        Dim medicareTaxTotal As Decimal
        medicareTaxTotal = GrossPay(hoursWorked, payRate) * medicareTaxRate
        Return medicareTaxTotal
    End Function

    Private Function netPay(ByVal totalMichiganTax As Decimal, ByVal totalSocialSecurityTax As Decimal, ByVal totalMedicareTax As Decimal, ByVal newGrossPay As Decimal) As Decimal
        Dim totalTax As Decimal
        Dim finalNet As Decimal
        totalTax = totalMichiganTax + totalSocialSecurityTax + totalMedicareTax
        finalNet = newGrossPay - totalTax
        Return finalNet
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
