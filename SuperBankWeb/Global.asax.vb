
Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        GlobalFilters.Filters.Add(New HandleErrorAttribute())
        RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
        RouteTable.Routes.MapRoute(Nothing, "{Controller}/{Action}", New With {.Controller = "Home", .Action = "Index"})
    End Sub

End Class
