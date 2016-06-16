using System;
using System.Collections.Generic;
using CANG2Shell.Models;
using CANG2Web.Model;

namespace CANG2Shell.Services
{
    public class JobRepo : IRepo<Job>
    {
        private IEnumerable<Job> _jobs;

        public JobRepo()
        {
            this._jobs = new List<Job>()
            {
                new Job
                {
                    Key = Guid.Parse("1F9F17DD-62E5-4D90-9753-95F10BD9664C"),
                    Position = "Software engeneer",
                    Wage = 60000
                },
                new Job
                {
                    Key = Guid.Parse("EECF1888-9710-484C-A3FA-8E10A4436C46"),
                    Position= "Data analyst",
                    Wage = 75000
                }
            };
        }

        public void Add(Job T)
        {
            throw new NotImplementedException();
        }

        public Job Find(Guid key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Job> GetAll()
        {
            return _jobs;
        }

        public Job Remove(Guid key)
        {
            throw new NotImplementedException();
        }

        public void Update(Job T)
        {
            throw new NotImplementedException();
        }
    }
}
