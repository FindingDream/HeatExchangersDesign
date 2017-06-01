Public Class Form_Check_LMTD
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
        TextBox_TemperatureDifference.Text = ""
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

        Dim Cp_Tube, Cp_Shell, Fai As Single

        If TextBox_Tube_outTemperature.Text <> Nothing Then
            Do
                Cp_Tube = Cp(ComboBox_Tube_Fluid.SelectedIndex, (Val(TextBox_Tube_inTemperature.Text) + Val(TextBox_Tube_outTemperature.Text)) / 2)
                Cp_Shell = Cp(ComboBox_Shell_Fluid.SelectedIndex, Val(TextBox_Shell_inTemperature.Text))
                TextBox_Shell_outTemperature.Text = Format((Val(TextBox_Shell_inTemperature.Text) + (Val(TextBox_Tube_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)) * Cp_Tube * Val(TextBox_Tube_Flux.Text) / Cp_Shell / Val(TextBox_Shell_Flux.Text)), "#.##")
                Fai = Val(TextBox_Tube_Flux.Text) * Cp_Tube * Math.Abs(Val(TextBox_Tube_inTemperature.Text) - Val(TextBox_Tube_outTemperature.Text)) * 1000 / 3.6

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

                TextBox_HeatTransferRate.Text = Format(Val(TextBox_HeatTransferArea.Text) * Val(TextBox_TemperatureDifference.Text) * Val(TextBox_OverallHeatTransferCoefficient.Text), "#.##")

                If Math.Abs(Val(TextBox_HeatTransferRate.Text) - Fai) / Fai <= 0.02 Then
                    Exit Do
                Else
                    TextBox_Tube_outTemperature.Text = Format((Val(TextBox_Tube_outTemperature.Text) + Val(TextBox_Tube_inTemperature.Text) +
                                        IIf(Val(TextBox_Tube_inTemperature.Text) > Val(TextBox_Tube_outTemperature.Text), -1, 1) *
                                        Val(TextBox_HeatTransferRate.Text) * 3.6 / Cp_Tube / Val(TextBox_Tube_Flux.Text) / 1000) / 2, "#.##")
                End If
            Loop
        ElseIf TextBox_Shell_outTemperature.Text <> Nothing Then
            Do
                Cp_Tube = Cp(ComboBox_Tube_Fluid.SelectedIndex, Val(TextBox_Tube_inTemperature.Text))
                Cp_Shell = Cp(ComboBox_Shell_Fluid.SelectedIndex, （Val(TextBox_Shell_inTemperature.Text) + Val(TextBox_Shell_outTemperature.Text)) / 2)
                TextBox_Tube_outTemperature.Text = Format((Val(TextBox_Tube_inTemperature.Text) + (Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Shell_outTemperature.Text)) * Cp_Shell * Val(TextBox_Shell_Flux.Text) / Cp_Tube / Val(TextBox_Tube_Flux.Text)), "#.##")
                Fai = Val(TextBox_Shell_Flux.Text) * Cp_Shell * Math.Abs(Val(TextBox_Shell_inTemperature.Text) - Val(TextBox_Shell_outTemperature.Text)) * 1000 / 3.6

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

                TextBox_HeatTransferRate.Text = Format(Val(TextBox_HeatTransferArea.Text) * Val(TextBox_TemperatureDifference.Text) * Val(TextBox_OverallHeatTransferCoefficient.Text), "#.##")

                If Math.Abs(Val(TextBox_HeatTransferRate.Text) - Fai) / Fai <= 0.02 Then
                    Exit Do
                Else
                    TextBox_Shell_outTemperature.Text = Format((Val(TextBox_Shell_outTemperature.Text) + Val(TextBox_Shell_inTemperature.Text) +
                                        IIf(Val(TextBox_Shell_inTemperature.Text) > Val(TextBox_Shell_outTemperature.Text), -1, 1) *
                                        Val(TextBox_HeatTransferRate.Text) * 3.6 / Cp_Shell / Val(TextBox_Shell_Flux.Text) / 1000) / 2, "#.##")
                End If
            Loop
        Else
            MsgBox("请先假设一个出口温度！",, "提示")
        End If
    End Sub
End Class