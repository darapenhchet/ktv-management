Public Class ClsCategory

    Private _ID As Integer
    Private _Category As String
    Private _Description As String
    Public Sub New()
        _ID = 0
        _Category = ""
        _Description = Nothing
    End Sub

    Public Sub New(ID As Integer, Language As String)
        _ID = ID
        _Category = Language
        _Description = Nothing
    End Sub

    Public Sub New(ID As Integer, Language As String, Description As String)
        _ID = ID
        _Category = Language
        _Description = Description
    End Sub

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Category As String
        Get
            Return _Category
        End Get
        Set(value As String)
            _Category = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _Description
        End Get
        Set(value As String)
            _Description = value
        End Set
    End Property
End Class
