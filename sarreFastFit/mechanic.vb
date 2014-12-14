Public Class mechanic
    Private mRate As Decimal
    Private mName As String
    Public Sub New(rate As Decimal, name As String)
        mRate = rate
        mName = name
    End Sub
    Public Property getMechRate
        Get
            Return mRate
        End Get
        Set(value)
            mRate = value
        End Set
    End Property
    Public Property getName
        Get
            Return mName
        End Get
        Set(value)
            mName = value
        End Set
    End Property
End Class
