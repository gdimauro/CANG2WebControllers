/*****************************************************\
* THIS FILE HAS BEEN GENERATED AUOMATICALLY           *
* don't change please                                 *
\*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NG2Sample.Commerce.Controllers
{
  [Route("api/ng2sample.commerce/{action}")]
  public partial class CommerceController : BaseCommerceController
  {
    // don't implement here your virtual methods. Create your own partial class instead.
  }

  public class BaseCommerceController : ApiController
  {
    public BaseCommerceController()
    {
      System.Diagnostics.Debug.WriteLine("CommerceController");
    }
    
    //#region operation webapi stubs
    
    [HttpGet]
    [ActionName("isVIP")]
    public abstract  IsVIP();

    [HttpGet]
    [ActionName("isVIP")]
    public abstract  IsVIP();

    //#endregion operation webapi stubs
  }
}
