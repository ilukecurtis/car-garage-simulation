Public Class vehicle
    Private mMake As String 'simply stores all data relating to a vehicle, along with properties
    Private mModel As String
    Private mTyre As String
    Private mEngine As Integer

    Public Sub New(make As String, model As String, tyre As String, engine As Integer)
        mMake = make
        mModel = model
        mTyre = tyre
        mEngine = engine

    End Sub
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
    Public Property getTyre
        Get
            Return mTyre
        End Get
        Set(value)
            mTyre = value
        End Set
    End Property
    Public Property getEngine
        Get
            Return mEngine
        End Get
        Set(value)
            mEngine = value
        End Set
    End Property

End Class
