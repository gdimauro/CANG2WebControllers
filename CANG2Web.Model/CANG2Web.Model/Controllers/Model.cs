using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANG2Web.Model.ShoppingCart
{
  /* Generated from GenMyModel */

  public class Account
  {
    public string billingAddress;
    public DateTime open;
    public DateTime closed;
    public bool isClosed;
  }

  public class Activity
  {
  }

  public class Dean
  {
    public string address;
    public string phone;
    public string email;
  }

  public class Customer
  {
    public string address;
    public string phone;
    public string email;
  }

  public class LineItem
  {
    public int quantity;
    public double price;
  }

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

  public class Payment
  {
    public DateTime paidDate;
    public double total;
    public string details;

  }

  public class ProductBrowse
  {
    public string id;
    public string name;
    public string description;
  }

  public class Product
  {
    public string name;
    public string description;
  }

  public class ShoppingCart
  {
    public DateTime creationDate;

  }

  public enum UserState
  {
    New = 0x01,
    Active = 0x02,
    Banned = 0x04
  }

  public class WebUser
  {
    protected string login;
    private string password;
    public UserState state;
  }
}
