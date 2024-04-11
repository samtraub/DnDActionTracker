<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.grpActionType = New System.Windows.Forms.GroupBox()
        Me.flpActionType = New System.Windows.Forms.FlowLayoutPanel()
        Me.rdoAction = New System.Windows.Forms.RadioButton()
        Me.rdoBonus = New System.Windows.Forms.RadioButton()
        Me.rdoReaction = New System.Windows.Forms.RadioButton()
        Me.rdoOther = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.flpTags = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTags = New System.Windows.Forms.Label()
        Me.txtTagInput = New System.Windows.Forms.TextBox()
        Me.btnAddTag = New System.Windows.Forms.Button()
        Me.grpActionType.SuspendLayout()
        Me.flpActionType.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(60, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(310, 23)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 15)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 50)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(70, 15)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(12, 68)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(358, 147)
        Me.txtDescription.TabIndex = 3
        '
        'grpActionType
        '
        Me.grpActionType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpActionType.Controls.Add(Me.flpActionType)
        Me.grpActionType.Location = New System.Drawing.Point(12, 221)
        Me.grpActionType.Name = "grpActionType"
        Me.grpActionType.Size = New System.Drawing.Size(358, 51)
        Me.grpActionType.TabIndex = 4
        Me.grpActionType.TabStop = False
        Me.grpActionType.Text = "Action Type:"
        '
        'flpActionType
        '
        Me.flpActionType.Controls.Add(Me.rdoAction)
        Me.flpActionType.Controls.Add(Me.rdoBonus)
        Me.flpActionType.Controls.Add(Me.rdoReaction)
        Me.flpActionType.Controls.Add(Me.rdoOther)
        Me.flpActionType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpActionType.Location = New System.Drawing.Point(3, 19)
        Me.flpActionType.Name = "flpActionType"
        Me.flpActionType.Size = New System.Drawing.Size(352, 29)
        Me.flpActionType.TabIndex = 0
        '
        'rdoAction
        '
        Me.rdoAction.AutoSize = True
        Me.rdoAction.Checked = True
        Me.rdoAction.Location = New System.Drawing.Point(3, 3)
        Me.rdoAction.Name = "rdoAction"
        Me.rdoAction.Size = New System.Drawing.Size(60, 19)
        Me.rdoAction.TabIndex = 2
        Me.rdoAction.TabStop = True
        Me.rdoAction.Text = "Action"
        Me.rdoAction.UseVisualStyleBackColor = True
        '
        'rdoBonus
        '
        Me.rdoBonus.AutoSize = True
        Me.rdoBonus.Location = New System.Drawing.Point(69, 3)
        Me.rdoBonus.Name = "rdoBonus"
        Me.rdoBonus.Size = New System.Drawing.Size(96, 19)
        Me.rdoBonus.TabIndex = 3
        Me.rdoBonus.Text = "Bonus Action"
        Me.rdoBonus.UseVisualStyleBackColor = True
        '
        'rdoReaction
        '
        Me.rdoReaction.AutoSize = True
        Me.rdoReaction.Location = New System.Drawing.Point(171, 3)
        Me.rdoReaction.Name = "rdoReaction"
        Me.rdoReaction.Size = New System.Drawing.Size(71, 19)
        Me.rdoReaction.TabIndex = 4
        Me.rdoReaction.Text = "Reaction"
        Me.rdoReaction.UseVisualStyleBackColor = True
        '
        'rdoOther
        '
        Me.rdoOther.AutoSize = True
        Me.rdoOther.Location = New System.Drawing.Point(248, 3)
        Me.rdoOther.Name = "rdoOther"
        Me.rdoOther.Size = New System.Drawing.Size(55, 19)
        Me.rdoOther.TabIndex = 5
        Me.rdoOther.Text = "Other"
        Me.rdoOther.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(295, 344)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(214, 344)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'flpTags
        '
        Me.flpTags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpTags.AutoSize = True
        Me.flpTags.Location = New System.Drawing.Point(15, 308)
        Me.flpTags.MaximumSize = New System.Drawing.Size(358, 0)
        Me.flpTags.Name = "flpTags"
        Me.flpTags.Size = New System.Drawing.Size(355, 28)
        Me.flpTags.TabIndex = 7
        '
        'lblTags
        '
        Me.lblTags.AutoSize = True
        Me.lblTags.Location = New System.Drawing.Point(12, 282)
        Me.lblTags.Name = "lblTags"
        Me.lblTags.Size = New System.Drawing.Size(33, 15)
        Me.lblTags.TabIndex = 8
        Me.lblTags.Text = "Tags:"
        '
        'txtTagInput
        '
        Me.txtTagInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTagInput.Location = New System.Drawing.Point(51, 279)
        Me.txtTagInput.Name = "txtTagInput"
        Me.txtTagInput.Size = New System.Drawing.Size(216, 23)
        Me.txtTagInput.TabIndex = 9
        '
        'btnAddTag
        '
        Me.btnAddTag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTag.Location = New System.Drawing.Point(273, 279)
        Me.btnAddTag.Name = "btnAddTag"
        Me.btnAddTag.Size = New System.Drawing.Size(97, 23)
        Me.btnAddTag.TabIndex = 10
        Me.btnAddTag.Text = "Add Tag"
        Me.btnAddTag.UseVisualStyleBackColor = True
        '
        'InputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 379)
        Me.Controls.Add(Me.btnAddTag)
        Me.Controls.Add(Me.txtTagInput)
        Me.Controls.Add(Me.lblTags)
        Me.Controls.Add(Me.flpTags)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpActionType)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "InputForm"
        Me.Text = "Action Information"
        Me.grpActionType.ResumeLayout(False)
        Me.flpActionType.ResumeLayout(False)
        Me.flpActionType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents grpActionType As GroupBox
    Friend WithEvents flpActionType As FlowLayoutPanel
    Friend WithEvents rdoAction As RadioButton
    Friend WithEvents rdoBonus As RadioButton
    Friend WithEvents rdoReaction As RadioButton
    Friend WithEvents rdoOther As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents flpTags As FlowLayoutPanel
    Friend WithEvents lblTags As Label
    Friend WithEvents txtTagInput As TextBox
    Friend WithEvents btnAddTag As Button
End Class
