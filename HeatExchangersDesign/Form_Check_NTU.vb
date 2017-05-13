Public Class Form_Check_NTU
    Private Sub Form_Check_LMTD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_Tube_Fluid.Text = ComboBox_Tube_Fluid.Items(0)
        ComboBox_Shell_Fluid.Text = ComboBox_Shell_Fluid.Items(0)
        ComboBox_FlowType.Text = ComboBox_FlowType.Items(0)

        TextBox_Tube_Flux.Text = "6.696"
        TextBox_Tube_inTemperature.Text = "92.3"
        TextBox_Shell_Flux.Text = "13.6"
        TextBox_Shell_inTemperature.Text = "37.8"
        TextBox_HeatTransferArea.Text = "6.13"
        TextBox_OverallHeatTransferCoefficient.Text = "1513.28"
    End Sub

    Private Sub Button_Clean_Click(sender As Object, e As EventArgs) Handles Button_Clean.Click
        TextBox_Tube_Flux.Text = ""
        TextBox_Tube_inTemperature.Text = ""
        TextBox_Shell_Flux.Text = ""
        TextBox_Shell_inTemperature.Text = ""
        TextBox_HeatTransferArea.Text = ""
        TextBox_Tube_outTemperature.Text = ""
        TextBox_Shell_outTemperature.Text = ""
        TextBox_OverallHeatTransferCoefficient.Text = ""
        TextBox_HeatTransferRate.Text = ""
        ComboBox_Tube_Fluid.Focus()
    End Sub

    Private Sub Button_Check_Click(sender As Object, e As EventArgs) Handles Button_Check.Click
        If TextBox_Tube_Flux.Text = Nothing Then
            MsgBox("请输入管侧流体流量！",, "提示")
            TextBox_Tube_Flux.Focus()
            Return
        End If

        If TextBox_Tube_inTemperature.Text = Nothing Then
            MsgBox("请输入管侧流体入口温度！",, "提示")
            TextBox_Tube_inTemperature.Focus()
            Return
        End If

        If TextBox_Shell_Flux.Text = Nothing Then
            MsgBox("请输入壳侧流体流量！",, "提示")
            TextBox_Shell_Flux.Focus()
            Return
        End If

        If TextBox_Shell_inTemperature.Text = Nothing Then
            MsgBox("请输入壳侧流体入口温度！",, "提示")
            TextBox_Shell_inTemperature.Focus()
            Return
        End If

        If TextBox_HeatTransferArea.Text = Nothing Then
            MsgBox("请输入换热面积！",, "提示")
            TextBox_HeatTransferArea.Focus()
            Return
        End If

        If TextBox_OverallHeatTransferCoefficient.Text = Nothing Then
            MsgBox("请输入总传热系数！",, "提示")
            TextBox_OverallHeatTransferCoefficient.Focus()
            Return
        End If

        Dim Cp_Tube, Cp_Shell, Cr, Effectiveness, NTU As Single

        TextBox_Tube_outTemperature.Text = Format((Val(TextBox_Tube_inTemperature.Text) + Val(TextBox_Shell_inTemperature.Text)) / 2, "#.##")

        Cp_Tube = Cp(ComboBox_Tube_Fluid.SelectedIndex, (Val(TextBox_Tube_inTemperature.Text) + Val(TextBox_Tube_outTemperature.Text)) / 2)
        Cp_Shell = Cp(ComboBox_Shell_Fluid.SelectedIndex, Val(TextBox_Shell_inTemperature.Text))

        If Cp_Shell * Val(TextBox_Shell_Flux.Text) > Cp_Tube * Val(TextBox_Tube_Flux.Text) Then
            Cr = (Cp_Tube * Val(TextBox_Tube_Flux.Text)) / (Cp_Shell * Val(TextBox_Shell_Flux.Text))
            NTU = Val(TextBox_OverallHeatTransferCoefficient.Text) * Val(TextBox_HeatTransferArea.Text) / Cp_Tube / Val(TextBox_Tube_Flux.Text) / 1000 * 3.6
        Else
            Cr = (Cp_Shell * Val(TextBox_Shell_Flux.Text)) / (Cp_Tube * Val(TextBox_Tube_Flux.Text))
            NTU = Val(TextBox_OverallHeatTransferCoefficient.Text) * Val(TextBox_HeatTransferArea.Text) / Cp_Shell / Val(TextBox_Shell_Flux.Text) / 1000 * 3.6
        End If

        If ComboBox_FlowType.Text = "顺流" Then
            Effectiveness = (1 - Math.Exp(-NTU * (1 + Cr))) / (1 + Cr)
        Else
            If Cr = 1 Then
                Effectiveness = NTU / (NTU + 1)
            Else
                Effectiveness = (1 - Math.Exp(-NTU * (1 - Cr))) / (1 - Cr * Math.Exp(-NTU * (1 - Cr)))
            End If
        End If

        TextBox_HeatTransferRate.Text = Format(Effectiveness *
                                               Min(Cp_Shell * Val(TextBox_Shell_Flux.Text), Cp_Tube * Val(TextBox_Tube_Flux.Text)) *
                                               1000 / 3.6 *
                                               Math.Abs(Val(TextBox_Tube_inTemperature.Text) -
                                               Val(TextBox_Shell_inTemperature.Text)), "#.##")

        If Val(TextBox_Tube_inTemperature.Text) > Val(TextBox_Shell_inTemperature.Text) Then
            TextBox_Tube_outTemperature.Text = Format(Val(TextBox_Tube_inTemperature.Text) - Val(TextBox_HeatTransferRate.Text) / Cp_Tube / Val(TextBox_Tube_Flux.Text) / 1000 * 3.6, "#.##")
            TextBox_Shell_outTemperature.Text = Format(Val(TextBox_Shell_inTemperature.Text) + Val(TextBox_HeatTransferRate.Text) / Cp_Shell / Val(TextBox_Shell_Flux.Text) / 1000 * 3.6, "#.##")
        Else
            TextBox_Tube_outTemperature.Text = Format(Val(TextBox_Tube_inTemperature.Text) + Val(TextBox_HeatTransferRate.Text) / Cp_Tube / Val(TextBox_Tube_Flux.Text) / 1000 * 3.6, "#.##")
            TextBox_Shell_outTemperature.Text = Format(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_HeatTransferRate.Text) / Cp_Shell / Val(TextBox_Shell_Flux.Text) / 1000 * 3.6, "#.##")
        End If
    End Sub
End Class