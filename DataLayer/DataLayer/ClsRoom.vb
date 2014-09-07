Public Class ClsRoom

    Private _ID As Integer
    Private _RoomName As String
    Private _RoomType As String
    Private _Price As Double
    Private _Discount As Integer

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property RoomName As String
        Get
            Return _RoomName
        End Get
        Set(value As String)
            _RoomName = value
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

    Public Property Discount As Integer
        Get
            Return _Discount
        End Get
        Set(value As Integer)
            _Discount = value
        End Set
    End Property
End Class

