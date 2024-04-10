Public Class Action
    Public Enum ActionType
        Action = 0
        Bonus = 1
        Reaction = 2
        Free = 3
        Other = 4
    End Enum

#Region "Declarations"
    Private _name As String = "Action"
    Private _description As String = "Description of the action."
    Private _type As ActionType = ActionType.Action
#End Region

#Region "Properties"
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property
    Public Property Type As ActionType
        Get
            Return _type
        End Get
        Set(value As ActionType)
            _type = value
        End Set
    End Property
#End Region

#Region "Initialization"
    Public Sub New()

    End Sub

    Public Sub New(ByVal name As String, Optional desc As String = "", Optional type As ActionType = ActionType.Action)
        Me.Name = name
        Me.Description = desc
        Me.Type = type
    End Sub
#End Region

End Class
