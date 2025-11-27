using System;
using Practice.Enums;

namespace Practice.Classes
{
    class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int GroupNumber { get; private set; }
        public int MissedEvents { get; set; }
        public StatusStudent Status { get; private set; }

        public Student(int id, string name, int groupNumber, StatusStudent status)
        {
            Id = id;
            Name = name;
            GroupNumber = groupNumber;
            MissedEvents = 0;
            Status = status;
        }

        public void ChangeStatus()
        {
            if (MissedEvents == 1)
            {
                Status = StatusStudent.LazyStudent;
            }
            else if (MissedEvents <= 0) 
            {
                Status = StatusStudent.FreeloaderStudent;
            }
            else if (MissedEvents >= 3)
            {
                Status = StatusStudent.NormalStudent;
            }
        }
    }
}
