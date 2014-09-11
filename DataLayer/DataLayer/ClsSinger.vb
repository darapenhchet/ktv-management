Public Class ClsSinger

    Private _ID As Integer
    Private _Name As String
    Private _Gender As String
    Private _Nationality As String
    Private _Photo As Byte()

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

    Public Property Nationality As String
        Get
            Return _Nationality
        End Get
        Set(value As String)
            _Nationality = value
        End Set
    End Property

    Public Property Photo() As Byte()
        Get
            Return _Photo
        End Get
        Set(value As Byte())
            _Photo = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
