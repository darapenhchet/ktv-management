Public Class ClsSinger

    Private _ID As Integer
    Private _Name As String
    Private _Gender As String
    Private _Photo As String

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Gender() As String
        Get
            Return _Gender
        End Get
        Set(value As String)
            _Gender = value
        End Set
    End Property

    Public Property Photo() As String
        Get
            Return _Photo
        End Get
        Set(value As String)
            _Photo = value
        End Set
    End Property
End Class
