using System;
using System.Collections.Generic;
using CANG2Shell.Models;
using CANG2Web.Model;
using CANG2Shell.Models.Services;

namespace CANG2Shell.Services
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

        public void SetScenarioTask(ScenarioTask scenarioTask) {
            this.scenarioTasks[scenarioTask.Key] = scenarioTask;
        }
    }
}
