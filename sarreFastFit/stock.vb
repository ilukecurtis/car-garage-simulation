Public Class stock
    Protected mStock As Integer 'due to this being the superclass/inheritor for tyre and exhaust it simply requires the stock, that way you can add many parts and not need to worry about individual stock
    Public Sub New(stock As Integer)
        mStock = stock
    End Sub
    Public Property getStock
        Get
            Return mStock
        End Get
        Set(value)
            mStock = value
        End Set
    End Property
End Class
