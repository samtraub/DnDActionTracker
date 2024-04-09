Public Class InputForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal name As String, ByVal description As String, ByVal type As Action.ActionType)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtName.Text = name
        txtDescription.Text = description
        Select Case type
            Case Action.ActionType.Action
                rdoAction.Checked = True
            Case Action.ActionType.Bonus
                rdoBonus.Checked = True
            Case Action.ActionType.Reaction
                rdoReaction.Checked = True
            Case Action.ActionType.Other
                rdoOther.Checked = True
        End Select
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtName.Text.Equals("") Then
                Me.DialogResult = DialogResult.None
                MessageBox.Show("Cannot create action with no name.")
            Else
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class