Public Class ClsLanguage

    Private _ID As Integer
    Private _Language As String
    Private _Photo As Byte()

    Public Sub New()
        _ID = 0
        _Language = ""
        _Photo = Nothing
    End Sub

    Public Sub New(ID As Integer, Language As String)
        _ID = ID
        _Language = Language
        _Photo = Nothing
    End Sub

    Public Sub New(ID As Integer, Language As String, Photo As Byte())
        _ID = ID
        _Language = Language
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

    Public Property Language As String
        Get
            Return _Language
        End Get
        Set(value As String)
            _Language = value
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
