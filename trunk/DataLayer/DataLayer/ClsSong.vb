Public Class ClsSong
    Private _ID As Integer
    Private _Title As String
    Private _Album As String
    Private _Production As New ClsProduction
    Private _Category As New ClsCategory
    Private _Lanauge As New ClsLanguage
    Private _path As String
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

    Public Property Category As ClsCategory

        Get
            Return _Category
        End Get
        Set(value As ClsCategory)
            _Category = value
        End Set
    End Property

    Public Property Production As ClsProduction
        Get
            Return _Production
        End Get
        Set(value As ClsProduction)
            _Production = value
        End Set
    End Property

    Public Property Language As ClsLanguage
        Get
            Return _Lanauge
        End Get
        Set(value As ClsLanguage)
            _Lanauge = value
        End Set
    End Property

    Public Property Path As String
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
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
