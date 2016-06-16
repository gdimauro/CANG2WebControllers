﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;

//[assembly: OwinStartup(typeof(CANG2WebControllers.Startup))]

namespace CANG2WebControllers
{
  public partial class Startup
  {
    static Startup()
    {
      //System.Diagnostics.Debug.WriteLine(typeof(MainHub));
    }

    public void Configuration(IAppBuilder app)
    {

      // Branch the pipeline here for requests that start with "/signalr"
      app.Map("/signalr", map =>
      {
        // Setup the CORS middleware to run before SignalR.
        // By default this will allow all origins. You can 
        // configure the set of origins and/or http verbs by
        // providing a cors options with a different policy.
        map.UseCors(CorsOptions.AllowAll);
        var hubConfiguration = new HubConfiguration
        {
          // You can enable JSONP by uncommenting line below.
          // JSONP requests are insecure but some older browsers (and some
          // versions of IE) require JSONP to work cross domain
          EnableJSONP = true
        };
        // Run the SignalR pipeline. We're not using MapSignalR
        // since this branch already runs under the "/signalr"
        // path.
        map.RunSignalR(hubConfiguration);
      });
      app.MapSignalR();

      ConfigureAuth(app);
    }
  }
}
