Public Class frmLab0

    Private Sub frmLab0_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        Me.ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color


    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Me.txtPay.Text = Me.txtHours.Text + Me.txtRate.Text

    End Sub
End Class
