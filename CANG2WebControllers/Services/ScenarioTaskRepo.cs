using CAEP5MockServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAEP5MockServer.Services
{
  public class ScenarioTaskRepo : IScenarioTaskRepo
  {
    private Dictionary<Guid, ScenarioTask> scenarioTasks = new Dictionary<Guid, ScenarioTask>();

    public IEnumerable<ScenarioTask> All()
    {
      return this.scenarioTasks.Values;
    }

    public ScenarioTask GetScenarioTask(Guid id)
    {
      return this.scenarioTasks.ContainsKey(id) ? this.scenarioTasks[id] : default(ScenarioTask);
    }

    public void SetScenarioTask(ScenarioTask scenarioTask)
    {
      this.scenarioTasks[scenarioTask.Key] = scenarioTask;
    }
  }
}