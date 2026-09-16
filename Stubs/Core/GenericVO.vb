Public NotInheritable Class GenericVO
    Private Sub New()
    End Sub

    Public Shared Function GetNewInstance(Of T As New)() As T
        Return New T()
    End Function
End Class
