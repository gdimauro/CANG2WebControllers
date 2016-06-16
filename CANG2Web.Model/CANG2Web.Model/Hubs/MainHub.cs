////using CANG2Shell.Models.Services;
//using Microsoft.AspNet.SignalR;
//using Microsoft.AspNet.SignalR.Hubs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CANG2Web.Model.Hubs
//{
//  public interface IMainHub
//  {
//    void PongCommand();
//    //void NavigationCommand(ScenarioTask scenarioTask);
//    //void LogCommand(Message message);
//  }

//  [HubName("Main")]
//  public class MainHub : Hub<IMainHub>
//  {
//    static MainHub()
//    {
//    }

//    public MainHub()
//    {
//    }

//    private IScenarioTaskRepo ScenarioTaskRepo { get; set; }

//    public MainHub(IScenarioTaskRepo scenarioTaskRepo) : base()
//    {
//      this.ScenarioTaskRepo = scenarioTaskRepo;
//    }

//    public Task JoinTaskDetailedGroup(Guid taskId)
//    {
//      var scenarioTask = ScenarioTaskRepo.GetScenarioTask(taskId);
//      if (scenarioTask == null)
//      {
//        scenarioTask = new ScenarioTask()
//        {
//          Key = taskId,
//          Name = "",
//          Params = null
//        };
//        ScenarioTaskRepo.SetScenarioTask(scenarioTask);
//        Groups.Add(Context.ConnectionId, taskId.ToString());
//      }

//      Clients.Caller.NavigationCommand(scenarioTask);
//      return Groups.Add(Context.ConnectionId, taskId.ToString());
//    }

//    public Task LeaveTaskDetailedGroup(Guid taskId)
//    {
//      return Groups.Remove(Context.ConnectionId, taskId.ToString());
//    }

//    public void PingCommand()
//    {
//      Clients.Caller.PongCommand();
//    }

//    public void NavigationCommand(ScenarioTask scenarioTask)
//    {
//      ScenarioTaskRepo.SetScenarioTask(scenarioTask);
//      Clients.All.LogCommand(new Message()
//      {
//        Key = Guid.NewGuid(),
//        Head = "State changed",
//        Body = String.Format("Task {0} has changed its state in {1}", scenarioTask.Key, scenarioTask.Name),
//        Timestamp = DateTime.UtcNow
//      });
//      Clients.Group(scenarioTask.Key.ToString()).NavigationCommand(scenarioTask);
//    }
//  }
//}
