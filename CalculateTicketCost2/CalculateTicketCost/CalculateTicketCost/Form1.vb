'Author: Ben Parsell
'Project: Homework 4
'Date: February 9, 2016
Option Strict On
Public Class frmCalculateGrade

    Const huntingtonTicketCost As Decimal = 25
    Const priorityTicketCost As Decimal = 18
    Const reservedTicketCost As Decimal = 15
    Const espnTicketCost As Decimal = 12
    Const vistorTicketCost As Decimal = 18
    Const studentTicketCost As Decimal = 0S
    Const michiganTax As Decimal = 0.06D
    Const discountReservedPrice As Decimal = 14
    Const discountPriorityReservedPrice As Decimal = 17

    Dim huntingtonInput As Integer
    Dim priorityInput As Integer
    Dim reservedInput As Integer
    Dim espnInput As Integer
    Dim visitorInput As Integer
    Dim studentInput As Integer

    Dim huntingtonOutput As Decimal
    Dim priorityOutput As Decimal
    Dim reservedOutput As Decimal
    Dim espnOutput As Decimal
    Dim visitorOutput As Decimal
    Dim studentOutput As Decimal
    Dim ticketTotal As Decimal

    Dim taxTotal As Decimal
    Dim finalTotal As Decimal
    Dim finalDiscount As Decimal


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearTextboxes(Me.GroupBox2)
        ClearTextboxes2(Me.GroupBox1)
        ClearTextboxes3(Me.GroupBox3)
    End Sub

    Private Sub ClearTextboxes(ByVal GroupBox2 As Control)

        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is TextBox Then

                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl

        txtDiscount.Visible = False
        lblTotalDiscount.Visible = False
        txtHuntingtonClubNum.Focus()
    End Sub

    Private Sub ClearTextboxes2(ByVal GroupBox1 As Control)

        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then

                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl

    End Sub
    Private Sub ClearTextboxes3(ByVal GroupBox3 As Control)

        For Each ctrl As Control In GroupBox3.Controls
            If TypeOf ctrl Is TextBox Then

                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is TextBox And ctrl.Text = "" Then
                CType(ctrl, TextBox).Text = "0"
            End If
        Next ctrl

        If Not IsNumeric(txtHuntingtonClubNum.Text) Then
            MsgBox("Huntington Tickets must be a number", , "Error")
            txtHuntingtonClubNum.Focus()
            txtHuntingtonClubNum.SelectAll()
        ElseIf (Convert.ToInt32(txtHuntingtonClubNum.Text) > 50) Then
            MsgBox("Huntington Tickets have to be smaller than 51", , "Error")
            txtHuntingtonClubNum.Focus()
            txtHuntingtonClubNum.SelectAll()
        ElseIf (Convert.ToInt32(txtHuntingtonClubNum.Text) < 0) Then
            MsgBox("Huntington Tickets have to be greater than 0", , "Error")
            txtHuntingtonClubNum.Focus()
            txtHuntingtonClubNum.SelectAll()

        ElseIf Not IsNumeric(txtPriorityReservedNum.Text) Then
            MsgBox("Priority Reserved must be a number", , "Error")
            txtPriorityReservedNum.Focus()
            txtPriorityReservedNum.SelectAll()
        ElseIf (Convert.ToInt32(txtPriorityReservedNum.Text) > 50) Then
            MsgBox("Priority Reserved Tickets have to be smaller than 51", , "Error")
            txtPriorityReservedNum.Focus()
            txtPriorityReservedNum.SelectAll()
        ElseIf (Convert.ToInt32(txtPriorityReservedNum.Text) < 0) Then
            MsgBox("Priority Reserved Tickets have to be greater than 0", , "Error")
            txtPriorityReservedNum.Focus()
            txtPriorityReservedNum.SelectAll()
            


        ElseIf Not IsNumeric(txtReservedNum.Text) Then
            MsgBox("Reserved Tickets must be a number", , "Error")
            txtReservedNum.Focus()
            txtReservedNum.SelectAll()
        ElseIf (Convert.ToInt32(txtReservedNum.Text) > 50) Then
            MsgBox("Reserved Tickets have to be smaller than 51", , "Error")
            txtReservedNum.Focus()
            txtReservedNum.SelectAll()
        ElseIf (Convert.ToInt32(txtReservedNum.Text) < 0) Then
            MsgBox("Reserved Tickets have to be greater than 0", , "Error")
            txtReservedNum.Focus()
            txtReservedNum.SelectAll()

        ElseIf Not IsNumeric(txtESPNNum.Text) Then
            MsgBox("ESPN Tickets must be a number", , "Error")
            txtESPNNum.Focus()
            txtESPNNum.SelectAll()
        ElseIf (Convert.ToInt32(txtESPNNum.Text) > 50) Then
            MsgBox("ESPN Tickets have to be smaller than 51", , "Error")
            txtESPNNum.Focus()
            txtESPNNum.SelectAll()
        ElseIf (Convert.ToInt32(txtESPNNum.Text) < 0) Then
            MsgBox("ESPN Tickets have to be greater than 0", , "Error")
            txtESPNNum.Focus()
            txtESPNNum.SelectAll()


        ElseIf Not IsNumeric(txtVisitingTeamNum.Text) Then
            MsgBox("Visiting Tickets must be a number", , "Error")
            txtVisitingTeamNum.Focus()
            txtVisitingTeamNum.SelectAll()
        ElseIf (Convert.ToInt32(txtVisitingTeamNum.Text) > 50) Then
            MsgBox("Visiting Tickets have to be smaller than 51", , "Error")
            txtVisitingTeamNum.Focus()
            txtVisitingTeamNum.SelectAll()
        ElseIf (Convert.ToInt32(txtVisitingTeamNum.Text) < 0) Then
            MsgBox("Visiting Tickets have to be greater than 0", , "Error")
            txtVisitingTeamNum.Focus()
            txtVisitingTeamNum.SelectAll()


        ElseIf Not IsNumeric(txtStudentNum.Text) Then
            MsgBox("Student Tickets must be a number", , "Error")
            txtStudentNum.Focus()
            txtStudentNum.SelectAll()
        ElseIf (Convert.ToInt32(txtStudentNum.Text) > 50) Then
            MsgBox("Student  Tickets have to be smaller than 51", , "Error")
            txtStudentNum.Focus()
            txtStudentNum.SelectAll()
        ElseIf (Convert.ToInt32(txtStudentNum.Text) < 0) Then
            MsgBox("Student  Tickets have to be greater than 0", , "Error")
            txtStudentNum.Focus()
            txtStudentNum.SelectAll()

        Else
            huntingtonInput = Convert.ToInt32(txtHuntingtonClubNum.Text)
            priorityInput = Convert.ToInt32(txtPriorityReservedNum.Text)
            reservedInput = Convert.ToInt32(txtReservedNum.Text)
            espnInput = Convert.ToInt32(txtESPNNum.Text)
            visitorInput = Convert.ToInt32(txtVisitingTeamNum.Text)
            studentInput = Convert.ToInt32(txtStudentNum.Text)


            If reservedInput >= 21 And priorityInput >= 21 Then
                reservedOutput = reservedInput * discountReservedPrice
                priorityOutput = priorityInput * discountPriorityReservedPrice
                finalDiscount = ((reservedInput * reservedTicketCost) - (reservedInput * discountReservedPrice)) + ((priorityInput * priorityTicketCost) - (priorityInput * discountPriorityReservedPrice))
                txtDiscount.Text = FormatCurrency(finalDiscount)
                txtDiscount.Visible = True
                lblTotalDiscount.Visible = True
            ElseIf reservedInput >= 21 Then
                reservedOutput = reservedInput * discountReservedPrice
                finalDiscount = ((reservedInput * reservedTicketCost) - (reservedInput * discountReservedPrice))
                txtDiscount.Text = FormatCurrency(finalDiscount)
                txtDiscount.Visible = True
                lblTotalDiscount.Visible = True
            ElseIf priorityInput >= 21 Then
                priorityOutput = priorityInput * discountPriorityReservedPrice
                finalDiscount = ((priorityInput * priorityTicketCost) - (priorityInput * discountPriorityReservedPrice))
                txtDiscount.Text = FormatCurrency(finalDiscount)
                txtDiscount.Visible = True
                lblTotalDiscount.Visible = True
            Else
                priorityOutput = priorityInput * priorityTicketCost
                reservedOutput = reservedInput * reservedTicketCost
            End If

            huntingtonOutput = huntingtonInput * huntingtonTicketCost
            espnOutput = espnInput * espnTicketCost
            visitorOutput = visitorInput * vistorTicketCost
            studentOutput = studentInput * studentTicketCost

            ticketTotal = huntingtonOutput + priorityOutput + reservedOutput + espnOutput + visitorOutput + studentOutput

            txtHuntingtonClubPrice.Text = FormatNumber(huntingtonOutput)
            txtPriorityReservedPrice.Text = FormatNumber(priorityOutput)
            txtReservedPrice.Text = FormatNumber(reservedOutput)
            txtESPNPrice.Text = FormatNumber(espnOutput)
            txtVisitingTeamPrice.Text = FormatNumber(visitorOutput)
            txtStudentPrice.Text = FormatNumber(studentOutput)

            txtTotal.Text = FormatCurrency(ticketTotal)

            taxTotal = ticketTotal * michiganTax
            txtSalesTax.Text = FormatCurrency(taxTotal)

            finalTotal = ticketTotal + taxTotal
            txtFinalTotal.Text = FormatCurrency(finalTotal)

            btnClear.Focus()
        End If


    End Sub

    Private Sub txtHuntingtonClubNum_GotFocus(sender As Object, e As EventArgs) Handles txtHuntingtonClubNum.GotFocus
        txtHuntingtonClubNum.SelectAll()
    End Sub

    Private Sub txtPriorityReservedNum_GotFocus(sender As Object, e As EventArgs) Handles txtPriorityReservedNum.GotFocus
        txtPriorityReservedNum.SelectAll()
    End Sub

    Private Sub txtReservedNum_GotFocus(sender As Object, e As EventArgs) Handles txtReservedNum.GotFocus
        txtPriorityReservedNum.SelectAll()
    End Sub

    Private Sub txtESPNNum_GotFocus(sender As Object, e As EventArgs) Handles txtESPNNum.GotFocus
        txtESPNNum.SelectAll()
    End Sub

    Private Sub txtVisitingTeamNum_GotFocus(sender As Object, e As EventArgs) Handles txtVisitingTeamNum.GotFocus
        txtVisitingTeamNum.SelectAll()
    End Sub

    Private Sub txtStudentNum_GotFocus(sender As Object, e As EventArgs) Handles txtStudentNum.GotFocus
        txtStudentNum.SelectAll()
    End Sub

    Private Sub frmCalculateGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtVisitingTeamNum_TextChanged(sender As Object, e As EventArgs) Handles txtVisitingTeamNum.TextChanged
        ClearTextboxes(GroupBox2)
        ClearTextboxes(GroupBox3)
    End Sub

    Private Sub txtHuntingtonClubNum_TextChanged(sender As Object, e As EventArgs) Handles txtHuntingtonClubNum.TextChanged
        ClearTextboxes(GroupBox2)
        ClearTextboxes(GroupBox3)
    End Sub

    Private Sub txtPriorityReservedNum_TextChanged(sender As Object, e As EventArgs) Handles txtPriorityReservedNum.TextChanged
        ClearTextboxes(GroupBox2)
        ClearTextboxes(GroupBox3)
    End Sub

    Private Sub txtReservedNum_TextChanged(sender As Object, e As EventArgs) Handles txtReservedNum.TextChanged
        ClearTextboxes(GroupBox2)
        ClearTextboxes(GroupBox3)
    End Sub

    Private Sub txtESPNNum_TextChanged(sender As Object, e As EventArgs) Handles txtESPNNum.TextChanged
        ClearTextboxes(GroupBox2)
        ClearTextboxes(GroupBox3)
    End Sub

    Private Sub txtStudentNum_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNum.TextChanged
        ClearTextboxes(GroupBox2)
        ClearTextboxes(GroupBox3)
    End Sub
End Class
