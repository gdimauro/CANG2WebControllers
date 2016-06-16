using System;
using System.Collections.Generic;
using CANG2Web.Model;

namespace CANG2Shell.Models.Services
{
    public interface IScenarioTaskRepo
    {
        IEnumerable<ScenarioTask> All();

        ScenarioTask GetScenarioTask(Guid id);

        void SetScenarioTask(ScenarioTask scenarioTask);
    }
}
