<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Check_LMTD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox_Shell = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Shell_Fluid = New System.Windows.Forms.ComboBox()
        Me.TextBox_Shell_Flux = New System.Windows.Forms.TextBox()
        Me.Label_Shell_Flux = New System.Windows.Forms.Label()
        Me.Label_Shell_Fluid = New System.Windows.Forms.Label()
        Me.TextBox_Shell_inTemperature = New System.Windows.Forms.TextBox()
        Me.Label_Shell_inTemperature = New System.Windows.Forms.Label()
        Me.GroupBox_Tube = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Tube_Fluid = New System.Windows.Forms.ComboBox()
        Me.TextBox_Tube_Flux = New System.Windows.Forms.TextBox()
        Me.Label_Tube_Flux = New System.Windows.Forms.Label()
        Me.Label_Tube_Fluid = New System.Windows.Forms.Label()
        Me.TextBox_Tube_inTemperature = New System.Windows.Forms.TextBox()
        Me.Label_Tube_inTemperature = New System.Windows.Forms.Label()
        Me.GroupBox_CheckResult = New System.Windows.Forms.GroupBox()
        Me.TextBox_TemperatureDifference = New System.Windows.Forms.TextBox()
        Me.Label_TemperatureDifference = New System.Windows.Forms.Label()
        Me.TextBox_HeatTransferRate = New System.Windows.Forms.TextBox()
        Me.Label_HeatTransferRate = New System.Windows.Forms.Label()
        Me.TextBox_Shell_outTemperature = New System.Windows.Forms.TextBox()
        Me.Label_Shell_outTemperature = New System.Windows.Forms.Label()
        Me.TextBox_Tube_outTemperature = New System.Windows.Forms.TextBox()
        Me.Label_Tube_outTemperature = New System.Windows.Forms.Label()
        Me.TextBox_OverallHeatTransferCoefficient = New System.Windows.Forms.TextBox()
        Me.Label_OverallHeatTransferCoefficient = New System.Windows.Forms.Label()
        Me.TextBox_HeatTransferArea = New System.Windows.Forms.TextBox()
        Me.Label_HeatTransferArea = New System.Windows.Forms.Label()
        Me.Button_Clean = New System.Windows.Forms.Button()
        Me.Button_Check = New System.Windows.Forms.Button()
        Me.ComboBox_FlowType = New System.Windows.Forms.ComboBox()
        Me.Label_FlowType = New System.Windows.Forms.Label()
        Me.GroupBox_Shell.SuspendLayout()
        Me.GroupBox_Tube.SuspendLayout()
        Me.GroupBox_CheckResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Shell
        '
        Me.GroupBox_Shell.Controls.Add(Me.ComboBox_Shell_Fluid)
        Me.GroupBox_Shell.Controls.Add(Me.TextBox_Shell_Flux)
        Me.GroupBox_Shell.Controls.Add(Me.Label_Shell_Flux)
        Me.GroupBox_Shell.Controls.Add(Me.Label_Shell_Fluid)
        Me.GroupBox_Shell.Controls.Add(Me.TextBox_Shell_inTemperature)
        Me.GroupBox_Shell.Controls.Add(Me.Label_Shell_inTemperature)
        Me.GroupBox_Shell.Location = New System.Drawing.Point(446, 35)
        Me.GroupBox_Shell.Name = "GroupBox_Shell"
        Me.GroupBox_Shell.Size = New System.Drawing.Size(260, 140)
        Me.GroupBox_Shell.TabIndex = 3
        Me.GroupBox_Shell.TabStop = False
        Me.GroupBox_Shell.Text = "壳侧"
        '
        'ComboBox_Shell_Fluid
        '
        Me.ComboBox_Shell_Fluid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Shell_Fluid.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox_Shell_Fluid.FormattingEnabled = True
        Me.ComboBox_Shell_Fluid.Items.AddRange(New Object() {"水", "14号润滑油"})
        Me.ComboBox_Shell_Fluid.Location = New System.Drawing.Point(125, 20)
        Me.ComboBox_Shell_Fluid.Name = "ComboBox_Shell_Fluid"
        Me.ComboBox_Shell_Fluid.Size = New System.Drawing.Size(120, 27)
        Me.ComboBox_Shell_Fluid.TabIndex = 0
        '
        'TextBox_Shell_Flux
        '
        Me.TextBox_Shell_Flux.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_Shell_Flux.Location = New System.Drawing.Point(177, 58)
        Me.TextBox_Shell_Flux.Name = "TextBox_Shell_Flux"
        Me.TextBox_Shell_Flux.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_Shell_Flux.TabIndex = 1
        Me.TextBox_Shell_Flux.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Shell_Flux
        '
        Me.Label_Shell_Flux.AutoSize = True
        Me.Label_Shell_Flux.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Shell_Flux.Location = New System.Drawing.Point(6, 62)
        Me.Label_Shell_Flux.Name = "Label_Shell_Flux"
        Me.Label_Shell_Flux.Size = New System.Drawing.Size(144, 19)
        Me.Label_Shell_Flux.TabIndex = 6
        Me.Label_Shell_Flux.Text = "流体流量(t/h)"
        '
        'Label_Shell_Fluid
        '
        Me.Label_Shell_Fluid.AutoSize = True
        Me.Label_Shell_Fluid.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Shell_Fluid.Location = New System.Drawing.Point(6, 23)
        Me.Label_Shell_Fluid.Name = "Label_Shell_Fluid"
        Me.Label_Shell_Fluid.Size = New System.Drawing.Size(89, 19)
        Me.Label_Shell_Fluid.TabIndex = 4
        Me.Label_Shell_Fluid.Text = "流体类别"
        '
        'TextBox_Shell_inTemperature
        '
        Me.TextBox_Shell_inTemperature.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_Shell_inTemperature.Location = New System.Drawing.Point(177, 98)
        Me.TextBox_Shell_inTemperature.Name = "TextBox_Shell_inTemperature"
        Me.TextBox_Shell_inTemperature.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_Shell_inTemperature.TabIndex = 2
        Me.TextBox_Shell_inTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Shell_inTemperature
        '
        Me.Label_Shell_inTemperature.AutoSize = True
        Me.Label_Shell_inTemperature.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Shell_inTemperature.Location = New System.Drawing.Point(6, 101)
        Me.Label_Shell_inTemperature.Name = "Label_Shell_inTemperature"
        Me.Label_Shell_inTemperature.Size = New System.Drawing.Size(131, 19)
        Me.Label_Shell_inTemperature.TabIndex = 0
        Me.Label_Shell_inTemperature.Text = "入口温度(℃)"
        '
        'GroupBox_Tube
        '
        Me.GroupBox_Tube.Controls.Add(Me.ComboBox_Tube_Fluid)
        Me.GroupBox_Tube.Controls.Add(Me.TextBox_Tube_Flux)
        Me.GroupBox_Tube.Controls.Add(Me.Label_Tube_Flux)
        Me.GroupBox_Tube.Controls.Add(Me.Label_Tube_Fluid)
        Me.GroupBox_Tube.Controls.Add(Me.TextBox_Tube_inTemperature)
        Me.GroupBox_Tube.Controls.Add(Me.Label_Tube_inTemperature)
        Me.GroupBox_Tube.Location = New System.Drawing.Point(41, 35)
        Me.GroupBox_Tube.Name = "GroupBox_Tube"
        Me.GroupBox_Tube.Size = New System.Drawing.Size(260, 140)
        Me.GroupBox_Tube.TabIndex = 2
        Me.GroupBox_Tube.TabStop = False
        Me.GroupBox_Tube.Text = "管侧"
        '
        'ComboBox_Tube_Fluid
        '
        Me.ComboBox_Tube_Fluid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Tube_Fluid.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox_Tube_Fluid.FormattingEnabled = True
        Me.ComboBox_Tube_Fluid.Items.AddRange(New Object() {"水", "14号润滑油"})
        Me.ComboBox_Tube_Fluid.Location = New System.Drawing.Point(124, 20)
        Me.ComboBox_Tube_Fluid.Name = "ComboBox_Tube_Fluid"
        Me.ComboBox_Tube_Fluid.Size = New System.Drawing.Size(120, 27)
        Me.ComboBox_Tube_Fluid.TabIndex = 0
        '
        'TextBox_Tube_Flux
        '
        Me.TextBox_Tube_Flux.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_Tube_Flux.Location = New System.Drawing.Point(176, 58)
        Me.TextBox_Tube_Flux.Name = "TextBox_Tube_Flux"
        Me.TextBox_Tube_Flux.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_Tube_Flux.TabIndex = 1
        Me.TextBox_Tube_Flux.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Tube_Flux
        '
        Me.Label_Tube_Flux.AutoSize = True
        Me.Label_Tube_Flux.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Tube_Flux.Location = New System.Drawing.Point(6, 62)
        Me.Label_Tube_Flux.Name = "Label_Tube_Flux"
        Me.Label_Tube_Flux.Size = New System.Drawing.Size(144, 19)
        Me.Label_Tube_Flux.TabIndex = 6
        Me.Label_Tube_Flux.Text = "流体流量(t/h)"
        '
        'Label_Tube_Fluid
        '
        Me.Label_Tube_Fluid.AutoSize = True
        Me.Label_Tube_Fluid.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Tube_Fluid.Location = New System.Drawing.Point(6, 23)
        Me.Label_Tube_Fluid.Name = "Label_Tube_Fluid"
        Me.Label_Tube_Fluid.Size = New System.Drawing.Size(89, 19)
        Me.Label_Tube_Fluid.TabIndex = 4
        Me.Label_Tube_Fluid.Text = "流体类别"
        '
        'TextBox_Tube_inTemperature
        '
        Me.TextBox_Tube_inTemperature.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_Tube_inTemperature.Location = New System.Drawing.Point(176, 98)
        Me.TextBox_Tube_inTemperature.Name = "TextBox_Tube_inTemperature"
        Me.TextBox_Tube_inTemperature.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_Tube_inTemperature.TabIndex = 2
        Me.TextBox_Tube_inTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Tube_inTemperature
        '
        Me.Label_Tube_inTemperature.AutoSize = True
        Me.Label_Tube_inTemperature.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Tube_inTemperature.Location = New System.Drawing.Point(6, 101)
        Me.Label_Tube_inTemperature.Name = "Label_Tube_inTemperature"
        Me.Label_Tube_inTemperature.Size = New System.Drawing.Size(131, 19)
        Me.Label_Tube_inTemperature.TabIndex = 0
        Me.Label_Tube_inTemperature.Text = "入口温度(℃)"
        '
        'GroupBox_CheckResult
        '
        Me.GroupBox_CheckResult.Controls.Add(Me.TextBox_TemperatureDifference)
        Me.GroupBox_CheckResult.Controls.Add(Me.Label_TemperatureDifference)
        Me.GroupBox_CheckResult.Controls.Add(Me.TextBox_HeatTransferRate)
        Me.GroupBox_CheckResult.Controls.Add(Me.Label_HeatTransferRate)
        Me.GroupBox_CheckResult.Controls.Add(Me.TextBox_Shell_outTemperature)
        Me.GroupBox_CheckResult.Controls.Add(Me.Label_Shell_outTemperature)
        Me.GroupBox_CheckResult.Controls.Add(Me.TextBox_Tube_outTemperature)
        Me.GroupBox_CheckResult.Controls.Add(Me.Label_Tube_outTemperature)
        Me.GroupBox_CheckResult.Controls.Add(Me.TextBox_OverallHeatTransferCoefficient)
        Me.GroupBox_CheckResult.Controls.Add(Me.Label_OverallHeatTransferCoefficient)
        Me.GroupBox_CheckResult.Location = New System.Drawing.Point(41, 278)
        Me.GroupBox_CheckResult.Name = "GroupBox_CheckResult"
        Me.GroupBox_CheckResult.Size = New System.Drawing.Size(665, 185)
        Me.GroupBox_CheckResult.TabIndex = 5
        Me.GroupBox_CheckResult.TabStop = False
        Me.GroupBox_CheckResult.Text = "校核结果"
        '
        'TextBox_TemperatureDifference
        '
        Me.TextBox_TemperatureDifference.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_TemperatureDifference.Location = New System.Drawing.Point(183, 130)
        Me.TextBox_TemperatureDifference.Name = "TextBox_TemperatureDifference"
        Me.TextBox_TemperatureDifference.ReadOnly = True
        Me.TextBox_TemperatureDifference.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_TemperatureDifference.TabIndex = 18
        Me.TextBox_TemperatureDifference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_TemperatureDifference
        '
        Me.Label_TemperatureDifference.AutoSize = True
        Me.Label_TemperatureDifference.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_TemperatureDifference.Location = New System.Drawing.Point(6, 133)
        Me.Label_TemperatureDifference.Name = "Label_TemperatureDifference"
        Me.Label_TemperatureDifference.Size = New System.Drawing.Size(131, 19)
        Me.Label_TemperatureDifference.TabIndex = 17
        Me.Label_TemperatureDifference.Text = "平均温差(℃)"
        '
        'TextBox_HeatTransferRate
        '
        Me.TextBox_HeatTransferRate.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_HeatTransferRate.Location = New System.Drawing.Point(521, 130)
        Me.TextBox_HeatTransferRate.Name = "TextBox_HeatTransferRate"
        Me.TextBox_HeatTransferRate.ReadOnly = True
        Me.TextBox_HeatTransferRate.Size = New System.Drawing.Size(111, 29)
        Me.TextBox_HeatTransferRate.TabIndex = 3
        Me.TextBox_HeatTransferRate.TabStop = False
        Me.TextBox_HeatTransferRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_HeatTransferRate
        '
        Me.Label_HeatTransferRate.AutoSize = True
        Me.Label_HeatTransferRate.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_HeatTransferRate.Location = New System.Drawing.Point(385, 133)
        Me.Label_HeatTransferRate.Name = "Label_HeatTransferRate"
        Me.Label_HeatTransferRate.Size = New System.Drawing.Size(120, 19)
        Me.Label_HeatTransferRate.TabIndex = 8
        Me.Label_HeatTransferRate.Text = "换热量（W）"
        '
        'TextBox_Shell_outTemperature
        '
        Me.TextBox_Shell_outTemperature.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_Shell_outTemperature.Location = New System.Drawing.Point(562, 28)
        Me.TextBox_Shell_outTemperature.Name = "TextBox_Shell_outTemperature"
        Me.TextBox_Shell_outTemperature.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_Shell_outTemperature.TabIndex = 1
        Me.TextBox_Shell_outTemperature.TabStop = False
        Me.TextBox_Shell_outTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Shell_outTemperature
        '
        Me.Label_Shell_outTemperature.AutoSize = True
        Me.Label_Shell_outTemperature.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Shell_outTemperature.Location = New System.Drawing.Point(385, 31)
        Me.Label_Shell_outTemperature.Name = "Label_Shell_outTemperature"
        Me.Label_Shell_outTemperature.Size = New System.Drawing.Size(171, 19)
        Me.Label_Shell_outTemperature.TabIndex = 6
        Me.Label_Shell_outTemperature.Text = "壳侧出口温度(℃)"
        '
        'TextBox_Tube_outTemperature
        '
        Me.TextBox_Tube_outTemperature.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_Tube_outTemperature.Location = New System.Drawing.Point(183, 28)
        Me.TextBox_Tube_outTemperature.Name = "TextBox_Tube_outTemperature"
        Me.TextBox_Tube_outTemperature.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_Tube_outTemperature.TabIndex = 0
        Me.TextBox_Tube_outTemperature.TabStop = False
        Me.TextBox_Tube_outTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Tube_outTemperature
        '
        Me.Label_Tube_outTemperature.AutoSize = True
        Me.Label_Tube_outTemperature.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Tube_outTemperature.Location = New System.Drawing.Point(6, 31)
        Me.Label_Tube_outTemperature.Name = "Label_Tube_outTemperature"
        Me.Label_Tube_outTemperature.Size = New System.Drawing.Size(171, 19)
        Me.Label_Tube_outTemperature.TabIndex = 4
        Me.Label_Tube_outTemperature.Text = "管侧出口温度(℃)"
        '
        'TextBox_OverallHeatTransferCoefficient
        '
        Me.TextBox_OverallHeatTransferCoefficient.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_OverallHeatTransferCoefficient.Location = New System.Drawing.Point(251, 80)
        Me.TextBox_OverallHeatTransferCoefficient.Name = "TextBox_OverallHeatTransferCoefficient"
        Me.TextBox_OverallHeatTransferCoefficient.Size = New System.Drawing.Size(111, 29)
        Me.TextBox_OverallHeatTransferCoefficient.TabIndex = 2
        Me.TextBox_OverallHeatTransferCoefficient.TabStop = False
        Me.TextBox_OverallHeatTransferCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_OverallHeatTransferCoefficient
        '
        Me.Label_OverallHeatTransferCoefficient.AutoSize = True
        Me.Label_OverallHeatTransferCoefficient.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_OverallHeatTransferCoefficient.Location = New System.Drawing.Point(6, 83)
        Me.Label_OverallHeatTransferCoefficient.Name = "Label_OverallHeatTransferCoefficient"
        Me.Label_OverallHeatTransferCoefficient.Size = New System.Drawing.Size(226, 19)
        Me.Label_OverallHeatTransferCoefficient.TabIndex = 0
        Me.Label_OverallHeatTransferCoefficient.Text = "总传热系数(W/(㎡·K))"
        '
        'TextBox_HeatTransferArea
        '
        Me.TextBox_HeatTransferArea.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_HeatTransferArea.Location = New System.Drawing.Point(534, 213)
        Me.TextBox_HeatTransferArea.Name = "TextBox_HeatTransferArea"
        Me.TextBox_HeatTransferArea.Size = New System.Drawing.Size(80, 29)
        Me.TextBox_HeatTransferArea.TabIndex = 4
        Me.TextBox_HeatTransferArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_HeatTransferArea
        '
        Me.Label_HeatTransferArea.AutoSize = True
        Me.Label_HeatTransferArea.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_HeatTransferArea.Location = New System.Drawing.Point(397, 216)
        Me.Label_HeatTransferArea.Name = "Label_HeatTransferArea"
        Me.Label_HeatTransferArea.Size = New System.Drawing.Size(131, 19)
        Me.Label_HeatTransferArea.TabIndex = 7
        Me.Label_HeatTransferArea.Text = "换热面积(㎡)"
        '
        'Button_Clean
        '
        Me.Button_Clean.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Clean.Location = New System.Drawing.Point(428, 493)
        Me.Button_Clean.Name = "Button_Clean"
        Me.Button_Clean.Size = New System.Drawing.Size(86, 32)
        Me.Button_Clean.TabIndex = 1
        Me.Button_Clean.Text = "清空"
        Me.Button_Clean.UseVisualStyleBackColor = True
        '
        'Button_Check
        '
        Me.Button_Check.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Check.Location = New System.Drawing.Point(234, 493)
        Me.Button_Check.Name = "Button_Check"
        Me.Button_Check.Size = New System.Drawing.Size(86, 32)
        Me.Button_Check.TabIndex = 0
        Me.Button_Check.Text = "校核"
        Me.Button_Check.UseVisualStyleBackColor = True
        '
        'ComboBox_FlowType
        '
        Me.ComboBox_FlowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_FlowType.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox_FlowType.FormattingEnabled = True
        Me.ComboBox_FlowType.Items.AddRange(New Object() {"纯逆流", "纯顺流", "其他形式"})
        Me.ComboBox_FlowType.Location = New System.Drawing.Point(219, 213)
        Me.ComboBox_FlowType.Name = "ComboBox_FlowType"
        Me.ComboBox_FlowType.Size = New System.Drawing.Size(103, 27)
        Me.ComboBox_FlowType.TabIndex = 16
        '
        'Label_FlowType
        '
        Me.Label_FlowType.AutoSize = True
        Me.Label_FlowType.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_FlowType.Location = New System.Drawing.Point(84, 216)
        Me.Label_FlowType.Name = "Label_FlowType"
        Me.Label_FlowType.Size = New System.Drawing.Size(129, 19)
        Me.Label_FlowType.TabIndex = 15
        Me.Label_FlowType.Text = "流体流动方式"
        '
        'Form_Check_LMTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 561)
        Me.Controls.Add(Me.ComboBox_FlowType)
        Me.Controls.Add(Me.Label_FlowType)
        Me.Controls.Add(Me.Button_Clean)
        Me.Controls.Add(Me.Button_Check)
        Me.Controls.Add(Me.TextBox_HeatTransferArea)
        Me.Controls.Add(Me.Label_HeatTransferArea)
        Me.Controls.Add(Me.GroupBox_CheckResult)
        Me.Controls.Add(Me.GroupBox_Shell)
        Me.Controls.Add(Me.GroupBox_Tube)
        Me.Name = "Form_Check_LMTD"
        Me.Text = "平均温差法校核计算"
        Me.GroupBox_Shell.ResumeLayout(False)
        Me.GroupBox_Shell.PerformLayout()
        Me.GroupBox_Tube.ResumeLayout(False)
        Me.GroupBox_Tube.PerformLayout()
        Me.GroupBox_CheckResult.ResumeLayout(False)
        Me.GroupBox_CheckResult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_Shell As GroupBox
    Friend WithEvents ComboBox_Shell_Fluid As ComboBox
    Friend WithEvents TextBox_Shell_Flux As TextBox
    Friend WithEvents Label_Shell_Flux As Label
    Friend WithEvents Label_Shell_Fluid As Label
    Friend WithEvents TextBox_Shell_inTemperature As TextBox
    Friend WithEvents Label_Shell_inTemperature As Label
    Friend WithEvents GroupBox_Tube As GroupBox
    Friend WithEvents ComboBox_Tube_Fluid As ComboBox
    Friend WithEvents TextBox_Tube_Flux As TextBox
    Friend WithEvents Label_Tube_Flux As Label
    Friend WithEvents Label_Tube_Fluid As Label
    Friend WithEvents TextBox_Tube_inTemperature As TextBox
    Friend WithEvents Label_Tube_inTemperature As Label
    Friend WithEvents GroupBox_CheckResult As GroupBox
    Friend WithEvents TextBox_OverallHeatTransferCoefficient As TextBox
    Friend WithEvents Label_OverallHeatTransferCoefficient As Label
    Friend WithEvents TextBox_HeatTransferArea As TextBox
    Friend WithEvents Label_HeatTransferArea As Label
    Friend WithEvents TextBox_Tube_outTemperature As TextBox
    Friend WithEvents Label_Tube_outTemperature As Label
    Friend WithEvents TextBox_Shell_outTemperature As TextBox
    Friend WithEvents Label_Shell_outTemperature As Label
    Friend WithEvents Button_Clean As Button
    Friend WithEvents Button_Check As Button
    Friend WithEvents TextBox_HeatTransferRate As TextBox
    Friend WithEvents Label_HeatTransferRate As Label
    Friend WithEvents ComboBox_FlowType As ComboBox
    Friend WithEvents Label_FlowType As Label
    Friend WithEvents TextBox_TemperatureDifference As TextBox
    Friend WithEvents Label_TemperatureDifference As Label
End Class
