using System;

namespace Tumakov.Classes
{
    class Building
    {
        private static int increasingNumber = 1;
        private int Id;
        private decimal Height;
        private int NumbFloors;
        private int NumbFlat;
        private int NumbEntrance;

        public Building(decimal height, int numbfloors, int numbflat, int numbentrance)
        {
            Id = NumberChange();
            Height = height;
            NumbFloors = numbfloors;
            NumbFlat = numbentrance;
            NumbEntrance = numbentrance;
        }
        public Building(int id, decimal height, int numbfloors, int numbflat, int numbentrance)
        {
            Id = id;
            Height = height;
            NumbFloors = numbfloors;
            NumbFlat = numbentrance;
            NumbEntrance = numbentrance;
        }
        private static int NumberChange()
        {
            return increasingNumber++;
        }
        public void PrintInfo() //Вывод информации
        {
            Console.WriteLine($"Информация о здании. \nУникальный номер здания: {Id}\nВысота: {Height}\nЭтажность: {NumbFloors}\nКол-во квартир: {NumbFlat}\nКол-во подъездов: {NumbEntrance}\nВысота этажа: {CalculHeightFloors()}\nКвартир в подъезде: {CalculNumbFlatEntrance()}\nКвартир на этаже: {CalculateApartmentsPerFloor()}");
        }
        public object[] GetInfo() //Получение значений
        {
            return new object[8] {Id, Height, NumbFloors, NumbFlat, NumbEntrance, CalculHeightFloors(), CalculNumbFlatEntrance(), CalculateApartmentsPerFloor()};
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
