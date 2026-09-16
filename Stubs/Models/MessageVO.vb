Public Class MessageVO
    Public Property message As String
    Public Property messageCode As String
    Public Property code As String
    Public Property type As Integer
    Public Property messageType As Integer

    Public Function IsError() As Boolean
        ' Stub local: o runtime PHC é a fonte de verdade.
        ' Nos payloads observados, messageType = 1 representa erro.
        Return messageType = 1 OrElse type = 1
    End Function
End Class
