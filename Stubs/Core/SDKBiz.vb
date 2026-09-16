Imports System.Collections.Generic

Public Class SDKBiz
    Public ReadOnly Property EntityName As String

    Public Sub New()
    End Sub

    Public Sub New(entityName As String)
        Me.EntityName = entityName
    End Sub

    Public Function GetNewInstance() As PHCResult
        Return New PHCResult()
    End Function

    Public Function GetNewInstance(id As Integer) As PHCResult
        Return New PHCResult()
    End Function

    Public Function Save(Of T)(entity As T) As List(Of MessageVO)
        Return New List(Of MessageVO)()
    End Function

    Public Function ActEntity(Of T)(entity As T) As List(Of MessageVO)
        Return New List(Of MessageVO)()
    End Function
End Class
