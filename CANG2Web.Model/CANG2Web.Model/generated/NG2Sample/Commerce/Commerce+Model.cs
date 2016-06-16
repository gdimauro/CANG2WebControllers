/*****************************************************\
* THIS FILE HAS BEEN GENERATED AUOMATICALLY           *
* don't change please                                 *
\*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NG2Sample.Commerce
{
  #region ENUMERATIONS

  /**
  * $$enumState$$
  */
  public enum State
  {
    Start = 1, // $enumState::Start$
    Pause = 2, // $enumState::Pause$
    Stop = 3 // $enumState::Stop$
  }

  #endregion

  #region ENTITIES


  /**
  * $$baseentity$$
  */
  
  public partial class Base
  {
    #region FIELD DECLARATIONS Base
    
    private  System.String _id;
    #endregion

    #region FIELD ASSOCIATIONS Base
    #endregion


    public Base() { }

    #region PROPERTIES Base
    /**
    * $baseentity::id$
    */
    public System.String Id { 
      get { return this._id; }
      
      set { this._id = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Base

  #endregion



    #region methods
    
    #endregion


  }


  /**
  * $$entityProductBase$$
  */
  
  public partial class ProductBrowse : Base
  {
    #region FIELD DECLARATIONS ProductBrowse
    
    private  System.Double _id;
    
    private  System.String _name;
    
    private  System.String _description;
    
    private  System.String _imageUrl;
    #endregion

    #region FIELD ASSOCIATIONS ProductBrowse
    #endregion


    public ProductBrowse() { }

    #region PROPERTIES ProductBrowse
    /**
    * $entityProduct::Id$
    */
    public System.Double Id { 
      get { return this._id; }
      
      set { this._id = value; } 
      
    }
    /**
    * $entityProduct::Name$
    */
    public System.String Name { 
      get { return this._name; }
      
      set { this._name = value; } 
      
    }
    /**
    * $entityProduct::Description$
    */
    public System.String Description { 
      get { return this._description; }
      
      set { this._description = value; } 
      
    }
    /**
    * $entityProduct::ImageUrl$
    */
    public System.String ImageUrl { 
      get { return this._imageUrl; }
      
      set { this._imageUrl = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES ProductBrowse

  #endregion



    #region methods
    
    #endregion


  }


  /**
  * $$entityVehicle::Vehicle$$
  */
  
  public partial class Vehicle : Base
  {
    #region FIELD DECLARATIONS Vehicle
    
    private  System.Double _id;
    
    private  System.String _name;
    
    private  System.String _type;
    #endregion

    #region FIELD ASSOCIATIONS Vehicle
    #endregion


    public Vehicle() { }

    #region PROPERTIES Vehicle
    /**
    * $entityVehicle::Id$
    */
    public System.Double Id { 
      get { return this._id; }
      
      set { this._id = value; } 
      
    }
    /**
    * $entityVehicle::Name$
    */
    public System.String Name { 
      get { return this._name; }
      
      set { this._name = value; } 
      
    }
    /**
    * $entityVehicle::Type$
    */
    public System.String Type { 
      get { return this._type; }
      
      set { this._type = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Vehicle

  #endregion



    #region methods
    
    #endregion


  }


  /**
  * $$entityPerson$$
  */
  
  public partial class Person : Base
  {
    #region FIELD DECLARATIONS Person
    
    private  System.String _name;
    
    private  System.String _lastname;
    private  List<Job> _jobs;
    #endregion

    #region FIELD ASSOCIATIONS Person
    #endregion


    public Person() { }

    #region PROPERTIES Person
    /**
    * Name of person
    */
    public System.String Name { 
      get { return this._name; }
      
      set { this._name = value; } 
      
    }
    /**
    * Lastname of person
    */
    public System.String Lastname { 
      get { return this._lastname; }
      
      set { this._lastname = value; } 
      
    }
    /**
    * Job of person
    */
    public List<Job> Jobs { 
      get { return this._jobs; }
      
      set { this._jobs = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Person

  #endregion



    #region methods
    
    #endregion


  }


  /**
  * $$entityJob$$
  */
  
  public partial class Job : Base
  {
    #region FIELD DECLARATIONS Job
    
    private  System.String _name;
    
    private  System.String _lastname;
    #endregion

    #region FIELD ASSOCIATIONS Job
    #endregion


    public Job() { }

    #region PROPERTIES Job
    /**
    * Name of person
    */
    public System.String Name { 
      get { return this._name; }
      
      set { this._name = value; } 
      
    }
    /**
    * Lastname of person
    */
    public System.String Lastname { 
      get { return this._lastname; }
      
      set { this._lastname = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Job

  #endregion



    #region methods
    
    #endregion


  }


  /**
  * aklsdjflkasdf
  */
  
  public partial class Pippo : Job
  {
    #region FIELD DECLARATIONS Pippo
    
    private  System.String _id;
    #endregion

    #region FIELD ASSOCIATIONS Pippo
    #endregion


    public Pippo() { }

    #region PROPERTIES Pippo
    /**
    * sadkfjlalksdf
    */
    public System.String Id { 
      get { return this._id; }
      
      set { this._id = value; } 
      
    }
    #endregion

  #region NAVIGATION PROPERTIES Pippo

  #endregion



    #region methods
    
    #endregion


  }

  #endregion
}

