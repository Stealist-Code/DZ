using Practice.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice.Classes
{
    static class StudentManager
    {
        public static List<Student> Students { get; set; } = new List<Student>();

        public static Student NewStudent(int id, string name, int groupNumber, StatusStudent type)
        {
            var student = new Student(id, name, groupNumber, type);
            Students.Add(student);
            return student;
        }
        public static void SearchStudentInFile()
        {
            string[] linesFromFile = File.ReadAllLines(@"..\..\Files\Students.txt");
            foreach (var line in linesFromFile)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string[] parts = line.Split(',');
                bool idBool = int.TryParse(parts[0].Trim(), out int id);
                string name = parts[1].Trim();
                bool groupBool = int.TryParse(parts[2].Trim(), out int group);
                bool statusBool = StatusStudent.TryParse(parts[3].Trim(), out StatusStudent status);
                Students.Add(new Student(id, name, group, status));
            }
        }
        public static Student[] SelectStudent(int quantityStudent, List<Student> studentInGroup)
        {
            var inactiveStudents = new List<Student>();
            var studentsMaybeChoose = new List<Student>();
            var normalStudents = new List<Student>();
            foreach (var student in studentInGroup)
            {
                if (student.Status == StatusStudent.FreeloaderStudent)
                {
                    inactiveStudents.Add(student);
                }
                else if (student.Status == StatusStudent.LazyStudent)
                {
                    studentsMaybeChoose.Add(student);
                }
                else
                {
                    normalStudents.Add(student);
                }
            }

            var countIndex = 0;
            var selectStudentArray = new Student[quantityStudent];
            if (inactiveStudents.Count >= quantityStudent)
            {
                for (int i = 0; i < quantityStudent; i++)
                {
                    selectStudentArray[countIndex++] = inactiveStudents[i];
                }
            }
            else
            {
                for (int i = 0; i < inactiveStudents.Count; i++)
                {
                    selectStudentArray[countIndex++] = inactiveStudents[i];
                }

                var lazyCount = Math.Min(quantityStudent - countIndex, studentsMaybeChoose.Count);
                for (int i = 0; i < lazyCount; i++)
                {
                    selectStudentArray[countIndex++] = studentsMaybeChoose[i];
                }

                var normalCount = Math.Min(quantityStudent - countIndex, normalStudents.Count);
                for (int i = 0; i < normalCount; i++)
                {
                    selectStudentArray[countIndex++] = normalStudents[i];
                }
            }
            return selectStudentArray;
        }
        public static List<List<Student>> DivisionGroups()
        {
            var uniqueGroupNumbers = Students.Select(s => s.GroupNumber).Distinct().ToList();

            var allGroups = new List<List<Student>>();

            foreach (var groupNumber in uniqueGroupNumbers)
            {
                var groupStudents = Students.Where(s => s.GroupNumber == groupNumber).ToList();
                allGroups.Add(groupStudents);
            }
            return allGroups;
        }
        public static void VerificationParticipation(Event eventOne)
        {
            var newArray = Students.Where(x => !eventOne.StudentsInEvent.Any(y => y.Id == x.Id));
            foreach (var student in newArray)
            {
                student.MissedEvents -= 1;
                student.ChangeStatus();
            }
        }
    }
}