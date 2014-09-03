Public Class ClsRoom

    Private _ID As Integer
    Private _RoomType As String
    Private _Price As Double

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property RoomType As String
        Get
            Return _RoomType
        End Get
        Set(value As String)
            _RoomType = value
        End Set
    End Property

    Public Property Price As Double
        Get
            Return _Price
        End Get
        Set(value As Double)
            _Price = value
        End Set
    End Property
End Class

