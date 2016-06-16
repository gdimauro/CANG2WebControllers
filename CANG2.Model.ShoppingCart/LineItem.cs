using CANG2.Model;

namespace CANG.Model.ShoppingCart
{
  public class LineItem : BaseEntity
  {
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Product Product { get; set; }
  }
}