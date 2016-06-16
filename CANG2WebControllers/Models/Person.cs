using System;

namespace CAEP5MockServer.Models
{
  public class Person
  {
    public Guid Key { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    public Job Job { get; set; }
    public Guid JobId { get; set; }
  }
}