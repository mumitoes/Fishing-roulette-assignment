Public Class FishCatch

    Protected _caught As Integer
    Protected _castsLeft As Integer
    Protected _name As String
    Protected _counter As Integer
    Public IsCaught As Boolean = False
    Public Snag As Boolean = False
    'set the defaults for all subclasses
    Sub New()
        _castsLeft = 6
        _name = ""
        _caught = _castsLeft
    End Sub


    Public ReadOnly Property Counter() As Integer
        Get
            Return _counter
        End Get
    End Property

    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property


    Public ReadOnly Property Caught() As Short
        Get
            Return _caught
        End Get
    End Property

    'records how many casts are left (label shown on Form1)
    Public Sub startover()
        _caught = _castsLeft

    End Sub

    'set a counter to countdown to 1 where a trout is caught and you win, or else your line snags, either way game over
    Public Sub spin()

        If _caught > 0 Then
            _caught -= 1
        ElseIf _caught = 0 And IsCaught = True Then
            _name = "You win"
            Dim dialogform As New Win_Game
            dialogform.Show()
        ElseIf _caught = 0 Then
            _name = "You lost"
            Dim dialogform As New Lost_Game
            dialogform.Show()
        End If
    End Sub

    Public Sub spinSnag()
        If _caught > 0 And Snag = True Then
            _caught += 1
            Dim dialogform As New Snag
            dialogform.Show()

        End If
    End Sub
    Private Sub PlayBackgroundSoundFile()
        Throw New NotImplementedException
    End Sub

End Class
