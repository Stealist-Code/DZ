using System;
using System.Collections.Generic;
using Practice.Enums;

namespace Practice.Classes
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }

        public Person(int id, string name, Role role)
        {
            Id = id;
            Name = name;
            Role = role;
        }

    }
}
