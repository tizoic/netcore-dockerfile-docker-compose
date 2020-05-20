using System;
using System.Collections.Generic;
using backend.Domain.Entities;
using backend.Domain.Repositories;
using backend.Domain.Services;

namespace backend.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }
        public Person Add(Person person)
        {
            return _repository.Add(person);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Person> GetAll()
        {
            return _repository.GetAll();
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}