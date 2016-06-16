/*****************************************************\
* THIS FILE HAS BEEN GENERATED AUOMATICALLY           *
* don't change please                                 *
\*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NG2Sample.Commerce.ShoppingCart.Controllers
{
  [Route("api/ng2sample.commerce.shoppingcart/{action}")]
  public partial class ShoppingCartController : BaseShoppingCartController
  {
    // don't implement here your virtual methods. Create your own partial class instead.
  }

  public class BaseShoppingCartController : ApiController
  {
    public BaseShoppingCartController()
    {
      System.Diagnostics.Debug.WriteLine("ShoppingCartController");
    }
    
    //#region operation webapi stubs
    
    [HttpGet]
    [ActionName("getApprovalDean")]
    public abstract IEnumerable<DEAN> GetApprovalDean();

    [HttpGet]
    [ActionName("isVIP")]
    public abstract  IsVIP();

    //#endregion operation webapi stubs
  }
}
