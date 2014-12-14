Public Class invoice
    Private mCustomerReg As String 'this invoice stores an arguably comprehensive list of all the data regarding the invoice
    Private mCustomerCarMake As String 'the reason for the many properties is simply to enforce strict checks later on in the recall form to be 100% sure that the recall is displaying the right item.
    Private mCustomerCarModel As String
    Private mCustomerCarEng As String
    Private mCustomerTyre As String
    Private mCustomerTyreAmount As Integer
    Private mCustomerPrice As Decimal
    Private mMechanicUsed As String
    Private mReg As String
    Private mExReq As Boolean
    Private mCustomerTyreSize As String



    Public Sub New(charge As Decimal, curMech As String, curCarMake As String, curCarModel As String, curTyre As String, curReg As String, req As Integer, ex As Boolean, engSize As String, tyreSize As String)
        mCustomerCarMake = curCarMake
        mCustomerCarModel = curCarModel
        mCustomerPrice = charge
        mCustomerTyre = curTyre
        mMechanicUsed = curMech
        mReg = curReg
        mCustomerTyreAmount = req
        mExReq = ex
        mCustomerCarEng = engSize
        mCustomerTyreSize = tyreSize
    End Sub
    Public Property getCharge
        Get
            Return mCustomerPrice
        End Get
        Set(value)
            mCustomerPrice = value
        End Set
    End Property
    Public Property getCarMake
        Get
            Return mCustomerCarMake
        End Get
        Set(value)
            mCustomerCarMake = value
        End Set
    End Property
    Public Property getCarModel
        Get
            Return mCustomerCarModel
        End Get
        Set(value)
            mCustomerCarModel = value
        End Set
    End Property
    Public Property getTyre
        Get
            Return mCustomerTyre
        End Get
        Set(value)
            mCustomerTyre = value
        End Set
    End Property
    Public Property getMech
        Get
            Return mMechanicUsed
        End Get
        Set(value)
            mMechanicUsed = value
        End Set
    End Property
    Public Property getReg
        Get
            Return mReg
        End Get
        Set(value)
            mReg = value
        End Set
    End Property
    Public Property getTyresReq
        Get
            Return mCustomerTyreAmount
        End Get
        Set(value)
            mCustomerTyreAmount = value
        End Set
    End Property
    Public Property getExNeeded
        Get
            Return mExReq
        End Get
        Set(value)
            mExReq = value
        End Set
    End Property
    Public Property getEng
        Get
            Return mCustomerCarEng
        End Get
        Set(value)
            mCustomerCarEng = value
        End Set
    End Property
    Public Property getCarTyre
        Get
            Return mCustomerTyreSize
        End Get
        Set(value)
            mCustomerTyreSize = value
        End Set
    End Property
End Class
