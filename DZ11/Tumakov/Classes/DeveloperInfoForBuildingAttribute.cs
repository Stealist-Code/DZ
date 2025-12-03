using System;

namespace Tumakov.Classes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DeveloperInfoForBuildingAttribute : Attribute
    {
        public string NameDeveloper { get; private set; }
        public string NameOrganization { get; private set; }

        public DeveloperInfoForBuildingAttribute()
        {
            NameDeveloper = "UnknownDeveloper";
            NameOrganization = "UnknownOrganization";
        }

        public DeveloperInfoForBuildingAttribute(string nameDeveloper, string nameOrganization)
        {
            NameDeveloper = nameDeveloper;
            NameOrganization = nameOrganization;
        }

        public void Print()
        {
            Console.WriteLine($"Данные класса атрибута.---\nРазработчик: {NameDeveloper}\nОрганизация: {NameOrganization}");
        }
    }
}
