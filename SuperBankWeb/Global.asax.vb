
Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        RouteTable.Routes.MapRoute(Nothing, "", New ControllerAction("Index"))
        RouteTable.Routes.MapRoute(Nothing, "Download", New ControllerAction("Download"))
    End Sub

    Private Class ControllerAction

        Public Property Controller As String = "Home"
        Public Property Action As String

        Public Sub New(Action As String)
            Me.Action = Action
        End Sub

    End Class

End Class
