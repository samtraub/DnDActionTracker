<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TagItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTagName = New System.Windows.Forms.Label()
        Me.btnDeleteTag = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTagName
        '
        Me.lblTagName.AutoSize = True
        Me.lblTagName.Location = New System.Drawing.Point(3, 4)
        Me.lblTagName.Name = "lblTagName"
        Me.lblTagName.Size = New System.Drawing.Size(54, 15)
        Me.lblTagName.TabIndex = 0
        Me.lblTagName.Text = "tagname"
        '
        'btnDeleteTag
        '
        Me.btnDeleteTag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteTag.Location = New System.Drawing.Point(78, 0)
        Me.btnDeleteTag.Name = "btnDeleteTag"
        Me.btnDeleteTag.Size = New System.Drawing.Size(22, 22)
        Me.btnDeleteTag.TabIndex = 1
        Me.btnDeleteTag.Text = "X"
        Me.btnDeleteTag.UseVisualStyleBackColor = True
        '
        'TagItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.btnDeleteTag)
        Me.Controls.Add(Me.lblTagName)
        Me.Name = "TagItem"
        Me.Size = New System.Drawing.Size(100, 22)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTagName As Label
    Friend WithEvents btnDeleteTag As Button
End Class
