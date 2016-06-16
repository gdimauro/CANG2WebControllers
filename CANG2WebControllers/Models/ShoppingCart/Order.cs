
/* Generated from GenMyModel */

using System;

namespace CAEP5MockServer.Models.ShoppingCart
{
  public enum OrderStatus
  {
    New,
    Old,
    Shipped,
    Delivered,
    Closed
  }
  
  public class Order
	{
    public Order()
    {

    }
		public int number;
		public DateTime ordered;
		public bool shipped;
		public string shipTo;
		public double total;
		public OrderStatus status;	
	}
}
