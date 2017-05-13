<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Design_LMTD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button_Calculate = New System.Windows.Forms.Button()
        Me.Button_Clean = New System.Windows.Forms.Button()
        Me.GroupBox_Tube = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Tube_Fluid = New System.Windows.Forms.ComboBox()
        Me.TextBox_Tube_Flux = New System.Windows.Forms.TextBox()
        Me.Label_Tube_Flux = New System.Windows.Forms.Label()
        Me.Label_Tube_Fluid = New System.Windows.Forms.Label()
        Me.TextBox_Tube_outTemperature = New System.Windows.Forms.TextBox()
        Me.Label_Tube_outTemperature = New System.Windows.Forms.Label()
        Me.TextBox_Tube_inTemperature = New System.Windows.Forms.TextBox()
        Me.Label_Tube_inTemperature = New System.Windows.Forms.Label()
        Me.GroupBox_Shell = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Shell_Fluid = New System.Windows.Forms.ComboBox()
        Me.TextBox_Shell_Flux = New System.Windows.Forms.TextBox()
        Me.Label_Shell_Flux = New System.Windows.Forms.Label()
        Me.Label_Shell_Fluid = New System.Windows.Forms.Label()
        Me.TextBox_Shell_outTemperature = New System.Windows.Forms.TextBox()
        Me.Label_Shell_outTemperature = New System.Windows.Forms.Label()
        Me.TextBox_Shell_inTemperature = New System.Windows.Forms.TextBox()
        Me.Label_Shell_inTemperature = New System.Windows.Forms.Label()
        Me.GroupBox_SurfaceArrangement = New System.Windows.Forms.GroupBox()
        Me.TextBox_ThermalConductivity = New System.Windows.Forms.TextBox()
        Me.Label_ThermalConductivity = New System.Windows.Forms.Label()
        Me.TextBox_Tube_h = New System.Windows.Forms.TextBox()
        Me.Label_Tube_h = New System.Windows.Forms.Label()
        Me.TextBox_Shell_h = New System.Windows.Forms.TextBox()
        Me.Label_Shell_h = New System.Windows.Forms.Label()
        Me.TextBox_OuterTubeDiameter = New System.Windows.Forms.TextBox()
        Me.Label_OuterTubeDiameter = New System.Windows.Forms.Label()
        Me.TextBox_InnerTubeDiameter = New System.Windows.Forms.TextBox()
        Me.Label_InnerTubeDiameter = New System.Windows.Forms.Label()
        Me.TextBox_HeatTransferArea = New System.Windows.Forms.TextBox()
        Me.Label_HeatTransferArea = New System.Windows.Forms.Label()
        Me.TextBox_OverallHeatTransferCoefficient = New System.Windows.Forms.TextBox()
        Me.Label_OverallHeatTransferCoefficient = New System.Windows.Forms.Label()
        Me.Label_FlowType = New System.Windows.Forms.Label()
        Me.ComboBox_FlowType = New System.Windows.Forms.ComboBox()
        Me.GroupBox_Tube.SuspendLayout()
        Me.GroupBox_Shell.SuspendLayout()
        Me.GroupBox_SurfaceArrangement.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Calculate
        '
        Me.Button_Calculate.Location = New System.Drawing.Point(150, 417)
        Me.Button_Calculate.Name = "Button_Calculate"
        Me.Button_Calculate.Size = New System.Drawing.Size(86, 32)
        Me.Button_Calculate.TabIndex = 0
        Me.Button_Calculate.Text = "计算"
        Me.Button_Calculate.UseVisualStyleBackColor = True
        '
        'Button_Clean
        '
        Me.Button_Clean.Location = New System.Drawing.Point(344, 417)
        Me.Button_Clean.Name = "Button_Clean"
        Me.Button_Clean.Size = New System.Drawing.Size(86, 32)
        Me.Button_Clean.TabIndex = 1
        Me.Button_Clean.Text = "清空"
        Me.Button_Clean.UseVisualStyleBackColor = True
        '
        'GroupBox_Tube
        '
        Me.GroupBox_Tube.Controls.Add(Me.ComboBox_Tube_Fluid)
        Me.GroupBox_Tube.Controls.Add(Me.TextBox_Tube_Flux)
        Me.GroupBox_Tube.Controls.Add(Me.Label_Tube_Flux)
        Me.GroupBox_Tube.Controls.Add(Me.Label_Tube_Fluid)
        Me.GroupBox_Tube.Controls.Add(Me.TextBox_Tube_outTemperature)
        Me.GroupBox_Tube.Controls.Add(Me.Label_Tube_outTemperature)
        Me.GroupBox_Tube.Controls.Add(Me.TextBox_Tube_inTemperature)
        Me.GroupBox_Tube.Controls.Add(Me.Label_Tube_inTemperature)
        Me.GroupBox_Tube.Location = New System.Drawing.Point(31, 25)
        Me.GroupBox_Tube.Name = "GroupBox_Tube"
        Me.GroupBox_Tube.Size = New System.Drawing.Size(205, 153)
        Me.GroupBox_Tube.TabIndex = 2
        Me.GroupBox_Tube.TabStop = False
        Me.GroupBox_Tube.Text = "管侧"
        '
        'ComboBox_Tube_Fluid
        '
        Me.ComboBox_Tube_Fluid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Tube_Fluid.FormattingEnabled = True
        Me.ComboBox_Tube_Fluid.Items.AddRange(New Object() {"水", "14号润滑油"})
        Me.ComboBox_Tube_Fluid.Location = New System.Drawing.Point(84, 25)
        Me.ComboBox_Tube_Fluid.Name = "ComboBox_Tube_Fluid"
        Me.ComboBox_Tube_Fluid.Size = New System.Drawing.Size(85, 20)
        Me.ComboBox_Tube_Fluid.TabIndex = 0
        '
        'TextBox_Tube_Flux
        '
        Me.TextBox_Tube_Flux.Location = New System.Drawing.Point(112, 51)
        Me.TextBox_Tube_Flux.Name = "TextBox_Tube_Flux"
        Me.TextBox_Tube_Flux.Size = New System.Drawing.Size(57, 21)
        Me.TextBox_Tube_Flux.TabIndex = 1
        Me.TextBox_Tube_Flux.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Tube_Flux
        '
        Me.Label_Tube_Flux.AutoSize = True
        Me.Label_Tube_Flux.Location = New System.Drawing.Point(6, 54)
        Me.Label_Tube_Flux.Name = "Label_Tube_Flux"
        Me.Label_Tube_Flux.Size = New System.Drawing.Size(83, 12)
        Me.Label_Tube_Flux.TabIndex = 6
        Me.Label_Tube_Flux.Text = "流体流量(t/h)"
        '
        'Label_Tube_Fluid
        '
        Me.Label_Tube_Fluid.AutoSize = True
        Me.Label_Tube_Fluid.Location = New System.Drawing.Point(6, 28)
        Me.Label_Tube_Fluid.Name = "Label_Tube_Fluid"
        Me.Label_Tube_Fluid.Size = New System.Drawing.Size(53, 12)
        Me.Label_Tube_Fluid.TabIndex = 4
        Me.Label_Tube_Fluid.Text = "流体类别"
        '
        'TextBox_Tube_outTemperature
        '
        Me.TextBox_Tube_outTemperature.Location = New System.Drawing.Point(112, 111)
        Me.TextBox_Tube_outTemperature.Name = "TextBox_Tube_outTemperature"
        Me.TextBox_Tube_outTemperature.Size = New System.Drawing.Size(57, 21)
        Me.TextBox_Tube_outTemperature.TabIndex = 3
        Me.TextBox_Tube_outTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Tube_outTemperature
        '
        Me.Label_Tube_outTemperature.AutoSize = True
        Me.Label_Tube_outTemperature.Location = New System.Drawing.Point(6, 114)
        Me.Label_Tube_outTemperature.Name = "Label_Tube_outTemperature"
        Me.Label_Tube_outTemperature.Size = New System.Drawing.Size(77, 12)
        Me.Label_Tube_outTemperature.TabIndex = 2
        Me.Label_Tube_outTemperature.Text = "出口温度(℃)"
        '
        'TextBox_Tube_inTemperature
        '
        Me.TextBox_Tube_inTemperature.Location = New System.Drawing.Point(112, 80)
        Me.TextBox_Tube_inTemperature.Name = "TextBox_Tube_inTemperature"
        Me.TextBox_Tube_inTemperature.Size = New System.Drawing.Size(57, 21)
        Me.TextBox_Tube_inTemperature.TabIndex = 2
        Me.TextBox_Tube_inTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Tube_inTemperature
        '
        Me.Label_Tube_inTemperature.AutoSize = True
        Me.Label_Tube_inTemperature.Location = New System.Drawing.Point(6, 83)
        Me.Label_Tube_inTemperature.Name = "Label_Tube_inTemperature"
        Me.Label_Tube_inTemperature.Size = New System.Drawing.Size(77, 12)
        Me.Label_Tube_inTemperature.TabIndex = 0
        Me.Label_Tube_inTemperature.Text = "入口温度(℃)"
        '
        'GroupBox_Shell
        '
        Me.GroupBox_Shell.Controls.Add(Me.ComboBox_Shell_Fluid)
        Me.GroupBox_Shell.Controls.Add(Me.TextBox_Shell_Flux)
        Me.GroupBox_Shell.Controls.Add(Me.Label_Shell_Flux)
        Me.GroupBox_Shell.Controls.Add(Me.Label_Shell_Fluid)
        Me.GroupBox_Shell.Controls.Add(Me.TextBox_Shell_outTemperature)
        Me.GroupBox_Shell.Controls.Add(Me.Label_Shell_outTemperature)
        Me.GroupBox_Shell.Controls.Add(Me.TextBox_Shell_inTemperature)
        Me.GroupBox_Shell.Controls.Add(Me.Label_Shell_inTemperature)
        Me.GroupBox_Shell.Location = New System.Drawing.Point(344, 25)
        Me.GroupBox_Shell.Name = "GroupBox_Shell"
        Me.GroupBox_Shell.Size = New System.Drawing.Size(205, 153)
        Me.GroupBox_Shell.TabIndex = 3
        Me.GroupBox_Shell.TabStop = False
        Me.GroupBox_Shell.Text = "壳侧"
        '
        'ComboBox_Shell_Fluid
        '
        Me.ComboBox_Shell_Fluid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Shell_Fluid.FormattingEnabled = True
        Me.ComboBox_Shell_Fluid.Items.AddRange(New Object() {"水", "14号润滑油"})
        Me.ComboBox_Shell_Fluid.Location = New System.Drawing.Point(84, 25)
        Me.ComboBox_Shell_Fluid.Name = "ComboBox_Shell_Fluid"
        Me.ComboBox_Shell_Fluid.Size = New System.Drawing.Size(85, 20)
        Me.ComboBox_Shell_Fluid.TabIndex = 0
        '
        'TextBox_Shell_Flux
        '
        Me.TextBox_Shell_Flux.Location = New System.Drawing.Point(112, 51)
        Me.TextBox_Shell_Flux.Name = "TextBox_Shell_Flux"
        Me.TextBox_Shell_Flux.Size = New System.Drawing.Size(57, 21)
        Me.TextBox_Shell_Flux.TabIndex = 1
        Me.TextBox_Shell_Flux.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Shell_Flux
        '
        Me.Label_Shell_Flux.AutoSize = True
        Me.Label_Shell_Flux.Location = New System.Drawing.Point(6, 54)
        Me.Label_Shell_Flux.Name = "Label_Shell_Flux"
        Me.Label_Shell_Flux.Size = New System.Drawing.Size(83, 12)
        Me.Label_Shell_Flux.TabIndex = 6
        Me.Label_Shell_Flux.Text = "流体流量(t/h)"
        '
        'Label_Shell_Fluid
        '
        Me.Label_Shell_Fluid.AutoSize = True
        Me.Label_Shell_Fluid.Location = New System.Drawing.Point(6, 28)
        Me.Label_Shell_Fluid.Name = "Label_Shell_Fluid"
        Me.Label_Shell_Fluid.Size = New System.Drawing.Size(53, 12)
        Me.Label_Shell_Fluid.TabIndex = 4
        Me.Label_Shell_Fluid.Text = "流体类别"
        '
        'TextBox_Shell_outTemperature
        '
        Me.TextBox_Shell_outTemperature.Location = New System.Drawing.Point(112, 111)
        Me.TextBox_Shell_outTemperature.Name = "TextBox_Shell_outTemperature"
        Me.TextBox_Shell_outTemperature.Size = New System.Drawing.Size(57, 21)
        Me.TextBox_Shell_outTemperature.TabIndex = 3
        Me.TextBox_Shell_outTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Shell_outTemperature
        '
        Me.Label_Shell_outTemperature.AutoSize = True
        Me.Label_Shell_outTemperature.Location = New System.Drawing.Point(6, 114)
        Me.Label_Shell_outTemperature.Name = "Label_Shell_outTemperature"
        Me.Label_Shell_outTemperature.Size = New System.Drawing.Size(77, 12)
        Me.Label_Shell_outTemperature.TabIndex = 2
        Me.Label_Shell_outTemperature.Text = "出口温度(℃)"
        '
        'TextBox_Shell_inTemperature
        '
        Me.TextBox_Shell_inTemperature.Location = New System.Drawing.Point(112, 80)
        Me.TextBox_Shell_inTemperature.Name = "TextBox_Shell_inTemperature"
        Me.TextBox_Shell_inTemperature.Size = New System.Drawing.Size(57, 21)
        Me.TextBox_Shell_inTemperature.TabIndex = 2
        Me.TextBox_Shell_inTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Shell_inTemperature
        '
        Me.Label_Shell_inTemperature.AutoSize = True
        Me.Label_Shell_inTemperature.Location = New System.Drawing.Point(6, 83)
        Me.Label_Shell_inTemperature.Name = "Label_Shell_inTemperature"
        Me.Label_Shell_inTemperature.Size = New System.Drawing.Size(77, 12)
        Me.Label_Shell_inTemperature.TabIndex = 0
        Me.Label_Shell_inTemperature.Text = "入口温度(℃)"
        '
        'GroupBox_SurfaceArrangement
        '
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.ComboBox_FlowType)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.Label_FlowType)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.TextBox_ThermalConductivity)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.Label_ThermalConductivity)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.TextBox_Tube_h)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.Label_Tube_h)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.TextBox_Shell_h)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.Label_Shell_h)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.TextBox_OuterTubeDiameter)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.Label_OuterTubeDiameter)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.TextBox_InnerTubeDiameter)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.Label_InnerTubeDiameter)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.TextBox_HeatTransferArea)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.Label_HeatTransferArea)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.TextBox_OverallHeatTransferCoefficient)
        Me.GroupBox_SurfaceArrangement.Controls.Add(Me.Label_OverallHeatTransferCoefficient)
        Me.GroupBox_SurfaceArrangement.Location = New System.Drawing.Point(31, 204)
        Me.GroupBox_SurfaceArrangement.Name = "GroupBox_SurfaceArrangement"
        Me.GroupBox_SurfaceArrangement.Size = New System.Drawing.Size(518, 184)
        Me.GroupBox_SurfaceArrangement.TabIndex = 4
        Me.GroupBox_SurfaceArrangement.TabStop = False
        Me.GroupBox_SurfaceArrangement.Text = "换热面布置"
        '
        'TextBox_ThermalConductivity
        '
        Me.TextBox_ThermalConductivity.Location = New System.Drawing.Point(431, 57)
        Me.TextBox_ThermalConductivity.Name = "TextBox_ThermalConductivity"
        Me.TextBox_ThermalConductivity.Size = New System.Drawing.Size(60, 21)
        Me.TextBox_ThermalConductivity.TabIndex = 5
        Me.TextBox_ThermalConductivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_ThermalConductivity
        '
        Me.Label_ThermalConductivity.AutoSize = True
        Me.Label_ThermalConductivity.Location = New System.Drawing.Point(249, 60)
        Me.Label_ThermalConductivity.Name = "Label_ThermalConductivity"
        Me.Label_ThermalConductivity.Size = New System.Drawing.Size(137, 12)
        Me.Label_ThermalConductivity.TabIndex = 12
        Me.Label_ThermalConductivity.Text = "管壁导热系数(W/(m·K))"
        '
        'TextBox_Tube_h
        '
        Me.TextBox_Tube_h.Location = New System.Drawing.Point(431, 24)
        Me.TextBox_Tube_h.Name = "TextBox_Tube_h"
        Me.TextBox_Tube_h.Size = New System.Drawing.Size(60, 21)
        Me.TextBox_Tube_h.TabIndex = 6
        Me.TextBox_Tube_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Tube_h
        '
        Me.Label_Tube_h.AutoSize = True
        Me.Label_Tube_h.Location = New System.Drawing.Point(249, 27)
        Me.Label_Tube_h.Name = "Label_Tube_h"
        Me.Label_Tube_h.Size = New System.Drawing.Size(167, 12)
        Me.Label_Tube_h.TabIndex = 10
        Me.Label_Tube_h.Text = "管侧对流换热系数(W/(㎡·K))"
        '
        'TextBox_Shell_h
        '
        Me.TextBox_Shell_h.Location = New System.Drawing.Point(431, 87)
        Me.TextBox_Shell_h.Name = "TextBox_Shell_h"
        Me.TextBox_Shell_h.Size = New System.Drawing.Size(60, 21)
        Me.TextBox_Shell_h.TabIndex = 4
        Me.TextBox_Shell_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Shell_h
        '
        Me.Label_Shell_h.AutoSize = True
        Me.Label_Shell_h.Location = New System.Drawing.Point(249, 90)
        Me.Label_Shell_h.Name = "Label_Shell_h"
        Me.Label_Shell_h.Size = New System.Drawing.Size(167, 12)
        Me.Label_Shell_h.TabIndex = 8
        Me.Label_Shell_h.Text = "壳侧对流换热系数(W/(㎡·K))"
        '
        'TextBox_OuterTubeDiameter
        '
        Me.TextBox_OuterTubeDiameter.Location = New System.Drawing.Point(113, 87)
        Me.TextBox_OuterTubeDiameter.Name = "TextBox_OuterTubeDiameter"
        Me.TextBox_OuterTubeDiameter.Size = New System.Drawing.Size(60, 21)
        Me.TextBox_OuterTubeDiameter.TabIndex = 3
        Me.TextBox_OuterTubeDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_OuterTubeDiameter
        '
        Me.Label_OuterTubeDiameter.AutoSize = True
        Me.Label_OuterTubeDiameter.Location = New System.Drawing.Point(6, 90)
        Me.Label_OuterTubeDiameter.Name = "Label_OuterTubeDiameter"
        Me.Label_OuterTubeDiameter.Size = New System.Drawing.Size(65, 12)
        Me.Label_OuterTubeDiameter.TabIndex = 6
        Me.Label_OuterTubeDiameter.Text = "外管径(mm)"
        '
        'TextBox_InnerTubeDiameter
        '
        Me.TextBox_InnerTubeDiameter.Location = New System.Drawing.Point(113, 57)
        Me.TextBox_InnerTubeDiameter.Name = "TextBox_InnerTubeDiameter"
        Me.TextBox_InnerTubeDiameter.Size = New System.Drawing.Size(60, 21)
        Me.TextBox_InnerTubeDiameter.TabIndex = 2
        Me.TextBox_InnerTubeDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_InnerTubeDiameter
        '
        Me.Label_InnerTubeDiameter.AutoSize = True
        Me.Label_InnerTubeDiameter.Location = New System.Drawing.Point(6, 60)
        Me.Label_InnerTubeDiameter.Name = "Label_InnerTubeDiameter"
        Me.Label_InnerTubeDiameter.Size = New System.Drawing.Size(65, 12)
        Me.Label_InnerTubeDiameter.TabIndex = 4
        Me.Label_InnerTubeDiameter.Text = "内管径(mm)"
        '
        'TextBox_HeatTransferArea
        '
        Me.TextBox_HeatTransferArea.Location = New System.Drawing.Point(411, 141)
        Me.TextBox_HeatTransferArea.Name = "TextBox_HeatTransferArea"
        Me.TextBox_HeatTransferArea.ReadOnly = True
        Me.TextBox_HeatTransferArea.Size = New System.Drawing.Size(80, 21)
        Me.TextBox_HeatTransferArea.TabIndex = 8
        Me.TextBox_HeatTransferArea.TabStop = False
        Me.TextBox_HeatTransferArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_HeatTransferArea
        '
        Me.Label_HeatTransferArea.AutoSize = True
        Me.Label_HeatTransferArea.Location = New System.Drawing.Point(305, 144)
        Me.Label_HeatTransferArea.Name = "Label_HeatTransferArea"
        Me.Label_HeatTransferArea.Size = New System.Drawing.Size(77, 12)
        Me.Label_HeatTransferArea.TabIndex = 2
        Me.Label_HeatTransferArea.Text = "换热面积(㎡)"
        '
        'TextBox_OverallHeatTransferCoefficient
        '
        Me.TextBox_OverallHeatTransferCoefficient.Location = New System.Drawing.Point(143, 141)
        Me.TextBox_OverallHeatTransferCoefficient.Name = "TextBox_OverallHeatTransferCoefficient"
        Me.TextBox_OverallHeatTransferCoefficient.ReadOnly = True
        Me.TextBox_OverallHeatTransferCoefficient.Size = New System.Drawing.Size(80, 21)
        Me.TextBox_OverallHeatTransferCoefficient.TabIndex = 7
        Me.TextBox_OverallHeatTransferCoefficient.TabStop = False
        Me.TextBox_OverallHeatTransferCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_OverallHeatTransferCoefficient
        '
        Me.Label_OverallHeatTransferCoefficient.AutoSize = True
        Me.Label_OverallHeatTransferCoefficient.Location = New System.Drawing.Point(6, 144)
        Me.Label_OverallHeatTransferCoefficient.Name = "Label_OverallHeatTransferCoefficient"
        Me.Label_OverallHeatTransferCoefficient.Size = New System.Drawing.Size(131, 12)
        Me.Label_OverallHeatTransferCoefficient.TabIndex = 0
        Me.Label_OverallHeatTransferCoefficient.Text = "总传热系数(W/(㎡·K))"
        '
        'Label_FlowType
        '
        Me.Label_FlowType.AutoSize = True
        Me.Label_FlowType.Location = New System.Drawing.Point(6, 27)
        Me.Label_FlowType.Name = "Label_FlowType"
        Me.Label_FlowType.Size = New System.Drawing.Size(77, 12)
        Me.Label_FlowType.TabIndex = 13
        Me.Label_FlowType.Text = "流体流动方式"
        '
        'ComboBox_FlowType
        '
        Me.ComboBox_FlowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_FlowType.FormattingEnabled = True
        Me.ComboBox_FlowType.Items.AddRange(New Object() {"逆流", "顺流"})
        Me.ComboBox_FlowType.Location = New System.Drawing.Point(113, 24)
        Me.ComboBox_FlowType.Name = "ComboBox_FlowType"
        Me.ComboBox_FlowType.Size = New System.Drawing.Size(61, 20)
        Me.ComboBox_FlowType.TabIndex = 14
        '
        'Form_Design_LMTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 483)
        Me.Controls.Add(Me.GroupBox_SurfaceArrangement)
        Me.Controls.Add(Me.GroupBox_Shell)
        Me.Controls.Add(Me.GroupBox_Tube)
        Me.Controls.Add(Me.Button_Clean)
        Me.Controls.Add(Me.Button_Calculate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_Design_LMTD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "平均温差法设计计算"
        Me.GroupBox_Tube.ResumeLayout(False)
        Me.GroupBox_Tube.PerformLayout()
        Me.GroupBox_Shell.ResumeLayout(False)
        Me.GroupBox_Shell.PerformLayout()
        Me.GroupBox_SurfaceArrangement.ResumeLayout(False)
        Me.GroupBox_SurfaceArrangement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Calculate As Button
    Friend WithEvents Button_Clean As Button
    Friend WithEvents GroupBox_Tube As GroupBox
    Friend WithEvents TextBox_Tube_Flux As TextBox
    Friend WithEvents Label_Tube_Flux As Label
    Friend WithEvents Label_Tube_Fluid As Label
    Friend WithEvents TextBox_Tube_outTemperature As TextBox
    Friend WithEvents Label_Tube_outTemperature As Label
    Friend WithEvents TextBox_Tube_inTemperature As TextBox
    Friend WithEvents Label_Tube_inTemperature As Label
    Friend WithEvents GroupBox_Shell As GroupBox
    Friend WithEvents TextBox_Shell_Flux As TextBox
    Friend WithEvents Label_Shell_Flux As Label
    Friend WithEvents Label_Shell_Fluid As Label
    Friend WithEvents TextBox_Shell_outTemperature As TextBox
    Friend WithEvents Label_Shell_outTemperature As Label
    Friend WithEvents TextBox_Shell_inTemperature As TextBox
    Friend WithEvents Label_Shell_inTemperature As Label
    Friend WithEvents GroupBox_SurfaceArrangement As GroupBox
    Friend WithEvents TextBox_ThermalConductivity As TextBox
    Friend WithEvents Label_ThermalConductivity As Label
    Friend WithEvents TextBox_Tube_h As TextBox
    Friend WithEvents Label_Tube_h As Label
    Friend WithEvents TextBox_Shell_h As TextBox
    Friend WithEvents Label_Shell_h As Label
    Friend WithEvents TextBox_OuterTubeDiameter As TextBox
    Friend WithEvents Label_OuterTubeDiameter As Label
    Friend WithEvents TextBox_InnerTubeDiameter As TextBox
    Friend WithEvents Label_InnerTubeDiameter As Label
    Friend WithEvents TextBox_HeatTransferArea As TextBox
    Friend WithEvents Label_HeatTransferArea As Label
    Friend WithEvents TextBox_OverallHeatTransferCoefficient As TextBox
    Friend WithEvents Label_OverallHeatTransferCoefficient As Label
    Friend WithEvents ComboBox_Tube_Fluid As ComboBox
    Friend WithEvents ComboBox_Shell_Fluid As ComboBox
    Friend WithEvents ComboBox_FlowType As ComboBox
    Friend WithEvents Label_FlowType As Label
End Class
