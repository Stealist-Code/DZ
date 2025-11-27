using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice.Classes
{
    class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int QuantityStudent { get; set; }
        public List<Student> StudentsInEvent { get; set; } = new List<Student>();

        public Event(string name, DateTime date, int quantityStudent, List<Student> students)
        {
            Name = name;
            Date = date;
            QuantityStudent = quantityStudent;
            StudentsInEvent = students;
        }
        public Event(string name, DateTime date, int quantityStudent)
        {
            Name = name;
            Date = date;
            QuantityStudent = quantityStudent;
        }

        public void AddStudent(List<Student> students)
        {
            StudentsInEvent.AddRange(students);
        }
        public void StartEvent()
        {
            if (QuantityStudent != StudentsInEvent.Count)
            {
                Console.WriteLine("Студентов либо много, либо мало");
                return;
            }
            var filePath = @"..\..\Files\EventInfo.txt";
            string namesString = string.Join(", ", StudentsInEvent.Select(s => s.Name));
            var textExport = $"{Name}; {Date.ToString("dd.MM.yyyy")}; {namesString}";
            File.WriteAllText(filePath, textExport);
            foreach (var student in StudentsInEvent)
            {
                student.MissedEvents = 3;
            }

        }
    }
}
