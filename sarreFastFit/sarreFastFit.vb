Imports Microsoft.VisualBasic.ControlChars
Public Class sarreFastFit
    ' LUKE CURTIS - PROGRAMMING 2 - MAIN FORM 1
    Private mMechanics As List(Of mechanic)
    Private mVehicle As List(Of vehicle)
    Private mTyre As List(Of tyre)
    Private mExhaust As List(Of exhaust)
    Private mInvoice As List(Of invoice)

    Dim currentMechPrice As Decimal = 0
    Dim currentExhaustPrice As Decimal = 0 ' These global variables are used to ensure integrity when changing options after selecting one previously.
    Dim currentTyrePrice As Decimal = 0 ' it's simply to ensure that if someone has malicious intent when using the program that the price could not be manipulated.
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mInvoice = New List(Of invoice)

        mMechanics = New List(Of mechanic)
        Dim tempMech As mechanic

        tempMech = New mechanic(14.95, "Michael")
        mMechanics.Add(tempMech)
        tempMech = New mechanic(12.95, "Richard")
        mMechanics.Add(tempMech)
        tempMech = New mechanic(9.95, "Dave")
        mMechanics.Add(tempMech)

        mVehicle = New List(Of vehicle)
        Dim tempCar As vehicle

        tempCar = New vehicle("Mitsubishi", "Topo Guppy", "165/65R13", 1100)
        mVehicle.Add(tempCar)
        tempCar = New vehicle("Mitsubishi", "Minica Winky", "155/85R12", 850)
        mVehicle.Add(tempCar)
        tempCar = New vehicle("Mitsubishi", "Minica Lettuce", "155/85R12", 1000)
        mVehicle.Add(tempCar)
        tempCar = New vehicle("Mitsubishi", "Mini Active Urban Scandal", "150/70R11", 650)
        mVehicle.Add(tempCar)

        mTyre = New List(Of tyre)
        Dim tempTyre As tyre

        tempTyre = New tyre("Slipstone", "Go", "165/65R13", 39.95, 8)
        mTyre.Add(tempTyre)
        tempTyre = New tyre("Slipstone", "Go", "155/85R12", 59.95, 4)
        mTyre.Add(tempTyre)
        tempTyre = New tyre("Slipstone", "NoStop", "155/85R12", 29.95, 2)
        mTyre.Add(tempTyre)
        tempTyre = New tyre("BadYear", "Screamer", "150/70R11", 34.95, 4)
        mTyre.Add(tempTyre)
        tempTyre = New tyre("BadYear", "Screamer", "155/85R12", 49.95, 2)
        mTyre.Add(tempTyre)

        mExhaust = New List(Of exhaust)
        Dim tempEx As exhaust

        tempEx = New exhaust("Mitsubishi", "Topo Guppy", 1100, 59.95, 1)
        mExhaust.Add(tempEx)
        tempEx = New exhaust("Mitsubishi", "Minica Winky", 850, 49.95, 2)
        mExhaust.Add(tempEx)
        tempEx = New exhaust("Mitsubishi", "Minica Lettuce", 1000, 49.95, 1)
        mExhaust.Add(tempEx)
        tempEx = New exhaust("Mitsubishi", "Mini Active Urban Scandal", 650, 44.95, 2)
        mExhaust.Add(tempEx) 'the previous code is used to send all the data into the system.

        For Each currentmech As mechanic In mMechanics
            cmbMechanic.Items.Add(currentmech.getName) ' after which it then lists all the mechanics, and cars
        Next                                           ' instead of explicitly saying what cars and mechanics the program should list
        ' this way it can have as many cars/mechanics listed as the system has  
        For Each currentCar As vehicle In mVehicle
            txtboxCarList.Items.Add(currentCar.getMake & " " & currentCar.getModel & " " & currentCar.getTyre & " " & "(" & currentCar.getEngine & ")")
        Next

    End Sub

    Private Sub btnDoJob_Click(sender As System.Object, e As System.EventArgs) Handles btnDoJob.Click
        storeInvoice()

    End Sub

    Private Sub cmbMechanic_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMechanic.SelectedIndexChanged
        getMech()

    End Sub

    Private Sub txtboxCarList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtboxCarList.SelectedIndexChanged
        selectCar()


    End Sub

    Private Sub txtboxTyresRequired_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtboxTyresRequired.TextChanged
        selectTyres()

    End Sub

    Private Sub chkboxExhaust_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkboxExhaust.CheckedChanged
        addExhaust()


    End Sub

    Private Sub txtboxTyres_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtboxTyres.SelectedIndexChanged
        selectTyresReq()

    End Sub

    Private Sub addExhaust()
        Dim currentCarIndex As Integer
        Dim curCarEx As Integer
        Dim curExPrice As Decimal
        Dim exhaustCheckLoop As Integer
        currentCarIndex = txtboxCarList.SelectedIndex
        If chkboxExhaust.Checked Then
            For Each carExhaust As vehicle In mVehicle
                If exhaustCheckLoop = currentCarIndex Then
                    curCarEx = carExhaust.getEngine 'checks what car is selected, stores what engine it has that can be used for the exhaust
                End If
                exhaustCheckLoop = exhaustCheckLoop + 1
                'finds current car exhaust size
            Next
            For Each exCheck As exhaust In mExhaust
                If curCarEx = exCheck.getSize Then
                    curExPrice = exCheck.getPrice
                End If
                'reads in car exhaust size, gives back price is exhausts are same
            Next
            'new price being declared for exhaust
            currentExhaustPrice = curExPrice
            'end new declare
        Else
            currentExhaustPrice = 0
        End If
        updatePriceBox() ' to update the price

    End Sub
    Private Sub getMech()
        Dim rate As Decimal
        Dim nameSelected As String
        nameSelected = cmbMechanic.SelectedItem
        For Each currentmech As mechanic In mMechanics
            If currentmech.getName = nameSelected Then
                rate = currentmech.getMechRate() 'simple method to get the rate of the mechanic and udpate the price box accordingly
            End If
        Next 'I could've used a selected index here instead of the name, incase there was duplicates of names, but this works fine for the assignment.
        currentMechPrice = rate
        updatePriceBox()
    End Sub
    Private Sub selectCar()
        Dim tyreSize As String = ""
        Dim curCarTyre As String = ""
        Dim indexCurrentlySelected As Integer
        Dim tyreCheckLoop As Integer

        Dim ex As Integer ' exhaust var
        Dim foundEx As Boolean = False ' exhaust var
        Dim exStock As Integer ' exhaust var
        Dim tyreReq As Integer
        txtboxTyres.Items.Clear()
        indexCurrentlySelected = txtboxCarList.SelectedIndex
        Dim intCheck As Integer
        If txtboxTyresRequired.Text = "" Or Not Integer.TryParse(txtboxTyresRequired.Text(), intCheck) Then
            tyreReq = 0  'simple error handingly incase the user has not yet selected how many tyres they want it can still continue the sub accordingly
        Else
            tyreReq = txtboxTyresRequired.Text()
        End If
        For Each currentCar As vehicle In mVehicle
            If tyreCheckLoop = indexCurrentlySelected Then
                tyreSize = currentCar.getTyre
                ex = currentCar.getEngine   'gets the engine size of the car selected, stores in variable ex, this way it can use later to check the stock of that engine size
            End If
            tyreCheckLoop = tyreCheckLoop + 1
        Next


        For Each tempTyre As tyre In mTyre
            Dim tyreFull As String = ""
            tempTyre.populateList(mTyre, tyreSize, tyreReq, tyreFull) ' this is simply to populate the list, stores all tyre data in a string.
            If tyreFull = "" Then
                'this is used to make sure spaces where the tyre it is checking against an ineligible tyre is not simply listed. 
            Else
                txtboxTyres.Items.Add(tyreFull) ' the populateList method returned a full tyre value, that can then be added to the list.
            End If
        Next

        For Each exhaustCheck As exhaust In mExhaust
            If ex = exhaustCheck.getSize Then
                exStock = exhaustCheck.getStock 'stores the stock of the current exhaust in a variable to then determine whether or not the checkbox should be enabled.
            End If
        Next
        If exStock < 1 Then
            chkboxExhaust.Enabled = False
        Else
            chkboxExhaust.Enabled = True
        End If
    End Sub
    Private Sub selectTyres()
        Dim tyreReq As Integer 'this sub runs when the user changes the amount of tyres they want.
        Dim tyreReqLoop As Integer
        Dim intCheck As Integer
        If txtboxTyresRequired.Text = "" Or Not Integer.TryParse(txtboxTyresRequired.Text(), intCheck) Then
            tyreReq = 0
        Else
            tyreReq = txtboxTyresRequired.Text()
        End If

        Dim tyreSize As String = ""
        Dim curCarTyre As String = ""
        Dim indexCurrentlySelected As Integer

        txtboxTyres.Items.Clear()
        indexCurrentlySelected = txtboxCarList.SelectedIndex
        For Each currentCar As vehicle In mVehicle
            If tyreReqLoop = indexCurrentlySelected Then 'it essentially repopulates the list by iterating through each tyre, checking 
                tyreSize = currentCar.getTyre            ' if the current car has the same tyre that is stored in the system 
            End If
            tyreReqLoop = tyreReqLoop + 1
        Next


        For Each tempTyre As tyre In mTyre
            Dim tyreFull As String = ""
            tempTyre.populateList(mTyre, tyreSize, tyreReq, tyreFull) 'the tyreSize variable is reused here to check in the populate list
            If tyreFull = "" Then                                     ' to make sure that it is indeed the same size, then it can list it.  
                ' dont put it in the list otherwise the list will look weird, it will have spaces
            Else
                txtboxTyres.Items.Add(tyreFull)
            End If
        Next
    End Sub
    Private Sub selectTyresReq()
        Dim amount As Decimal
        Dim tyreString As String = ""
        Dim getTyreSplits() As String
        Dim currentPriceOfTyre As Decimal
        If txtboxTyres.SelectedItem = Nothing Then
            Exit Sub
        Else
            tyreString = txtboxTyres.SelectedItem
        End If

        getTyreSplits = tyreString.Split(" ") 'I could've used selected index here to get the tyre selected, but a split works just as well for this assignment
        Dim intCheck As Integer
        If txtboxTyresRequired.Text = "" Or Not Integer.TryParse(txtboxTyresRequired.Text(), intCheck) Then
            amount = 0
        Else
            amount = txtboxTyresRequired.Text()
        End If
        For Each getTyrePrice As tyre In mTyre
            Dim curTyreSize As String
            Dim curTyreModel As String

            curTyreSize = getTyrePrice.getTyre
            curTyreModel = getTyrePrice.getModel

            If curTyreSize = getTyreSplits(2) And curTyreModel = getTyreSplits(1) Then
                currentPriceOfTyre = getTyrePrice.getPrice 'here it compares the model and size and if they are the same, it knows that the price in this current iteration is the price needed.
            End If

        Next
        currentTyrePrice = (currentPriceOfTyre * amount) 'it then updates the price accordingly based on how many tyres the user requires and what tyre is selected.
        updatePriceBox()
    End Sub
    Private Sub updatePriceBox()
        Dim temporaryFinalPrice As Decimal
        temporaryFinalPrice = currentExhaustPrice + currentMechPrice + currentTyrePrice
        Math.Round(temporaryFinalPrice, 2) 'rounds the price to 2 decimal places, ensure that it is a proper currency number.

        txtboxPrice.Text = ("£" & temporaryFinalPrice) ' updates price with the global variables that may of been manipulated earlier in code.

    End Sub
    Private Sub storeInvoice()
        Dim tempInv As invoice
        Dim vehicleLoop As Integer
        Dim tempEx As exhaust = Nothing

        Dim charge As Decimal

        Dim curMech As String
        Dim curCarMake As String = " "
        Dim curCarModel As String = " "
        Dim curCarEng As String = " "
        Dim curCarTyre As String = " "
        Dim curTyre As String = " "
        Dim curReg As String = "N/A"
        Dim intCheck As Integer
        Dim tyresNeeded As Integer = 0
        Dim tyreSold As tyre = Nothing
        Dim exNeeded As Boolean = False 'all these variables are used to store certain information regarding what job has just been completed.

        If cmbMechanic.SelectedItem = Nothing Then
            MessageBox.Show("Please select mechanic!") 'there are various error checks here to ensure a job does not incorrectly go through
            Exit Sub
        End If
        If txtboxPrice.Text = "" Then
            MessageBox.Show("Error, please purchase again, you seemed to of tried to purchase without first selecting anything")
            charge = 0 'this checks that if somehow the user managed to click do job without first having any price being displayed it would exit the sub.
            Exit Sub
        Else
            charge = txtboxPrice.Text()
            curMech = cmbMechanic.SelectedItem
            If chkboxExhaust.Checked = True Then
                exNeeded = True 'this then checks whether or not if later on in the sub the exhaust stock will need to be deducted for the current car
            End If
            For Each curCar As vehicle In mVehicle
                If txtboxCarList.SelectedIndex = vehicleLoop Then
                    curCarMake = curCar.getMake
                    curCarModel = curCar.getModel
                    curCarEng = curCar.getEngine ' uses an index search to check what car is selected, after which it then checks what exhaust it will need to continue the sub with incase exhaust is selected.
                    curCarTyre = curCar.getTyre
                    If exNeeded = True Then
                        For Each ex In mExhaust
                            If curCarMake = ex.getModel And curCarModel = ex.getMake Then
                                tempEx = ex
                            End If
                        Next
                    End If
                End If
                vehicleLoop = vehicleLoop + 1
            Next

            If txtboxTyres.SelectedItem = Nothing Then
            Else
                curTyre = txtboxTyres.SelectedItem

                If txtboxTyresRequired.Text = "" Or Not Integer.TryParse(txtboxTyresRequired.Text(), intCheck) Then

                Else
                    tyresNeeded = txtboxTyresRequired.Text()
                End If
                Dim tyreString As String = ""
                Dim getTyreSplits() As String

                tyreString = txtboxTyres.SelectedItem

                getTyreSplits = tyreString.Split(" ") 'once again a split is used to get the tyre information.
                For Each tempTyre As tyre In mTyre
                    Dim curTyreSize As String
                    Dim curTyreModel As String

                    curTyreSize = tempTyre.getTyre
                    curTyreModel = tempTyre.getModel

                    If curTyreSize = getTyreSplits(2) And curTyreModel = getTyreSplits(1) Then
                        tyreSold = tempTyre
                    End If

                Next
            End If
        End If

        If tyreSold Is Nothing And tempEx Is Nothing Then
            MessageBox.Show("You have tried to purchase nothing, please select either exhaust or tyres") 'more error checking incase no tyre is selected AND no exhaust is needed either.
        Else
            If tyreSold Is Nothing Then
            ElseIf tyreSold IsNot Nothing And tyreSold.getStock < tyresNeeded Then
                MessageBox.Show("Not enough tyres for selected job, please select different make, add tyres, or change quantity.") 'checks stock ONLY for tyres
                Exit Sub
            Else
                tyreSold.getStock = tyreSold.getStock - tyresNeeded ' take stock from tyre
            End If
            If tempEx Is Nothing Then
            ElseIf tempEx IsNot Nothing And tempEx.getStock = 0 Then
                MessageBox.Show("No exhausts available, please add stock") 'checks if there is no stock ONLY for the exhaust.
                Exit Sub
            Else
                tempEx.getStock = tempEx.getStock - 1 ' take stock from exhaust
            End If
            curReg = txtboxRegNum.Text()
            tempInv = New invoice(charge, curMech, curCarMake, curCarModel, curTyre, curReg, tyresNeeded, exNeeded, curCarEng, curCarTyre)
            mInvoice.Add(tempInv) 'if all goes well, the code will get here, store the invoice and add it to the invoice list.
            resetVals()
        End If
    End Sub
    Private Sub btnStock_Click(sender As System.Object, e As System.EventArgs) Handles btnStock.Click
        Dim showStock As New stockPage
        showStock.getList(mTyre, mExhaust)
        showStock.ShowDialog()

    End Sub

    Private Sub uiViewInvoicesButton_Click(sender As System.Object, e As System.EventArgs) Handles uiViewInvoicesButton.Click
        showInvoice()
    End Sub
    Private Sub showInvoice()
        Dim showInvoice As New invoiceForm
        showInvoice.listInvoices(mInvoice)
        showInvoice.ShowDialog() 'opens invoice form.

    End Sub
    Public Sub resetVals()
        txtboxTyres.Items.Clear()
        txtboxCarList.SelectedItem = Nothing
        txtboxTyresRequired.Text = ""
        chkboxExhaust.Checked = False
        cmbMechanic.SelectedItem = Nothing
        currentMechPrice = 0
        currentExhaustPrice = 0
        currentTyrePrice = 0
        txtboxPrice.Text = ""
        txtboxRegNum.Text = "" 'when do job is clicked it resets all values to ensure no data is incorrectly reused when wanting to do another job.
    End Sub

    Private Sub btnRecall_Click(sender As System.Object, e As System.EventArgs) Handles btnRecall.Click
        Dim showRecall As New recallList
        showRecall.getData(mTyre, mExhaust, mInvoice)
        showRecall.ShowDialog()

    End Sub
End Class
