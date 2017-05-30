Module Module_Modify
    Public P, R, ModifiedCoefficient As Single
    Public Function TemperatureModify(ByVal Tube_inTemperature As Single, ByVal Tube_outTemperature As Single, ByVal Shell_inTemperature As Single, ByVal Shell_outTemperature As Single) As Single
        P = (Tube_outTemperature - Tube_inTemperature) / (Shell_inTemperature - Tube_inTemperature)
        R = (Shell_inTemperature - Shell_outTemperature) / (Tube_outTemperature - Tube_inTemperature)
        Dim NewForm As New Form_TemperatureModify
        NewForm.ShowDialog()
        Return ModifiedCoefficient
    End Function
End Module
