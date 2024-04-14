Public Class FilterButton
    Inherits Button

    Public Enum FilterState
        Base = 0
        Show = 1
        Hide = 2
    End Enum

    Private _baseColor As Color = Color.White
    Private _showColor As Color = Color.Green
    Private _hideColor As Color = Color.Red

    Private _state As FilterState = FilterState.Base

    Public Property BaseColor As Color
        Get
            Return _baseColor
        End Get
        Set(value As Color)
            _baseColor = value
        End Set
    End Property

    Public Property ShowColor As Color
        Get
            Return _showColor
        End Get
        Set(value As Color)
            _showColor = value
        End Set
    End Property

    Public Property HideColor As Color
        Get
            Return _hideColor
        End Get
        Set(value As Color)
            _hideColor = value
        End Set
    End Property

    Public Property State As FilterState
        Get
            Return _state
        End Get
        Set(value As FilterState)
            _state = value
            ChangeBackground()
        End Set
    End Property

    Private Sub Clicked(sender As Object, e As EventArgs) Handles Me.Click
        Select Case State
            Case FilterState.Base
                State = FilterState.Show
            Case FilterState.Show
                State = FilterState.Hide
            Case FilterState.Hide
                State = FilterState.Base
        End Select
    End Sub

    Private Sub ChangeBackground()
        Select Case State
            Case FilterState.Base
                Me.BackColor = BaseColor
            Case FilterState.Show
                Me.BackColor = ShowColor
            Case FilterState.Hide
                Me.BackColor = HideColor
        End Select
    End Sub
End Class
