<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox_Design = New System.Windows.Forms.GroupBox()
        Me.Button_Design_NTU = New System.Windows.Forms.Button()
        Me.Button_Design_CMTD = New System.Windows.Forms.Button()
        Me.GroupBox_Check = New System.Windows.Forms.GroupBox()
        Me.Button_Check_NTU = New System.Windows.Forms.Button()
        Me.Button_Check_CMTD = New System.Windows.Forms.Button()
        Me.GroupBox_Design.SuspendLayout()
        Me.GroupBox_Check.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Design
        '
        Me.GroupBox_Design.Controls.Add(Me.Button_Design_NTU)
        Me.GroupBox_Design.Controls.Add(Me.Button_Design_CMTD)
        Me.GroupBox_Design.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox_Design.Location = New System.Drawing.Point(20, 14)
        Me.GroupBox_Design.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox_Design.Name = "GroupBox_Design"
        Me.GroupBox_Design.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox_Design.Size = New System.Drawing.Size(302, 89)
        Me.GroupBox_Design.TabIndex = 0
        Me.GroupBox_Design.TabStop = False
        Me.GroupBox_Design.Text = "设计计算"
        '
        'Button_Design_NTU
        '
        Me.Button_Design_NTU.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Design_NTU.Location = New System.Drawing.Point(174, 24)
        Me.Button_Design_NTU.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Design_NTU.Name = "Button_Design_NTU"
        Me.Button_Design_NTU.Size = New System.Drawing.Size(118, 46)
        Me.Button_Design_NTU.TabIndex = 1
        Me.Button_Design_NTU.Text = "传热单元数法"
        Me.Button_Design_NTU.UseVisualStyleBackColor = True
        '
        'Button_Design_CMTD
        '
        Me.Button_Design_CMTD.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Design_CMTD.Location = New System.Drawing.Point(10, 24)
        Me.Button_Design_CMTD.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Design_CMTD.Name = "Button_Design_CMTD"
        Me.Button_Design_CMTD.Size = New System.Drawing.Size(118, 46)
        Me.Button_Design_CMTD.TabIndex = 0
        Me.Button_Design_CMTD.Text = "平均温差法"
        Me.Button_Design_CMTD.UseVisualStyleBackColor = True
        '
        'GroupBox_Check
        '
        Me.GroupBox_Check.Controls.Add(Me.Button_Check_NTU)
        Me.GroupBox_Check.Controls.Add(Me.Button_Check_CMTD)
        Me.GroupBox_Check.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox_Check.Location = New System.Drawing.Point(373, 14)
        Me.GroupBox_Check.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox_Check.Name = "GroupBox_Check"
        Me.GroupBox_Check.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox_Check.Size = New System.Drawing.Size(302, 89)
        Me.GroupBox_Check.TabIndex = 1
        Me.GroupBox_Check.TabStop = False
        Me.GroupBox_Check.Text = "校核计算"
        '
        'Button_Check_NTU
        '
        Me.Button_Check_NTU.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Check_NTU.Location = New System.Drawing.Point(174, 24)
        Me.Button_Check_NTU.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Check_NTU.Name = "Button_Check_NTU"
        Me.Button_Check_NTU.Size = New System.Drawing.Size(118, 46)
        Me.Button_Check_NTU.TabIndex = 1
        Me.Button_Check_NTU.Text = "传热单元数法"
        Me.Button_Check_NTU.UseVisualStyleBackColor = True
        '
        'Button_Check_CMTD
        '
        Me.Button_Check_CMTD.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Check_CMTD.Location = New System.Drawing.Point(10, 24)
        Me.Button_Check_CMTD.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Check_CMTD.Name = "Button_Check_CMTD"
        Me.Button_Check_CMTD.Size = New System.Drawing.Size(118, 46)
        Me.Button_Check_CMTD.TabIndex = 0
        Me.Button_Check_CMTD.Text = "平均温差法"
        Me.Button_Check_CMTD.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 120)
        Me.Controls.Add(Me.GroupBox_Check)
        Me.Controls.Add(Me.GroupBox_Design)
        Me.Font = New System.Drawing.Font("SimSun", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "换热器热计算"
        Me.GroupBox_Design.ResumeLayout(False)
        Me.GroupBox_Check.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_Design As GroupBox
    Friend WithEvents Button_Design_NTU As Button
    Friend WithEvents Button_Design_CMTD As Button
    Friend WithEvents GroupBox_Check As GroupBox
    Friend WithEvents Button_Check_NTU As Button
    Friend WithEvents Button_Check_CMTD As Button
End Class
