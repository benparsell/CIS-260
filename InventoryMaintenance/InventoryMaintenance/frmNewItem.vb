'Author: Ben Parsell
'Project: Lab 10
'Date: 4/5/2016
Public Class frmNewItem

    Public InvItem As InvItem

    Private Sub btnSave_Click(sender As Object,
            e As EventArgs) Handles btnSave.Click
        If IsValidData() Then
            If (rdoPlant.Checked) Then

                InvItem = New Plant(CInt(txtItemNo.Text),
                                      txtDescription.Text, CDec(txtPrice.Text), cboSizeOrManufacturer.SelectedItem.ToString)
            Else
                InvItem = New Manufacturer(CInt(txtItemNo.Text),
                                       txtDescription.Text, CDec(txtPrice.Text), cboSizeOrManufacturer.SelectedItem.ToString)
            End If
            Me.Close()
        End If
    End Sub

    Private Function IsValidData() As Boolean
        Return Validator.IsPresent(txtItemNo) AndAlso
               Validator.IsInt32(txtItemNo) AndAlso
               Validator.IsPresent(txtDescription) AndAlso
               Validator.IsPresent(txtPrice) AndAlso
               Validator.IsDecimal(txtPrice)
    End Function

    Private Sub btnCancel_Click(sender As Object,
            e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboSizeOrManufacturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdoPlant.CheckedChanged, rdoSupply.CheckedChanged
        cboSizeOrManufacturer.Items.Clear()
        If rdoPlant.Checked Then
            lblSizeOrManufacturer.Text = "Size"
            cboSizeOrManufacturer.Items.Add("1 gallon")
            cboSizeOrManufacturer.Items.Add("5 gallon")
            cboSizeOrManufacturer.Items.Add("15 gallon")
            cboSizeOrManufacturer.Items.Add("24-inch box")
            cboSizeOrManufacturer.Items.Add("36-inch box")
        Else
            lblSizeOrManufacturer.Text = "Manufacturer"
            cboSizeOrManufacturer.Items.Add("Bayer")
            cboSizeOrManufacturer.Items.Add("Jobe's")
            cboSizeOrManufacturer.Items.Add("Ortho")
            cboSizeOrManufacturer.Items.Add("Roundup")
            cboSizeOrManufacturer.Items.Add("Scotts")
        End If

    End Sub
End Class