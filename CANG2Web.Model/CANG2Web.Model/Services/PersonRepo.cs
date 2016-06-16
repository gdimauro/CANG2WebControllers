using System;
using System.Collections.Generic;
using System.Linq;
using CANG2Shell.Models;
using CANG2Web.Model;

namespace CANG2Shell.Services
{
    public class PersonRepo : IRepo<Person>
    {
        private IRepo<Job> _jobRepo;
        private IEnumerable<Person> _persons;

        public PersonRepo(IRepo<Job> jobRepo)
        {
            if (jobRepo == null)
                throw new ArgumentNullException("jobRepo");

            this._jobRepo = jobRepo;

            this._persons = new List<Person>()
            {
                new Person
                {
                    Key = Guid.Parse("0C736BCF-8191-41A8-88B3-FA5944E0EBD1"),
                    FirstName = "John",
                    LastName = "Doe",
                    Birthday = new DateTime(1982, 9, 1),
                    Job = jobRepo.GetAll().ElementAt(0),
                    JobId = jobRepo.GetAll().ElementAt(0).Key
                },
                new Person
                {
                    Key = Guid.Parse("5E08701E-EC61-4204-9541-4641E88D0444"),
                    FirstName = "Jane",
                    LastName = "Doe",
                    Birthday = new DateTime(1981, 4, 2),
                    Job = jobRepo.GetAll().ElementAt(1),
                    JobId = jobRepo.GetAll().ElementAt(1).Key
                }
            };
        }

        public Person Find(Guid key)
        {
            return _persons.FirstOrDefault(p => p.Key == key);
        }

        public void Add(Person person)
        {
            person.Key = Guid.NewGuid();
            person.Job = this._jobRepo.GetAll().FirstOrDefault(j => j.Key == person.JobId);
            this._persons = _persons.Concat(new List<Person>() { person });
        }

        public void Update(Person person)
        {
            person.Job = this._jobRepo.GetAll().FirstOrDefault(j => j.Key == person.JobId);
            this._persons = _persons.Where(p => p.Key != person.Key).Concat(new List<Person>() { person });
        }

        public Person Remove(Guid key)
        {
            var person = _persons.FirstOrDefault(p => p.Key == key);
            this._persons = _persons.Where(p => p.Key != key);
            return person;
        }

        public IEnumerable<Person> GetAll()
        {
            return _persons;
        }
    }
}
