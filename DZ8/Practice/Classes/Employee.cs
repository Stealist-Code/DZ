using Practice.Enums;
using System.Collections.Generic;
using System;

namespace Practice.Classes
{
    class Employee : Person
    {
        public List<Task> Tasks { get; set; } = new List<Task>();

        public Employee(int id, string name, Role role) : base(id, name, role) { }

        public void SetTask(Task task)
        {
            Tasks.Add(task);
        }
        public void DeleteTask(Task task)
        {
            Tasks.Remove(task);
        }
    }
}