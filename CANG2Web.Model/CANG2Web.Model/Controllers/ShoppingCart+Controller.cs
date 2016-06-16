using NG2Sample.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NG2Sample.Commerce.ShoppingCart.Controllers
{
  public partial class ShoppingCartController
  {
    //[Route("GetProducts")]
    // don't implement here your virtual methods. Create your own partial class instead.
    public override IEnumerable<ProductBrowse> GetProducts()
    {
      throw new NotImplementedException();
    }

    //public override IEnumerable<ProductBrowseBlueNext> GetProdottiForBlueNext()
    //{
    //  throw new NotImplementedException();
    //}

    public override IEnumerable<ProductBrowse> GetOrderProducts()
    {
      throw new NotImplementedException();
    }

    public override IEnumerable<ProductBrowse> GetProductsByName()
    {
      throw new NotImplementedException();
    }

    public override IEnumerable<ProductBrowse> GetProductsByVendorExtended()
    {
      throw new NotImplementedException();
    }

    public override IEnumerable<ProductBrowse> GetProductsByBestSell()
    {
      throw new NotImplementedException();
    }

    public override IEnumerable<ProductBrowse> GetProdotti()
    {
      throw new NotImplementedException();
    }

    public override IEnumerable<ProductBrowse> GetPipperi()
    {
      throw new NotImplementedException();
    }
  }
}
