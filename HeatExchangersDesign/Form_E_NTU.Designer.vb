<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_E_NTU
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
        Me.PictureBox_E_NTU = New System.Windows.Forms.PictureBox()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.TextBox_NTU = New System.Windows.Forms.TextBox()
        Me.Label_NTU = New System.Windows.Forms.Label()
        Me.TextBox_Effectiveness = New System.Windows.Forms.TextBox()
        Me.Label_Effectiveness = New System.Windows.Forms.Label()
        Me.TextBox_Cr = New System.Windows.Forms.TextBox()
        Me.Label_Cr = New System.Windows.Forms.Label()
        Me.Label_MixedType = New System.Windows.Forms.Label()
        Me.ComboBox_MixedType = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox_E_NTU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_E_NTU
        '
        Me.PictureBox_E_NTU.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_E_NTU.Name = "PictureBox_E_NTU"
        Me.PictureBox_E_NTU.Size = New System.Drawing.Size(643, 649)
        Me.PictureBox_E_NTU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_E_NTU.TabIndex = 0
        Me.PictureBox_E_NTU.TabStop = False
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(688, 512)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(84, 34)
        Me.Button_Cancel.TabIndex = 15
        Me.Button_Cancel.Text = "取消"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_OK
        '
        Me.Button_OK.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_OK.Location = New System.Drawing.Point(688, 441)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(84, 34)
        Me.Button_OK.TabIndex = 14
        Me.Button_OK.Text = "确定"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'TextBox_NTU
        '
        Me.TextBox_NTU.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_NTU.Location = New System.Drawing.Point(674, 356)
        Me.TextBox_NTU.Name = "TextBox_NTU"
        Me.TextBox_NTU.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_NTU.TabIndex = 26
        Me.TextBox_NTU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_NTU
        '
        Me.Label_NTU.AutoSize = True
        Me.Label_NTU.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_NTU.Location = New System.Drawing.Point(666, 325)
        Me.Label_NTU.Name = "Label_NTU"
        Me.Label_NTU.Size = New System.Drawing.Size(142, 19)
        Me.Label_NTU.TabIndex = 25
        Me.Label_NTU.Text = "传热单元数NTU"
        '
        'TextBox_Effectiveness
        '
        Me.TextBox_Effectiveness.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_Effectiveness.Location = New System.Drawing.Point(674, 264)
        Me.TextBox_Effectiveness.Name = "TextBox_Effectiveness"
        Me.TextBox_Effectiveness.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_Effectiveness.TabIndex = 24
        Me.TextBox_Effectiveness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Effectiveness
        '
        Me.Label_Effectiveness.AutoSize = True
        Me.Label_Effectiveness.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Effectiveness.Location = New System.Drawing.Point(666, 230)
        Me.Label_Effectiveness.Name = "Label_Effectiveness"
        Me.Label_Effectiveness.Size = New System.Drawing.Size(129, 19)
        Me.Label_Effectiveness.TabIndex = 23
        Me.Label_Effectiveness.Text = "换热器效能ε"
        '
        'TextBox_Cr
        '
        Me.TextBox_Cr.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox_Cr.Location = New System.Drawing.Point(674, 173)
        Me.TextBox_Cr.Name = "TextBox_Cr"
        Me.TextBox_Cr.ReadOnly = True
        Me.TextBox_Cr.Size = New System.Drawing.Size(68, 29)
        Me.TextBox_Cr.TabIndex = 28
        Me.TextBox_Cr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Cr
        '
        Me.Label_Cr.AutoSize = True
        Me.Label_Cr.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Cr.Location = New System.Drawing.Point(666, 139)
        Me.Label_Cr.Name = "Label_Cr"
        Me.Label_Cr.Size = New System.Drawing.Size(91, 19)
        Me.Label_Cr.TabIndex = 27
        Me.Label_Cr.Text = "热容比Cr"
        '
        'Label_MixedType
        '
        Me.Label_MixedType.AutoSize = True
        Me.Label_MixedType.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_MixedType.Location = New System.Drawing.Point(666, 61)
        Me.Label_MixedType.Name = "Label_MixedType"
        Me.Label_MixedType.Size = New System.Drawing.Size(129, 19)
        Me.Label_MixedType.TabIndex = 29
        Me.Label_MixedType.Text = "流体是否混合"
        '
        'ComboBox_MixedType
        '
        Me.ComboBox_MixedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_MixedType.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox_MixedType.FormattingEnabled = True
        Me.ComboBox_MixedType.Items.AddRange(New Object() {"不混合", "壳侧混合", "管侧混合"})
        Me.ComboBox_MixedType.Location = New System.Drawing.Point(670, 83)
        Me.ComboBox_MixedType.Name = "ComboBox_MixedType"
        Me.ComboBox_MixedType.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox_MixedType.TabIndex = 30
        '
        'Form_E_NTU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 648)
        Me.Controls.Add(Me.ComboBox_MixedType)
        Me.Controls.Add(Me.Label_MixedType)
        Me.Controls.Add(Me.TextBox_Cr)
        Me.Controls.Add(Me.Label_Cr)
        Me.Controls.Add(Me.TextBox_NTU)
        Me.Controls.Add(Me.Label_NTU)
        Me.Controls.Add(Me.TextBox_Effectiveness)
        Me.Controls.Add(Me.Label_Effectiveness)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.PictureBox_E_NTU)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_E_NTU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ε-NTU线算图"
        CType(Me.PictureBox_E_NTU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox_E_NTU As PictureBox
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_OK As Button
    Friend WithEvents TextBox_NTU As TextBox
    Friend WithEvents Label_NTU As Label
    Friend WithEvents TextBox_Effectiveness As TextBox
    Friend WithEvents Label_Effectiveness As Label
    Friend WithEvents TextBox_Cr As TextBox
    Friend WithEvents Label_Cr As Label
    Friend WithEvents Label_MixedType As Label
    Friend WithEvents ComboBox_MixedType As ComboBox
End Class
