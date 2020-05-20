using backend.Domain.Entities;
using backend.Infraestructure.Data.EF.Mapping;
using Microsoft.EntityFrameworkCore;

namespace backend.Infraestructure.Data.EF.Context
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PersonMap());
        }
    }   
}
