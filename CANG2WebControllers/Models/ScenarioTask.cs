using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CAEP5MockServer.Models
{
  public class ScenarioTask
  {
    [JsonProperty("key")]
    public Guid Key { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("params")]
    public List<string> Params { get; set; }
  }
}