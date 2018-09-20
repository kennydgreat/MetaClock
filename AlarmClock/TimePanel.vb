Public Class TimePanel
    'Fields
    Private mainForm As Form1 'the form timePanel is interacting with
    Private isBeingSet As Boolean 'Indicate that timepPanel is being set i.e. interaction with keyboard has began
    Private AlarmPanel As AlarmPanel 'The Alarm that will contain this timePanel
    Private isClock As Boolean 'Property of TimePanel and indicates whether Timepanel is a Clock Panel
    Private isClockBeingSet As Boolean 'indicates if Clock Tab is being set
    Private OldTime As String
    'Handlers 
    Private Sub BorderPanel_Paint(sender As Object, e As PaintEventArgs) Handles BorderPanel.Paint

    End Sub
    'Set the form that timePanel will be interacting with and indicate ttime not being set

    Public Sub Intialize(ByVal mainForm1 As Form1, AlarmPanel1 As AlarmPanel)
        mainForm = mainForm1
        'isBeingSet = False
        AlarmPanel = AlarmPanel1
        DigitLED1.MaxDigit = 1
        DigitLED2.MaxDigit = 2
        DigitLED3.MaxDigit = 5
        DigitLED4.MaxDigit = 9
        SetTime("00:00")
        AmRadioButton.Checked = True
        OldTime = GetTime()
    End Sub
    'Intializes the TimePanel as a Clock TimePanel
    Public Sub IntializeForClock(ByVal mainForm1 As Form1)
        DigitLED1.MaxDigit = 1
        DigitLED2.MaxDigit = 2
        DigitLED3.MaxDigit = 5
        DigitLED4.MaxDigit = 9
        mainForm = mainForm1
        isClock = True
        isClockBeingSet = False
    End Sub
    'Set Button handler: Set time LED to 00:00 and checks AM radio Button
    'then and starts interaction with keypad and clear isSet field of DigitLED so 
    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        'Since set time will update Oldtime and we only need to get DigitLeds to 00:00 for setting time 
        DigitLED1.SetDigit("0")
        DigitLED2.SetDigit("0")
        DigitLED3.SetDigit("0")
        DigitLED4.SetDigit("0")
        '----------------------------------
        AmRadioButton.Checked = True ' SET AM radio button
        mainForm.ResizeForm() ' resize form to make form visuable 
        If Not IsClockPanel Then 'if timePanel is for clock tab
            AlarmPanel.setMeForKeypad() 'Indicate that Alarm is being set i.e. interaction with keyboard has began
        Else
            isClockBeingSet = True
        End If
        DigitLED1.UnsetMe()
        DigitLED2.UnsetMe()
        DigitLED3.UnsetMe()
        DigitLED4.UnsetMe()
        mainForm.ButtonDisabler(DigitLED1.MaxDigit, False)
        DigitLED1.ForeColor = Color.White

    End Sub
    'Indicate whether led is set
    ''-----------------------------------------------
    '' Public Function isDigitOneSet() As Boolean
    ''    Return DigitLED1.isLedSet()
    'End Function

    'Public Function isDigitTwoSet() As Boolean
    '    Return DigitLED2.isLedSet()
    'End Function

    'Public Function isDigitThreeSet() As Boolean
    '    Return DigitLED3.isLedSet()
    'End Function

    'Public Function isDigitFourSet() As Boolean
    '    Return DigitLED4.isLedSet()
    'End Function
    ''-----------------------------------------------
    Public Sub SetTimeFromKeyPad(ByVal ButtonText As String)
        If DigitLED1.isLedNotSet Then
            'mainForm.ButtonDisabler(DigitLED1.MaxDigit)
            DigitLED1.SetDigit(ButtonText)
            DigitLED1.ForeColor = Color.Black
            DigitLED2.ForeColor = Color.White
            If DigitLED1.Text.Contains("0") Then
                mainForm.ButtonDisabler(10, True)
            Else
                mainForm.ButtonDisabler(DigitLED2.MaxDigit, False
                                        )
            End If
        ElseIf DigitLED2.isLedNotSet() Then
            DigitLED2.SetDigit(ButtonText)
            DigitLED2.ForeColor = Color.Black
            DigitLED3.ForeColor = Color.White
            mainForm.ButtonDisabler(DigitLED3.MaxDigit, False)
        ElseIf DigitLED3.isLedNotSet() Then
            DigitLED3.SetDigit(ButtonText)
            DigitLED3.ForeColor = Color.Black
            DigitLED4.ForeColor = Color.White
            mainForm.ButtonDisabler(DigitLED4.MaxDigit, False)
        Else
            DigitLED4.SetDigit(ButtonText)
            DigitLED4.ForeColor = Color.Black
        End If
    End Sub
    'Reset Button Event handler: Set time LED to 00:00 and checks AM radio Button 
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If isClock Then 'If timePanel is for clock then Rest sets to current time 
            Me.SetAmPmCurrent(TimeOfDay)
            Me.SetTime(Format(TimeOfDay, "hh:mm"))
        Else 'Else timePanel for an Alarm Panel
            SetTime("00:00")
            AmRadioButton.Checked = True
        End If
        'ClockTimePanel.SetAmPmCurrent(TimeOfDay) 'sets the right Radio button for AM OR PM
        'ClockTimePanel.SetTime(Format(TimeOfDay, "hh:mm"))

    End Sub
    'Methods
    'GetTime in format 00:00AM OR PM
    Public Function GetTime() As String
        Dim AmOrPm As String
        If AmRadioButton.Checked = True Then
            AmOrPm = "AM"
        Else : AmOrPm = "PM"
        End If
        Return DigitLED1.GetDigit() + DigitLED2.GetDigit() + ":" + DigitLED3.GetDigit() + DigitLED4.GetDigit() + " " + AmOrPm

    End Function
    'SetAmPmCurrent sets the current am or pm radio button based on current time
    Public Sub SetAmPmCurrent(ByVal time As String)
        If time.Contains("A") Then
            AmRadioButton.Checked = True
        Else : PmRadioButton.Checked = True
        End If
    End Sub

    'SetTime: Sets the LEDs to the right time
    Public Sub SetTime(ByVal time As String)
        Dim timeCharArray As Array
        timeCharArray = time.ToCharArray()
        DigitLED1.SetDigit(timeCharArray(0).ToString)
        DigitLED2.SetDigit(timeCharArray(1).ToString)
        DigitLED3.SetDigit(timeCharArray(3).ToString)
        DigitLED4.SetDigit(timeCharArray(4).ToString)
        OldTime = Me.GetTime 'Current time Becomes Old time 
        SetAmPmCurrent(time)
    End Sub
    'Sets all digitLEDs to to black
    Public Sub recolorBlackDigit()
        DigitLED1.ForeColor = Color.Black
        DigitLED2.ForeColor = Color.Black
        DigitLED3.ForeColor = Color.Black
        DigitLED4.ForeColor = Color.Black
    End Sub
    'Tells if Timepanel is being set ( this is for the ClockTab)
    Public Function GetIsBeingSet() As Boolean
        Return isBeingSet
    End Function

    'Indicates that clock panel is not being set
    Public Sub ClockisNotBeingSet()
        isClockBeingSet = False
    End Sub
    Public Function GetIsClockBeingSet() As Boolean
        Return isClockBeingSet
    End Function
    'Gets OldTime (tIME BEFORE CHANGE)
    Public Function GetOldTime() As String
        Return OldTime
    End Function
    'Set OldTime  (Ok button on keypad has been clicked and time has changed)
    Public Sub SetOldTime()
        OldTime = Me.GetTime
    End Sub
    'Property of TimePanel and indicates whether Timepanel is a Clock Panel
    Public Property IsClockPanel() As Boolean
        Get
            Return isClock
        End Get
        Set(ByVal value As Boolean)
            isClock = value
        End Set
    End Property


    Private Sub DigitLED1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DigitLED4_Click(sender As Object, e As EventArgs) Handles DigitLED4.Click

    End Sub
End Class
