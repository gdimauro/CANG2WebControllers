/*****************************************************\
* THIS FILE HAS BEEN GENERATED AUOMATICALLY           *
* don't change please                                 *
\*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NG2Sample.Controllers
{
  [Route("api/ng2sample/{action}")]
  public partial class NG2SampleController : BaseNG2SampleController
  {
    // don't implement here your virtual methods. Create your own partial class instead.
  }

  public abstract class BaseNG2SampleController : ApiController
  {
    public BaseNG2SampleController()
    {
      System.Diagnostics.Debug.WriteLine("NG2SampleController");
    }
    
    #region operation webapi stubs
    
    [HttpGet]
    [ActionName("getPolicies")]
    public abstract IEnumerable<Policy> GetPolicies();

    #endregion
  }
}
