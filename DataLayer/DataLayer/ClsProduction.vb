Public Class ClsProduction

    Private _ID As Integer
    Private _Production As String
    Private _Photo As Byte()

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
