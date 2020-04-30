Public Class Post
    Public Property Id As Integer
    Public Property userId As Integer
    Public Property title As String
    Public Property body As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal userId As Integer, ByVal title As String, ByVal body As String)
        Me.userId = userId
        Me.title = title
        Me.body = body
    End Sub
End Class
