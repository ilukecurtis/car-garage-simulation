<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoiceForm
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
        Me.uiOkButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uiInvoicesListView = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'uiOkButton
        '
        Me.uiOkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.uiOkButton.Location = New System.Drawing.Point(12, 235)
        Me.uiOkButton.Name = "uiOkButton"
        Me.uiOkButton.Size = New System.Drawing.Size(82, 23)
        Me.uiOkButton.TabIndex = 0
        Me.uiOkButton.Text = "OK"
        Me.uiOkButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Invoices"
        '
        'uiInvoicesListView
        '
        Me.uiInvoicesListView.Location = New System.Drawing.Point(12, 30)
        Me.uiInvoicesListView.Name = "uiInvoicesListView"
        Me.uiInvoicesListView.Size = New System.Drawing.Size(936, 199)
        Me.uiInvoicesListView.TabIndex = 3
        Me.uiInvoicesListView.UseCompatibleStateImageBehavior = False
        '
        'invoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 266)
        Me.Controls.Add(Me.uiInvoicesListView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uiOkButton)
        Me.Name = "invoiceForm"
        Me.Text = "invoiceForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uiOkButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uiInvoicesListView As System.Windows.Forms.ListView
End Class
