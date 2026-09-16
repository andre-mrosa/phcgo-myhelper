Imports System.Collections.Generic

Public Class SDKQuery
    Public Function GetEntityData(Of T)(filter As FilterItem) As List(Of T)
        Return New List(Of T)()
    End Function

    Public Function GetEntityData(Of T)(filters As List(Of FilterItem)) As List(Of T)
        Return New List(Of T)()
    End Function

    Public Function GetEntityData(sql As String) As System.Collections.IList
        Return New System.Collections.ArrayList()
    End Function

    Public Function GetEntityByStamp(Of T)(stamp As String) As T
        Return Nothing
    End Function
End Class
