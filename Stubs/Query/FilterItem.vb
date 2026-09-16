Public Class FilterItem
    Public Property Field As String
    Public Property Comparison As Comparison
    Public Property Value As Object

    Public Sub New(field As String, comparison As Comparison, value As Object)
        Me.Field = field
        Me.Comparison = comparison
        Me.Value = value
    End Sub
End Class
