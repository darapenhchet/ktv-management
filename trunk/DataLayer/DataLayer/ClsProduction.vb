Public Class ClsProduction

    Private _ID As Integer
    Private _Production As String
    Private _Photo As Byte()

    Public Sub New()
        _ID = 0
        _Production = ""
        _Photo = Nothing
    End Sub

    Public Sub New(ID As Integer, Production As String)
        _ID = ID
        _Production = Production
        _Photo = Nothing
    End Sub

    Public Sub New(ID As Integer, Production As String, Photo As Byte())
        _ID = ID
        _Production = Production
        _Photo = Photo
    End Sub

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Production As String
        Get
            Return _Production
        End Get
        Set(value As String)
            _Production = value
        End Set
    End Property

    Public Property Photo As Byte()
        Get
            Return _Photo
        End Get
        Set(value As Byte())
            _Photo = value
        End Set
    End Property
End Class
