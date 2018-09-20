Public Class Form1
    Private buttonArry As Array
    'Function for resizing form to be used for set button functionality in TimePanel class
    Public Sub ResizeForm()
        buttonArry = New Button() {DigitButton1, DigitButton2, DigitButton3, DigitButton4, DigitButton5, DigitButton6, DigitButton7, DigitButton8, DigitButton9}
        ButtonEnabler(buttonArry)
        Me.Size = New System.Drawing.Size(870, 551) 'resize form to make keypad visiable 
        'TabControl1.Enabled = False
        Timer1.Enabled = False  'Disables the timer so the time can be set
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set each panel the form they will be interacting with (this form)
        MessageBox.Show("Hey there I am MetaClock 1.0. congratulations on being my first ever user. Hope you enjoy using me. :)")
        AlarmPanel3.Intialize(Me, KeyPadPanel, My.Resources.World)
        AlarmPanel2.Intialize(Me, KeyPadPanel, My.Resources.Bee)
        AlarmPanel1.Intialize(Me, KeyPadPanel, My.Resources.Twister)
        ClockTimePanel.IntializeForClock(Me)
        Me.Size = New System.Drawing.Size(870, 328) 'resize form to make keypad invisiable 
    End Sub



    Private Sub ClockTimePanel_Load(sender As Object, e As EventArgs) Handles ClockTimePanel.Load
        ClockTimePanel.SetAmPmCurrent(TimeOfDay) 'sets the right Radio button for AM OR PM
        ClockTimePanel.SetTime(Format(TimeOfDay, "hh:mm")) 'sets the LED screen the current time
    End Sub

    Private Sub ClockTabPage_Click(sender As Object, e As EventArgs) Handles ClockTabPage.Click

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelKeypadButton.Click
        Me.Size = New System.Drawing.Size(870, 328) 'resize form to make keypad visiable 
        'TabControl1.Enabled = True
        If ClockTimePanel.GetIsClockBeingSet Then 'if Tab  that is select has a C in it's name .i.e if it's ClockTime
            ClockTimePanel.SetTime(ClockTimePanel.GetOldTime)
        ElseIf AlarmPanel3.GetIsbeingSet Then 'if the alarm is being set then response to button
            AlarmPanel3.SetTime(AlarmPanel3.GetOldTime)
        ElseIf AlarmPanel2.GetIsbeingSet Then
            AlarmPanel2.SetTime(AlarmPanel2.GetOldTime)
        Else : AlarmPanel1.SetTime(AlarmPanel1.GetOldTime)
        End If
        'Indicating that the Panels are not being set. Time Panel and Alarm uses this know which Panel is being update by the keypad
        ClockTimePanel.ClockisNotBeingSet()
        AlarmPanel3.unSetMeForKeypad()
        AlarmPanel2.unSetMeForKeypad()
        AlarmPanel1.unSetMeForKeypad()
        ClockTimePanel.recolorBlackDigit()
        AlarmPanel3.recolorBlackDigit()
        AlarmPanel2.recolorBlackDigit()
        AlarmPanel1.recolorBlackDigit()
        'Enables the Timer
        Timer1.Enabled = True




    End Sub
    'Turns on Alarm when check is checked on ClockTab
    '----------------------------------------------------------------

    Private Sub Alarm1CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm1CheckBox.CheckedChanged
        If Alarm1CheckBox.Checked = True Then
            AlarmPanel1.TurnOnAlarm()
        Else : AlarmPanel1.TurnOffAlarm()
        End If
    End Sub

    Private Sub Alarm2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm2CheckBox.CheckedChanged
        If Alarm2CheckBox.Checked = True Then
            AlarmPanel2.TurnOnAlarm()
        Else : AlarmPanel2.TurnOffAlarm()
        End If
    End Sub

    Private Sub Alarm3CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm3CheckBox.CheckedChanged
        If Alarm3CheckBox.Checked = True Then
            AlarmPanel3.TurnOnAlarm()
        Else : AlarmPanel3.TurnOffAlarm()
        End If
    End Sub

    '----------------------------------------------------------------
    'Disables Buttons based on maxDigit of current DigitLED
    Public Sub ButtonDisabler(ByVal maxDigit As Integer, ByVal DisableZero As Boolean)
        buttonArry = New Button() {DigitButton1, DigitButton2, DigitButton3, DigitButton4, DigitButton5, DigitButton6, DigitButton7, DigitButton8, DigitButton9, DigitButton0}
        For i = 0 To 8 'Length og first dimenesion 
            If i + 1 > maxDigit Then
                buttonArry(i).Enabled = False
                buttonArry(i).BackColor = Color.Gray
            End If
        Next
        'If Zero button is to be enabled
        If DisableZero Then
            buttonArry(9).Enabled = False
            buttonArry(9).BackColor = Color.Gray
        End If
        'Disabling ok button
        OkButton.Enabled = False
        OkButton.BackColor = Color.Gray
    End Sub
    '----------------------------------------------------------------
    'Enables Buttons based on maxDigit of current DigitLED
    Public Sub ButtonEnabler(ByVal buttonArry As Array)
        buttonArry = New Button() {DigitButton1, DigitButton2, DigitButton3, DigitButton4, DigitButton5, DigitButton6, DigitButton7, DigitButton8, DigitButton9, DigitButton0}
        For i = 0 To 8 'Length og first dimenesion 
            buttonArry(i).Enabled = True
            buttonArry(i).BackColor = Color.White
        Next
        'Enable Zero
        buttonArry(9).Enabled = True
        buttonArry(9).BackColor = Color.White
        'Enabling ok button
        OkButton.Enabled = True
        OkButton.BackColor = Color.White
    End Sub
    'Handler for KeyPad digits 
    Private Sub DigitButton1_Click(sender As Object, e As EventArgs) Handles DigitButton1.Click, DigitButton0.Click, DigitButton2.Click, DigitButton3.Click, DigitButton4.Click, DigitButton5.Click, DigitButton6.Click, DigitButton7.Click, DigitButton8.Click, DigitButton9.Click
        Dim button As Button = sender
        buttonArry = New Button() {DigitButton1, DigitButton2, DigitButton3, DigitButton4, DigitButton5, DigitButton6, DigitButton7, DigitButton8, DigitButton9}
        ButtonEnabler(buttonArry) 'Endable all buttons. Right buttons will be disabled by SetTimeFromKeyPad invoking ButtonDisabler on this form
        If ClockTimePanel.GetIsClockBeingSet Then 'if Tab  that is select has a C in it's name .i.e if it's ClockTime
            ClockTimePanel.SetTimeFromKeyPad(button.Text)
        ElseIf AlarmPanel3.GetIsbeingSet Then 'if the alarm is being set then response to button
            AlarmPanel3.SetTimeFromKeyPad(button.Text)
        ElseIf AlarmPanel2.GetIsbeingSet Then
            AlarmPanel2.SetTimeFromKeyPad(button.Text)
        Else : AlarmPanel1.SetTimeFromKeyPad(button.Text)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ClockTime As String
        ClockTime = ClockTimePanel.GetTime()
        Dim newTime As Date = DateAdd(DateInterval.Minute, 1, TimeValue(ClockTime))
        ClockTimePanel.SetTime(newTime.ToString("hh:mm tt"))
        If AlarmPanel1.GetAlarmTime.Contains(newTime.ToString("hh:mm tt")) Then
            If Alarm1CheckBox.Checked Then
                AlarmPanel1.PlayGif()
                TabControl1.SelectedTab = AlarmTabPage1
            End If
        End If
        If AlarmPanel2.GetAlarmTime.Contains(newTime.ToString("hh:mm tt")) Then
            If Alarm2CheckBox.Checked Then
                AlarmPanel2.PlayGif()
                TabControl1.SelectedTab = AlarmTabPage2
            End If
        End If
        If AlarmPanel3.GetAlarmTime.Contains(newTime.ToString("hh:mm tt")) Then
            If Alarm2CheckBox.Checked Then
                AlarmPanel3.PlayGif()
                TabControl1.SelectedTab = AlarmTabpage3
            End If
        End If
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Me.Size = New System.Drawing.Size(870, 328) 'resize form to make keypad visiable 
        'TabControl1.Enabled = True
        If ClockTimePanel.GetIsClockBeingSet Then 'if Tab  that is select has a C in it's name .i.e if it's ClockTime
            ClockTimePanel.SetOldTime()
        ElseIf AlarmPanel1.GetIsbeingSet Then 'if the alarm is being set then response to button
            AlarmPanel1.SetOldTime()
        ElseIf AlarmPanel2.GetIsbeingSet Then
            AlarmPanel2.SetOldTime()
        Else : AlarmPanel3.SetOldTime()
        End If
        'Indicating that the Panels are not being set. Time Panel and Alarm uses this know which Panel is being update by the keypad
        ClockTimePanel.ClockisNotBeingSet()
        AlarmPanel3.unSetMeForKeypad()
        AlarmPanel2.unSetMeForKeypad()
        AlarmPanel1.unSetMeForKeypad()
        ClockTimePanel.recolorBlackDigit()
        AlarmPanel3.recolorBlackDigit()
        AlarmPanel2.recolorBlackDigit()
        AlarmPanel1.recolorBlackDigit()
        Timer1.Enabled = True 'Enable the timer so clock ticks again
    End Sub
    'Sets Alarm check boxes on clock tab at resquest of AlarmPanel
    Public Sub ClickMyAlarmCheckBox(ByVal Name As String, ByVal checkBoxValue As Boolean)
        If Name.Contains("1") Then
            Alarm1CheckBox.Checked = checkBoxValue
        ElseIf Name.Contains("2") Then
            Alarm2CheckBox.Checked = checkBoxValue
        Else : Alarm3CheckBox.Checked = checkBoxValue
        End If
    End Sub
    Private Sub AlarmPanel3_Load(sender As Object, e As EventArgs)

    End Sub
End Class
