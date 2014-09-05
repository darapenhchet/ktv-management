Public Class ClsSongDetails

    Private _SongID As Integer
    Private _SingerID As Integer

    Public Property SongID As Integer
        Get
            Return _SongID
        End Get
        Set(value As Integer)
            _SongID = value
        End Set
    End Property

    Public Property SingerID As Integer
        Get
            Return _SingerID
        End Get
        Set(value As Integer)
            _SingerID = value
        End Set
    End Property
End Class
