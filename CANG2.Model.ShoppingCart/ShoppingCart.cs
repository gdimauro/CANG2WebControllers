using CANG2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANG.Model.ShoppingCart
{
  public class ShoppingCart : BaseEntity
  {
    public Account Account { get; set; }
    public DateTime Created { get; set; }
  }
}
