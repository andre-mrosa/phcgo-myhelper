Public Class SDKBusiness
    Public Function CreateBiz(entityName As String) As SDKBiz
        Return New SDKBiz(entityName)
    End Function
End Class
