<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ClockTabPage = New System.Windows.Forms.TabPage()
        Me.Alarm2CheckBox = New System.Windows.Forms.CheckBox()
        Me.Alarm3CheckBox = New System.Windows.Forms.CheckBox()
        Me.Alarm1CheckBox = New System.Windows.Forms.CheckBox()
        Me.ClockTimePanel = New AlarmClock.TimePanel()
        Me.AlarmTabPage1 = New System.Windows.Forms.TabPage()
        Me.AlarmPanel1 = New AlarmClock.AlarmPanel()
        Me.AlarmTabPage2 = New System.Windows.Forms.TabPage()
        Me.AlarmPanel2 = New AlarmClock.AlarmPanel()
        Me.AlarmTabpage3 = New System.Windows.Forms.TabPage()
        Me.AlarmPanel3 = New AlarmClock.AlarmPanel()
        Me.DigitButton1 = New System.Windows.Forms.Button()
        Me.DigitButton2 = New System.Windows.Forms.Button()
        Me.DigitButton3 = New System.Windows.Forms.Button()
        Me.DigitButton4 = New System.Windows.Forms.Button()
        Me.DigitButton5 = New System.Windows.Forms.Button()
        Me.DigitButton6 = New System.Windows.Forms.Button()
        Me.DigitButton7 = New System.Windows.Forms.Button()
        Me.DigitButton8 = New System.Windows.Forms.Button()
        Me.DigitButton9 = New System.Windows.Forms.Button()
        Me.DigitButton0 = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.CancelKeypadButton = New System.Windows.Forms.Button()
        Me.KeyPadPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.ClockTabPage.SuspendLayout()
        Me.AlarmTabPage1.SuspendLayout()
        Me.AlarmTabPage2.SuspendLayout()
        Me.AlarmTabpage3.SuspendLayout()
        Me.KeyPadPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ClockTabPage)
        Me.TabControl1.Controls.Add(Me.AlarmTabPage1)
        Me.TabControl1.Controls.Add(Me.AlarmTabPage2)
        Me.TabControl1.Controls.Add(Me.AlarmTabpage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 9)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(833, 277)
        Me.TabControl1.TabIndex = 0
        '
        'ClockTabPage
        '
        Me.ClockTabPage.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClockTabPage.Controls.Add(Me.Alarm2CheckBox)
        Me.ClockTabPage.Controls.Add(Me.Alarm3CheckBox)
        Me.ClockTabPage.Controls.Add(Me.Alarm1CheckBox)
        Me.ClockTabPage.Controls.Add(Me.ClockTimePanel)
        Me.ClockTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ClockTabPage.Name = "ClockTabPage"
        Me.ClockTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ClockTabPage.Size = New System.Drawing.Size(825, 251)
        Me.ClockTabPage.TabIndex = 0
        Me.ClockTabPage.Text = "Clock"
        '
        'Alarm2CheckBox
        '
        Me.Alarm2CheckBox.AutoSize = True
        Me.Alarm2CheckBox.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alarm2CheckBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Alarm2CheckBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Alarm2CheckBox.Location = New System.Drawing.Point(406, 83)
        Me.Alarm2CheckBox.Name = "Alarm2CheckBox"
        Me.Alarm2CheckBox.Size = New System.Drawing.Size(106, 26)
        Me.Alarm2CheckBox.TabIndex = 6
        Me.Alarm2CheckBox.Text = "Alarm 2"
        Me.Alarm2CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Alarm2CheckBox.UseVisualStyleBackColor = True
        '
        'Alarm3CheckBox
        '
        Me.Alarm3CheckBox.AutoSize = True
        Me.Alarm3CheckBox.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alarm3CheckBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Alarm3CheckBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Alarm3CheckBox.Location = New System.Drawing.Point(406, 159)
        Me.Alarm3CheckBox.Name = "Alarm3CheckBox"
        Me.Alarm3CheckBox.Size = New System.Drawing.Size(106, 26)
        Me.Alarm3CheckBox.TabIndex = 5
        Me.Alarm3CheckBox.Text = "Alarm 3"
        Me.Alarm3CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Alarm3CheckBox.UseVisualStyleBackColor = True
        '
        'Alarm1CheckBox
        '
        Me.Alarm1CheckBox.AutoSize = True
        Me.Alarm1CheckBox.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alarm1CheckBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Alarm1CheckBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Alarm1CheckBox.Location = New System.Drawing.Point(406, 18)
        Me.Alarm1CheckBox.Name = "Alarm1CheckBox"
        Me.Alarm1CheckBox.Size = New System.Drawing.Size(106, 26)
        Me.Alarm1CheckBox.TabIndex = 4
        Me.Alarm1CheckBox.Text = "Alarm 1"
        Me.Alarm1CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Alarm1CheckBox.UseVisualStyleBackColor = True
        '
        'ClockTimePanel
        '
        Me.ClockTimePanel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClockTimePanel.IsClockPanel = False
        Me.ClockTimePanel.Location = New System.Drawing.Point(6, 6)
        Me.ClockTimePanel.Name = "ClockTimePanel"
        Me.ClockTimePanel.Size = New System.Drawing.Size(372, 190)
        Me.ClockTimePanel.TabIndex = 0
        '
        'AlarmTabPage1
        '
        Me.AlarmTabPage1.Controls.Add(Me.AlarmPanel1)
        Me.AlarmTabPage1.Location = New System.Drawing.Point(4, 22)
        Me.AlarmTabPage1.Name = "AlarmTabPage1"
        Me.AlarmTabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.AlarmTabPage1.Size = New System.Drawing.Size(825, 251)
        Me.AlarmTabPage1.TabIndex = 1
        Me.AlarmTabPage1.Text = "Alarm 1"
        Me.AlarmTabPage1.UseVisualStyleBackColor = True
        '
        'AlarmPanel1
        '
        Me.AlarmPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.AlarmPanel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.AlarmPanel1.Location = New System.Drawing.Point(7, 4)
        Me.AlarmPanel1.Name = "AlarmPanel1"
        Me.AlarmPanel1.Size = New System.Drawing.Size(818, 244)
        Me.AlarmPanel1.TabIndex = 0
        '
        'AlarmTabPage2
        '
        Me.AlarmTabPage2.Controls.Add(Me.AlarmPanel2)
        Me.AlarmTabPage2.Location = New System.Drawing.Point(4, 22)
        Me.AlarmTabPage2.Name = "AlarmTabPage2"
        Me.AlarmTabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.AlarmTabPage2.Size = New System.Drawing.Size(825, 251)
        Me.AlarmTabPage2.TabIndex = 2
        Me.AlarmTabPage2.Text = "Alarm 2"
        Me.AlarmTabPage2.UseVisualStyleBackColor = True
        '
        'AlarmPanel2
        '
        Me.AlarmPanel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.AlarmPanel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.AlarmPanel2.Location = New System.Drawing.Point(3, 3)
        Me.AlarmPanel2.Name = "AlarmPanel2"
        Me.AlarmPanel2.Size = New System.Drawing.Size(818, 244)
        Me.AlarmPanel2.TabIndex = 1
        '
        'AlarmTabpage3
        '
        Me.AlarmTabpage3.Controls.Add(Me.AlarmPanel3)
        Me.AlarmTabpage3.Location = New System.Drawing.Point(4, 22)
        Me.AlarmTabpage3.Name = "AlarmTabpage3"
        Me.AlarmTabpage3.Padding = New System.Windows.Forms.Padding(3)
        Me.AlarmTabpage3.Size = New System.Drawing.Size(825, 251)
        Me.AlarmTabpage3.TabIndex = 3
        Me.AlarmTabpage3.Text = "Alarm 3"
        Me.AlarmTabpage3.UseVisualStyleBackColor = True
        '
        'AlarmPanel3
        '
        Me.AlarmPanel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.AlarmPanel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.AlarmPanel3.Location = New System.Drawing.Point(3, 3)
        Me.AlarmPanel3.Name = "AlarmPanel3"
        Me.AlarmPanel3.Size = New System.Drawing.Size(818, 244)
        Me.AlarmPanel3.TabIndex = 1
        '
        'DigitButton1
        '
        Me.DigitButton1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DigitButton1.Location = New System.Drawing.Point(31, 4)
        Me.DigitButton1.Name = "DigitButton1"
        Me.DigitButton1.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton1.TabIndex = 0
        Me.DigitButton1.Text = "1"
        Me.DigitButton1.UseVisualStyleBackColor = False
        '
        'DigitButton2
        '
        Me.DigitButton2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DigitButton2.Location = New System.Drawing.Point(129, 4)
        Me.DigitButton2.Name = "DigitButton2"
        Me.DigitButton2.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton2.TabIndex = 1
        Me.DigitButton2.Text = "2"
        Me.DigitButton2.UseVisualStyleBackColor = False
        '
        'DigitButton3
        '
        Me.DigitButton3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DigitButton3.Location = New System.Drawing.Point(225, 4)
        Me.DigitButton3.Name = "DigitButton3"
        Me.DigitButton3.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton3.TabIndex = 2
        Me.DigitButton3.Text = "3"
        Me.DigitButton3.UseVisualStyleBackColor = False
        '
        'DigitButton4
        '
        Me.DigitButton4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DigitButton4.Location = New System.Drawing.Point(31, 55)
        Me.DigitButton4.Name = "DigitButton4"
        Me.DigitButton4.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton4.TabIndex = 3
        Me.DigitButton4.Text = "4"
        Me.DigitButton4.UseVisualStyleBackColor = False
        '
        'DigitButton5
        '
        Me.DigitButton5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DigitButton5.Location = New System.Drawing.Point(129, 55)
        Me.DigitButton5.Name = "DigitButton5"
        Me.DigitButton5.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton5.TabIndex = 4
        Me.DigitButton5.Text = "5"
        Me.DigitButton5.UseVisualStyleBackColor = False
        '
        'DigitButton6
        '
        Me.DigitButton6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DigitButton6.Location = New System.Drawing.Point(225, 55)
        Me.DigitButton6.Name = "DigitButton6"
        Me.DigitButton6.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton6.TabIndex = 5
        Me.DigitButton6.Text = "6"
        Me.DigitButton6.UseVisualStyleBackColor = False
        '
        'DigitButton7
        '
        Me.DigitButton7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DigitButton7.Location = New System.Drawing.Point(31, 106)
        Me.DigitButton7.Name = "DigitButton7"
        Me.DigitButton7.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton7.TabIndex = 6
        Me.DigitButton7.Text = "7"
        Me.DigitButton7.UseVisualStyleBackColor = False
        '
        'DigitButton8
        '
        Me.DigitButton8.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DigitButton8.Location = New System.Drawing.Point(129, 106)
        Me.DigitButton8.Name = "DigitButton8"
        Me.DigitButton8.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton8.TabIndex = 7
        Me.DigitButton8.Text = "8"
        Me.DigitButton8.UseVisualStyleBackColor = False
        '
        'DigitButton9
        '
        Me.DigitButton9.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DigitButton9.Location = New System.Drawing.Point(225, 106)
        Me.DigitButton9.Name = "DigitButton9"
        Me.DigitButton9.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton9.TabIndex = 8
        Me.DigitButton9.Text = "9"
        Me.DigitButton9.UseVisualStyleBackColor = False
        '
        'DigitButton0
        '
        Me.DigitButton0.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DigitButton0.Location = New System.Drawing.Point(129, 157)
        Me.DigitButton0.Name = "DigitButton0"
        Me.DigitButton0.Size = New System.Drawing.Size(64, 45)
        Me.DigitButton0.TabIndex = 9
        Me.DigitButton0.Text = "0"
        Me.DigitButton0.UseVisualStyleBackColor = False
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.SystemColors.HighlightText
        Me.OkButton.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.OkButton.Location = New System.Drawing.Point(384, 83)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(95, 44)
        Me.OkButton.TabIndex = 10
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'CancelKeypadButton
        '
        Me.CancelKeypadButton.BackColor = System.Drawing.SystemColors.HighlightText
        Me.CancelKeypadButton.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelKeypadButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CancelKeypadButton.Location = New System.Drawing.Point(514, 83)
        Me.CancelKeypadButton.Name = "CancelKeypadButton"
        Me.CancelKeypadButton.Size = New System.Drawing.Size(95, 44)
        Me.CancelKeypadButton.TabIndex = 11
        Me.CancelKeypadButton.Text = "Cancel"
        Me.CancelKeypadButton.UseVisualStyleBackColor = False
        '
        'KeyPadPanel
        '
        Me.KeyPadPanel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.KeyPadPanel.Controls.Add(Me.CancelKeypadButton)
        Me.KeyPadPanel.Controls.Add(Me.OkButton)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton0)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton9)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton8)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton7)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton6)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton5)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton4)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton3)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton2)
        Me.KeyPadPanel.Controls.Add(Me.DigitButton1)
        Me.KeyPadPanel.Location = New System.Drawing.Point(12, 292)
        Me.KeyPadPanel.Name = "KeyPadPanel"
        Me.KeyPadPanel.Size = New System.Drawing.Size(833, 210)
        Me.KeyPadPanel.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 512)
        Me.Controls.Add(Me.KeyPadPanel)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "MetaClock by Kenneth Uyabeme"
        Me.TabControl1.ResumeLayout(False)
        Me.ClockTabPage.ResumeLayout(False)
        Me.ClockTabPage.PerformLayout()
        Me.AlarmTabPage1.ResumeLayout(False)
        Me.AlarmTabPage2.ResumeLayout(False)
        Me.AlarmTabpage3.ResumeLayout(False)
        Me.KeyPadPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ClockTabPage As System.Windows.Forms.TabPage
    Friend WithEvents AlarmTabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents AlarmTabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents AlarmTabpage3 As System.Windows.Forms.TabPage
    Friend WithEvents ClockTimePanel As AlarmClock.TimePanel
    Friend WithEvents Alarm2CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Alarm3CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Alarm1CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DigitButton1 As System.Windows.Forms.Button
    Friend WithEvents DigitButton2 As System.Windows.Forms.Button
    Friend WithEvents DigitButton3 As System.Windows.Forms.Button
    Friend WithEvents DigitButton4 As System.Windows.Forms.Button
    Friend WithEvents DigitButton5 As System.Windows.Forms.Button
    Friend WithEvents DigitButton6 As System.Windows.Forms.Button
    Friend WithEvents DigitButton7 As System.Windows.Forms.Button
    Friend WithEvents DigitButton8 As System.Windows.Forms.Button
    Friend WithEvents DigitButton9 As System.Windows.Forms.Button
    Friend WithEvents DigitButton0 As System.Windows.Forms.Button
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents CancelKeypadButton As System.Windows.Forms.Button
    Friend WithEvents KeyPadPanel As System.Windows.Forms.Panel
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AlarmPanel1 As AlarmClock.AlarmPanel
    Friend WithEvents AlarmPanel2 As AlarmClock.AlarmPanel
    Friend WithEvents AlarmPanel3 As AlarmClock.AlarmPanel

End Class
