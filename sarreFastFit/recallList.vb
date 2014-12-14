Public Class recallList
    Private mTyres As List(Of tyre)
    Private mExhaust As List(Of exhaust)
    Private mInvoices As List(Of invoice)
    Private selectedTyre As tyre
    Private selectedEx As exhaust

    Private Sub recallList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub popList()
        Dim tempTyre As tyre ' simply adds all parts stocked
        Dim tempExhaust As exhaust
        uiPartsListBox.Items.Clear()

        For Each tyre As tyre In mTyres
            uiPartsListBox.Items.Add(tyre.getMake & " " & tyre.getModel & " " & tyre.getTyre)
            tempTyre = tyre
        Next

        For Each ex As exhaust In mExhaust
            uiPartsListBox.Items.Add(ex.getModel & " " & ex.getMake & " (" & ex.getSize & ")" & " Exhaust")
            tempExhaust = ex
        Next
    End Sub
    Public Sub getData(ByRef mTyreList As List(Of tyre), ByRef mExhList As List(Of exhaust), ByRef invList As List(Of invoice))
        mTyres = mTyreList
        mExhaust = mExhList 'passes over all the lists required for this to work, it needs to tyre, exhaust and invoices.
        mInvoices = invList
        popList()

    End Sub

    Private Sub uiPartsListBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles uiPartsListBox.SelectedIndexChanged
        updateList()
    End Sub
    Private Sub popCustomer()
        uiAffectedCustomerListBox.Items.Clear()

        For Each inv As invoice In mInvoices 'uses global variables, if a selected exhaust is nothing then a TYRE MUST be selected. it then can compare the current invoice iteration to the tyre selected, if they are the same then list it along with the registration.
            If selectedEx Is Nothing Then
                If inv.getTyre = (selectedTyre.getMake & " " & selectedTyre.getModel & " " & selectedTyre.getTyre) Then
                    uiAffectedCustomerListBox.Items.Add(inv.getCarMake & " " & inv.getCarModel & " " & inv.getReg) 'note it does not list the tyre model, nor the engine, this is assumed due to the selected item being an indicator of type. The important data is realisticly the REGISTRATION NUMBER
                End If
            ElseIf selectedTyre Is Nothing Then 'the same happens here, if no tyre is selected then it MUST BE an exhaust
                If inv.getExNeeded = True And selectedEx.getModel = inv.getCarMake And selectedEx.getMake = inv.getCarModel Then
                    uiAffectedCustomerListBox.Items.Add(inv.getCarMake & " " & inv.getCarModel & " " & inv.getReg) 'note it does not list the tyre model, nor the engine, this is assumed due to the selected item being an indicator of type. The important data is realisticly the REGISTRATION NUMBER
                End If
            End If
        Next
        selectedTyre = Nothing
        selectedEx = Nothing 'resets the variables so that the user can then select another part to compare against.
    End Sub
    Private Sub updateList()
        Dim selectedPartIndex As Integer
        Dim partCounter As Integer = 0
        Dim entireTyreModelsStocked As Integer

        selectedPartIndex = uiPartsListBox.SelectedIndex

        For Each getTyreModelsStocked As tyre In mTyres
            entireTyreModelsStocked += 1 'gets how many tyre models are actually stocked so that you could add as many tyres as you want and the 
            ' algorithm will still work for working out which part is selected
        Next

        For Each tyreSelected As tyre In mTyres
            If selectedPartIndex = partCounter Then
                selectedTyre = tyreSelected ' checks is the index is the same as the part selected ONLY FOR TYRES
            End If
            partCounter += 1 'adds one to the part counter here, saying it has checked against this tyre

            If partCounter >= entireTyreModelsStocked Then
                For Each exh As exhaust In mExhaust ' if it gets here it means the list of tyres has all been checked and it is now checking against the exhaust
                    If (selectedPartIndex - entireTyreModelsStocked) = (partCounter - entireTyreModelsStocked) Then
                        selectedEx = exh
                    End If
                    partCounter += 1 'adds one to the part counter here to which it uses the same variable as before but is in essence deducted depending on the amount of tyres, therefore the index of the selected item is the same as the index of the exhaust
                Next
            End If
        Next
        popCustomer()
    End Sub
End Class