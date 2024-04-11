Public Class InputForm

    Private _currentTagPanelHeight As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal name As String, ByVal description As String, ByVal type As Action.ActionType, Optional ByVal tags As List(Of String) = Nothing)

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

        _currentTagPanelHeight = flpTags.Height

        If tags IsNot Nothing Then
            AddTags(tags)
        End If
    End Sub

#Region "Adding and Deleting Tags"
    Private Sub AddTags(ByVal tags As List(Of String))
        For Each tag As String In tags
            AddTag(tag)
        Next
    End Sub

    Private Sub CheckAndAddTag()
        If Not txtTagInput.Text.Equals("") Then
            Dim tagExists As Boolean = False
            For Each control As TagItem In flpTags.Controls
                If control.TagName.ToLower.Equals(txtTagInput.Text.ToLower) Then
                    tagExists = True
                End If
            Next

            If Not tagExists Then
                AddTag(txtTagInput.Text.ToLower)
                txtTagInput.Text = ""
            End If
        End If
    End Sub

    Private Sub AddTag(ByVal tag As String)
        Dim control As New TagItem(tag)
        control.Name = "ti" & tag
        AddHandler control.DeleteClicked, AddressOf DeleteTag

        If control.Width > flpTags.Width - 5 Then
            control.Width = flpTags.Width - 5
        End If
        flpTags.Controls.Add(control)
    End Sub

    Private Sub DeleteTag(control As TagItem)
        flpTags.Controls.Remove(control)
        System.GC.Collect()
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub flpTags_SizeChanged(sender As Object, e As EventArgs) Handles flpTags.SizeChanged
        Try
            If flpTags.Height <> _currentTagPanelHeight Then
                Dim dif As Integer = flpTags.Height - _currentTagPanelHeight
                Me.Height += dif
                _currentTagPanelHeight = flpTags.Height
                btnCancel.Location = New Point(btnCancel.Location.X, flpTags.Location.Y + flpTags.Height + 8)
                btnSave.Location = New Point(btnSave.Location.X, flpTags.Location.Y + flpTags.Height + 8)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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

    Private Sub btnAddTag_Click(sender As Object, e As EventArgs) Handles btnAddTag.Click
        Try
            CheckAndAddTag()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtTagInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTagInput.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                CheckAndAddTag()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
End Class