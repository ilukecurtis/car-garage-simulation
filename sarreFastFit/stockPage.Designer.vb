<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockPage
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
        Me.uiQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.uiCarPartsListBox = New System.Windows.Forms.ListBox()
        Me.uiAddStockButton = New System.Windows.Forms.Button()
        Me.uiQuantity = New System.Windows.Forms.Label()
        Me.uiSarreStockLabel = New System.Windows.Forms.Label()
        Me.uiDoneButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'uiQuantityTextBox
        '
        Me.uiQuantityTextBox.Location = New System.Drawing.Point(67, 278)
        Me.uiQuantityTextBox.Name = "uiQuantityTextBox"
        Me.uiQuantityTextBox.Size = New System.Drawing.Size(139, 20)
        Me.uiQuantityTextBox.TabIndex = 0
        '
        'uiCarPartsListBox
        '
        Me.uiCarPartsListBox.FormattingEnabled = True
        Me.uiCarPartsListBox.Location = New System.Drawing.Point(15, 24)
        Me.uiCarPartsListBox.Name = "uiCarPartsListBox"
        Me.uiCarPartsListBox.Size = New System.Drawing.Size(410, 251)
        Me.uiCarPartsListBox.TabIndex = 1
        '
        'uiAddStockButton
        '
        Me.uiAddStockButton.Location = New System.Drawing.Point(212, 276)
        Me.uiAddStockButton.Name = "uiAddStockButton"
        Me.uiAddStockButton.Size = New System.Drawing.Size(75, 23)
        Me.uiAddStockButton.TabIndex = 2
        Me.uiAddStockButton.Text = "Add Stock"
        Me.uiAddStockButton.UseVisualStyleBackColor = True
        '
        'uiQuantity
        '
        Me.uiQuantity.AutoSize = True
        Me.uiQuantity.Location = New System.Drawing.Point(12, 281)
        Me.uiQuantity.Name = "uiQuantity"
        Me.uiQuantity.Size = New System.Drawing.Size(49, 13)
        Me.uiQuantity.TabIndex = 3
        Me.uiQuantity.Text = "Quantity:"
        '
        'uiSarreStockLabel
        '
        Me.uiSarreStockLabel.AutoSize = True
        Me.uiSarreStockLabel.Location = New System.Drawing.Point(12, 9)
        Me.uiSarreStockLabel.Name = "uiSarreStockLabel"
        Me.uiSarreStockLabel.Size = New System.Drawing.Size(63, 13)
        Me.uiSarreStockLabel.TabIndex = 4
        Me.uiSarreStockLabel.Text = "Sarre Stock"
        '
        'uiDoneButton
        '
        Me.uiDoneButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.uiDoneButton.Location = New System.Drawing.Point(350, 276)
        Me.uiDoneButton.Name = "uiDoneButton"
        Me.uiDoneButton.Size = New System.Drawing.Size(75, 23)
        Me.uiDoneButton.TabIndex = 5
        Me.uiDoneButton.Text = "OK"
        Me.uiDoneButton.UseVisualStyleBackColor = True
        '
        'stockPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 306)
        Me.Controls.Add(Me.uiDoneButton)
        Me.Controls.Add(Me.uiSarreStockLabel)
        Me.Controls.Add(Me.uiQuantity)
        Me.Controls.Add(Me.uiAddStockButton)
        Me.Controls.Add(Me.uiCarPartsListBox)
        Me.Controls.Add(Me.uiQuantityTextBox)
        Me.Name = "stockPage"
        Me.Text = "Sarre Fast Fit - Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uiQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents uiCarPartsListBox As System.Windows.Forms.ListBox
    Friend WithEvents uiAddStockButton As System.Windows.Forms.Button
    Friend WithEvents uiQuantity As System.Windows.Forms.Label
    Friend WithEvents uiSarreStockLabel As System.Windows.Forms.Label
    Friend WithEvents uiDoneButton As System.Windows.Forms.Button
End Class
