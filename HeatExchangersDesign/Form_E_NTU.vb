Public Class Form_E_NTU
    Public Cq_Tube, Cq_Shell As Single
    Private Sub Form_E_NTU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NewImage As Image = Image.FromFile("G:\Graduation Project\HeatExchangersDesign\HeatExchangersDesign\Images\IMG_2_1.jpg")
        PictureBox_E_NTU.Image = NewImage
        ComboBox_MixedType.Text = ComboBox_MixedType.Items(0)
        TextBox_Cr.Text = Format(Min(Cq_Shell, Cq_Tube) / Max(Cq_Tube, Cq_Shell), "#.##")
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        If TextBox_Effectiveness.ReadOnly = True Then
            If TextBox_NTU.Text = Nothing Then
                MsgBox("请查图后输入传热单元数！",, "提示")
            Else
                NTU = Val(TextBox_NTU.Text)
                Me.Close()
            End If
        Else
            If TextBox_Effectiveness.Text = Nothing Then
                MsgBox("请查图后输入换热器效能！",, "提示")
            Else
                Effectiveness = Val(TextBox_Effectiveness.Text)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ComboBox_MixedType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_MixedType.SelectedIndexChanged
        If ComboBox_MixedType.Text = "管侧混合" Then
            TextBox_Cr.Text = Format(Cq_Tube / Cq_Shell, "#.##")
        ElseIf ComboBox_MixedType.Text = "壳侧混合" Then
            TextBox_Cr.Text = Format(Cq_Shell / Cq_Tube, "#.##")
        Else
            TextBox_Cr.Text = Format(Min(Cq_Shell, Cq_Tube) / Max(Cq_Tube, Cq_Shell), "#.##")
        End If
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Effectiveness = 0
        NTU = 0
        Me.Close()
    End Sub
End Class