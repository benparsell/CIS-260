'Author: Ben Parsell
'Date: Feb 2 2016
'Project: Lab 3 Test Scores

Option Strict On
Public Class Lab3
    Dim numScores As Integer
    Dim sumScores As Double
    Dim bestScore As Double
    Dim worstScore As Double = 100
    Dim letterGrade As String
    Dim averageScore As Double

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click


        If txtTestScore.Text = "" Then
            MsgBox("Cannot leave Test Score blank", , "Error")
            txtTestScore.SelectAll()
        ElseIf IsNumeric(txtTestScore.Text) = False Then
            MsgBox("Please enter a valid number for Test Score", , "Error")
            txtTestScore.SelectAll()
        ElseIf Convert.ToDouble(txtTestScore.Text) < 0 Or Convert.ToDouble(txtTestScore.Text) > 100 Then
            MsgBox("Please enter number between 0-100 for Test Score", , "Error")
            txtTestScore.SelectAll()
        Else
            numScores = numScores + 1
            txtNumScores.Text = Convert.ToString(numScores)

            sumScores = sumScores + Convert.ToDouble(txtTestScore.Text)

            averageScore = Math.Round(sumScores / numScores, 1)
            txtAverageScore.Text = Convert.ToString(averageScore)

            Select Case averageScore
                Case Is > 93.49
                    letterGrade = "A"
                Case Is > 89.49
                    letterGrade = "A-"
                Case Is > 86.49
                    letterGrade = "B+"
                Case Is > 82.49
                    letterGrade = "B"
                Case Is > 79.49
                    letterGrade = "B-"
                Case Is > 76.49
                    letterGrade = "C+"
                Case Is > 72.49
                    letterGrade = "C"
                Case Is > 69.49
                    letterGrade = "C-"
                Case Is > 66.49
                    letterGrade = "D+"
                Case Is > 59.49
                    letterGrade = "D"
                Case 0 To 59
                    letterGrade = "F"
            End Select
            txtLetterGrade.Text = letterGrade

            Dim testScore As Double = Convert.ToDouble(txtTestScore.Text)

            bestScore = Math.Max(bestScore, testScore)
            txtBestScore.Text = Convert.ToString(bestScore)

            worstScore = Math.Min(worstScore, testScore)
            txtWorstScore.Text = Convert.ToString(worstScore)

            txtTestScore.SelectAll()
        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtBestScore.Text = ""
        txtWorstScore.Text = ""
        txtLetterGrade.Text = ""
        txtAverageScore.Text = ""
        txtNumScores.Text = ""
        txtTestScore.Text = ""

        sumScores = 0
        bestScore = 0
        worstScore = 100
        numScores = 0
        txtTestScore.Focus()
    End Sub
End Class
