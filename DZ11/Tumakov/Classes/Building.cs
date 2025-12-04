using System;

namespace Tumakov.Classes
{
    [DeveloperInfoForBuilding()]
    class Building
    {
        public Guid Id { get; set; }
        public decimal Height { get; set; }
        public int NumbFloors { get; set; }
        public int NumbFlat { get; set; }
        public int NumbEntrance { get; set; }

        public Building(decimal height, int numbfloors, int numbflat, int numbentrance)
        {
            Id = Guid.NewGuid();
            Height = height;
            NumbFloors = numbfloors;
            NumbFlat = numbflat;
            NumbEntrance = numbentrance;
        }

        public Building()
        {
            Id = Guid.NewGuid();
            Height = 1;
            NumbFloors = 1;
            NumbFlat = 1;
            NumbEntrance = 1;
        }

        public void PrintInfo() //Вывод информации
        {
            Console.WriteLine($"Информация о здании. \nУникальный номер здания: {Id}\nВысота: {Height}\nЭтажность: {NumbFloors}\nКол-во квартир: {NumbFlat}\nКол-во подъездов: {NumbEntrance}\nВысота этажа: {CalculHeightFloors()}\nКвартир в подъезде: {CalculNumbFlatEntrance()}\nКвартир на этаже: {CalculateApartmentsPerFloor()}");
        }
        
        public decimal CalculHeightFloors()
        {
            return NumbFloors > 0 ? Height / NumbFloors : 0;
        }

        public int CalculNumbFlatEntrance()
        {
            return NumbEntrance > 0 ? NumbFlat / NumbEntrance : 0;
        }

        public int CalculateApartmentsPerFloor()
        {
            int flatEntrance = CalculNumbFlatEntrance();
            return NumbFloors > 0 ? flatEntrance / NumbFloors : 0;
        }
    }
}