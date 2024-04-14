<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActionItem
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
        Me.btnActionName = New System.Windows.Forms.Button()
        Me.lblActionDescription = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnActionName
        '
        Me.btnActionName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActionName.Location = New System.Drawing.Point(0, 0)
        Me.btnActionName.Name = "btnActionName"
        Me.btnActionName.Size = New System.Drawing.Size(210, 36)
        Me.btnActionName.TabIndex = 0
        Me.btnActionName.Text = "Title"
        Me.btnActionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActionName.UseVisualStyleBackColor = True
        '
        'lblActionDescription
        '
        Me.lblActionDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblActionDescription.AutoSize = True
        Me.lblActionDescription.Location = New System.Drawing.Point(0, 39)
        Me.lblActionDescription.Name = "lblActionDescription"
        Me.lblActionDescription.Size = New System.Drawing.Size(41, 15)
        Me.lblActionDescription.TabIndex = 1
        Me.lblActionDescription.Text = "Label1"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(209, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(46, 36)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteItem.Location = New System.Drawing.Point(254, 0)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(46, 36)
        Me.btnDeleteItem.TabIndex = 3
        Me.btnDeleteItem.Text = "Del"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'ActionItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblActionDescription)
        Me.Controls.Add(Me.btnActionName)
        Me.Name = "ActionItem"
        Me.Size = New System.Drawing.Size(300, 70)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActionName As Button
    Friend WithEvents lblActionDescription As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDeleteItem As Button
End Class
