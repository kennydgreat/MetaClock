Public Class DigitLED
    Inherits System.Windows.Forms.Label
    'Fields
    Private maxDigitValue As Integer 'max digit of LED
    Private isNotSet As Boolean 'Indicates whether LED has been set or not

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Me.Font = New System.Drawing.Font("Consolas", 36, FontStyle.Bold)
        'Add your custom paint code here

    End Sub
    'Properties
    'Maximum digit for Digit lED.
    Public Property MaxDigit() As Integer
        Get
            Return Me.maxDigitValue
        End Get
        Set(ByVal value As Integer)
            Me.maxDigitValue = value
        End Set
    End Property

    'Methods
    'Gets digit of LED
    Public Function GetDigit() As String
        Return Me.Text
    End Function
    'Indicates whether LED is set or not
    Public Function isLedNotSet() As Boolean
        Return isNotSet
    End Function
    'Indicate that LED has not been set
    Public Sub UnsetMe()
        isNotSet = True
    End Sub
    'Sets digit of LED and indicates LED has been set
    Public Sub SetDigit(ByVal value As String)
        'Dim int As Integer
        'int = Val(value.First)
        'If Val(value.First) <= maxDigitValue Then
        'Me.Text = value
        'Else : MessageBox.Show("Integer being set is ")
        'End If
        Me.Text = value
        isNotSet = False
    End Sub
End Class
