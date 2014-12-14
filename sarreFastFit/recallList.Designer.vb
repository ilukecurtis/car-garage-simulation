<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recallList
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
        Me.uiPartsListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uiAffectedCustomerListBox = New System.Windows.Forms.ListBox()
        Me.uiCloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'uiPartsListBox
        '
        Me.uiPartsListBox.FormattingEnabled = True
        Me.uiPartsListBox.Location = New System.Drawing.Point(12, 45)
        Me.uiPartsListBox.Name = "uiPartsListBox"
        Me.uiPartsListBox.Size = New System.Drawing.Size(283, 251)
        Me.uiPartsListBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Part to Recall"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Affected Customer"
        '
        'uiAffectedCustomerListBox
        '
        Me.uiAffectedCustomerListBox.FormattingEnabled = True
        Me.uiAffectedCustomerListBox.Location = New System.Drawing.Point(322, 45)
        Me.uiAffectedCustomerListBox.Name = "uiAffectedCustomerListBox"
        Me.uiAffectedCustomerListBox.Size = New System.Drawing.Size(261, 251)
        Me.uiAffectedCustomerListBox.TabIndex = 3
        '
        'uiCloseButton
        '
        Me.uiCloseButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.uiCloseButton.Location = New System.Drawing.Point(508, 302)
        Me.uiCloseButton.Name = "uiCloseButton"
        Me.uiCloseButton.Size = New System.Drawing.Size(75, 23)
        Me.uiCloseButton.TabIndex = 4
        Me.uiCloseButton.Text = "Done"
        Me.uiCloseButton.UseVisualStyleBackColor = True
        '
        'recallList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 341)
        Me.Controls.Add(Me.uiCloseButton)
        Me.Controls.Add(Me.uiAffectedCustomerListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uiPartsListBox)
        Me.Name = "recallList"
        Me.Text = "Sarre Fast Fit - Recall"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uiPartsListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents uiAffectedCustomerListBox As System.Windows.Forms.ListBox
    Friend WithEvents uiCloseButton As System.Windows.Forms.Button
End Class
