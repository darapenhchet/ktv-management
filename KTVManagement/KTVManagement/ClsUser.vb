Public Class ClsUser
    Private _ID As Integer
    Private _Username As String
    Private _Password As String
    Private _Position As String
    Private _Photo As String

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _Username
        End Get
        Set(value As String)
            _Username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value

        End Set
    End Property

    Public Property Position As String
        Get
            Return _Position
        End Get
        Set(value As String)
            _Position = value
        End Set
    End Property

    Public Property Photo As String
        Get
            Return _Photo
        End Get
        Set(value As String)
            _Photo = value
        End Set
    End Property

End Class
