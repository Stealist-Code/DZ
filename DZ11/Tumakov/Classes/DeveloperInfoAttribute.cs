using System;

namespace Tumakov.Classes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DeveloperInfoAttribute : Attribute
    {
        public string NameDeveloper { get; private set; }
        public DateTime Date {  get; private set; }

        public DeveloperInfoAttribute()
        {
            NameDeveloper = "UnknownDeveloper";
            Date = DateTime.Now;
        }

        public DeveloperInfoAttribute(string nameDeveloper, string date)
        {
            NameDeveloper = nameDeveloper;
            if (DateTime.TryParse(date, out DateTime parsedDate))
            {
                Date = parsedDate;
            }
            else
            {
                Date = DateTime.Now;
            }
        }

        public void Print()
        {
            Console.WriteLine($"\nДанные класса атрибута.---\nРазработчик: {NameDeveloper}\nДата: {Date}");
        }
    }
}
