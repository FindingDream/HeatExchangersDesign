Module Module_Modify
    Public P, R, ModifiedCoefficient As Single
    Public Function TemperatureModify(ByVal Tube_inTemperature As Single, ByVal Tube_outTemperature As Single, ByVal Shell_inTemperature As Single, ByVal Shell_outTemperature As Single) As Single
        P = (Tube_outTemperature - Tube_inTemperature) / (Shell_inTemperature - Tube_inTemperature)
        R = (Shell_inTemperature - Shell_outTemperature) / (Tube_outTemperature - Tube_inTemperature)
        Dim NewForm As New Form_TemperatureModify
        NewForm.ShowDialog()
        Return ModifiedCoefficient
    End Function

    Public Effectiveness, NTU As Single
    Public Function E_To_NTU(ByVal Cq_Tube As Single, ByVal Cq_Shell As Single, ByVal Effectiveness As Single) As Single
        Dim NewForm As New Form_E_NTU
        NewForm.Cq_Tube = Cq_Tube
        NewForm.Cq_Shell = Cq_Shell
        NewForm.TextBox_Effectiveness.ReadOnly = True
        NewForm.TextBox_Effectiveness.Text = Format(Effectiveness, "#.##")
        NewForm.ShowDialog()
        Return NTU
    End Function
    Public Function NTU_To_E(ByVal Cq_Tube As Single, ByVal Cq_Shell As Single, ByVal NTU As Single) As Single
        Dim NewForm As New Form_E_NTU
        NewForm.Cq_Tube = Cq_Tube
        NewForm.Cq_Shell = Cq_Shell
        NewForm.TextBox_NTU.ReadOnly = True
        NewForm.TextBox_NTU.Text = Format(NTU, "#.##")
        NewForm.ShowDialog()
        Return Effectiveness
    End Function
End Module
