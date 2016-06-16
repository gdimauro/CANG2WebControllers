/*****************************************************\
* THIS FILE HAS BEEN GENERATED AUOMATICALLY           *
* don't change please                                 *
\*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NG2Sample.Commerce.ShoppingCart
{
  #region ENUMERATIONS

  /**  */
  public enum UserState
  {
    New, // 
    Active, // 
    Banned // 
  }

  /**  */
  public enum OrderStatus
  {
    New, // 
    Old, // 
    Shipped, // 
    Delivered, // 
    Closed // 
  }

  /**
  * State of procedure
  */
  public enum Status
  {
    Started = 1, // Procedure started
    Stopped, // Procedure stopped
    Finished // Procedure finished
  }

  #endregion

  #region ENTITIES


  /**  */
  
  public abstract partial class Customer
  {
    #region FIELD DECLARATIONS Customer
    
    private  System.String _address;
    
    private  System.String _phone;
    
    private  System.String _email;
    #endregion

    #region FIELD ASSOCIATIONS Customer

    // association: WebUser_Customer 
    private WebUser _webUser;  

    // association: Customer_Account 
    private Account _account;  
    #endregion


    public Customer() { }

    #region PROPERTIES Customer
    /**
    * 
    */
    public System.String Address { 
      get { return this._address; }
      
      set { this._address = value; } 
      
    }
    /**
    * 
    */
    public System.String Phone { 
      get { return this._phone; }
      
      set { this._phone = value; } 
      
    }
    /**
    * 
    */
    public System.String Email { 
      get { return this._email; }
      
      set { this._email = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Customer
  public WebUser WebUser {
  
    // get WebUser_Customer
    get { return _webUser; }
    // set WebUser_Customer
    set { _webUser = value;
        #region FIXUPS Customer
    if(value.Customer != this)
      value.Customer = this; 
    #endregion

    }
  }
  
  public Account Account {
  
    // get Customer_Account
    get { return _account; }
    // set Customer_Account
    set { _account = value;
        #region FIXUPS Customer
    if(value.Customer != this)
      value.Customer = this; 
    #endregion

    }
  }
  

  #endregion



    #region methods
    
    [HttpGet]
    [ActionName("isVIP")]
    public abstract void IsVIP();

    [HttpGet]
    [ActionName("sendSMS")]
    public abstract void SendSMS();

    #endregion


  }


  /**  */
  
  public partial class Payment
  {
    #region FIELD DECLARATIONS Payment
    
    private  System.DateTime _paidDate;
    
    private  float _total;
    
    private  System.String _details;
    #endregion

    #region FIELD ASSOCIATIONS Payment

    // association: Account_Payment 
    private Account _acc;  

    // association: Payment_Order 
    private Order _order;  
    #endregion


    public Payment() { }

    #region PROPERTIES Payment
    /**
    * 
    */
    public System.DateTime PaidDate { 
      get { return this._paidDate; }
      
      set { this._paidDate = value; } 
      
    }
    /**
    * 
    */
    public float Total { 
      get { return this._total; }
      
      set { this._total = value; } 
      
    }
    /**
    * 
    */
    public System.String Details { 
      get { return this._details; }
      
      set { this._details = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Payment
  public Account Account {
  
    // get Account_Payment
    get { return _acc; }
    // set Account_Payment
    set { _acc = value;
        #region FIXUPS Payment    
    Boolean isContained = false;
    foreach (Payment currentPayment in value.Payment) {
      if (currentPayment == this && isContained == false) {
        isContained = true;
      }
    }
    if (!isContained)
      value.Payment.Add(this); 
    #endregion

    }
  }
  
  public Order Order {
  
    // get Payment_Order
    get { return _order; }
    // set Payment_Order
    set { _order = value;
        #region FIXUPS Payment
    #endregion

    }
  }
  

  #endregion



    #region methods
    
    #endregion


  }


  /**  */
  
  public partial class ShoppingCart
  {
    #region FIELD DECLARATIONS ShoppingCart
    
    private  System.DateTime _creationDate;
    #endregion

    #region FIELD ASSOCIATIONS ShoppingCart

    // association: WebUser_ShoppingCart 
    private WebUser _webUser;  

    // association: Account_ShoppingCart 
    private Account _account;  

    // association: ShoppingCart_LineItem 
    private LineItem _items;  
    #endregion


    public ShoppingCart() { }

    #region PROPERTIES ShoppingCart
    /**
    * 
    */
    public System.DateTime CreationDate { 
      get { return this._creationDate; }
      
      set { this._creationDate = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES ShoppingCart
  public WebUser WebUser {
  
    // get WebUser_ShoppingCart
    get { return _webUser; }
    // set WebUser_ShoppingCart
    set { _webUser = value;
        #region FIXUPS ShoppingCart
    if(value.ShoppingCart != this)
      value.ShoppingCart = this; 
    #endregion

    }
  }
  
  public Account Account {
  
    // get Account_ShoppingCart
    get { return _account; }
    // set Account_ShoppingCart
    set { _account = value;
        #region FIXUPS ShoppingCart
    if(value.ShoppingCart != this)
      value.ShoppingCart = this; 
    #endregion

    }
  }
  
  public LineItem LineItem {
  
    // get ShoppingCart_LineItem
    get { return _items; }
    // set ShoppingCart_LineItem
    set { _items = value;
        #region FIXUPS ShoppingCart
    if(value.ShoppingCart != this)
      value.ShoppingCart = this; 
    #endregion

    }
  }
  

  #endregion



    #region methods
    
    #endregion


  }


  /**  */
  
  public partial class Account
  {
    #region FIELD DECLARATIONS Account
    
    private  System.String _billingAddress;
    
    private  System.DateTime _open;
    
    private  System.DateTime _closed;
    
    private  System.Boolean _isClosed;
    #endregion

    #region FIELD ASSOCIATIONS Account

    // association: Account_Payment 
    private List<Payment> _p; 
    
    // Add Account_Payment
    public Account AddPayment(Payment p) {
    _p.Add(p);
    return this;
  }
  
    // Remove Account_Payment
    public Account RemovePayment(Payment p) {
    _p.Remove(p);
    return this;
  }  

    // association: Customer_Account 
    private Customer _customer;  

    // association: Account_ShoppingCart 
    private ShoppingCart _cart;  

    // association: Account_Order 
    private List<Order> _order; 
    
    // Add Account_Order
    public Account AddOrder(Order order) {
    _order.Add(order);
    return this;
  }
  
    // Remove Account_Order
    public Account RemoveOrder(Order order) {
    _order.Remove(order);
    return this;
  }  
    #endregion


    public Account() { }

    #region PROPERTIES Account
    /**
    * 
    */
    public System.String BillingAddress { 
      get { return this._billingAddress; }
      
      set { this._billingAddress = value; } 
      
    }
    /**
    * 
    */
    public System.DateTime Open { 
      get { return this._open; }
      
      set { this._open = value; } 
      
    }
    /**
    * 
    */
    public System.DateTime Closed { 
      get { return this._closed; }
      
      set { this._closed = value; } 
      
    }
    /**
    * 
    */
    public System.Boolean IsClosed { 
      get { return this._isClosed; }
      
      set { this._isClosed = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Account
  
  public List<Payment> Payment {
    // get Account_Payment
    get { return _p; }
    // set Account_Payment
    set { _p = value;
        #region FIXUPS Account
    foreach (Payment currentPayment in value) {
      if ( currentPayment.Account != this)
         currentPayment.Account = this;
    } 
    #endregion

    }
  }
  
  public Customer Customer {
  
    // get Customer_Account
    get { return _customer; }
    // set Customer_Account
    set { _customer = value;
        #region FIXUPS Account
    if(value.Account != this)
      value.Account = this; 
    #endregion

    }
  }
  
  public ShoppingCart ShoppingCart {
  
    // get Account_ShoppingCart
    get { return _cart; }
    // set Account_ShoppingCart
    set { _cart = value;
        #region FIXUPS Account
    if(value.Account != this)
      value.Account = this; 
    #endregion

    }
  }
  
  
  public List<Order> Order {
    // get Account_Order
    get { return _order; }
    // set Account_Order
    set { _order = value;
        #region FIXUPS Account
    foreach (Order currentOrder in value) {
      if ( currentOrder.Account != this)
         currentOrder.Account = this;
    } 
    #endregion

    }
  }
  

  #endregion



    #region methods
    
    #endregion


  }


  /**  */
  
  public partial class WebUser
  {
    #region FIELD DECLARATIONS WebUser
    
    private  System.String _login;
    
    private  System.String _password;
    
    private  UserState _state;
    private  List<System.String> _attributeArray;
    
    private static int __staticAttribute;
    
    private  System.Boolean _readOnlyAttribute;
    #endregion

    #region FIELD ASSOCIATIONS WebUser

    // association: WebUser_ShoppingCart 
    private ShoppingCart _shoppingCart;  

    // association: WebUser_Customer 
    private Customer _customer;  
    #endregion


    public WebUser() { }

    #region PROPERTIES WebUser
    /**
    * 
    */
    protected System.String Login { 
      get { return this._login; }
      
      set { this._login = value; } 
      
    }
    /**
    * 
    */
    private System.String Password { 
      get { return this._password; }
      
      set { this._password = value; } 
      
    }
    /**
    * 
    */
    public UserState State { 
      get { return this._state; }
      
      set { this._state = value; } 
      
    }
    /**
    * 
    */
    public List<System.String> AttributeArray { 
      get { return this._attributeArray; }
      
      set { this._attributeArray = value; } 
      
    }
    /**
    * 
    */
    public System.Boolean ReadOnlyAttribute { 
      get { return this._readOnlyAttribute; }
      
      
    }
    #endregion

  #region NAVIGATION PROPERTIES WebUser
  public ShoppingCart ShoppingCart {
  
    // get WebUser_ShoppingCart
    get { return _shoppingCart; }
    // set WebUser_ShoppingCart
    set { _shoppingCart = value;
        #region FIXUPS WebUser
    if(value.WebUser != this)
      value.WebUser = this; 
    #endregion

    }
  }
  
  public Customer Customer {
  
    // get WebUser_Customer
    get { return _customer; }
    // set WebUser_Customer
    set { _customer = value;
        #region FIXUPS WebUser
    if(value.WebUser != this)
      value.WebUser = this; 
    #endregion

    }
  }
  

  #endregion



    #region methods
    
    #endregion


  }


  /**  */
  
  public partial class Order
  {
    #region FIELD DECLARATIONS Order
    
    private  int _number;
    
    private  System.DateTime _ordered;
    
    private  System.Boolean _shipped;
    
    private  System.String _shipTo;
    
    private  float _total;
    
    private  OrderStatus _status;
    #endregion

    #region FIELD ASSOCIATIONS Order

    // association: Order_LineItem 
    private List<LineItem> _items; 
    
    // Add Order_LineItem
    public Order AddLineItem(LineItem items) {
    _items.Add(items);
    return this;
  }
  
    // Remove Order_LineItem
    public Order RemoveLineItem(LineItem items) {
    _items.Remove(items);
    return this;
  }  

    // association: Account_Order 
    private Account _account;  
    #endregion


    public Order() { }

    #region PROPERTIES Order
    /**
    * 
    */
    public int Number { 
      get { return this._number; }
      
      set { this._number = value; } 
      
    }
    /**
    * 
    */
    public System.DateTime Ordered { 
      get { return this._ordered; }
      
      set { this._ordered = value; } 
      
    }
    /**
    * 
    */
    public System.Boolean Shipped { 
      get { return this._shipped; }
      
      set { this._shipped = value; } 
      
    }
    /**
    * 
    */
    public System.String ShipTo { 
      get { return this._shipTo; }
      
      set { this._shipTo = value; } 
      
    }
    /**
    * 
    */
    public float Total { 
      get { return this._total; }
      
      set { this._total = value; } 
      
    }
    /**
    * 
    */
    public OrderStatus Status { 
      get { return this._status; }
      
      set { this._status = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Order
  
  public List<LineItem> LineItem {
    // get Order_LineItem
    get { return _items; }
    // set Order_LineItem
    set { _items = value;
        #region FIXUPS Order
    #endregion

    }
  }
  
  public Account Account {
  
    // get Account_Order
    get { return _account; }
    // set Account_Order
    set { _account = value;
        #region FIXUPS Order    
    Boolean isContained = false;
    foreach (Order currentOrder in value.Order) {
      if (currentOrder == this && isContained == false) {
        isContained = true;
      }
    }
    if (!isContained)
      value.Order.Add(this); 
    #endregion

    }
  }
  

  #endregion



    #region methods
    
    #endregion


  }


  /**  */
  
  public partial class LineItem
  {
    #region FIELD DECLARATIONS LineItem
    
    private  int _quantity;
    
    private  float _price;
    #endregion

    #region FIELD ASSOCIATIONS LineItem

    // association: ShoppingCart_LineItem 
    private ShoppingCart _sc;  

    // association: Product_LineItem 
    private Product _product;  
    #endregion


    public LineItem() { }

    #region PROPERTIES LineItem
    /**
    * 
    */
    public int Quantity { 
      get { return this._quantity; }
      
      set { this._quantity = value; } 
      
    }
    /**
    * 
    */
    public float Price { 
      get { return this._price; }
      
      set { this._price = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES LineItem
  public ShoppingCart ShoppingCart {
  
    // get ShoppingCart_LineItem
    get { return _sc; }
    // set ShoppingCart_LineItem
    set { _sc = value;
        #region FIXUPS LineItem
    if(value.LineItem != this)
      value.LineItem = this; 
    #endregion

    }
  }
  
  public Product Product {
  
    // get Product_LineItem
    get { return _product; }
    // set Product_LineItem
    set { _product = value;
        #region FIXUPS LineItem    
    Boolean isContained = false;
    foreach (LineItem currentLineItem in value.LineItem) {
      if (currentLineItem == this && isContained == false) {
        isContained = true;
      }
    }
    if (!isContained)
      value.LineItem.Add(this); 
    #endregion

    }
  }
  

  #endregion



    #region methods
    
    #endregion


  }


  /**  */
  
  public partial class Product
  {
    #region FIELD DECLARATIONS Product
    
    private  System.String _name;
    
    private  System.String _description;
    #endregion

    #region FIELD ASSOCIATIONS Product

    // association: Product_LineItem 
    private List<LineItem> _lineItems; 
    
    // Add Product_LineItem
    public Product AddLineItem(LineItem lineItems) {
    _lineItems.Add(lineItems);
    return this;
  }
  
    // Remove Product_LineItem
    public Product RemoveLineItem(LineItem lineItems) {
    _lineItems.Remove(lineItems);
    return this;
  }  
    #endregion


    public Product() { }

    #region PROPERTIES Product
    /**
    * 
    */
    public System.String Name { 
      get { return this._name; }
      
      set { this._name = value; } 
      
    }
    /**
    * 
    */
    public System.String Description { 
      get { return this._description; }
      
      set { this._description = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Product
  
  public List<LineItem> LineItem {
    // get Product_LineItem
    get { return _lineItems; }
    // set Product_LineItem
    set { _lineItems = value;
        #region FIXUPS Product
    foreach (LineItem currentLineItem in value) {
      if ( currentLineItem.Product != this)
         currentLineItem.Product = this;
    } 
    #endregion

    }
  }
  

  #endregion



    #region methods
    
    #endregion


  }


  /**  */
  
  public abstract partial class AbstractClass
  {
    #region FIELD DECLARATIONS AbstractClass
    #endregion

    #region FIELD ASSOCIATIONS AbstractClass
    #endregion


    public AbstractClass() { }

    #region PROPERTIES AbstractClass
    #endregion

  #region NAVIGATION PROPERTIES AbstractClass

  #endregion



    #region methods
    
    #endregion


  }


  /**  */
  // @isSealed
  public partial class LeafClass
  {
    #region FIELD DECLARATIONS LeafClass
    #endregion

    #region FIELD ASSOCIATIONS LeafClass
    #endregion


    public LeafClass() { }

    #region PROPERTIES LeafClass
    #endregion

  #region NAVIGATION PROPERTIES LeafClass

  #endregion



    #region methods
    
    #endregion


  }


  /**
  * $$entity::ShoppingCartWebUser$$
  */
  
  public partial class ShoppingCartWebUser : WebUser
  {
    #region FIELD DECLARATIONS ShoppingCartWebUser
    
    private  System.String _id;
    
    private  System.String _userId;
    
    private  Status _status;
    #endregion

    #region FIELD ASSOCIATIONS ShoppingCartWebUser
    #endregion


    public ShoppingCartWebUser() { }

    #region PROPERTIES ShoppingCartWebUser
    /**
    * $entity::ShoppingCartWebUser::Id$
    */
    public System.String Id { 
      get { return this._id; }
      
      set { this._id = value; } 
      
    }
    /**
    * $entity::ShoppingCartWebUser::UserId$
    */
    public System.String UserId { 
      get { return this._userId; }
      
      set { this._userId = value; } 
      
    }
    /**
    * The status of the shoppingcart web user entity
    */
    public Status Status { 
      get { return this._status; }
      
      set { this._status = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES ShoppingCartWebUser

  #endregion



    #region methods
    
    #endregion


  }

  #endregion
}

