Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If DEBUG Then
        btnDebug.Visible = True
#End If
        cmbCharacter.Items.AddRange(GetCharacterList)
    End Sub

#Region "Control Events"
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearActions()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim addNewForm As New InputForm
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

            Dim newAction As New Action(name, description, actionType)
            AddAction(newAction)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim charName As String = cmbCharacter.Text
            If Not charName.Equals("") Then
                Dim actionList As New List(Of Action)
                For Each control As ActionItem In flpActions.Controls
                    actionList.Add(control.ActionData)
                Next
                For Each control As ActionItem In flpBonus.Controls
                    actionList.Add(control.ActionData)
                Next
                For Each control As ActionItem In flpReactions.Controls
                    actionList.Add(control.ActionData)
                Next
                For Each control As ActionItem In flpOther.Controls
                    actionList.Add(control.ActionData)
                Next

                SaveCharacter(charName, actionList)
            Else
                MessageBox.Show("Unable to save character with no name.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For i = flpActions.Controls.Count - 1 To 0 Step -1
            Dim currentControl As ActionItem = flpActions.Controls(i)
            If currentControl.Selected Then
                flpActions.Controls.Remove(currentControl)
                System.GC.Collect()
            End If
        Next
    End Sub

    Private Sub cmbCharacter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCharacter.SelectedValueChanged
        Try
            Dim character As Character = GetCharacterFromName(cmbCharacter.Text)

            ClearActions()

            For Each action As Action In character.Actions
                AddAction(action)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

    Private Sub AddAction(ByVal newAction As Action)
        Dim newActionItem As New ActionItem(newAction) With {
                .Width = flpActions.Width - 24
            }
        AddHandler newActionItem.btnActionName.MouseDown, AddressOf Item_MouseDown
        AddHandler newActionItem.btnActionName.MouseUp, AddressOf Item_MouseUp
        AddHandler newActionItem.btnActionName.MouseMove, AddressOf Item_MouseMove

        Select Case newAction.Type
            Case Action.ActionType.Action
                flpActions.Controls.Add(newActionItem)
            Case Action.ActionType.Bonus
                flpBonus.Controls.Add(newActionItem)
            Case Action.ActionType.Reaction
                flpReactions.Controls.Add(newActionItem)
            Case Action.ActionType.Other
                flpOther.Controls.Add(newActionItem)
            Case Else
                flpOther.Controls.Add(newActionItem)
        End Select
    End Sub

    Private Sub ClearActions()
        flpActions.Controls.Clear()
        flpBonus.Controls.Clear()
        flpReactions.Controls.Clear()
        flpOther.Controls.Clear()
        System.GC.Collect()
    End Sub

#Region "Dragging"
    Private dragging As Boolean = False
    Private xOffset As Integer = 0
    Private yOffset As Integer = 0
    Private clickedIndex As Integer = -1

    Private Sub Item_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim itemControl As ActionItem = sender.Parent
            Dim parentPanel As FlowLayoutPanel = itemControl.Parent

            parentPanel.SuspendLayout()
            ' Save the current index in case it's just a click, then set to 0 so it is on top
            clickedIndex = parentPanel.Controls.GetChildIndex(itemControl)
            parentPanel.Controls.SetChildIndex(itemControl, 0)

            If Control.ModifierKeys = Keys.Control Then
                dragging = True
                xOffset = e.X
                yOffset = e.Y
            End If
        End If
    End Sub

    Private Sub Item_MouseUp(sender As Object, e As MouseEventArgs)
        Dim itemControl As ActionItem = sender.Parent
        Dim parentPanel As FlowLayoutPanel = itemControl.Parent

        dragging = False
        Dim idX As Integer = GetIndexOfOverlappedControl(itemControl)

        If idX <> -1 Then
            parentPanel.Controls.SetChildIndex(itemControl, idX)
        End If

        parentPanel.ResumeLayout()
    End Sub

    Private Function GetIndexOfOverlappedControl(item As ActionItem) As Integer
        Dim bloc As Point = item.Location
        Dim idx As Integer = clickedIndex

        For Each newItem As ActionItem In item.Parent.Controls
            If (item.Location.X > newItem.Location.X) AndAlso (item.Location.X < (newItem.Location.X + item.Width) AndAlso (item.Location.Y > newItem.Location.Y) AndAlso (item.Location.Y < (newItem.Location.Y + item.Height))) Then
                idx = item.Parent.Controls.GetChildIndex(newItem)
            End If
        Next

        clickedIndex = -1
        Return idx
    End Function

    Private Sub Item_MouseMove(sender As Object, e As MouseEventArgs)
        If dragging Then
            Dim itemControl As ActionItem = sender.Parent
            Dim parentPanel As FlowLayoutPanel = itemControl.Parent

            Dim xMoved As Integer
            Dim yMoved As Integer

            Dim newX As Integer
            Dim newY As Integer

            xMoved = e.Location.X - xOffset
            yMoved = e.Location.Y - yOffset

            newX = itemControl.Location.X + xMoved
            newY = itemControl.Location.Y + yMoved

            If newX <= 0 Then
                newX = itemControl.Location.X
            ElseIf newX + itemControl.Width >= Me.ClientSize.Width Then
                newX = itemControl.Location.X
            End If

            If newY <= 0 Then
                newY = itemControl.Location.Y
            ElseIf newY + itemControl.Height >= Me.ClientSize.Height Then
                newY = itemControl.Location.Y
            End If

            itemControl.Location = New Point(newX, newY)
        End If
    End Sub

    Private Sub DisableLayouts()
        flpActions.SuspendLayout()
    End Sub

    Private Sub EnableLayouts()
        flpActions.ResumeLayout()
    End Sub
#End Region

#Region "Debug"
    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        AddAction(New Action("Bonus", "", Action.ActionType.Bonus))
    End Sub
#End Region
End Class
