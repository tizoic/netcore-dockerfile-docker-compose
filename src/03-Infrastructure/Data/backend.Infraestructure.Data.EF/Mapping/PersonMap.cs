using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infraestructure.Data.EF.Mapping
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p=> p.Id);
            builder.Property(p=> p.Name).IsRequired();
            builder.Property(p=> p.LastName);

            builder.ToTable("Person");

        }
    }
}
