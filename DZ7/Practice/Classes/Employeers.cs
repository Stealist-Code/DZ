using System;
using System.Collections.Generic;
using Practice.Enums;

namespace Practice.Classes
{
    class Employee
    {
        public string Name { get; private set; }
        public DepartamentType Departament { get; private set; }
        public List<Employee> Head { get; private set; } = new List<Employee>();
        public List<Employee> Subordinates { get; private set; } = new List<Employee>();

        public Employee(string name, DepartamentType departament)
        {
            Name = name;
            Departament = departament;
        }

        public void AddSubordinates(params Employee[] employees)
        {
            Subordinates.AddRange(employees);
        }
        public void DeleteSubordinates(Employee employee)
        {
            Subordinates.Remove(employee);
        }
        public void AddHead(params Employee[] employees)
        {
            Head.AddRange(employees);
        }
        public void DeleteHead(Employee employee)
        {
            Head.Remove(employee);
        }

        
    }
}
