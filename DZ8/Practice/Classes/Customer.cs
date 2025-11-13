using System;
using System.Collections.Generic;
using Practice.Enums;

namespace Practice.Classes
{
    class Customer : Person
    {
        public List<Report> reports { get; set; } = new List<Report>();
        public Customer(int id, string name, Role role) : base(id, name, role) { }
        
        public void AddReport(Report report)
        {
            reports.Add(report);  
        }
    }
}
