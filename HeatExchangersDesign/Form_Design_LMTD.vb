Public Class Form_Design_LMTD
    Private Sub Form_Design_LMTD_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox_Tube_Fluid.Text = ComboBox_Tube_Fluid.Items(0)
        ComboBox_Shell_Fluid.Text = ComboBox_Shell_Fluid.Items(0)
        ComboBox_FlowType.Text = ComboBox_FlowType.Items(0)

        TextBox_Tube_Flux.Text = "6.696"
        TextBox_Tube_inTemperature.Text = "92.3"
        TextBox_Tube_outTemperature.Text = "58.51"
        TextBox_Shell_Flux.Text = "13.6"
        TextBox_Shell_inTemperature.Text = "37.8"
        TextBox_InnerTubeDiameter.Text = "14"
        TextBox_OuterTubeDiameter.Text = "16"
        TextBox_Shell_h.Text = "3958"
        TextBox_Tube_h.Text = "2800"
    End Sub

    Private Sub Button_Clean_Click(sender As Object, e As EventArgs) Handles Button_Clean.Click
        TextBox_Tube_Flux.Text = ""
        TextBox_Tube_inTemperature.Text = ""
        TextBox_Tube_outTemperature.Text = ""
        TextBox_Shell_Flux.Text = ""
        TextBox_Shell_inTemperature.Text = ""
        TextBox_Shell_outTemperature.Text = ""
        TextBox_InnerTubeDiameter.Text = ""
        TextBox_OuterTubeDiameter.Text = ""
        TextBox_TemperatureDifference.Text = ""
        TextBox_Tube_h.Text = ""
        TextBox_Tube_Rf.Text = ""
        TextBox_Shell_h.Text = ""
        TextBox_Shell_Rf.Text = ""
        TextBox_ThermalConductivity.Text = ""
        TextBox_OverallHeatTransferCoefficient.Text = ""
        TextBox_HeatTransferArea.Text = ""
        ComboBox_Tube_Fluid.Focus()
    End Sub

    Private Sub Button_Calculate_Click(sender As Object, e As EventArgs) Handles Button_Calculate.Click
        Dim Cp_Tube, Cp_Shell As Single
        If TextBox_Tube_Flux.Text = Nothing Then
            MsgBox("请输入管侧流体流量！",, "提示")
            TextBox_Tube_Flux.Focus()
            Return
        End If

        If TextBox_Shell_Flux.Text = Nothing Then
            MsgBox("请输入壳侧流体流量！",, "提示")
            TextBox_Shell_Flux.Focus()
            Return
        End If

        If TextBox_Tube_inTemperature.Text <> "" And TextBox_Tube_outTemperature.Text <> "" And TextBox_Shell_inTemperature.Text <> "" Then
            Cp_Tube = Cp(ComboBox_Tube_Fluid.SelectedIndex, (Val(TextBox_Tube_inTemperature.Text) + Val(TextBox_Tube_outTemperature.Text)) / 2)
            Cp_Shell = Cp(ComboBox_Shell_Fluid.SelectedIndex, Val(TextBox_Shell_inTemperature.Text))
            TextBox_Shell_outTemperature.Text = Format((Val(TextBox_Shell_inTemperature.Text) + (Val(TextBox_Tube_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)) * Cp_Tube * Val(TextBox_Tube_Flux.Text) / Cp_Shell / Val(TextBox_Shell_Flux.Text)), "#.##")
        ElseIf TextBox_Tube_inTemperature.Text <> "" And TextBox_Tube_outTemperature.Text <> "" And TextBox_Shell_outTemperature.Text <> "" Then
            Cp_Tube = Cp(ComboBox_Tube_Fluid.SelectedIndex, (Val(TextBox_Tube_inTemperature.Text) + Val(TextBox_Tube_outTemperature.Text)) / 2)
            Cp_Shell = Cp(ComboBox_Shell_Fluid.SelectedIndex, Val(TextBox_Shell_outTemperature.Text))
            TextBox_Shell_inTemperature.Text = Format((Val(TextBox_Shell_outTemperature.Text) - (Val(TextBox_Tube_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)) * Cp_Tube * Val(TextBox_Tube_Flux.Text) / Cp_Shell / Val(TextBox_Shell_Flux.Text)), "#.##")
        ElseIf TextBox_Tube_inTemperature.Text <> "" And TextBox_Shell_inTemperature.Text <> "" And TextBox_Shell_outTemperature.Text <> "" Then
            Cp_Tube = Cp(ComboBox_Tube_Fluid.SelectedIndex, Val(TextBox_Tube_inTemperature.Text))
            Cp_Shell = Cp(ComboBox_Shell_Fluid.SelectedIndex, (Val(TextBox_Shell_inTemperature.Text) + Val(TextBox_Shell_outTemperature.Text)) / 2)
            TextBox_Tube_outTemperature.Text = Format((Val(TextBox_Tube_inTemperature.Text) + (Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Shell_outTemperature.Text)) * Cp_Shell * Val(TextBox_Shell_Flux.Text) / Cp_Tube / Val(TextBox_Tube_Flux.Text)), "#.##")
        ElseIf TextBox_Tube_outTemperature.Text <> "" And TextBox_Shell_inTemperature.Text <> "" And TextBox_Shell_outTemperature.Text <> "" Then
            Cp_Tube = Cp(ComboBox_Tube_Fluid.SelectedIndex, Val(TextBox_Tube_outTemperature.Text))
            Cp_Shell = Cp(ComboBox_Shell_Fluid.SelectedIndex, (Val(TextBox_Shell_inTemperature.Text) + Val(TextBox_Shell_outTemperature.Text)) / 2)
            TextBox_Tube_inTemperature.Text = Format((Val(TextBox_Tube_outTemperature.Text) - (Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Shell_outTemperature.Text)) * Cp_Shell * Val(TextBox_Shell_Flux.Text) / Cp_Tube / Val(TextBox_Tube_Flux.Text)), "#.##")
        Else
            MsgBox("温度数据不足，请至少输入三个温度数据！",, "提示")
            Return
        End If

        If TextBox_InnerTubeDiameter.Text = Nothing Then
            MsgBox("请输入内管径！",, "提示")
            TextBox_InnerTubeDiameter.Focus()
            Return
        End If

        If TextBox_OuterTubeDiameter.Text = Nothing Then
            MsgBox("请输入外管径！",, "提示")
            TextBox_OuterTubeDiameter.Focus()
            Return
        End If

        If TextBox_Shell_h.Text = Nothing Then
            MsgBox("请输入壳侧对流换热系数！",, "提示")
            TextBox_Shell_h.Focus()
            Return
        End If

        If TextBox_Tube_h.Text = Nothing Then
            MsgBox("请输入管侧对流换热系数！",, "提示")
            TextBox_Tube_h.Focus()
            Return
        End If

        If TextBox_ThermalConductivity.Text = Nothing Or TextBox_ThermalConductivity.Text = "0" Then
            TextBox_OverallHeatTransferCoefficient.Text = Format((1.0 / (Val(TextBox_OuterTubeDiameter.Text) / Val(TextBox_InnerTubeDiameter.Text) *
                (Val(TextBox_Tube_Rf.Text) + 1.0 / Val(TextBox_Tube_h.Text)) + 1.0 / Val(TextBox_Shell_h.Text) + Val(TextBox_Shell_Rf.Text))), "#.##")
        Else
            TextBox_OverallHeatTransferCoefficient.Text = Format((1.0 / (Val(TextBox_OuterTubeDiameter.Text) / Val(TextBox_InnerTubeDiameter.Text) *
                (Val(TextBox_Tube_Rf.Text) + 1.0 / Val(TextBox_Tube_h.Text)) + 1.0 / Val(TextBox_Shell_h.Text) + Val(TextBox_Shell_Rf.Text) +
                Val(TextBox_OuterTubeDiameter.Text) / 2000.0 / Val(TextBox_ThermalConductivity.Text) *
                Math.Log(Val(TextBox_OuterTubeDiameter.Text) / Val(TextBox_InnerTubeDiameter.Text)))), "#.##")
        End If

        If ComboBox_FlowType.Text = "纯顺流" Then
            TextBox_TemperatureDifference.Text = Format(((Max(Val(TextBox_Tube_inTemperature.Text), Val(TextBox_Shell_inTemperature.Text)) - Min(Val(TextBox_Tube_inTemperature.Text), Val(TextBox_Shell_inTemperature.Text))) -
                (Max(Val(TextBox_Tube_outTemperature.Text), Val(TextBox_Shell_outTemperature.Text)) - Min(Val(TextBox_Tube_outTemperature.Text), Val(TextBox_Shell_outTemperature.Text)))) /
                System.Math.Log((Max(Val(TextBox_Tube_inTemperature.Text), Val(TextBox_Shell_inTemperature.Text)) - Min(Val(TextBox_Tube_inTemperature.Text), Val(TextBox_Shell_inTemperature.Text))) /
                                (Max(Val(TextBox_Tube_outTemperature.Text), Val(TextBox_Shell_outTemperature.Text)) - Min(Val(TextBox_Tube_outTemperature.Text), Val(TextBox_Shell_outTemperature.Text)))), "#.##")
        ElseIf ComboBox_FlowType.Text = "纯逆流" Then
            TextBox_TemperatureDifference.Text = Format((Max(Math.Abs(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)), Math.Abs(Val(TextBox_Shell_outTemperature.Text) - Val(TextBox_Tube_inTemperature.Text))) -
                Min(Math.Abs(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)), Math.Abs(Val(TextBox_Shell_outTemperature.Text) - Val(TextBox_Tube_inTemperature.Text)))) /
                Math.Log(Max(Math.Abs(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)), Math.Abs(Val(TextBox_Shell_outTemperature.Text) - Val(TextBox_Tube_inTemperature.Text))) /
                Min(Math.Abs(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)), Math.Abs(Val(TextBox_Shell_outTemperature.Text) - Val(TextBox_Tube_inTemperature.Text)))), "#.##")
        Else
            Dim Coefficient As Single
            Coefficient = TemperatureModify(Val(TextBox_Tube_inTemperature.Text), Val(TextBox_Tube_outTemperature.Text),
                                          Val(TextBox_Shell_inTemperature.Text), Val(TextBox_Shell_outTemperature.Text))
            If Coefficient = 0 Then
                Return
            Else
                TextBox_TemperatureDifference.Text = Format(((Max(Math.Abs(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)), Math.Abs(Val(TextBox_Shell_outTemperature.Text) - Val(TextBox_Tube_inTemperature.Text))) -
                Min(Math.Abs(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)), Math.Abs(Val(TextBox_Shell_outTemperature.Text) - Val(TextBox_Tube_inTemperature.Text)))) /
                Math.Log(Max(Math.Abs(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)), Math.Abs(Val(TextBox_Shell_outTemperature.Text) - Val(TextBox_Tube_inTemperature.Text))) /
                Min(Math.Abs(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)), Math.Abs(Val(TextBox_Shell_outTemperature.Text) - Val(TextBox_Tube_inTemperature.Text))))) * Coefficient, "#.##")
            End If
        End If

        TextBox_HeatTransferArea.Text = Format((Math.Abs(Val(TextBox_Tube_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)) * Val(TextBox_Tube_Flux.Text) * Cp_Tube * 1000 / Val(TextBox_TemperatureDifference.Text) / Val(TextBox_OverallHeatTransferCoefficient.Text) / 3.6), "#.##")
    End Sub
End Class