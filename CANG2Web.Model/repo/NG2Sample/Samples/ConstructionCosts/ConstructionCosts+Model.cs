/*****************************************************\
* THIS FILE HAS BEEN GENERATED AUOMATICALLY           *
* don't change please                                 *
\*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NG2Sample.Samples.ConstructionCosts
{
  #region ENUMERATIONS

  #endregion

  #region ENTITIES


  /**  */
  
  public abstract partial class ConstructionCosts
  {
    #region FIELD DECLARATIONS ConstructionCosts
    
    private  System.String _buildingType;
    
    private  System.String _inhabitants;
    
    private  int _le95House;
    
    private  System.Double _le95Area;
    
    private  int _gt95le110House;
    
    private  System.Double _gt95le110Area;
    
    private  int _gt110le130House;
    
    private  System.Double _gt110le130Area;
    
    private  int _gt130le160House;
    
    private  System.Double _gt130le160Area;
    
    private  int _gt160House;
    
    private  System.Double _gt160Area;
    
    private  System.Double _basementArea;
    
    private  System.Double _garageArea;
    
    private  System.Double _lobbyArea;
    
    private  System.Double _balconyArea;
    
    private  System.Double _features;
    
    private  System.Double _netArea;
    
    private  System.Double _accessoriesArea;
    
    private  System.Double _costPerMq;
    
    private  System.Double _paid;
    #endregion

    #region FIELD ASSOCIATIONS ConstructionCosts
    #endregion


    public ConstructionCosts() { }

    #region PROPERTIES ConstructionCosts
    /**
    * 
    */
    public System.String BuildingType { 
      get { return this._buildingType; }
      
      set { this._buildingType = value; } 
      
    }
    /**
    * 
    */
    public System.String Inhabitants { 
      get { return this._inhabitants; }
      
      set { this._inhabitants = value; } 
      
    }
    /**
    * 
    */
    public int Le95House { 
      get { return this._le95House; }
      
      set { this._le95House = value; } 
      
    }
    /**
    * 
    */
    public System.Double Le95Area { 
      get { return this._le95Area; }
      
      set { this._le95Area = value; } 
      
    }
    /**
    * 
    */
    public int Gt95le110House { 
      get { return this._gt95le110House; }
      
      set { this._gt95le110House = value; } 
      
    }
    /**
    * 
    */
    public System.Double Gt95le110Area { 
      get { return this._gt95le110Area; }
      
      set { this._gt95le110Area = value; } 
      
    }
    /**
    * 
    */
    public int Gt110le130House { 
      get { return this._gt110le130House; }
      
      set { this._gt110le130House = value; } 
      
    }
    /**
    * 
    */
    public System.Double Gt110le130Area { 
      get { return this._gt110le130Area; }
      
      set { this._gt110le130Area = value; } 
      
    }
    /**
    * 
    */
    public int Gt130le160House { 
      get { return this._gt130le160House; }
      
      set { this._gt130le160House = value; } 
      
    }
    /**
    * 
    */
    public System.Double Gt130le160Area { 
      get { return this._gt130le160Area; }
      
      set { this._gt130le160Area = value; } 
      
    }
    /**
    * 
    */
    public int Gt160House { 
      get { return this._gt160House; }
      
      set { this._gt160House = value; } 
      
    }
    /**
    * 
    */
    public System.Double Gt160Area { 
      get { return this._gt160Area; }
      
      set { this._gt160Area = value; } 
      
    }
    /**
    * 
    */
    public System.Double BasementArea { 
      get { return this._basementArea; }
      
      set { this._basementArea = value; } 
      
    }
    /**
    * 
    */
    public System.Double GarageArea { 
      get { return this._garageArea; }
      
      set { this._garageArea = value; } 
      
    }
    /**
    * 
    */
    public System.Double LobbyArea { 
      get { return this._lobbyArea; }
      
      set { this._lobbyArea = value; } 
      
    }
    /**
    * 
    */
    public System.Double BalconyArea { 
      get { return this._balconyArea; }
      
      set { this._balconyArea = value; } 
      
    }
    /**
    * 
    */
    public System.Double Features { 
      get { return this._features; }
      
      set { this._features = value; } 
      
    }
    /**
    * 
    */
    public System.Double NetArea { 
      get { return this._netArea; }
      
      set { this._netArea = value; } 
      
    }
    /**
    * 
    */
    public System.Double AccessoriesArea { 
      get { return this._accessoriesArea; }
      
      set { this._accessoriesArea = value; } 
      
    }
    /**
    * 
    */
    public System.Double CostPerMq { 
      get { return this._costPerMq; }
      
      set { this._costPerMq = value; } 
      
    }
    /**
    * 
    */
    public System.Double Paid { 
      get { return this._paid; }
      
      set { this._paid = value; } 
      
    }    #endregion

  #region NAVIGATION PROPERTIES ConstructionCosts

  // #endregion



    #region methods
    
    [HttpGet]
    [ActionName("setCostPerMq")]
    public abstract ConstructionCosts SetCostPerMq();

    [HttpGet]
    [ActionName("usableArea")]
    public abstract void UsableArea();

    [HttpGet]
    [ActionName("le95AreaRate")]
    public abstract void Le95AreaRate();

    [HttpGet]
    [ActionName("gt95le110AreaRate")]
    public abstract void Gt95le110AreaRate();

    [HttpGet]
    [ActionName("gt110le130AreaRate")]
    public abstract void Gt110le130AreaRate();

    [HttpGet]
    [ActionName("gt130le160AreaRate")]
    public abstract void Gt130le160AreaRate();

    [HttpGet]
    [ActionName("gt160AreaRate")]
    public abstract void Gt160AreaRate();

    [HttpGet]
    [ActionName("le95AreaIncrement")]
    public abstract void Le95AreaIncrement();

    [HttpGet]
    [ActionName("gt95le110AreaIncrement")]
    public abstract void Gt95le110AreaIncrement();

    [HttpGet]
    [ActionName("gt110le130AreaIncrement")]
    public abstract void Gt110le130AreaIncrement();

    [HttpGet]
    [ActionName("gt130le160AreaIncrement")]
    public abstract void Gt130le160AreaIncrement();

    [HttpGet]
    [ActionName("gt160AreaIncrement")]
    public abstract void Gt160AreaIncrement();

    [HttpGet]
    [ActionName("notResidentialArea")]
    public abstract void NotResidentialArea();

    [HttpGet]
    [ActionName("notResidentialAreaRate")]
    public abstract void NotResidentialAreaRate();

    [HttpGet]
    [ActionName("informedNotResidentialArea")]
    public abstract void InformedNotResidentialArea();

    [HttpGet]
    [ActionName("totalArea")]
    public abstract void TotalArea();

    [HttpGet]
    [ActionName("informedAccessoriesArea")]
    public abstract void InformedAccessoriesArea();

    [HttpGet]
    [ActionName("totalAreaPercentage")]
    public abstract void TotalAreaPercentage();

    [HttpGet]
    [ActionName("totalResidentialAndNotResidentialArea")]
    public abstract void TotalResidentialAndNotResidentialArea();

    [HttpGet]
    [ActionName("incrementI1")]
    public abstract void IncrementI1();

    [HttpGet]
    [ActionName("incrementI2")]
    public abstract void IncrementI2();

    [HttpGet]
    [ActionName("incrementI3")]
    public abstract void IncrementI3();

    [HttpGet]
    [ActionName("totalIncrement")]
    public abstract void TotalIncrement();

    [HttpGet]
    [ActionName("increase")]
    public abstract void Increase();

    [HttpGet]
    [ActionName("costPerMqIncreased")]
    public abstract void CostPerMqIncreased();

    [HttpGet]
    [ActionName("totalCost")]
    public abstract void TotalCost();

    [HttpGet]
    [ActionName("class")]
    public abstract void Class();

    [HttpGet]
    [ActionName("percentageToPay")]
    public abstract void PercentageToPay();

    [HttpGet]
    [ActionName("totalToPay")]
    public abstract void TotalToPay();

    [HttpGet]
    [ActionName("balance")]
    public abstract void Balance();

    [HttpGet]
    [ActionName("areSettings")]
    public abstract void AreSettings();

    [HttpGet]
    [ActionName("isClass")]
    public abstract void IsClass();

    #endregion


  }

  #endregion
}

