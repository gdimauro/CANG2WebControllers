using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace NG2Sample.Commerce.ShoppingCart
{
  public partial class ShoppingCartController
  {
    //public override IEnumerable<string> GetApprovalDean(string id, string name, string lastname)
    //{
    //  throw new NotImplementedException();
    //}
  }
}
[Route("api/commerce/shoppingcart/{action}")]
public class ShoppingCartController : ApiController
{
  public ShoppingCartController()
  {
    System.Diagnostics.Debug.WriteLine("ShoppingCartController");
  }
  #region PRODUCTS
  private string _productsData = @"{
  ""odata.metadata"": ""http://services.odata.org/V3/OData/OData.svc/$metadata#Products"",
  ""value"": [
    {
      ""ID"": 0,
      ""Name"": ""Bread"",
      ""Description"": ""Whole grain bread"",
      ""ReleaseDate"": ""1992-01-01T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 4,
      ""Price"": 2.5
    },
    {
      ""ID"": 1,
      ""Name"": ""Milk"",
      ""Description"": ""Low fat milk"",
      ""ReleaseDate"": ""1995-10-01T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 3,
      ""Price"": 3.5
    },
    {
      ""ID"": 2,
      ""Name"": ""Vint soda"",
      ""Description"": ""Americana Variety - Mix of 6 flavors"",
      ""ReleaseDate"": ""2000-10-01T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 3,
      ""Price"": 20.9
    },
    {
      ""ID"": 3,
      ""Name"": ""Havina Cola"",
      ""Description"": ""The Original Key Lime Cola"",
      ""ReleaseDate"": ""2005-10-01T00:00:00"",
      ""DiscontinuedDate"": ""2006-10-01T00:00:00"",
      ""Rating"": 3,
      ""Price"": 19.9
    },
    {
      ""ID"": 4,
      ""Name"": ""Fruit Punch"",
      ""Description"": ""Mango flavor, 8.3 Ounce Cans (Pack of 24)"",
      ""ReleaseDate"": ""2003-01-05T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 3,
      ""Price"": 22.99
    },
    {
      ""ID"": 5,
      ""Name"": ""Cranberry Juice"",
      ""Description"": ""16-Ounce Plastic Bottles (Pack of 12)"",
      ""ReleaseDate"": ""2006-08-04T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 3,
      ""Price"": 22.8
    },
    {
      ""ID"": 6,
      ""Name"": ""Pink Lemonade"",
      ""Description"": ""36 Ounce Cans (Pack of 3)"",
      ""ReleaseDate"": ""2006-11-05T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 3,
      ""Price"": 18.8
    },
    {
      ""ID"": 7,
      ""Name"": ""DVD Player"",
      ""Description"": ""1080P Upconversion DVD Player"",
      ""ReleaseDate"": ""2006-11-15T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 5,
      ""Price"": 35.88
    },
    {
      ""ID"": 8,
      ""Name"": ""LCD HDTV"",
      ""Description"": ""42 inch 1080p LCD with Built-in Blu-ray Disc Player"",
      ""ReleaseDate"": ""2008-05-08T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 3,
      ""Price"": 1088.8
    },
    {
      ""odata.type"": ""ODataDemo.FeaturedProduct"",
      ""ID"": 9,
      ""Name"": ""Lemonade"",
      ""Description"": ""Classic, refreshing lemonade (Single bottle)"",
      ""ReleaseDate"": ""1970-01-01T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 7,
      ""Price"": 1.01
    },
    {
      ""odata.type"": ""ODataDemo.FeaturedProduct"",
      ""ID"": 10,
      ""Name"": ""Coffee"",
      ""Description"": ""Bulk size can of instant coffee"",
      ""ReleaseDate"": ""1982-12-31T00:00:00"",
      ""DiscontinuedDate"": null,
      ""Rating"": 1,
      ""Price"": 6.99
    }
  ]
}";
  #endregion

//  [FromServices]
//  public IRepo<ShoppingCart> ShoppingCartRepo { get; set; }

//  [FromServices]
//  public ILogger<ShoppingCartController> Logger { get; set; }

//  [HttpGet]
//  [ActionName("ShoppingCart")]
//  public IEnumerable<ShoppingCart> Get()
//  {
//    return new ShoppingCart[] { new ShoppingCart { creationDate = System.DateTime.Now } };
//    Logger.LogInformation("GET Request received for path /api/ShoppingCart");
//    return ShoppingCartRepo.GetAll();
//  }

//  [HttpGet]
//  [ActionName("ProductBrowse")]
//  public IEnumerable<ProductBrowse> Get(string id = null, string name = null, string description = null)
//  {
//    List<ProductBrowse> products = new List<ProductBrowse>();
//    for (var i = 0; i < 1000; i++)
//      products.Add(new ProductBrowse { id = i.ToString(), name = "name " + i.ToString(), description = "description " + i.ToString() });
//    var result = products.Where(
//      i => ((String.IsNullOrEmpty(id) || i.id.Contains(id)))
//      && ((String.IsNullOrEmpty(name) || i.name.Contains(id)))
//      && ((String.IsNullOrEmpty(description) || i.description.Contains(description)))
//    ).ToArray();
//    return result;
//  }

//  [HttpGet("getorder/{number}")]
//  [HttpGet]
//  [ActionName("Order")]
//  public Order Get(int number)
//  {
//    System.Console.WriteLine("shoppingcart/getorder[Order number = {0}]", number);
//    var order = new Order
//    {
//      number = number,
//      ordered = DateTime.Now,
//      shipped = false,
//      shipTo = "London",
//      total = 100,
//      status = OrderStatus.Old
//    };
//    return order;
//  }

//  [HttpPost]
//  public IActionResult Create([FromBody] ShoppingCart ShoppingCart)
//  {
//    Logger.LogInformation("POST request received for path /api/ShoppingCart");
//    if (ShoppingCart == null)
//    {
//      return HttpBadRequest();
//    }

//    ShoppingCartRepo.Add(ShoppingCart);

//    return CreatedAtRoute("GetShoppingCart", new { controller = "ShoppingCart", id = ShoppingCart.Key }, ShoppingCart);
//  }

//  [HttpPut("{id}")]
//  public IActionResult Update(Guid id, [FromBody] ShoppingCart ShoppingCart)
//  {
//    Logger.LogInformation("PUT request received for path /api/ShoppingCart/{0}", id);
//    if (ShoppingCart == null || ShoppingCart.Key != id)
//    {
//      return HttpBadRequest();
//    }

//    var todo = ShoppingCartRepo.Find(id);
//    if (todo == null)
//    {
//      return HttpNotFound();
//    }

//    ShoppingCartRepo.Update(ShoppingCart);
//    return new NoContentResult();
//  }

//  [HttpDelete("{id}")]
//  public void Delete(Guid id)
//  {
//    Logger.LogInformation("DELETE request received for path /api/ShoppingCart/{0}", id);
//    ShoppingCartRepo.Remove(id);
//  }
//}
}
