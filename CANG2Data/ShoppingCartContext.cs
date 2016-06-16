using CANG.Model.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANG2Data.Samples.Model
{
  [DbConfigurationType(typeof(DataConfiguration))]
  public class ShoppingCartContext : DbContext
  {
    const string DefaultDomain = "SC";

    public ShoppingCartContext()
      : base("name=ShoppingCart")
    {
      Configuration.LazyLoadingEnabled = false;
      Configuration.ProxyCreationEnabled = false;
      Configuration.EnsureTransactionsForFunctionsAndCommands = false;
      Configuration.AutoDetectChangesEnabled = true;
    }

    public DbSet<WebUser> WebUsers { get; set; }
    public DbSet<People> Peoples { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<LineItem> LineItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<Product> Products { get; set; }
  }
}