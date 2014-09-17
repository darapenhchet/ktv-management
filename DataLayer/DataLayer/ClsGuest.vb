Public Class ClsGuest
    Private _ID As Integer
    Private _Room As ClsRoom
    Private _duration As Integer
    Private _timeIn As New DateTime
    Private _timeout As New DateTime
    Private _amount As Double
    Private _status As Boolean


    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Room As ClsRoom
        Get
            Return _Room
        End Get
        Set(value As ClsRoom)
            _Room = value
        End Set
    End Property

    Public Property Duration As Integer
        Get
            Return _duration
        End Get
        Set(value As Integer)
            If value < 0 Then
                MsgBox("The duration of the singing is cannot less than 0")
            Else
                _duration = value
            End If
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

    Public Property Status As Boolean
        Get
            Return _status
        End Get
        Set(value As Boolean)
            _status = value
        End Set
    End Property
End Class
