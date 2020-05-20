using System;

namespace backend.Domain.Entities
{
    public class Person
    {

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public Person(Guid id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public Person(string name, string lastName)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
        }
    }   
}
