Public Class Form1
    Private actionTags As List(Of String)
    Private actionItemList As List(Of ActionItem)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCharacter.Items.AddRange(GetCharacterList)
        _currentTagPanelHeight = flpActionTags.Height
        actionItemList = New List(Of ActionItem)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        ' disable horizontal resizing, but keep vertical resize
        Select Case m.Msg
            Case &H84
                Dim result As Integer = m.Result.ToInt32()
                If result = 10 OrElse result = 11 Then ' left and right
                    m.Result = New IntPtr(0) ' nowhere
                ElseIf result = 13 OrElse result = 14 Then ' topleft and topright
                    m.Result = New IntPtr(12) ' top
                ElseIf result = 16 OrElse result = 17 Then 'bottomleft and bottomright
                    m.Result = New IntPtr(15) 'bottom
                End If
        End Select
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

            Dim tagList As New List(Of String)
            For Each tag As TagItem In addNewForm.flpTags.Controls
                tagList.Add(tag.TagName)
            Next

            Dim newAction As New Action(name, description, actionType, tagList)
            AddAction(newAction)

            AddFilterButtons()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim charName As String = cmbCharacter.Text
            If Not charName.Equals("") Then
                Dim actionList As New List(Of Action)
                For Each control As ActionItem In actionItemList
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

    Private Sub cmbCharacter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCharacter.SelectedValueChanged
        Try
            Dim character As Character = GetCharacterFromName(cmbCharacter.Text)

            ClearActions()

            For Each action As Action In character.Actions
                AddAction(action)
            Next

            AddFilterButtons()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub FilterButtonClicked(sender As Object, e As EventArgs)
        FilterActions()
    End Sub

    Private Sub FilterActions()
        Dim showList As New List(Of String)
        Dim hideList As New List(Of String)

        For Each tagButton As FilterButton In flpActionTags.Controls
            Select Case tagButton.State
                Case FilterButton.FilterState.Show
                    showList.Add(tagButton.Text)
                Case FilterButton.FilterState.Hide
                    hideList.Add(tagButton.Text)
            End Select
        Next

        If showList.Count > 0 OrElse hideList.Count > 0 Then
            For Each item As ActionItem In actionItemList
                Dim inHideList As Boolean = False
                Dim inShowList As Boolean = False
                For Each tag As String In item.ActionData.Tags
                    If hideList.Contains(tag) Then
                        inHideList = True
                    ElseIf showList.Contains(tag) Then
                        inShowList = True
                    End If
                Next

                If inHideList Then
                    item.Visible = False
                ElseIf inShowList Then
                    item.Visible = True
                Else
                    item.Visible = False
                End If
            Next
        Else
            For Each item As ActionItem In actionItemList
                item.Visible = True
            Next
        End If
    End Sub
#End Region

    Private _currentTagPanelHeight As Integer = 0
    Private Sub AddFilterButtons()
        Dim tagList As New List(Of String)
        flpActionTags.Controls.Clear()

        For Each item As ActionItem In actionItemList
            For Each tag As String In item.ActionData.Tags
                If Not tagList.Contains(tag) Then
                    tagList.Add(tag)
                End If
            Next
        Next

        For Each tag As String In tagList
            Dim filterButton As New FilterButton With {
                .Name = "fbt" & tag,
                .AutoSize = True,
                .AutoSizeMode = AutoSizeMode.GrowOnly,
                .Text = tag
            }
            AddHandler filterButton.Click, AddressOf FilterButtonClicked

            flpActionTags.Controls.Add(filterButton)
        Next
    End Sub

    Private Sub flpActionTags_SizeChanged(sender As Object, e As EventArgs) Handles flpActionTags.SizeChanged
        Try
            If flpActionTags.Height <> _currentTagPanelHeight Then
                Dim dif As Integer = flpActionTags.Height - _currentTagPanelHeight
                Me.Height += dif
                Me.MinimumSize = New Size(Me.MinimumSize.Width, Me.MinimumSize.Height + dif)
                _currentTagPanelHeight = flpActionTags.Height
                tcActionBreakdown.Location = New Point(tcActionBreakdown.Location.X, flpActionTags.Location.Y + _currentTagPanelHeight + 6)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub AddAction(ByVal newAction As Action)
        Dim newActionItem As New ActionItem(newAction) With {
                .Width = flpActions.Width - 24
            }
        AddHandler newActionItem.btnActionName.MouseDown, AddressOf Item_MouseDown
        AddHandler newActionItem.btnActionName.MouseUp, AddressOf Item_MouseUp
        AddHandler newActionItem.btnActionName.MouseMove, AddressOf Item_MouseMove
        AddHandler newActionItem.ActionMoved, AddressOf ActionMoved
        AddHandler newActionItem.DeleteItem, AddressOf ActionDeleted

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

        actionItemList.Add(newActionItem)
    End Sub

    Private Sub ActionDeleted(item As ActionItem, e As EventArgs)
        RemoveActionItem(item)
    End Sub

    Private Sub RemoveActionItem(ByVal item As ActionItem)
        Dim parentList As Control = item.Parent
        parentList.Controls.Remove(item)
        actionItemList.Remove(item)
    End Sub

    Private Sub ClearActions()
        actionItemList.Clear()
        flpActions.Controls.Clear()
        flpBonus.Controls.Clear()
        flpReactions.Controls.Clear()
        flpOther.Controls.Clear()
        System.GC.Collect()
    End Sub

    Private Sub ActionMoved(item As ActionItem, type As Action.ActionType)
        RemoveActionItem(item)
        AddAction(item.ActionData)
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
#End Region
End Class
