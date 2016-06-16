using CANG2.Model;
using System;
using System.Collections.Generic;

namespace CANG.Model.ShoppingCart
{
  public class Order : BaseEntity
  {
    public int Number { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime? ShippingDate { get; set; } = null;
    public List<string> ShipTo { get; set; }
    public double Total { get; set; }
    public OrderStatus Status { get; set; }
  }

  public enum OrderStatus
  {
    New,
    Old,
    Shipped,
    Delivered,
    Closed
  }
}