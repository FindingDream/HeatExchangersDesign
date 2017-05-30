Module Module_PhysicalParameter
    Structure Fluid
        Dim Temperature As Single                       't  单位℃
        Dim Specific_HeatCapacity As Single             'Cp 单位kJ/(kg·K)
        Dim ThermalConductivity As Single               'λ*10^2  单位W/(m·K)
        Dim Density As Single                           'ρ  单位kg/m^3
        Dim KineticViscosity As Single                  'ν*10^6  单位m^2/s
        Dim PrandtlNumber As Single                     'Pr 无量纲
        Sub New(ByVal t As Single, ByVal s As Single, ByVal tc As Single, ByVal d As Single, ByVal k As Single, ByVal p As Single)
            Temperature = t
            Specific_HeatCapacity = s
            ThermalConductivity = tc
            Density = d
            KineticViscosity = k
            PrandtlNumber = p
        End Sub
    End Structure

    Public Water() As Fluid = {
        New Fluid(0, 4.212, 55.1, 999.9, 1.789, 13.67), New Fluid(10, 4.191, 57.4, 999.7, 1.306, 9.52),
        New Fluid(20, 4.183, 59.9, 998.2, 1.006, 7.02), New Fluid(30, 4.174, 61.8, 995.7, 0.805, 5.42),
        New Fluid(40, 4.174, 63.5, 992.2, 0.659, 4.31), New Fluid(50, 4.174, 64.8, 988.1, 0.556, 3.54),
        New Fluid(60, 4.179, 65.9, 983.1, 0.478, 2.99), New Fluid(70, 4.187, 66.8, 977.8, 0.415, 2.55),
        New Fluid(80, 4.195, 67.4, 971.8, 0.365, 2.21), New Fluid(90, 4.208, 68.0, 965.3, 0.326, 1.95),
        New Fluid(100, 4.22, 68.3, 958.4, 0.295, 1.75), New Fluid(110, 4.233, 68.5, 951.0, 0.272, 1.6),
        New Fluid(120, 4.25, 68.6, 943.1, 0.252, 1.47), New Fluid(130, 4.266, 68.6, 934.8, 0.233, 1.36),
        New Fluid(140, 4.287, 68.5, 926.1, 0.217, 1.26), New Fluid(150, 4.313, 68.4, 917.0, 0.203, 1.17),
        New Fluid(160, 4.346, 68.3, 907.0, 0.191, 1.1), New Fluid(170, 4.38, 67.9, 897.3, 0.181, 1.05),
        New Fluid(180, 4.417, 67.4, 886.9, 0.173, 1.0), New Fluid(190, 4.459, 67.0, 876.0, 0.165, 0.96),
        New Fluid(200, 4.505, 66.3, 863.0, 0.158, 0.93), New Fluid(210, 4.555, 65.5, 852.3, 0.153, 0.91),
        New Fluid(220, 4.614, 64.5, 840.3, 0.148, 0.89), New Fluid(230, 4.681, 63.7, 827.3, 0.145, 0.88),
        New Fluid(240, 4.756, 62.8, 813.6, 0.141, 0.87), New Fluid(250, 4.844, 61.8, 799.0, 0.137, 0.86),
        New Fluid(260, 4.949, 60.5, 784.0, 0.135, 0.87), New Fluid(270, 5.07, 59.0, 767.9, 0.133, 0.88),
        New Fluid(280, 5.23, 57.4, 750.7, 0.131, 0.9), New Fluid(290, 5.484, 55.8, 732.3, 0.129, 0.93),
        New Fluid(300, 5.736, 54.0, 712.5, 0.128, 0.97), New Fluid(310, 6.071, 52.3, 691.1, 0.128, 1.03),
        New Fluid(320, 6.574, 50.6, 667.1, 0.128, 1.11), New Fluid(330, 7.244, 48.4, 640.2, 0.127, 1.22),
        New Fluid(340, 8.165, 45.7, 610.1, 0.127, 1.39), New Fluid(350, 9.504, 43.0, 574.4, 0.126, 1.6),
        New Fluid(360, 13.984, 39.5, 528.0, 0.126, 2.35), New Fluid(370, 40.321, 33.7, 450.5, 0.126, 6.79)
        }

    Public Air() As Fluid = {
        New Fluid(-50, 1.013, 2.04, 1.584, 9.23, 0.728), New Fluid(-40, 1.013, 2.12, 1.515, 10.04, 0.728),
        New Fluid(-30, 1.013, 2.2, 1.453, 10.8, 0.723), New Fluid(-20, 1.009, 2.28, 1.395, 11.61, 0.716),
        New Fluid(-10, 1.009, 2.36, 1.342, 12.43, 0.712), New Fluid(0, 1.005, 2.44, 1.293, 13.28, 0.707),
        New Fluid(10, 1.005, 2.51, 1.247, 14.16, 0.705), New Fluid(20, 1.005, 2.59, 1.205, 15.06, 0.703),
        New Fluid(30, 1.005, 2.67, 1.165, 16.0, 0.701), New Fluid(40, 1.005, 2.76, 1.128, 16.96, 0.699),
        New Fluid(50, 1.005, 2.83, 1.093, 17.95, 0.698), New Fluid(60, 1.005, 2.9, 1.06, 18.97, 0.696),
        New Fluid(70, 1.009, 2.96, 1.029, 20.02, 0.694), New Fluid(80, 1.009, 3.05, 1.0, 21.09, 0.692),
        New Fluid(90, 1.009, 3.13, 0.972, 22.1, 0.69), New Fluid(100, 1.009, 3.21, 0.946, 23.13, 0.688),
        New Fluid(120, 1.009, 3.34, 0.898, 25.45, 0.686), New Fluid(140, 1.013, 3.49, 0.854, 27.8, 0.684),
        New Fluid(160, 1.017, 3.64, 0.815, 30.09, 0.682), New Fluid(180, 1.022, 3.78, 0.779, 32.49, 0.681),
        New Fluid(200, 1.026, 3.93, 0.746, 34.85, 0.68), New Fluid(250, 1.038, 4.27, 0.674, 40.61, 0.677),
        New Fluid(300, 1.047, 4.6, 0.615, 48.33, 0.674), New Fluid(350, 1.059, 4.91, 0.566, 55.46, 0.676),
        New Fluid(400, 1.068, 5.21, 0.524, 63.09, 0.678), New Fluid(500, 1.093, 5.74, 0.456, 79.38, 0.687),
        New Fluid(600, 1.114, 6.22, 0.404, 96.89, 0.699), New Fluid(700, 1.135, 6.71, 0.362, 115.4, 0.706),
        New Fluid(800, 1.156, 7.18, 0.329, 134.8, 0.713), New Fluid(900, 1.172, 7.63, 0.301, 155.1, 0.717),
        New Fluid(1000, 1.185, 8.07, 0.277, 177.1, 0.719), New Fluid(1100, 1.197, 8.5, 0.257, 199.3, 0.722),
        New Fluid(1200, 1.21, 9.15, 0.239, 233.7, 0.724)
        }

    Public Lubricant11() As Fluid = {
        New Fluid(0, 1.834, 14.49, 905.0, 1336, vbNull), New Fluid(10, 1.872, 14.41, 898.8, 564.2, 15310),
        New Fluid(20, 1.909, 14.32, 892.7, 280.2, 6591), New Fluid(30, 1.947, 14.23, 886.6, 153.2, 3335),
        New Fluid(40, 1.985, 14.14, 880.6, 90.7, 1859), New Fluid(50, 2.022, 14.05, 874.6, 57.4, 1121),
        New Fluid(60, 2.064, 13.96, 868.8, 38.4, 723), New Fluid(70, 2.106, 13.87, 863.1, 27.0, 493),
        New Fluid(80, 2.148, 13.79, 857.4, 19.7, 354), New Fluid(90, 2.19, 13.7, 851.8, 14.9, 263),
        New Fluid(100, 2.236, 13.61, 846.2, 11.5, 203)
        }

    Public Lubricant14() As Fluid = {
        New Fluid(0, 1.866, 14.93, 905.2, 2237, 25310), New Fluid(10, 1.909, 14.85, 899.0, 863.2, 9979),
        New Fluid(20, 1.915, 14.77, 892.8, 410.9, 4846), New Fluid(30, 1.993, 14.7, 886.7, 216.5, 2603),
        New Fluid(40, 2.035, 14.62, 880.7, 124.2, 1522), New Fluid(50, 2.077, 14.54, 874.8, 76.5, 956),
        New Fluid(60, 2.114, 14.46, 869.0, 50.5, 462), New Fluid(70, 2.156, 14.39, 863.2, 34.3, 444),
        New Fluid(80, 2.194, 14.31, 857.5, 24.6, 323), New Fluid(90, 2.227, 14.24, 851.9, 18.3, 244),
        New Fluid(100, 2.265, 14.16, 846.4, 14.0, 190)
        }

    Public Function Max(ByVal ParamArray a())
        Dim Temp As Object = a(0)
        For I = LBound(a) To UBound(a)
            If a(I) > Temp Then
                Temp = a(I)
            End If
        Next I
        Return Temp
    End Function

    Public Function Min(ByVal ParamArray a())
        Dim Temp As Object = a(0)
        For I = LBound(a) To UBound(a)
            If a(I) < Temp Then
                Temp = a(I)
            End If
        Next I
        Return Temp
    End Function

    Public Function Cp(ByVal fluid As Integer, ByVal t As Single) As Single
        Dim X, Y As Integer
        Dim Temp As Single

        Select Case fluid
            Case 0
                X = UBound(Water)
                Y = LBound(Water)
                If t > Water(X).Temperature Or t < Water(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Water(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Water(Y).Specific_HeatCapacity) -
                        (Water(Y).Specific_HeatCapacity - Water(Y - 1).Specific_HeatCapacity) /
                        (Water(Y).Temperature - Water(Y - 1).Temperature) *
                        (Water(Y).Temperature - t)
                End If
            Case 1
                X = UBound(Air)
                Y = LBound(Air)
                If t > Air(X).Temperature Or t < Air(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Air(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Air(Y).Specific_HeatCapacity) -
                        (Air(Y).Specific_HeatCapacity - Air(Y - 1).Specific_HeatCapacity) /
                        (Air(Y).Temperature - Air(Y - 1).Temperature) *
                        (Air(Y).Temperature - t)
                End If
            Case 2
                X = UBound(Lubricant11)
                Y = LBound(Lubricant11)
                If t > Lubricant11(X).Temperature Or t < Lubricant11(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant11(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Lubricant11(Y).Specific_HeatCapacity) -
                        (Lubricant11(Y).Specific_HeatCapacity - Lubricant11(Y - 1).Specific_HeatCapacity) /
                        (Lubricant11(Y).Temperature - Lubricant11(Y - 1).Temperature) *
                        (Lubricant11(Y).Temperature - t)
                End If
            Case 3
                X = UBound(Lubricant14)
                Y = LBound(Lubricant14)
                If t > Lubricant14(X).Temperature Or t < Lubricant14(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant14(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = Lubricant14(Y).Specific_HeatCapacity -
                        (Lubricant14(Y).Specific_HeatCapacity - Lubricant14(Y - 1).Specific_HeatCapacity) /
                        (Lubricant14(Y).Temperature - Lubricant14(Y - 1).Temperature) *
                        (Lubricant14(Y).Temperature - t)
                End If
        End Select
        Return Temp
    End Function

    Public Function Lamda(ByVal fluid As Integer, ByVal t As Single) As Single
        Dim X, Y As Integer
        Dim Temp As Single

        Select Case fluid
            Case 0
                X = UBound(Water)
                Y = LBound(Water)
                If t > Water(X).Temperature Or t < Water(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Water(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Water(Y).ThermalConductivity) -
                        (Water(Y).ThermalConductivity - Water(Y - 1).ThermalConductivity) /
                        (Water(Y).Temperature - Water(Y - 1).Temperature) *
                        (Water(Y).Temperature - t)
                End If
            Case 1
                X = UBound(Air)
                Y = LBound(Air)
                If t > Air(X).Temperature Or t < Air(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Air(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Air(Y).ThermalConductivity) -
                        (Air(Y).ThermalConductivity - Air(Y - 1).ThermalConductivity) /
                        (Air(Y).Temperature - Air(Y - 1).Temperature) *
                        (Air(Y).Temperature - t)
                End If
            Case 2
                X = UBound(Lubricant11)
                Y = LBound(Lubricant11)
                If t > Lubricant11(X).Temperature Or t < Lubricant11(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant11(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Lubricant11(Y).ThermalConductivity) -
                        (Lubricant11(Y).ThermalConductivity - Lubricant11(Y - 1).ThermalConductivity) /
                        (Lubricant11(Y).Temperature - Lubricant11(Y - 1).Temperature) *
                        (Lubricant11(Y).Temperature - t)
                End If
            Case 3
                X = UBound(Lubricant14)
                Y = LBound(Lubricant14)
                If t > Lubricant14(X).Temperature Or t < Lubricant14(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant14(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = Lubricant14(Y).ThermalConductivity -
                        (Lubricant14(Y).ThermalConductivity - Lubricant14(Y - 1).ThermalConductivity) /
                        (Lubricant14(Y).Temperature - Lubricant14(Y - 1).Temperature) *
                        (Lubricant14(Y).Temperature - t)
                End If
        End Select
        Return Temp
    End Function

    Public Function Rho(ByVal fluid As Integer, ByVal t As Single) As Single
        Dim X, Y As Integer
        Dim Temp As Single

        Select Case fluid
            Case 0
                X = UBound(Water)
                Y = LBound(Water)
                If t > Water(X).Temperature Or t < Water(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Water(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Water(Y).Density) -
                        (Water(Y).Density - Water(Y - 1).Density) /
                        (Water(Y).Temperature - Water(Y - 1).Temperature) *
                        (Water(Y).Temperature - t)
                End If
            Case 1
                X = UBound(Air)
                Y = LBound(Air)
                If t > Air(X).Temperature Or t < Air(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Air(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Air(Y).Density) -
                        (Air(Y).Density - Air(Y - 1).Density) /
                        (Air(Y).Temperature - Air(Y - 1).Temperature) *
                        (Air(Y).Temperature - t)
                End If
            Case 2
                X = UBound(Lubricant11)
                Y = LBound(Lubricant11)
                If t > Lubricant11(X).Temperature Or t < Lubricant11(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant11(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Lubricant11(Y).Density) -
                        (Lubricant11(Y).Density - Lubricant11(Y - 1).Density) /
                        (Lubricant11(Y).Temperature - Lubricant11(Y - 1).Temperature) *
                        (Lubricant11(Y).Temperature - t)
                End If
            Case 3
                X = UBound(Lubricant14)
                Y = LBound(Lubricant14)
                If t > Lubricant14(X).Temperature Or t < Lubricant14(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant14(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = Lubricant14(Y).Density -
                        (Lubricant14(Y).Density - Lubricant14(Y - 1).Density) /
                        (Lubricant14(Y).Temperature - Lubricant14(Y - 1).Temperature) *
                        (Lubricant14(Y).Temperature - t)
                End If
        End Select
        Return Temp
    End Function

    Public Function Nv(ByVal fluid As Integer, ByVal t As Single) As Single
        Dim X, Y As Integer
        Dim Temp As Single

        Select Case fluid
            Case 0
                X = UBound(Water)
                Y = LBound(Water)
                If t > Water(X).Temperature Or t < Water(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Water(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Water(Y).KineticViscosity) -
                        (Water(Y).KineticViscosity - Water(Y - 1).KineticViscosity) /
                        (Water(Y).Temperature - Water(Y - 1).Temperature) *
                        (Water(Y).Temperature - t)
                End If
            Case 1
                X = UBound(Air)
                Y = LBound(Air)
                If t > Air(X).Temperature Or t < Air(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Air(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Air(Y).KineticViscosity) -
                        (Air(Y).KineticViscosity - Air(Y - 1).KineticViscosity) /
                        (Air(Y).Temperature - Air(Y - 1).Temperature) *
                        (Air(Y).Temperature - t)
                End If
            Case 2
                X = UBound(Lubricant11)
                Y = LBound(Lubricant11)
                If t > Lubricant11(X).Temperature Or t < Lubricant11(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant11(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Lubricant11(Y).KineticViscosity) -
                        (Lubricant11(Y).KineticViscosity - Lubricant11(Y - 1).KineticViscosity) /
                        (Lubricant11(Y).Temperature - Lubricant11(Y - 1).Temperature) *
                        (Lubricant11(Y).Temperature - t)
                End If
            Case 3
                X = UBound(Lubricant14)
                Y = LBound(Lubricant14)
                If t > Lubricant14(X).Temperature Or t < Lubricant14(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant14(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = Lubricant14(Y).KineticViscosity -
                        (Lubricant14(Y).KineticViscosity - Lubricant14(Y - 1).KineticViscosity) /
                        (Lubricant14(Y).Temperature - Lubricant14(Y - 1).Temperature) *
                        (Lubricant14(Y).Temperature - t)
                End If
        End Select
        Return Temp
    End Function

    Public Function Pr(ByVal fluid As Integer, ByVal t As Single) As Single
        Dim X, Y As Integer
        Dim Temp As Single

        Select Case fluid
            Case 0
                X = UBound(Water)
                Y = LBound(Water)
                If t > Water(X).Temperature Or t < Water(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Water(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Water(Y).PrandtlNumber) -
                        (Water(Y).PrandtlNumber - Water(Y - 1).PrandtlNumber) /
                        (Water(Y).Temperature - Water(Y - 1).Temperature) *
                        (Water(Y).Temperature - t)
                End If
            Case 1
                X = UBound(Air)
                Y = LBound(Air)
                If t > Air(X).Temperature Or t < Air(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Air(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Air(Y).PrandtlNumber) -
                        (Air(Y).PrandtlNumber - Air(Y - 1).PrandtlNumber) /
                        (Air(Y).Temperature - Air(Y - 1).Temperature) *
                        (Air(Y).Temperature - t)
                End If
            Case 2
                X = UBound(Lubricant11)
                Y = LBound(Lubricant11)
                If t > Lubricant11(X).Temperature Or t < Lubricant11(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant11(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = (Lubricant11(Y).PrandtlNumber) -
                        (Lubricant11(Y).PrandtlNumber - Lubricant11(Y - 1).PrandtlNumber) /
                        (Lubricant11(Y).Temperature - Lubricant11(Y - 1).Temperature) *
                        (Lubricant11(Y).Temperature - t)
                End If
            Case 3
                X = UBound(Lubricant14)
                Y = LBound(Lubricant14)
                If t > Lubricant14(X).Temperature Or t < Lubricant14(Y).Temperature Then
                    MsgBox("流体温度超出计算范围，请重新输入",, "提示")
                Else
                    While (t >= Lubricant14(Y).Temperature)
                        Y = Y + 1
                    End While
                    Temp = Lubricant14(Y).PrandtlNumber -
                        (Lubricant14(Y).PrandtlNumber - Lubricant14(Y - 1).PrandtlNumber) /
                        (Lubricant14(Y).Temperature - Lubricant14(Y - 1).Temperature) *
                        (Lubricant14(Y).Temperature - t)
                End If
        End Select
        Return Temp
    End Function

End Module