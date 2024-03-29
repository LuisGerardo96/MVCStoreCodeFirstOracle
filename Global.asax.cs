using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using MusicStore.Models;

namespace MusicStore
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //inicializamos una base de datos de prueba 
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MusicStoreEntities>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
