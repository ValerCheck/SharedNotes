using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using SharedNotes.Domain.Concrete;
using SharedNotes.Infrastructure;

namespace SharedNotes
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //DependencyResolver.SetResolver(new NinjectControllerFactory());
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
        }
    }
}
