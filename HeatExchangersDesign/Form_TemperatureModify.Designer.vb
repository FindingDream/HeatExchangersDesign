<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TemperatureModify
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
        Me.ComboBox_FlowType = New System.Windows.Forms.ComboBox()
        Me.PictureBox_ModifiedCoefficient = New System.Windows.Forms.PictureBox()
        Me.Label_R = New System.Windows.Forms.Label()
        Me.TextBox_R = New System.Windows.Forms.TextBox()
        Me.TextBox_P = New System.Windows.Forms.TextBox()
        Me.Label_P = New System.Windows.Forms.Label()
        Me.TextBox_PR = New System.Windows.Forms.TextBox()
        Me.Label_PR = New System.Windows.Forms.Label()
        Me.TextBox_1R = New System.Windows.Forms.TextBox()
        Me.Label_1R = New System.Windows.Forms.Label()
        Me.TextBox_ModifiedCoefficient = New System.Windows.Forms.TextBox()
        Me.Label_ModifiedCoefficient = New System.Windows.Forms.Label()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Label_FlowType = New System.Windows.Forms.Label()
        CType(Me.PictureBox_ModifiedCoefficient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_FlowType
        '
        Me.ComboBox_FlowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_FlowType.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox_FlowType.FormattingEnabled = True
        Me.ComboBox_FlowType.Items.AddRange(New Object() {"1壳程，2、4、6、8 ... 管程", "2壳程，4、8、12 ... 管程", "一次交叉流，两种流体各自不混合", "一次交叉流，一种流体混合，另一种流体不混合"})
        Me.ComboBox_FlowType.Location = New System.Drawing.Point(322, 451)
        Me.ComboBox_FlowType.Name = "ComboBox_FlowType"
        Me.ComboBox_FlowType.Size = New System.Drawing.Size(477, 27)
        Me.ComboBox_FlowType.TabIndex = 0
        '
        'PictureBox_ModifiedCoefficient
        '
        Me.PictureBox_ModifiedCoefficient.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox_ModifiedCoefficient.Name = "PictureBox_ModifiedCoefficient"
        Me.PictureBox_ModifiedCoefficient.Size = New System.Drawing.Size(1063, 433)
        Me.PictureBox_ModifiedCoefficient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_ModifiedCoefficient.TabIndex = 1
        Me.PictureBox_ModifiedCoefficient.TabStop = False
        '
        'Label_R
        '
        Me.Label_R.AutoSize = True
        Me.Label_R.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_R.Location = New System.Drawing.Point(210, 498)
        Me.Label_R.Name = "Label_R"
        Me.Label_R.Size = New System.Drawing.Size(20, 19)
        Me.Label_R.TabIndex = 2
        Me.Label_R.Text = "R"
        '
        'TextBox_R
        '
        Me.TextBox_R.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_R.Location = New System.Drawing.Point(236, 495)
        Me.TextBox_R.Name = "TextBox_R"
        Me.TextBox_R.ReadOnly = True
        Me.TextBox_R.Size = New System.Drawing.Size(69, 29)
        Me.TextBox_R.TabIndex = 3
        Me.TextBox_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_P
        '
        Me.TextBox_P.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_P.Location = New System.Drawing.Point(236, 536)
        Me.TextBox_P.Name = "TextBox_P"
        Me.TextBox_P.ReadOnly = True
        Me.TextBox_P.Size = New System.Drawing.Size(69, 29)
        Me.TextBox_P.TabIndex = 5
        Me.TextBox_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_P
        '
        Me.Label_P.AutoSize = True
        Me.Label_P.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_P.Location = New System.Drawing.Point(212, 539)
        Me.Label_P.Name = "Label_P"
        Me.Label_P.Size = New System.Drawing.Size(20, 19)
        Me.Label_P.TabIndex = 4
        Me.Label_P.Text = "P"
        '
        'TextBox_PR
        '
        Me.TextBox_PR.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_PR.Location = New System.Drawing.Point(850, 536)
        Me.TextBox_PR.Name = "TextBox_PR"
        Me.TextBox_PR.ReadOnly = True
        Me.TextBox_PR.Size = New System.Drawing.Size(69, 29)
        Me.TextBox_PR.TabIndex = 9
        Me.TextBox_PR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_PR
        '
        Me.Label_PR.AutoSize = True
        Me.Label_PR.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_PR.Location = New System.Drawing.Point(802, 539)
        Me.Label_PR.Name = "Label_PR"
        Me.Label_PR.Size = New System.Drawing.Size(31, 19)
        Me.Label_PR.TabIndex = 8
        Me.Label_PR.Text = "PR"
        '
        'TextBox_1R
        '
        Me.TextBox_1R.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_1R.Location = New System.Drawing.Point(850, 495)
        Me.TextBox_1R.Name = "TextBox_1R"
        Me.TextBox_1R.ReadOnly = True
        Me.TextBox_1R.Size = New System.Drawing.Size(69, 29)
        Me.TextBox_1R.TabIndex = 7
        Me.TextBox_1R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_1R
        '
        Me.Label_1R.AutoSize = True
        Me.Label_1R.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_1R.Location = New System.Drawing.Point(802, 498)
        Me.Label_1R.Name = "Label_1R"
        Me.Label_1R.Size = New System.Drawing.Size(42, 19)
        Me.Label_1R.TabIndex = 6
        Me.Label_1R.Text = "1/R"
        '
        'TextBox_ModifiedCoefficient
        '
        Me.TextBox_ModifiedCoefficient.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_ModifiedCoefficient.Location = New System.Drawing.Point(598, 521)
        Me.TextBox_ModifiedCoefficient.Name = "TextBox_ModifiedCoefficient"
        Me.TextBox_ModifiedCoefficient.Size = New System.Drawing.Size(69, 29)
        Me.TextBox_ModifiedCoefficient.TabIndex = 11
        Me.TextBox_ModifiedCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_ModifiedCoefficient
        '
        Me.Label_ModifiedCoefficient.AutoSize = True
        Me.Label_ModifiedCoefficient.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_ModifiedCoefficient.Location = New System.Drawing.Point(434, 524)
        Me.Label_ModifiedCoefficient.Name = "Label_ModifiedCoefficient"
        Me.Label_ModifiedCoefficient.Size = New System.Drawing.Size(149, 19)
        Me.Label_ModifiedCoefficient.TabIndex = 10
        Me.Label_ModifiedCoefficient.Text = "温差修正系数ψ"
        '
        'Button_OK
        '
        Me.Button_OK.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_OK.Location = New System.Drawing.Point(413, 566)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(84, 34)
        Me.Button_OK.TabIndex = 12
        Me.Button_OK.Text = "确定"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(607, 566)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(84, 34)
        Me.Button_Cancel.TabIndex = 13
        Me.Button_Cancel.Text = "取消"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Label_FlowType
        '
        Me.Label_FlowType.AutoSize = True
        Me.Label_FlowType.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_FlowType.Location = New System.Drawing.Point(193, 454)
        Me.Label_FlowType.Name = "Label_FlowType"
        Me.Label_FlowType.Size = New System.Drawing.Size(129, 19)
        Me.Label_FlowType.TabIndex = 14
        Me.Label_FlowType.Text = "流体流动方式"
        '
        'Form_TemperatureModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 625)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.Label_FlowType)
        Me.Controls.Add(Me.TextBox_ModifiedCoefficient)
        Me.Controls.Add(Me.Label_ModifiedCoefficient)
        Me.Controls.Add(Me.TextBox_PR)
        Me.Controls.Add(Me.Label_PR)
        Me.Controls.Add(Me.TextBox_1R)
        Me.Controls.Add(Me.Label_1R)
        Me.Controls.Add(Me.TextBox_P)
        Me.Controls.Add(Me.Label_P)
        Me.Controls.Add(Me.TextBox_R)
        Me.Controls.Add(Me.Label_R)
        Me.Controls.Add(Me.PictureBox_ModifiedCoefficient)
        Me.Controls.Add(Me.ComboBox_FlowType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_TemperatureModify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "平均温差修正"
        CType(Me.PictureBox_ModifiedCoefficient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_FlowType As ComboBox
    Friend WithEvents PictureBox_ModifiedCoefficient As PictureBox
    Friend WithEvents Label_R As Label
    Friend WithEvents TextBox_R As TextBox
    Friend WithEvents TextBox_P As TextBox
    Friend WithEvents Label_P As Label
    Friend WithEvents TextBox_PR As TextBox
    Friend WithEvents Label_PR As Label
    Friend WithEvents TextBox_1R As TextBox
    Friend WithEvents Label_1R As Label
    Friend WithEvents TextBox_ModifiedCoefficient As TextBox
    Friend WithEvents Label_ModifiedCoefficient As Label
    Friend WithEvents Button_OK As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Label_FlowType As Label
End Class
