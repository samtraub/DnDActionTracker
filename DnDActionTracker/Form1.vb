Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



#Region "Control Events"
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pnlActions.Controls.Clear()
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
            Dim newActionItem As New ActionItem(newAction) With {
                .Dock = DockStyle.Top,
                .Width = pnlActions.Width - 24
            }

            Select Case actionType
                Case Action.ActionType.Action
                    pnlActions.Controls.Add(newActionItem)
                Case Else

            End Select
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim charName As String = cmbCharacter.Text
        If Not charName.Equals("") Then
            Dim actionList As New List(Of Action)
            For Each control As ActionItem In pnlActions.Controls
                actionList.Add(control.ActionData)
            Next

            SaveCharacter(charName, actionList)
        Else
            MessageBox.Show("Unable to save character with no name.")
        End If
    End Sub
#End Region
End Class
