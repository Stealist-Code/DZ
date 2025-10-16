using static Practice.Enums.Exams;
using System;


namespace Practice.Structs
{
    internal class Student
    {
        public struct StudentInfo
        {
            public string Name;
            public string Surname;
            public DateTime TimeBirth;
            public Exam Exam;
            public int Scores;

            public StudentInfo(string name, string surname, DateTime timeBirth, Exam exam, int scores)
            {
                this.Name = name;
                this.Surname = surname;
                this.TimeBirth = timeBirth;
                this.Exam = exam;
                this.Scores = scores;
            }
        }

    }
}
