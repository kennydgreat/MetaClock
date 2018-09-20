<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BorderPanel = New System.Windows.Forms.Panel()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.PmRadioButton = New System.Windows.Forms.RadioButton()
        Me.AmRadioButton = New System.Windows.Forms.RadioButton()
        Me.colon = New System.Windows.Forms.Label()
        Me.DigitLED2 = New AlarmClock.DigitLED()
        Me.DigitLED3 = New AlarmClock.DigitLED()
        Me.DigitLED4 = New AlarmClock.DigitLED()
        Me.DigitLED1 = New AlarmClock.DigitLED()
        Me.BorderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorderPanel
        '
        Me.BorderPanel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BorderPanel.Controls.Add(Me.ResetButton)
        Me.BorderPanel.Controls.Add(Me.SetButton)
        Me.BorderPanel.Controls.Add(Me.PmRadioButton)
        Me.BorderPanel.Controls.Add(Me.AmRadioButton)
        Me.BorderPanel.Controls.Add(Me.colon)
        Me.BorderPanel.Controls.Add(Me.DigitLED2)
        Me.BorderPanel.Controls.Add(Me.DigitLED3)
        Me.BorderPanel.Controls.Add(Me.DigitLED4)
        Me.BorderPanel.Controls.Add(Me.DigitLED1)
        Me.BorderPanel.Location = New System.Drawing.Point(19, 13)
        Me.BorderPanel.Name = "BorderPanel"
        Me.BorderPanel.Size = New System.Drawing.Size(335, 162)
        Me.BorderPanel.TabIndex = 0
        '
        'ResetButton
        '
        Me.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ResetButton.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ResetButton.Location = New System.Drawing.Point(169, 120)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(79, 33)
        Me.ResetButton.TabIndex = 8
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'SetButton
        '
        Me.SetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SetButton.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.SetButton.Location = New System.Drawing.Point(33, 120)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(79, 33)
        Me.SetButton.TabIndex = 7
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'PmRadioButton
        '
        Me.PmRadioButton.AutoSize = True
        Me.PmRadioButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PmRadioButton.Location = New System.Drawing.Point(286, 67)
        Me.PmRadioButton.Name = "PmRadioButton"
        Me.PmRadioButton.Size = New System.Drawing.Size(41, 17)
        Me.PmRadioButton.TabIndex = 6
        Me.PmRadioButton.TabStop = True
        Me.PmRadioButton.Text = "PM"
        Me.PmRadioButton.UseVisualStyleBackColor = True
        '
        'AmRadioButton
        '
        Me.AmRadioButton.AutoSize = True
        Me.AmRadioButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.AmRadioButton.Location = New System.Drawing.Point(286, 39)
        Me.AmRadioButton.Name = "AmRadioButton"
        Me.AmRadioButton.Size = New System.Drawing.Size(41, 17)
        Me.AmRadioButton.TabIndex = 5
        Me.AmRadioButton.TabStop = True
        Me.AmRadioButton.Text = "AM"
        Me.AmRadioButton.UseVisualStyleBackColor = True
        '
        'colon
        '
        Me.colon.AutoSize = True
        Me.colon.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.colon.Location = New System.Drawing.Point(118, 28)
        Me.colon.Name = "colon"
        Me.colon.Size = New System.Drawing.Size(50, 56)
        Me.colon.TabIndex = 4
        Me.colon.Text = ":"
        '
        'DigitLED2
        '
        Me.DigitLED2.AutoSize = True
        Me.DigitLED2.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold)
        Me.DigitLED2.Location = New System.Drawing.Point(62, 28)
        Me.DigitLED2.MaxDigit = 0
        Me.DigitLED2.Name = "DigitLED2"
        Me.DigitLED2.Size = New System.Drawing.Size(50, 56)
        Me.DigitLED2.TabIndex = 3
        Me.DigitLED2.Text = "0"
        '
        'DigitLED3
        '
        Me.DigitLED3.AutoSize = True
        Me.DigitLED3.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold)
        Me.DigitLED3.Location = New System.Drawing.Point(159, 28)
        Me.DigitLED3.MaxDigit = 0
        Me.DigitLED3.Name = "DigitLED3"
        Me.DigitLED3.Size = New System.Drawing.Size(50, 56)
        Me.DigitLED3.TabIndex = 2
        Me.DigitLED3.Text = "0"
        '
        'DigitLED4
        '
        Me.DigitLED4.AutoSize = True
        Me.DigitLED4.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold)
        Me.DigitLED4.Location = New System.Drawing.Point(200, 28)
        Me.DigitLED4.MaxDigit = 0
        Me.DigitLED4.Name = "DigitLED4"
        Me.DigitLED4.Size = New System.Drawing.Size(50, 56)
        Me.DigitLED4.TabIndex = 1
        Me.DigitLED4.Text = "0"
        '
        'DigitLED1
        '
        Me.DigitLED1.AutoSize = True
        Me.DigitLED1.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold)
        Me.DigitLED1.Location = New System.Drawing.Point(23, 28)
        Me.DigitLED1.MaxDigit = 0
        Me.DigitLED1.Name = "DigitLED1"
        Me.DigitLED1.Size = New System.Drawing.Size(50, 56)
        Me.DigitLED1.TabIndex = 0
        Me.DigitLED1.Text = "0"
        '
        'TimePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Controls.Add(Me.BorderPanel)
        Me.Name = "TimePanel"
        Me.Size = New System.Drawing.Size(372, 190)
        Me.BorderPanel.ResumeLayout(False)
        Me.BorderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BorderPanel As System.Windows.Forms.Panel
    Friend WithEvents DigitLED1 As AlarmClock.DigitLED
    Friend WithEvents SetButton As System.Windows.Forms.Button
    Friend WithEvents PmRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AmRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents colon As System.Windows.Forms.Label
    Friend WithEvents DigitLED2 As AlarmClock.DigitLED
    Friend WithEvents DigitLED3 As AlarmClock.DigitLED
    Friend WithEvents DigitLED4 As AlarmClock.DigitLED
    Friend WithEvents ResetButton As System.Windows.Forms.Button

End Class
