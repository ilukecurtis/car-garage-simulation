<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sarreFastFit
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
        Me.cmbMechanic = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxRegNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxTyresRequired = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxCarList = New System.Windows.Forms.ListBox()
        Me.txtboxTyres = New System.Windows.Forms.ListBox()
        Me.uiViewInvoicesButton = New System.Windows.Forms.Button()
        Me.btnDoJob = New System.Windows.Forms.Button()
        Me.chkboxExhaust = New System.Windows.Forms.CheckBox()
        Me.txtboxPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnRecall = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbMechanic
        '
        Me.cmbMechanic.FormattingEnabled = True
        Me.cmbMechanic.Location = New System.Drawing.Point(31, 54)
        Me.cmbMechanic.Name = "cmbMechanic"
        Me.cmbMechanic.Size = New System.Drawing.Size(129, 21)
        Me.cmbMechanic.TabIndex = 1
        Me.cmbMechanic.Text = "SELECT MECHANIC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Registration Number"
        '
        'txtboxRegNum
        '
        Me.txtboxRegNum.Location = New System.Drawing.Point(31, 112)
        Me.txtboxRegNum.Name = "txtboxRegNum"
        Me.txtboxRegNum.Size = New System.Drawing.Size(150, 20)
        Me.txtboxRegNum.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select Car"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(548, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tyres Required"
        '
        'txtboxTyresRequired
        '
        Me.txtboxTyresRequired.Location = New System.Drawing.Point(477, 112)
        Me.txtboxTyresRequired.Name = "txtboxTyresRequired"
        Me.txtboxTyresRequired.Size = New System.Drawing.Size(150, 20)
        Me.txtboxTyresRequired.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tyres"
        '
        'txtboxCarList
        '
        Me.txtboxCarList.FormattingEnabled = True
        Me.txtboxCarList.Location = New System.Drawing.Point(31, 151)
        Me.txtboxCarList.Name = "txtboxCarList"
        Me.txtboxCarList.Size = New System.Drawing.Size(306, 121)
        Me.txtboxCarList.TabIndex = 15
        '
        'txtboxTyres
        '
        Me.txtboxTyres.FormattingEnabled = True
        Me.txtboxTyres.Location = New System.Drawing.Point(392, 151)
        Me.txtboxTyres.Name = "txtboxTyres"
        Me.txtboxTyres.Size = New System.Drawing.Size(242, 121)
        Me.txtboxTyres.TabIndex = 16
        '
        'uiViewInvoicesButton
        '
        Me.uiViewInvoicesButton.Location = New System.Drawing.Point(533, 54)
        Me.uiViewInvoicesButton.Name = "uiViewInvoicesButton"
        Me.uiViewInvoicesButton.Size = New System.Drawing.Size(101, 25)
        Me.uiViewInvoicesButton.TabIndex = 17
        Me.uiViewInvoicesButton.Text = "View Invoices"
        Me.uiViewInvoicesButton.UseVisualStyleBackColor = True
        '
        'btnDoJob
        '
        Me.btnDoJob.Location = New System.Drawing.Point(275, 361)
        Me.btnDoJob.Name = "btnDoJob"
        Me.btnDoJob.Size = New System.Drawing.Size(101, 25)
        Me.btnDoJob.TabIndex = 0
        Me.btnDoJob.Text = "Do Job"
        Me.btnDoJob.UseVisualStyleBackColor = True
        '
        'chkboxExhaust
        '
        Me.chkboxExhaust.AutoSize = True
        Me.chkboxExhaust.Location = New System.Drawing.Point(268, 298)
        Me.chkboxExhaust.Name = "chkboxExhaust"
        Me.chkboxExhaust.Size = New System.Drawing.Size(110, 17)
        Me.chkboxExhaust.TabIndex = 10
        Me.chkboxExhaust.Text = "Exhaust Required"
        Me.chkboxExhaust.UseVisualStyleBackColor = True
        '
        'txtboxPrice
        '
        Me.txtboxPrice.Location = New System.Drawing.Point(256, 334)
        Me.txtboxPrice.Name = "txtboxPrice"
        Me.txtboxPrice.ReadOnly = True
        Me.txtboxPrice.Size = New System.Drawing.Size(143, 20)
        Me.txtboxPrice.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(299, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total Cost:"
        '
        'btnStock
        '
        Me.btnStock.Location = New System.Drawing.Point(88, 360)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(101, 25)
        Me.btnStock.TabIndex = 13
        Me.btnStock.Text = "Stock"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnRecall
        '
        Me.btnRecall.Location = New System.Drawing.Point(466, 361)
        Me.btnRecall.Name = "btnRecall"
        Me.btnRecall.Size = New System.Drawing.Size(101, 25)
        Me.btnRecall.TabIndex = 14
        Me.btnRecall.Text = "Recall List"
        Me.btnRecall.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(25, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 31)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Sarre Fast Fit"
        '
        'sarreFastFit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(656, 399)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.uiViewInvoicesButton)
        Me.Controls.Add(Me.txtboxTyres)
        Me.Controls.Add(Me.txtboxCarList)
        Me.Controls.Add(Me.btnRecall)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtboxPrice)
        Me.Controls.Add(Me.chkboxExhaust)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtboxTyresRequired)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxRegNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMechanic)
        Me.Controls.Add(Me.btnDoJob)
        Me.Name = "sarreFastFit"
        Me.Text = "Sarre Fast Fit!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMechanic As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtboxRegNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtboxTyresRequired As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtboxCarList As System.Windows.Forms.ListBox
    Friend WithEvents txtboxTyres As System.Windows.Forms.ListBox
    Friend WithEvents uiViewInvoicesButton As System.Windows.Forms.Button
    Friend WithEvents btnDoJob As System.Windows.Forms.Button
    Friend WithEvents chkboxExhaust As System.Windows.Forms.CheckBox
    Friend WithEvents txtboxPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnRecall As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
