using System;
using Practice.Enums;

namespace Practice.Classes
{
    class Report
    {
        public string Text { get; set; }
        public DateTime DateComplection { get; set; }
        public Employee Executor { get; set; }

        public Report(string text, DateTime dateComplection, Employee executor)
        {
            Text = text;
            DateComplection = dateComplection;
            Executor = executor;
        }

    }
}
