Public Class ClsSong

    Private _ID As Integer
    Private _Title As String
    Private _Album As String
    Private _Production As String
    Private _Category As String
    Private _Lanauge As String
    Private _Singers As New List(Of ClsSinger)

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property

    Public Property Album As String
        Get
            Return _Album
        End Get
        Set(value As String)
            _Album = value
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

    Public Property Language As String
        Get
            Return _Lanauge
        End Get
        Set(value As String)
            _Lanauge = value
        End Set
    End Property

    Public Property Singers As List(Of ClsSinger)
        Get
            Return _Singers
        End Get
        Set(value As List(Of ClsSinger))
            _Singers = value
        End Set
    End Property
End Class
