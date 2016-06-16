using CAEP5MockServer.Models;
using CAEP5MockServer.Services;
using System;
using System.Web.Http;

namespace CAEP5MockServer.Controllers
{
  public class PersonController : ApiController
  {
    private IRepo<Person> personRepo;
    //private IHubContext<IMainHub> hubContext { get; set; }

    public PersonController(IRepo<Person> personRepo/*, IHubContext<IMainHub> hubContext*/)
    {
      this.personRepo = personRepo;
      //this.hubContext = hubContext;
    }

    [HttpGet]
    public IHttpActionResult Get()
    {
      return Ok(personRepo.GetAll());
    }

    [HttpGet, ActionName("GetPerson")]
    public IHttpActionResult Get([FromUri] Guid id)
    {
      var person = personRepo.Find(id);
      if (person == default(Person))
      {
        return NotFound();
      }
      return Ok(person);
    }

    [HttpPost]
    public IHttpActionResult Create([FromBody] Person person)
    {
      if (person == null)
      {
        return BadRequest();
      }

      personRepo.Add(person);

      //this.hubContext.Clients.All.LogCommand(new Message()
      //{
      //  Key = Guid.NewGuid(),
      //  Head = "Person created",
      //  Body = String.Format("Person {0} {1} created successfully", person.FirstName, person.LastName),
      //  Timestamp = DateTime.UtcNow
      //});

      return CreatedAtRoute("DefaultApi", new { controller = "Person", id = person.Key }, person);
    }

    [HttpPut]
    public IHttpActionResult Update([FromUri] Guid id, [FromBody] Person person)
    {
      if (person == null || person.Key != id)
      {
        return BadRequest();
      }

      var todo = personRepo.Find(id);
      if (todo == null)
      {
        return NotFound();
      }

      personRepo.Update(person);

      //this.hubContext.Clients.All.LogCommand(new Message()
      //{
      //  Key = Guid.NewGuid(),
      //  Head = "Person updated",
      //  Body = String.Format("Person {0} {1} updated successfully", person.FirstName, person.LastName),
      //  Timestamp = DateTime.UtcNow
      //});

      return Ok();
    }

    [HttpDelete]
    public void Delete([FromUri] Guid id)
    {
      var person = personRepo.Remove(id);

      //this.HubContext.Clients.All.LogCommand(new Message()
      //{
      //  Key = Guid.NewGuid(),
      //  Head = "Person removed",
      //  Body = String.Format("Person {0} {1} removed successfully", person.FirstName, person.LastName),
      //  Timestamp = DateTime.UtcNow
      //});
    }
  }
}
