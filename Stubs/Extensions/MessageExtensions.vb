Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.CompilerServices

Public Module MessageExtensions
    <Extension>
    Public Function HasMsgErrors(messages As List(Of MessageVO)) As Boolean
        Return messages IsNot Nothing AndAlso messages.Any(Function(x) x IsNot Nothing AndAlso x.IsError())
    End Function
End Module
