Public Class stockPage
    Private mTyre As List(Of tyre)
    Private mExhaust As List(Of exhaust)

    Dim selectedTyre As tyre
    Dim selectedEx As exhaust

    Private Sub stockPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub


    Private Sub uiCarPartsListBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles uiCarPartsListBox.SelectedIndexChanged
        Dim selectedPartIndex As Integer
        Dim partCounter As Integer = 0
        Dim entireTyreModelsStocked As Integer

        selectedPartIndex = uiCarPartsListBox.SelectedIndex

        For Each getTyreModelsStocked As tyre In mTyre
            entireTyreModelsStocked += 1 'gets how many tyre models are actually stocked so that you could add as many tyres as you want and the 
            ' algorithm will still work for working out which part is selected
        Next

        For Each tyreSelected As tyre In mTyre
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

    End Sub
    Public Sub getList(ByRef mTyreList As List(Of tyre), ByRef mExhList As List(Of exhaust))
        mTyre = mTyreList
        mExhaust = mExhList
        populateStock()
    End Sub
    Private Sub populateStock()
        Dim tempTyre As tyre 'this sub simply lists all the tyres and exhausts stored, its important it lists in this way for the
        Dim tempExhaust As exhaust 'algorithm later used when deciding what part is selected to update
        uiCarPartsListBox.Items.Clear()

        For Each tyre As tyre In mTyre
            uiCarPartsListBox.Items.Add(tyre.getStock & " x " & tyre.getMake & " " & tyre.getModel & " " & tyre.getTyre)
            tempTyre = tyre
        Next

        For Each ex As exhaust In mExhaust
            uiCarPartsListBox.Items.Add(ex.getStock & " x " & ex.getMake & " " & ex.getModel & " (" & ex.getSize & ")" & " Exhaust")
            tempExhaust = ex
        Next
    End Sub

    Private Sub uiAddStockButton_Click(sender As System.Object, e As System.EventArgs) Handles uiAddStockButton.Click
        addStock()

    End Sub
    Private Sub addStock()
        Dim stockToAdd As Integer 'this sub could simply work by updating the stock with the global tyre/exhaust selected, but by using boolean determiners it then stops the chance of erros occuring when attempting to add stock for multiple items in one go.
        Dim intCheck As Integer
        If uiCarPartsListBox.SelectedItem = Nothing Or uiQuantityTextBox.Text() = "" Or Not Integer.TryParse(uiQuantityTextBox.Text(), intCheck) Then
            MessageBox.Show("Invalid select please try again.")
            selectedEx = Nothing
            selectedTyre = Nothing
            Exit Sub
        End If
        stockToAdd = uiQuantityTextBox.Text()
        If selectedTyre Is Nothing Then ' this means it is definitely an exhaust that has been selected
            selectedEx.getStock = selectedEx.getStock + stockToAdd
            uiQuantityTextBox.Text() = ""
            selectedEx = Nothing ' gets rid of the selected exhaust so that if you then wanted to add a tyre it would go into the next if statement
        ElseIf selectedEx Is Nothing Then
            selectedTyre.getStock = selectedTyre.getStock + stockToAdd
            uiQuantityTextBox.Text() = ""
            selectedTyre = Nothing 'same as before but with tyre
        End If
        populateStock()

    End Sub
End Class