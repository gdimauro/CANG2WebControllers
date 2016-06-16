using Newtonsoft.Json;
using System;

namespace CAEP5MockServer.Models
{
  public class Message
  {
    // FIXME: find better solution for automatic camel casing of property with SignalR v3
    // @see https://blogs.msdn.microsoft.com/stuartleeks/2013/11/28/automatic-camel-casing-of-properties-with-signalr-hubs-signalr-v2/
    [JsonProperty("key")]
    public Guid Key { get; set; }

    [JsonProperty("head")]
    public string Head { get; set; }

    [JsonProperty("body")]
    public string Body { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }
  }
}