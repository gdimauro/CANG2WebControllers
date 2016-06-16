/*****************************************************\
* THIS FILE HAS BEEN GENERATED AUOMATICALLY           *
* don't change please                                 *
\*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NG2Sample
{
  // #region ENUMERATIONS

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
  * $$enumState$$
  */
  public enum State
  {
    Start = 1, // $enumState::Start$
    Pause = 2, // $enumState::Pause$
    Stop = 3 // $enumState::Stop$
  }

  // #endregion ENUMERATIONS

  // #region ENTITIES


  /**  */
  public abstract partial class Customer
  {
    // #region FIELD DECLARATIONS Customer
    private System.String _address;
    private System.String _phone;
    private System.String _email;
    // #endregion FIELD DECLARATIONS


    public Customer()
    { }

    // #region PROPERTIES Customer
    /**
    * 
    */
    public System.String Address
    {
      get
      {
        return this._address;
      }
      set
      {
        this._address = value;
      }
    }

    /**
    * 
    */
    public System.String Phone
    {
      get
      {
        return this._phone;
      }
      set
      {
        this._phone = value;
      }
    }

    /**
    * 
    */
    public System.String Email
    {
      get
      {
        return this._email;
      }
      set
      {
        this._email = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class Payment
  {
    // #region FIELD DECLARATIONS Payment
    private System.Date _paidDate;
    private int _total;
    private System.String _details;
    // #endregion FIELD DECLARATIONS


    public Payment()
    { }

    // #region PROPERTIES Payment
    /**
    * 
    */
    public System.Date PaidDate
    {
      get
      {
        return this._paidDate;
      }
      set
      {
        this._paidDate = value;
      }
    }

    /**
    * 
    */
    public int Total
    {
      get
      {
        return this._total;
      }
      set
      {
        this._total = value;
      }
    }

    /**
    * 
    */
    public System.String Details
    {
      get
      {
        return this._details;
      }
      set
      {
        this._details = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class ShoppingCart
  {
    // #region FIELD DECLARATIONS ShoppingCart
    private System.Date _creationDate;
    // #endregion FIELD DECLARATIONS


    public ShoppingCart()
    { }

    // #region PROPERTIES ShoppingCart
    /**
    * 
    */
    public System.Date CreationDate
    {
      get
      {
        return this._creationDate;
      }
      set
      {
        this._creationDate = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class Account
  {
    // #region FIELD DECLARATIONS Account
    private System.String _billingAddress;
    private System.Date _open;
    private System.Date _closed;
    private System.Boolean _isClosed;
    // #endregion FIELD DECLARATIONS


    public Account()
    { }

    // #region PROPERTIES Account
    /**
    * 
    */
    public System.String BillingAddress
    {
      get
      {
        return this._billingAddress;
      }
      set
      {
        this._billingAddress = value;
      }
    }

    /**
    * 
    */
    public System.Date Open
    {
      get
      {
        return this._open;
      }
      set
      {
        this._open = value;
      }
    }

    /**
    * 
    */
    public System.Date Closed
    {
      get
      {
        return this._closed;
      }
      set
      {
        this._closed = value;
      }
    }

    /**
    * 
    */
    public System.Boolean IsClosed
    {
      get
      {
        return this._isClosed;
      }
      set
      {
        this._isClosed = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class WebUser
  {
    // #region FIELD DECLARATIONS WebUser
    private System.String _login;
    private System.String _password;
    private UserState _state;
    // #endregion FIELD DECLARATIONS


    public WebUser()
    { }

    // #region PROPERTIES WebUser
    /**
    * 
    */
    public System.String Login
    {
      get
      {
        return this._login;
      }
      set
      {
        this._login = value;
      }
    }

    /**
    * 
    */
    public System.String Password
    {
      get
      {
        return this._password;
      }
      set
      {
        this._password = value;
      }
    }

    /**
    * 
    */
    public UserState State
    {
      get
      {
        return this._state;
      }
      set
      {
        this._state = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class Order
  {
    // #region FIELD DECLARATIONS Order
    private int _number;
    private System.Date _ordered;
    private System.Boolean _shipped;
    private System.String _shipTo;
    private int _total;
    private OrderStatus _status;
    // #endregion FIELD DECLARATIONS


    public Order()
    { }

    // #region PROPERTIES Order
    /**
    * 
    */
    public int Number
    {
      get
      {
        return this._number;
      }
      set
      {
        this._number = value;
      }
    }

    /**
    * 
    */
    public System.Date Ordered
    {
      get
      {
        return this._ordered;
      }
      set
      {
        this._ordered = value;
      }
    }

    /**
    * 
    */
    public System.Boolean Shipped
    {
      get
      {
        return this._shipped;
      }
      set
      {
        this._shipped = value;
      }
    }

    /**
    * 
    */
    public System.String ShipTo
    {
      get
      {
        return this._shipTo;
      }
      set
      {
        this._shipTo = value;
      }
    }

    /**
    * 
    */
    public int Total
    {
      get
      {
        return this._total;
      }
      set
      {
        this._total = value;
      }
    }

    /**
    * 
    */
    public OrderStatus Status
    {
      get
      {
        return this._status;
      }
      set
      {
        this._status = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class LineItem
  {
    // #region FIELD DECLARATIONS LineItem
    private int _quantity;
    private int _price;
    // #endregion FIELD DECLARATIONS


    public LineItem()
    { }

    // #region PROPERTIES LineItem
    /**
    * 
    */
    public int Quantity
    {
      get
      {
        return this._quantity;
      }
      set
      {
        this._quantity = value;
      }
    }

    /**
    * 
    */
    public int Price
    {
      get
      {
        return this._price;
      }
      set
      {
        this._price = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class Product
  {
    // #region FIELD DECLARATIONS Product
    private System.String _name;
    private System.String _description;
    // #endregion FIELD DECLARATIONS


    public Product()
    { }

    // #region PROPERTIES Product
    /**
    * 
    */
    public System.String Name
    {
      get
      {
        return this._name;
      }
      set
      {
        this._name = value;
      }
    }

    /**
    * 
    */
    public System.String Description
    {
      get
      {
        return this._description;
      }
      set
      {
        this._description = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class Customer
  {
    // #region FIELD DECLARATIONS Customer
    private System.String _address;
    private System.String _phone;
    private System.String _email;
    // #endregion FIELD DECLARATIONS


    public Customer()
    { }

    // #region PROPERTIES Customer
    /**
    * 
    */
    public System.String Address
    {
      get
      {
        return this._address;
      }
      set
      {
        this._address = value;
      }
    }

    /**
    * 
    */
    public System.String Phone
    {
      get
      {
        return this._phone;
      }
      set
      {
        this._phone = value;
      }
    }

    /**
    * 
    */
    public System.String Email
    {
      get
      {
        return this._email;
      }
      set
      {
        this._email = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class Payment
  {
    // #region FIELD DECLARATIONS Payment
    private System.Date _paidDate;
    private int _total;
    private System.String _details;
    // #endregion FIELD DECLARATIONS


    public Payment()
    { }

    // #region PROPERTIES Payment
    /**
    * 
    */
    public System.Date PaidDate
    {
      get
      {
        return this._paidDate;
      }
      set
      {
        this._paidDate = value;
      }
    }

    /**
    * 
    */
    public int Total
    {
      get
      {
        return this._total;
      }
      set
      {
        this._total = value;
      }
    }

    /**
    * 
    */
    public System.String Details
    {
      get
      {
        return this._details;
      }
      set
      {
        this._details = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class ShoppingCart
  {
    // #region FIELD DECLARATIONS ShoppingCart
    private System.Date _creationDate;
    // #endregion FIELD DECLARATIONS


    public ShoppingCart()
    { }

    // #region PROPERTIES ShoppingCart
    /**
    * 
    */
    public System.Date CreationDate
    {
      get
      {
        return this._creationDate;
      }
      set
      {
        this._creationDate = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class Account
  {
    // #region FIELD DECLARATIONS Account
    private System.String _billingAddress;
    private System.Date _open;
    private System.Date _closed;
    private System.Boolean _isClosed;
    // #endregion FIELD DECLARATIONS


    public Account()
    { }

    // #region PROPERTIES Account
    /**
    * 
    */
    public System.String BillingAddress
    {
      get
      {
        return this._billingAddress;
      }
      set
      {
        this._billingAddress = value;
      }
    }

    /**
    * 
    */
    public System.Date Open
    {
      get
      {
        return this._open;
      }
      set
      {
        this._open = value;
      }
    }

    /**
    * 
    */
    public System.Date Closed
    {
      get
      {
        return this._closed;
      }
      set
      {
        this._closed = value;
      }
    }

    /**
    * 
    */
    public System.Boolean IsClosed
    {
      get
      {
        return this._isClosed;
      }
      set
      {
        this._isClosed = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class WebUser
  {
    // #region FIELD DECLARATIONS WebUser
    private System.String _login;
    private System.String _password;
    private UserState _state;
    // #endregion FIELD DECLARATIONS


    public WebUser()
    { }

    // #region PROPERTIES WebUser
    /**
    * 
    */
    public System.String Login
    {
      get
      {
        return this._login;
      }
      set
      {
        this._login = value;
      }
    }

    /**
    * 
    */
    public System.String Password
    {
      get
      {
        return this._password;
      }
      set
      {
        this._password = value;
      }
    }

    /**
    * 
    */
    public UserState State
    {
      get
      {
        return this._state;
      }
      set
      {
        this._state = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class Order
  {
    // #region FIELD DECLARATIONS Order
    private int _number;
    private System.Date _ordered;
    private System.Boolean _shipped;
    private System.String _shipTo;
    private int _total;
    private OrderStatus _status;
    // #endregion FIELD DECLARATIONS


    public Order()
    { }

    // #region PROPERTIES Order
    /**
    * 
    */
    public int Number
    {
      get
      {
        return this._number;
      }
      set
      {
        this._number = value;
      }
    }

    /**
    * 
    */
    public System.Date Ordered
    {
      get
      {
        return this._ordered;
      }
      set
      {
        this._ordered = value;
      }
    }

    /**
    * 
    */
    public System.Boolean Shipped
    {
      get
      {
        return this._shipped;
      }
      set
      {
        this._shipped = value;
      }
    }

    /**
    * 
    */
    public System.String ShipTo
    {
      get
      {
        return this._shipTo;
      }
      set
      {
        this._shipTo = value;
      }
    }

    /**
    * 
    */
    public int Total
    {
      get
      {
        return this._total;
      }
      set
      {
        this._total = value;
      }
    }

    /**
    * 
    */
    public OrderStatus Status
    {
      get
      {
        return this._status;
      }
      set
      {
        this._status = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class LineItem
  {
    // #region FIELD DECLARATIONS LineItem
    private int _quantity;
    private int _price;
    // #endregion FIELD DECLARATIONS


    public LineItem()
    { }

    // #region PROPERTIES LineItem
    /**
    * 
    */
    public int Quantity
    {
      get
      {
        return this._quantity;
      }
      set
      {
        this._quantity = value;
      }
    }

    /**
    * 
    */
    public int Price
    {
      get
      {
        return this._price;
      }
      set
      {
        this._price = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**  */
  public abstract partial class Product
  {
    // #region FIELD DECLARATIONS Product
    private System.String _name;
    private System.String _description;
    // #endregion FIELD DECLARATIONS


    public Product()
    { }

    // #region PROPERTIES Product
    /**
    * 
    */
    public System.String Name
    {
      get
      {
        return this._name;
      }
      set
      {
        this._name = value;
      }
    }

    /**
    * 
    */
    public System.String Description
    {
      get
      {
        return this._description;
      }
      set
      {
        this._description = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**
  * $$baseentity$$
  */
  public abstract partial class Base
  {
    // #region FIELD DECLARATIONS Base
    private System.String _id;
    // #endregion FIELD DECLARATIONS


    public Base()
    { }

    // #region PROPERTIES Base
    /**
    * $baseentity::id$
    */
    public System.String Id
    {
      get
      {
        return this._id;
      }
      set
      {
        this._id = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**
  * $$entity::ShoppingCartWebUser$$
  */
  public abstract partial class ShoppingCartWebUser : WebUser
  {
    // #region FIELD DECLARATIONS ShoppingCartWebUser
    private System.String _id;
    private System.String _userId;
    // #endregion FIELD DECLARATIONS


    public ShoppingCartWebUser()
    { }

    // #region PROPERTIES ShoppingCartWebUser
    /**
    * $entity::ShoppingCartWebUser::Id$
    */
    public System.String Id
    {
      get
      {
        return this._id;
      }
      set
      {
        this._id = value;
      }
    }

    /**
    * $entity::ShoppingCartWebUser::UserId$
    */
    public System.String UserId
    {
      get
      {
        return this._userId;
      }
      set
      {
        this._userId = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**
  * $$entityProductBase$$
  */
  public abstract partial class ProductBrowse : Base
  {
    // #region FIELD DECLARATIONS ProductBrowse
    private System.Double _id;
    private System.String _name;
    private System.String _description;
    private System.String _imageUrl;
    // #endregion FIELD DECLARATIONS


    public ProductBrowse()
    { }

    // #region PROPERTIES ProductBrowse
    /**
    * $entityProduct::Id$
    */
    public System.Double Id
    {
      get
      {
        return this._id;
      }
      set
      {
        this._id = value;
      }
    }

    /**
    * $entityProduct::Name$
    */
    public System.String Name
    {
      get
      {
        return this._name;
      }
      set
      {
        this._name = value;
      }
    }

    /**
    * $entityProduct::Description$
    */
    public System.String Description
    {
      get
      {
        return this._description;
      }
      set
      {
        this._description = value;
      }
    }

    /**
    * $entityProduct::ImageUrl$
    */
    public System.String ImageUrl
    {
      get
      {
        return this._imageUrl;
      }
      set
      {
        this._imageUrl = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**
  * $$entityVehicle::Vehicle$$
  */
  public abstract partial class Vehicle : Base
  {
    // #region FIELD DECLARATIONS Vehicle
    private System.Double _id;
    private System.String _name;
    private System.String _type;
    // #endregion FIELD DECLARATIONS


    public Vehicle()
    { }

    // #region PROPERTIES Vehicle
    /**
    * $entityVehicle::Id$
    */
    public System.Double Id
    {
      get
      {
        return this._id;
      }
      set
      {
        this._id = value;
      }
    }

    /**
    * $entityVehicle::Name$
    */
    public System.String Name
    {
      get
      {
        return this._name;
      }
      set
      {
        this._name = value;
      }
    }

    /**
    * $entityVehicle::Type$
    */
    public System.String Type
    {
      get
      {
        return this._type;
      }
      set
      {
        this._type = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**
  * $$entityPerson$$
  */
  public abstract partial class Person : Base
  {
    // #region FIELD DECLARATIONS Person
    private System.String _name;
    private System.String _lastname;
    private Job[] _jobs;
    // #endregion FIELD DECLARATIONS


    public Person()
    { }

    // #region PROPERTIES Person
    /**
    * Name of person
    */
    public System.String Name
    {
      get
      {
        return this._name;
      }
      set
      {
        this._name = value;
      }
    }

    /**
    * Lastname of person
    */
    public System.String Lastname
    {
      get
      {
        return this._lastname;
      }
      set
      {
        this._lastname = value;
      }
    }

    /**
    * Job of person
    */
    public Job[] Jobs
    {
      get
      {
        return this._jobs;
      }
      set
      {
        this._jobs = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**
  * $$entityJob$$
  */
  public abstract partial class Job : Base
  {
    // #region FIELD DECLARATIONS Job
    private System.String _name;
    private System.String _lastname;
    // #endregion FIELD DECLARATIONS


    public Job()
    { }

    // #region PROPERTIES Job
    /**
    * Name of person
    */
    public System.String Name
    {
      get
      {
        return this._name;
      }
      set
      {
        this._name = value;
      }
    }

    /**
    * Lastname of person
    */
    public System.String Lastname
    {
      get
      {
        return this._lastname;
      }
      set
      {
        this._lastname = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**
  * aklsdjflkasdf
  */
  public abstract partial class Pippo : Job
  {
    // #region FIELD DECLARATIONS Pippo
    private System.String _id;
    // #endregion FIELD DECLARATIONS


    public Pippo()
    { }

    // #region PROPERTIES Pippo
    /**
    * sadkfjlalksdf
    */
    public System.String Id
    {
      get
      {
        return this._id;
      }
      set
      {
        this._id = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }

  // #endregion ENTITIES
}


