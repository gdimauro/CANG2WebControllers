using CANG2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANG.Model.ShoppingCart
{
  public class Account : BaseEntity
  {
    public string BillingAddress { get; set; }
    public DateTime DateOpen { get; set; }
    public DateTime DateClose { get; set; }

    public AccountState State { get; set;}
    public People Customer { get; set; }
    public List<Payment> Payments { get; set; }
    public List<Order> Order { get; set; }

    public List<LineItem> LineItems { get; set; }
    //public ShoppingCart Cart { get; set; }
  }
}
