Public NotInheritable Class SDK
    Public Shared ReadOnly Query As New SDKQuery()
    Public Shared ReadOnly Business As New SDKBusiness()
    Public Shared ReadOnly Debug As New SDKDebug()
    Public Shared ReadOnly JSON As New SDKJSON()
    Public Shared ReadOnly Dates As New SDKDates()

    Private Sub New()
    End Sub
End Class
