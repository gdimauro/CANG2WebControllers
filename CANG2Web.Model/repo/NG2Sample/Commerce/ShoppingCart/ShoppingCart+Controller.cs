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
  [Route("api/ng2sample/commerce/shoppingcart/{action}")]
  public partial class ShoppingCartController : BaseShoppingCartController
  {
    // don't implement here your virtual methods. Create your own partial class instead.
  }

  public abstract class BaseShoppingCartController : ApiController
  {
    public BaseShoppingCartController()
    {
      System.Diagnostics.Debug.WriteLine("ShoppingCartController");
    }
    
    #region operation webapi stubs
    
    [HttpGet]
    [ActionName("getProducts")]
    public abstract IEnumerable<ProductBrowse> GetProducts();

    [HttpGet]
    [ActionName("getOrder")]
    public abstract IEnumerable<ProductBrowse> GetOrder();

    [HttpGet]
    [ActionName("getProductsByName")]
    public abstract IEnumerable<ProductBrowse> GetProductsByName();

    [HttpGet]
    [ActionName("getProductsByVendor")]
    public abstract IEnumerable<ProductBrowse> GetProductsByVendor();

    [HttpGet]
    [ActionName("getProductsByBestSell")]
    public abstract IEnumerable<ProductBrowse> GetProductsByBestSell();

    [HttpGet]
    [ActionName("getProdotti")]
    public abstract IEnumerable<ProductBrowse> GetProdotti();

    #endregion
  }
}
