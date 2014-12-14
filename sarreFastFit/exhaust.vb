Public Class exhaust
    Inherits stock 'INHERITANCE USED
    Private mModel As String 'simply stores all data relating to exhausts and properties.
    Private mMake As String
    Private mExhaustSize As Integer
    Private mPrice As Decimal
    Public Sub New(model As String, make As String, eng As Integer, price As Decimal, stocks As Integer)
        MyBase.New(stocks)
        mModel = model
        mMake = make
        mExhaustSize = eng
        mPrice = price
    End Sub
    Public Property getPrice
        Get
            Return mPrice
        End Get
        Set(value)
            mPrice = value
        End Set
    End Property
    Public Property getSize
        Get
            Return mExhaustSize
        End Get
        Set(value)
            mExhaustSize = value
        End Set
    End Property
    Public Property getMake
        Get
            Return mMake
        End Get
        Set(value)
            mMake = value
        End Set
    End Property
    Public Property getModel
        Get
            Return mModel
        End Get
        Set(value)
            mModel = value
        End Set
    End Property
End Class
