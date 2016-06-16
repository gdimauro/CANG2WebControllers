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
    [ActionName("getPipperi")]
    public abstract IEnumerable<ProductBrowse> GetPipperi();

    [HttpGet]
    [ActionName("getOrderProducts")]
    public abstract IEnumerable<ProductBrowse> GetOrderProducts();

    [HttpGet]
    [ActionName("getProductsByName")]
    public abstract IEnumerable<ProductBrowse> GetProductsByName();

    [HttpGet]
    [ActionName("getProductsByVendorExtended")]
    public abstract IEnumerable<ProductBrowse> GetProductsByVendorExtended();

    [HttpGet]
    [ActionName("getProductsByBestSell")]
    public abstract IEnumerable<ProductBrowse> GetProductsByBestSell();

    [HttpGet]
    [ActionName("getProdotti")]
    public abstract IEnumerable<ProductBrowse> GetProdotti();

    #endregion
  }
}
