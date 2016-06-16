using CANG2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANG.Model.ShoppingCart
{
  public class WebUser : BaseEntity
  {
    public string Login { get; set; }
    public string Password { get; set; }
    public State UserState { get; set; }
    public ShoppingCart ShoppingCart { get; set; }
  }
}
