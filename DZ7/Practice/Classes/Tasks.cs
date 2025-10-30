using Practice.Enums;
using System;

namespace Practice.Classes
{
    public class Task
    {
        public string Name { get; private set; }
        public DepartamentType Type {get; private set; }
        
        public Task(string name, DepartamentType type)
        {
            Name = name;
            Type = type;
        }
    }
}
