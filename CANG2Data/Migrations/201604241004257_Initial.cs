namespace CANG2Data.Samples.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BillingAddress = c.String(),
                        DateOpen = c.DateTime(nullable: false),
                        DateClose = c.DateTime(nullable: false),
                        State = c.Int(nullable: false),
                        Customer_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LineItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Product_Id = c.Guid(),
                        Account_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Number = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        ShippingDate = c.DateTime(),
                        Total = c.Double(nullable: false),
                        Status = c.Int(nullable: false),
                        Account_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Order_Id = c.Guid(),
                        Account_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Account_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.WebUsers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        UserState = c.Int(nullable: false),
                        ShoppingCart_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCart_Id)
                .Index(t => t.ShoppingCart_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WebUsers", "ShoppingCart_Id", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCarts", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Payments", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Payments", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.LineItems", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.LineItems", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Accounts", "Customer_Id", "dbo.People");
            DropIndex("dbo.WebUsers", new[] { "ShoppingCart_Id" });
            DropIndex("dbo.ShoppingCarts", new[] { "Account_Id" });
            DropIndex("dbo.Payments", new[] { "Account_Id" });
            DropIndex("dbo.Payments", new[] { "Order_Id" });
            DropIndex("dbo.Orders", new[] { "Account_Id" });
            DropIndex("dbo.LineItems", new[] { "Account_Id" });
            DropIndex("dbo.LineItems", new[] { "Product_Id" });
            DropIndex("dbo.Accounts", new[] { "Customer_Id" });
            DropTable("dbo.WebUsers");
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.Payments");
            DropTable("dbo.Orders");
            DropTable("dbo.Products");
            DropTable("dbo.LineItems");
            DropTable("dbo.People");
            DropTable("dbo.Accounts");
        }
    }
}
