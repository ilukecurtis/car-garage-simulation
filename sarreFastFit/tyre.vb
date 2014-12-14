Public Class tyre
    Inherits stock 'INHERITANCE USED
    Private mMake As String 'simply stores all data relating to tyre and properties (along with method below, see comment there as to why).
    Private mModel As String
    Private mTyreSize As String
    Private mPrice As Decimal
    Public Sub New(make As String, model As String, tyre As String, price As Decimal, stocks As Integer)
        MyBase.New(stocks)
        mMake = make
        mModel = model
        mTyreSize = tyre
        mPrice = price
    End Sub
    Public Property getTyre
        Get
            Return mTyreSize
        End Get
        Set(value)
            mTyreSize = value
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
    Public Property getPrice
        Get
            Return mPrice
        End Get
        Set(value)
            mPrice = value
        End Set
    End Property
    Public Function populateList(ByRef mTyre As List(Of tyre), ByRef tyreSize As String, ByRef tyreReq As Integer, ByRef tyreFull As String)
        Dim tyreStock As Integer ' this code is used in two instances, once in the default form, and once in the recall, it makes sense to put it here to avoid reusing code.
        Dim tyreSize2 As String
        tyreSize2 = getTyre
        tyreStock = mStock
        If mStock >= 1 Then
            If tyreSize = tyreSize2 And tyreStock >= tyreReq Then
                tyreFull = (getMake & " " & getModel & " " & getTyre)
                If tyreFull = "" Then
                    tyreFull = vbNull
                End If
            End If
        End If
        Return tyreFull
    End Function
End Class
