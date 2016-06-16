using CAEP5MockServer.Models;
using CAEP5MockServer.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace CAEP5MockServer.Controllers
{
  public class JobController : ApiController
  {
    private IRepo<Job> jobRepo;

    public JobController(IRepo<Job> jobRepo)
    {
      this.jobRepo = jobRepo;
    }

    [HttpGet]
    public IEnumerable<Job> Get()
    {
      return jobRepo.GetAll();
    }
  }
}
