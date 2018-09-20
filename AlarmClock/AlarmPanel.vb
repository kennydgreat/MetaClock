Public Class AlarmPanel
    Private mainFoam As Form1
    Private keyPanel As Panel
    Private isBeingSet As Boolean 'Indicates whether this alarm is being set

    'sets form that alarm's time panel will interact with
    Public Sub Intialize(ByVal form As Form1, ByVal KeyPanel1 As Panel, ByVal Picture As Image)
        mainFoam = form
        PictureBox.Image = Picture
        isBeingSet = False
    End Sub
    Private Sub AlarmPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimePanel1.Intialize(mainFoam, Me)
    End Sub
    'setting that this AlarmPanel is being set
    Public Sub setMeForKeypad()
        isBeingSet = True
    End Sub
    'setting that this AlarmPanel is not being set
    Public Sub unSetMeForKeypad()
        isBeingSet = False
    End Sub
    'Returns time set for Alarm
    Public Function GetAlarmTime() As String
        Return TimePanel1.GetTime
    End Function
    'tells if Alarm is being set
    Public Function GetIsbeingSet()
        Return isBeingSet
    End Function
    'Checks the Onturn checkbox
    Public Sub TurnOnAlarm()
        CheckBox1.Checked = True
    End Sub
    'UnChecks the Onturn checkbox
    Public Sub TurnOffAlarm()
        CheckBox1.Checked = False
    End Sub
    'Sets each digitLED from keypad
    Public Sub SetTimeFromKeyPad(ByVal ButtonText As String)
        TimePanel1.SetTimeFromKeyPad(ButtonText)
    End Sub
    'Sets all digitLEDs to to black, calls TimePanel Method that does this
    Public Sub recolorBlackDigit()
        TimePanel1.recolorBlackDigit()
    End Sub
    'Gets OldTime (tIME BEFORE CHANGE)
    Public Function GetOldTime() As String
        Return TimePanel1.GetOldTime
    End Function
    'Gets OldTime (tIME BEFORE CHANGE)
    Public Sub SetOldTime()
        TimePanel1.SetOldTime()
    End Sub
    'Set time for Alarm
    Public Sub SetTime(ByVal time As String)
        TimePanel1.SetTime(time)
        TimePanel1.SetAmPmCurrent(time)
    End Sub

    'Indicate whether led is set
    '-----------------------------------------------
    'Public Function isDigitOneSet() As Boolean
    '    Return TimePanel1.isDigitOneSet
    'End Function

    'Public Function isDigitTwoSet() As Boolean
    '    Return TimePanel1.isDigitTwoSet
    'End Function

    'Public Function isDigitThreeSet() As Boolean
    '    Return TimePanel1.isDigitThreeSet()
    'End Function

    'Public Function isDigitFourSet() As Boolean
    '    Return TimePanel1.isDigitFourSet
    'End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        mainFoam.ClickMyAlarmCheckBox(Me.Name, CheckBox1.Checked)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox.Click
        My.Computer.Audio.Stop()
        PictureBox.Enabled = False
    End Sub
    'Plays Gif and alarm sound
    Public Sub PlayGif()
        PictureBox.Enabled = True
        If ListBox1.SelectedIndex = 0 Then
            My.Computer.Audio.Play(My.Resources.train, AudioPlayMode.BackgroundLoop)
        ElseIf ListBox1.SelectedIndex = 1 Then
            My.Computer.Audio.Play(My.Resources.crickets, AudioPlayMode.BackgroundLoop)
        ElseIf ListBox1.SelectedIndex = 2 Then
            My.Computer.Audio.Play(My.Resources.drum_roll, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
