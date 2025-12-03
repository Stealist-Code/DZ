using System;

namespace Tumakov.Classes
{
    class SeveralBuildings
    {
        public Building[] Buildings { get; set; } = new Building[10];

        public SeveralBuildings(Building[] buildings)
        {
            Buildings = buildings;
        }
        public Building this[int index]
        {
            get
            {
                if (index >= 0 || index <= Buildings.Length)
                {
                    return Buildings[index];
                }
                throw new IndexOutOfRangeException();
            }
        }
    }
}
