Public Class ClsGuest
    Private _ID As Integer
    Private _roomID As Integer
    Private _duration As Integer
    Private _timeIn As New DateTime
    Private _timeout As New DateTime
    Private _amount As Double

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property RoomID As Integer
        Get
            Return _roomID
        End Get
        Set(value As Integer)
            _roomID = value
        End Set
    End Property

    Public Property Duration As Integer
        Get
            Return _duration
        End Get
        Set(value As Integer)
            _duration = value
        End Set
    End Property

    Public Property TimeIn As DateTime
        Get
            Return _timeIn
        End Get
        Set(value As DateTime)
            _timeIn = value
        End Set
    End Property

    Public Property TimeOut As DateTime
        Get
            Return _timeout
        End Get
        Set(value As DateTime)
            _timeout = value
        End Set
    End Property


    Public Property Amount As Double
        Get
            Return _amount
        End Get
        Set(value As Double)
            _amount = value
        End Set
    End Property
End Class
