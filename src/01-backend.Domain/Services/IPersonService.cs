using System;
using System.Collections.Generic;
using backend.Domain.Entities;

namespace backend.Domain.Services
{
    public interface IPersonService
    {
        Person Add(Person person);
        void Delete(Guid id);
        Person Update(Person person);
        IEnumerable<Person> GetAll();
    }
}