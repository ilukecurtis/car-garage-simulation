Public Class invoiceForm
    Private mInvoices As List(Of invoice)

    Private Sub uiInvoiceListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub listInvoices(ByRef mInvoicesForm1 As List(Of invoice))
        mInvoices = mInvoicesForm1
        populateList() 'passes over the invoices
    End Sub
    Private Sub populateList()
        uiInvoicesListView.View = View.Details 'list view items are used to make sure the formatting if correct if a car/tyre name is too long
        uiInvoicesListView.FullRowSelect = True
        uiInvoicesListView.Columns.Add("Mechanic:", 70)
        uiInvoicesListView.Columns.Add("Car:", 280)
        uiInvoicesListView.Columns.Add("Registration:", 100)
        uiInvoicesListView.Columns.Add("Tyres(Quantity):", 250)
        uiInvoicesListView.Columns.Add("Price:", 80)
        uiInvoicesListView.Columns.Add("Exhaust Needed?:", 140)
        For Each inv In mInvoices
            Dim invoiceArray(5) As String
            Dim addItem As ListViewItem
            invoiceArray(0) = inv.getMech
            invoiceArray(1) = (inv.getCarMake & " " & inv.getCarModel & " " & inv.getCarTyre & " (" & inv.getEng & ") ")
            invoiceArray(2) = inv.getReg
            invoiceArray(3) = (inv.getTyre & " (" & inv.getTyresReq & ") ")
            invoiceArray(4) = ("£" & inv.getCharge)
            invoiceArray(5) = inv.getExNeeded
            addItem = New ListViewItem(invoiceArray)
            uiInvoicesListView.Items.Add(addItem)

        Next
    End Sub

    Private Sub invoiceForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub uiInvoicesListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiInvoicesListView.SelectedIndexChanged

    End Sub
End Class