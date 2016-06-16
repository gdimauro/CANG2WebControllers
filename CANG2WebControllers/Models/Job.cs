using System;

namespace CAEP5MockServer.Models
{
  public class Job
  {
    public Guid Key { get; set; }
    public string Position { get; set; }
    public decimal Wage { get; set; }
  }
}