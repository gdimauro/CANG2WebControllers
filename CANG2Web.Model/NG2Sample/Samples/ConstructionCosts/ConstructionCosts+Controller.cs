/*****************************************************\
* THIS FILE HAS BEEN GENERATED AUOMATICALLY           *
* don't change please                                 *
\*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NG2Sample.Samples.ConstructionCosts.Controllers
{
  [Route("api/ng2sample.samples.constructioncosts/{action}")]
  public partial class ConstructionCostsController : BaseConstructionCostsController
  {
    // don't implement here your virtual methods. Create your own partial class instead.
  }

  public class BaseConstructionCostsController : ApiController
  {
    public BaseConstructionCostsController()
    {
      System.Diagnostics.Debug.WriteLine("ConstructionCostsController");
    }
    
    //#region operation webapi stubs
    
    [HttpGet]
    [ActionName("setCostPerMq")]
    public abstract  SetCostPerMq();

    [HttpGet]
    [ActionName("usableArea")]
    public abstract  UsableArea();

    [HttpGet]
    [ActionName("le95AreaRate")]
    public abstract  Le95AreaRate();

    [HttpGet]
    [ActionName("gt95le110AreaRate")]
    public abstract  Gt95le110AreaRate();

    [HttpGet]
    [ActionName("gt110le130AreaRate")]
    public abstract  Gt110le130AreaRate();

    [HttpGet]
    [ActionName("gt130le160AreaRate")]
    public abstract  Gt130le160AreaRate();

    [HttpGet]
    [ActionName("gt160AreaRate")]
    public abstract  Gt160AreaRate();

    [HttpGet]
    [ActionName("le95AreaIncrement")]
    public abstract  Le95AreaIncrement();

    [HttpGet]
    [ActionName("gt95le110AreaIncrement")]
    public abstract  Gt95le110AreaIncrement();

    [HttpGet]
    [ActionName("gt110le130AreaIncrement")]
    public abstract  Gt110le130AreaIncrement();

    [HttpGet]
    [ActionName("gt130le160AreaIncrement")]
    public abstract  Gt130le160AreaIncrement();

    [HttpGet]
    [ActionName("gt160AreaIncrement")]
    public abstract  Gt160AreaIncrement();

    [HttpGet]
    [ActionName("notResidentialArea")]
    public abstract  NotResidentialArea();

    [HttpGet]
    [ActionName("notResidentialAreaRate")]
    public abstract  NotResidentialAreaRate();

    [HttpGet]
    [ActionName("informedNotResidentialArea")]
    public abstract  InformedNotResidentialArea();

    [HttpGet]
    [ActionName("totalArea")]
    public abstract  TotalArea();

    [HttpGet]
    [ActionName("informedAccessoriesArea")]
    public abstract  InformedAccessoriesArea();

    [HttpGet]
    [ActionName("totalAreaPercentage")]
    public abstract  TotalAreaPercentage();

    [HttpGet]
    [ActionName("totalResidentialAndNotResidentialArea")]
    public abstract  TotalResidentialAndNotResidentialArea();

    [HttpGet]
    [ActionName("incrementI1")]
    public abstract  IncrementI1();

    [HttpGet]
    [ActionName("incrementI2")]
    public abstract  IncrementI2();

    [HttpGet]
    [ActionName("incrementI3")]
    public abstract  IncrementI3();

    [HttpGet]
    [ActionName("totalIncrement")]
    public abstract  TotalIncrement();

    [HttpGet]
    [ActionName("increase")]
    public abstract  Increase();

    [HttpGet]
    [ActionName("costPerMqIncreased")]
    public abstract  CostPerMqIncreased();

    [HttpGet]
    [ActionName("totalCost")]
    public abstract  TotalCost();

    [HttpGet]
    [ActionName("class")]
    public abstract  Class();

    [HttpGet]
    [ActionName("percentageToPay")]
    public abstract  PercentageToPay();

    [HttpGet]
    [ActionName("totalToPay")]
    public abstract  TotalToPay();

    [HttpGet]
    [ActionName("balance")]
    public abstract  Balance();

    [HttpGet]
    [ActionName("areSettings")]
    public abstract  AreSettings();

    [HttpGet]
    [ActionName("isClass")]
    public abstract  IsClass();

    //#endregion operation webapi stubs
  }
}
