Public Class ActionItem
    Private _selected As Boolean = False
    Private _actionData As Action

    Public Property Selected As Boolean
        Get
            Return _selected
        End Get
        Set(value As Boolean)
            _selected = value
        End Set
    End Property

    Public Property ActionData As Action
        Get
            Return _actionData
        End Get
        Set(value As Action)
            _actionData = value
            UpdateControlsFromData()
        End Set
    End Property
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ActionData = New Action()
        lblActionDescription.MaximumSize = New Size(Me.Width, 0)

        Me.Height = btnActionName.Height
        lblActionDescription.Visible = False
    End Sub

    Public Sub New(ByVal action As Action)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ActionData = action
        lblActionDescription.MaximumSize = New Size(Me.Width, 0)

        Me.Height = btnActionName.Height
        lblActionDescription.Visible = False
    End Sub

    Private Sub UpdateControlsFromData()
        btnActionName.Text = Me.ActionData.Name
        lblActionDescription.Text = Me.ActionData.Description
    End Sub

    Private Sub btnActionName_Click(sender As Object, e As EventArgs) Handles btnActionName.Click
        If Not Control.ModifierKeys = Keys.Control Then
            If Selected Then
                Me.Height = btnActionName.Height
                lblActionDescription.Visible = False
                Selected = False
            Else
                lblActionDescription.Visible = True
                Me.Height = btnActionName.Height + lblActionDescription.Height + 5
                Selected = True
            End If
        End If
    End Sub

    Private Sub ActionItem_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        lblActionDescription.MaximumSize = New Size(Me.Width, 0)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim currentType As Action.ActionType
        Select Case Me.Parent.Name
            Case "pnlActions"
                currentType = Action.ActionType.Action
            Case "pnlBonus"
                currentType = Action.ActionType.Bonus
            Case "pnlReactions"
                currentType = Action.ActionType.Reaction
            Case "pnlOther"
                currentType = Action.ActionType.Other
            Case Else
                currentType = Action.ActionType.Other
        End Select

        Dim addNewForm As New InputForm(btnActionName.Text, lblActionDescription.Text, currentType)
        If addNewForm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            'Add a new item with the info
            Dim name As String = addNewForm.txtName.Text
            Dim description As String = addNewForm.txtDescription.Text
            Dim checkedButton As RadioButton = addNewForm.flpActionType.Controls.OfType(Of RadioButton).FirstOrDefault(Function(x) x.Checked)
            Dim actionType As Action.ActionType
            Select Case checkedButton.Text
                Case "Action"
                    actionType = Action.ActionType.Action
                Case "Bonus Action"
                    actionType = Action.ActionType.Bonus
                Case "Reaction"
                    actionType = Action.ActionType.Reaction
                Case "Other"
                    actionType = Action.ActionType.Other
                Case Else
                    actionType = Action.ActionType.Other
            End Select

            'TODO: if currentType and actionType are not the same, move the item to the proper location

            Me.ActionData = New Action(name, description, actionType)
        End If
    End Sub
End Class
