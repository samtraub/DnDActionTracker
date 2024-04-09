Public Class Character
    Private _name As String
    Private _actions As List(Of Action)

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Actions As List(Of Action)
        Get
            Return _actions
        End Get
        Set(value As List(Of Action))
            _actions = value
        End Set
    End Property

    Public Sub New(ByVal name As String, ByVal actionList As List(Of Action))
        Me.Name = name
        Me.Actions = actionList
    End Sub
End Class
