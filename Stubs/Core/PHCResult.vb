Imports System.Collections.Generic
Imports System.Linq

Public Class PHCResult
    Public Property messages As New List(Of MessageVO)()

    Public Function GetResult(Of T)() As T
        Return Nothing
    End Function

    Public Function HasErrors() As Boolean
        Return messages IsNot Nothing AndAlso messages.Any(Function(x) x IsNot Nothing AndAlso x.IsError())
    End Function

    Public Function GetMsgsError() As List(Of MessageVO)
        If messages Is Nothing Then Return New List(Of MessageVO)()
        Return messages.Where(Function(x) x IsNot Nothing AndAlso x.IsError()).ToList()
    End Function
End Class
