using CAEP5MockServer.Models;
using System;
using System.Collections.Generic;

namespace CAEP5MockServer.Services
{
  public interface IScenarioTaskRepo
  {
    IEnumerable<ScenarioTask> All();

    ScenarioTask GetScenarioTask(Guid id);

    void SetScenarioTask(ScenarioTask scenarioTask);
  }
}