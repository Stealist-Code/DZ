using System;
using System.Collections;

namespace Tumakov.Classes
{
    class Creator
    {
        public static Hashtable buildings { get; private set; } = new Hashtable();

        private Creator() { }

        public static Building CreateBuild(decimal height, int numbfloors, int numbflat, int numbentrance)
        {
            Building building = new Building(height, numbfloors, numbflat, numbentrance);
            buildings[building.Id] = building;
            return building;
        }
        public static Building CreateBuild(int id, decimal height, int numbfloors, int numbflat, int numbentrance)
        {
            Building building = new Building(id, height, numbfloors, numbflat, numbentrance);
            buildings[building.Id] = building;
            return building;
        }

        public static void RemoveBuild(long id)
        {
            if (buildings.ContainsKey(id))
            {
                buildings.Remove(id);
                Console.WriteLine($"Успешно. Здание с id: {id}, удалилось.");
                return;
            }
            Console.WriteLine($"Неудачно. Здание с id: {id}, не удалилось.");
        }
    }
}
