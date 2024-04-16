Public Class TagItem
    Private _tagName As String = ""
    Public Event DeleteClicked(item As TagItem)

    Public Property TagName As String
        Get
            Return _tagName
        End Get
        Set(value As String)
            _tagName = value
            lblTagName.Text = value
        End Set
    End Property

    Public Sub New(tagName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.TagName = tagName
        Me.Width = lblTagName.Width + 24 ' button size plus buffer
    End Sub
    Private Sub btnDeleteTag_Click(sender As Object, e As EventArgs) Handles btnDeleteTag.Click
        RaiseEvent DeleteClicked(Me)
    End Sub
End Class
