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
  #region ENUMERATIONS

  #endregion

  #region ENTITIES


  /**
  * common base entity
  */
  
  public abstract partial class Base
  {
    #region FIELD DECLARATIONS Base
    
    private  System.String _id;
    #endregion

    #region FIELD ASSOCIATIONS Base
    #endregion


    public Base() { }

    #region PROPERTIES Base
    /**
    * the identifier
    */
    public System.String Id { 
      get { return this._id; }
      
      set { this._id = value; } 
      
    }    #endregion

  #region NAVIGATION PROPERTIES Base

  // #endregion



    #region methods
    
    #endregion


  }


  /**
  * $$entityPolicy$$
  */
  
  public abstract partial class Policy
  {
    #region FIELD DECLARATIONS Policy
    
    private  System.String _id;
    
    private  System.String _userId;
    private  List<Claim> _claims;
    #endregion

    #region FIELD ASSOCIATIONS Policy
    #endregion


    public Policy() { }

    #region PROPERTIES Policy
    /**
    * Key
    */
    public System.String Id { 
      get { return this._id; }
      
      set { this._id = value; } 
      
    }
    /**
    * User identifier
    */
    public System.String UserId { 
      get { return this._userId; }
      
      set { this._userId = value; } 
      
    }
    /**
    * Claims of user
    */
    public List<Claim> Claims { 
      get { return this._claims; }
      
      set { this._claims = value; } 
      
    }    #endregion

  #region NAVIGATION PROPERTIES Policy

  // #endregion



    #region methods
    
    #endregion


  }


  /**
  * a security claim
  */
  
  public abstract partial class Claim
  {
    #region FIELD DECLARATIONS Claim
    
    private  System.String _id;
    
    private  System.String _key;
    
    private  System.String _value;
    #endregion

    #region FIELD ASSOCIATIONS Claim
    #endregion


    public Claim() { }

    #region PROPERTIES Claim
    /**
    * Key
    */
    public System.String Id { 
      get { return this._id; }
      
      set { this._id = value; } 
      
    }
    /**
    * claim key
    */
    public System.String Key { 
      get { return this._key; }
      
      set { this._key = value; } 
      
    }
    /**
    * Claim value
    */
    public System.String Value { 
      get { return this._value; }
      
      set { this._value = value; } 
      
    }    #endregion

  #region NAVIGATION PROPERTIES Claim

  // #endregion



    #region methods
    
    #endregion


  }

  #endregion
}

