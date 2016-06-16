using CANG2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANG.Model.ShoppingCart
{
  public class Payment : BaseEntity
  {
    public DateTime Date { get; set; }
    public List<string> Details { get; set; } = new List<string>();
    public Order Order { get; set; }
  }
}
