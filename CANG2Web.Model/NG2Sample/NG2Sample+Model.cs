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

  // #endregion ENUMERATIONS

  // #region ENTITIES


  /**
  * common base entity
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
    * the identifier
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
  * $$entityPolicy$$
  */
  public abstract partial class Policy
  {
    // #region FIELD DECLARATIONS Policy
    private System.String _id;
    private System.String _userId;
    private Claim[] _claims;
    // #endregion FIELD DECLARATIONS


    public Policy()
    { }

    // #region PROPERTIES Policy
    /**
    * Key
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
    * User identifier
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

    /**
    * Claims of user
    */
    public Claim[] Claims
    {
      get
      {
        return this._claims;
      }
      set
      {
        this._claims = value;
      }
    }
    // #endregion PROPERTIES

    // #region NAVIGATION PROPERTIES
    // #endregion NAVIGATION PROPERTIES

    // #region FIXUPS
    // #endregion FIXUPS

  }


  /**
  * a security claim
  */
  public abstract partial class Claim
  {
    // #region FIELD DECLARATIONS Claim
    private System.String _id;
    private System.String _key;
    private System.String[] _value;
    // #endregion FIELD DECLARATIONS


    public Claim()
    { }

    // #region PROPERTIES Claim
    /**
    * Key
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
    * claim key
    */
    public System.String Key
    {
      get
      {
        return this._key;
      }
      set
      {
        this._key = value;
      }
    }

    /**
    * Claim value
    */
    public System.String[] Value
    {
      get
      {
        return this._value;
      }
      set
      {
        this._value = value;
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


