Public Class Form_TemperatureModify
    Dim Image0 As Image = Image.FromFile("G:\Graduation Project\HeatExchangersDesign\HeatExchangersDesign\Images\IMG_1_1.jpg")
    Dim Image1 As Image = Image.FromFile("G:\Graduation Project\HeatExchangersDesign\HeatExchangersDesign\Images\IMG_1_2.jpg")
    Dim Image2 As Image = Image.FromFile("G:\Graduation Project\HeatExchangersDesign\HeatExchangersDesign\Images\IMG_1_3.jpg")
    Dim Image3 As Image = Image.FromFile("G:\Graduation Project\HeatExchangersDesign\HeatExchangersDesign\Images\IMG_1_4.jpg")

    Private Sub Form_TemperatureModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_FlowType.Text = ComboBox_FlowType.Items(0)
        PictureBox_ModifiedCoefficient.Image = Image0
        TextBox_R.Text = Format(R, "#.##")
        TextBox_P.Text = Format(P, "#.##")
        TextBox_1R.Text = Format(1.0 / R, "#.##")
        TextBox_PR.Text = Format(P * R, "#.##")
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        If TextBox_ModifiedCoefficient.Text = Nothing Then
            MsgBox("请查图后输入温差修正系数！",, "提示")
        Else
            ModifiedCoefficient = Val(TextBox_ModifiedCoefficient.Text)
            Me.Close()
        End If
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub ComboBox_FlowType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_FlowType.SelectedIndexChanged
        Select Case ComboBox_FlowType.SelectedIndex
            Case 0
                PictureBox_ModifiedCoefficient.Image = Image0
            Case 1
                PictureBox_ModifiedCoefficient.Image = Image1
            Case 2
                PictureBox_ModifiedCoefficient.Image = Image2
            Case 3
                PictureBox_ModifiedCoefficient.Image = Image3
        End Select
    End Sub
End Class