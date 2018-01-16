using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;

namespace ProjectA.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //var db = Assembly.GetAssembly(typeof(ProjectDAL.Implement.Staging.TBL_CategoryRepository));

            //builder.RegisterAssemblyTypes(db)
            //    .Where(t => t.Name.EndsWith("Repository"))
            //    .AsImplementedInterfaces().PropertiesAutowired()
            //          .InstancePerHttpRequest();


        }
    }
}
