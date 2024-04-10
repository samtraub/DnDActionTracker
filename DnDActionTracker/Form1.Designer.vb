<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.cmbCharacter = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tcActionBreakdown = New System.Windows.Forms.TabControl()
        Me.tpActions = New System.Windows.Forms.TabPage()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.tpBonus = New System.Windows.Forms.TabPage()
        Me.tpReactions = New System.Windows.Forms.TabPage()
        Me.tpOther = New System.Windows.Forms.TabPage()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.tcActionBreakdown.SuspendLayout()
        Me.tpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddItem
        '
        Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddItem.Location = New System.Drawing.Point(674, 12)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(98, 23)
        Me.btnAddItem.TabIndex = 0
        Me.btnAddItem.Text = "Add New..."
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'cmbCharacter
        '
        Me.cmbCharacter.FormattingEnabled = True
        Me.cmbCharacter.Location = New System.Drawing.Point(12, 12)
        Me.cmbCharacter.Name = "cmbCharacter"
        Me.cmbCharacter.Size = New System.Drawing.Size(336, 23)
        Me.cmbCharacter.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(570, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tcActionBreakdown
        '
        Me.tcActionBreakdown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcActionBreakdown.Controls.Add(Me.tpActions)
        Me.tcActionBreakdown.Controls.Add(Me.tpBonus)
        Me.tcActionBreakdown.Controls.Add(Me.tpReactions)
        Me.tcActionBreakdown.Controls.Add(Me.tpOther)
        Me.tcActionBreakdown.Location = New System.Drawing.Point(12, 58)
        Me.tcActionBreakdown.Name = "tcActionBreakdown"
        Me.tcActionBreakdown.SelectedIndex = 0
        Me.tcActionBreakdown.Size = New System.Drawing.Size(760, 391)
        Me.tcActionBreakdown.TabIndex = 3
        '
        'tpActions
        '
        Me.tpActions.Controls.Add(Me.pnlActions)
        Me.tpActions.Location = New System.Drawing.Point(4, 24)
        Me.tpActions.Name = "tpActions"
        Me.tpActions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpActions.Size = New System.Drawing.Size(752, 363)
        Me.tpActions.TabIndex = 0
        Me.tpActions.Text = "Actions"
        Me.tpActions.UseVisualStyleBackColor = True
        '
        'pnlActions
        '
        Me.pnlActions.AutoScroll = True
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlActions.Location = New System.Drawing.Point(3, 3)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(746, 357)
        Me.pnlActions.TabIndex = 0
        '
        'tpBonus
        '
        Me.tpBonus.Location = New System.Drawing.Point(4, 24)
        Me.tpBonus.Name = "tpBonus"
        Me.tpBonus.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBonus.Size = New System.Drawing.Size(752, 363)
        Me.tpBonus.TabIndex = 1
        Me.tpBonus.Text = "Bonus Actions"
        Me.tpBonus.UseVisualStyleBackColor = True
        '
        'tpReactions
        '
        Me.tpReactions.Location = New System.Drawing.Point(4, 24)
        Me.tpReactions.Name = "tpReactions"
        Me.tpReactions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReactions.Size = New System.Drawing.Size(752, 363)
        Me.tpReactions.TabIndex = 2
        Me.tpReactions.Text = "Reactions"
        Me.tpReactions.UseVisualStyleBackColor = True
        '
        'tpOther
        '
        Me.tpOther.Location = New System.Drawing.Point(4, 24)
        Me.tpOther.Name = "tpOther"
        Me.tpOther.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOther.Size = New System.Drawing.Size(752, 363)
        Me.tpOther.TabIndex = 3
        Me.tpOther.Text = "Other"
        Me.tpOther.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(466, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(362, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnDebug
        '
        Me.btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDebug.Location = New System.Drawing.Point(674, 41)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(98, 23)
        Me.btnDebug.TabIndex = 6
        Me.btnDebug.Text = "Add Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        Me.btnDebug.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tcActionBreakdown)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbCharacter)
        Me.Controls.Add(Me.btnAddItem)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Form1"
        Me.Text = "D&D 5e Action Tracker"
        Me.tcActionBreakdown.ResumeLayout(False)
        Me.tpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddItem As Button
    Friend WithEvents cmbCharacter As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents tcActionBreakdown As TabControl
    Friend WithEvents tpActions As TabPage
    Friend WithEvents tpBonus As TabPage
    Friend WithEvents tpReactions As TabPage
    Friend WithEvents tpOther As TabPage
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlActions As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnDebug As Button
End Class
