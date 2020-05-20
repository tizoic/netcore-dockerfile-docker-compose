
using backend.Domain.Entities;
using backend.Domain.Repositories;
using backend.Infraestructure.Data.EF.Base;
using backend.Infraestructure.Data.EF.Context;

namespace backend.Infraestructure.Data.EF.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(PersonContext personContext) : base(personContext)
        {
        }
    }
}
