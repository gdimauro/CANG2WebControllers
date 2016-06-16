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


  /**  */
  public abstract partial class ConstructionCosts
  {
    // #region FIELD DECLARATIONS ConstructionCosts
    private System.String _buildingType;
    private System.String _inhabitants;
    private int _le95House;
    private System.Double _le95Area;
    private int _gt95le110House;
    private System.Double _gt95le110Area;
    private int _gt110le130House;
    private System.Double _gt110le130Area;
    private int _gt130le160House;
    private System.Double _gt130le160Area;
    private int _gt160House;
    private System.Double _gt160Area;
    private System.Double _basementArea;
    private System.Double _garageArea;
    private System.Double _lobbyArea;
    private System.Double _balconyArea;
    private System.Double _features;
    private System.Double _netArea;
    private System.Double _accessoriesArea;
    private System.Double _costPerMq;
    private System.Double _paid;
    // #endregion FIELD DECLARATIONS


    public ConstructionCosts()
    { }

    // #region PROPERTIES ConstructionCosts
    /**
    * 
    */
    public System.String BuildingType
    {
      get
      {
        return this._buildingType;
      }
      set
      {
        this._buildingType = value;
      }
    }

    /**
    * 
    */
    public System.String Inhabitants
    {
      get
      {
        return this._inhabitants;
      }
      set
      {
        this._inhabitants = value;
      }
    }

    /**
    * 
    */
    public int Le95House
    {
      get
      {
        return this._le95House;
      }
      set
      {
        this._le95House = value;
      }
    }

    /**
    * 
    */
    public System.Double Le95Area
    {
      get
      {
        return this._le95Area;
      }
      set
      {
        this._le95Area = value;
      }
    }

    /**
    * 
    */
    public int Gt95le110House
    {
      get
      {
        return this._gt95le110House;
      }
      set
      {
        this._gt95le110House = value;
      }
    }

    /**
    * 
    */
    public System.Double Gt95le110Area
    {
      get
      {
        return this._gt95le110Area;
      }
      set
      {
        this._gt95le110Area = value;
      }
    }

    /**
    * 
    */
    public int Gt110le130House
    {
      get
      {
        return this._gt110le130House;
      }
      set
      {
        this._gt110le130House = value;
      }
    }

    /**
    * 
    */
    public System.Double Gt110le130Area
    {
      get
      {
        return this._gt110le130Area;
      }
      set
      {
        this._gt110le130Area = value;
      }
    }

    /**
    * 
    */
    public int Gt130le160House
    {
      get
      {
        return this._gt130le160House;
      }
      set
      {
        this._gt130le160House = value;
      }
    }

    /**
    * 
    */
    public System.Double Gt130le160Area
    {
      get
      {
        return this._gt130le160Area;
      }
      set
      {
        this._gt130le160Area = value;
      }
    }

    /**
    * 
    */
    public int Gt160House
    {
      get
      {
        return this._gt160House;
      }
      set
      {
        this._gt160House = value;
      }
    }

    /**
    * 
    */
    public System.Double Gt160Area
    {
      get
      {
        return this._gt160Area;
      }
      set
      {
        this._gt160Area = value;
      }
    }

    /**
    * 
    */
    public System.Double BasementArea
    {
      get
      {
        return this._basementArea;
      }
      set
      {
        this._basementArea = value;
      }
    }

    /**
    * 
    */
    public System.Double GarageArea
    {
      get
      {
        return this._garageArea;
      }
      set
      {
        this._garageArea = value;
      }
    }

    /**
    * 
    */
    public System.Double LobbyArea
    {
      get
      {
        return this._lobbyArea;
      }
      set
      {
        this._lobbyArea = value;
      }
    }

    /**
    * 
    */
    public System.Double BalconyArea
    {
      get
      {
        return this._balconyArea;
      }
      set
      {
        this._balconyArea = value;
      }
    }

    /**
    * 
    */
    public System.Double Features
    {
      get
      {
        return this._features;
      }
      set
      {
        this._features = value;
      }
    }

    /**
    * 
    */
    public System.Double NetArea
    {
      get
      {
        return this._netArea;
      }
      set
      {
        this._netArea = value;
      }
    }

    /**
    * 
    */
    public System.Double AccessoriesArea
    {
      get
      {
        return this._accessoriesArea;
      }
      set
      {
        this._accessoriesArea = value;
      }
    }

    /**
    * 
    */
    public System.Double CostPerMq
    {
      get
      {
        return this._costPerMq;
      }
      set
      {
        this._costPerMq = value;
      }
    }

    /**
    * 
    */
    public System.Double Paid
    {
      get
      {
        return this._paid;
      }
      set
      {
        this._paid = value;
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


