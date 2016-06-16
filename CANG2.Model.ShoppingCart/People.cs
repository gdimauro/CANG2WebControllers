using CANG2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANG.Model.ShoppingCart
{
  public class People : BaseEntity
  {
    public PeopleType Type { get; set; }
    public List<string> Emails { get; set; }
    public List<string> PhoneNumbers { get; set; }
    public List<string> Addresses { get; set; }
  }

  [Flags]
  public enum PeopleType
  {
    Customer = 0x1,
    Vendor = 0x2,
    VIP = 0x4
  }
}
