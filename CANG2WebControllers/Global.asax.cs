using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CANG2WebControllers
{
  public class WebApiApplication : System.Web.HttpApplication
  {
    static object[] Controllers = new object[] {
      //typeof(NG2Sample.Commerce.Controllers.CommerceController),
      //typeof(NG2Sample..ShoppingCartController),
      //typeof(NG2Sample.Samples.Controllers.SamplesController),
      //typeof(NG2Sample.Samples.ConstructionCosts.Controllers.ConstructionCostsController),
    };

    protected void Application_Start()
    {
      System.Diagnostics.Debug.WriteLine(Controllers.Length.ToString());
      AreaRegistration.RegisterAllAreas();
      GlobalConfiguration.Configure(WebApiConfig.Register);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }
  }
}
