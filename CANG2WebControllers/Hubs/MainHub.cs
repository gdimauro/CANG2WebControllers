//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Microsoft.AspNet.SignalR;
//using Microsoft.AspNet.SignalR.Hubs;
//using System.Threading.Tasks;

//namespace CANG2WebControllers.Hubs
//{
//  public interface IMainHub
//  {
//    void PongCommand();
//  }

//  [HubName("Main")]
//  public class MainHub : Hub<IMainHub>
//  {
//    static MainHub()
//    {

//    }

//    public MainHub() : base()
//    {
//    }

//    public void PingCommand()
//    {
//      Clients.Caller.PongCommand();
//    }
//  }
//}