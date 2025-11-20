using System;
using Practice.Interfaces;

namespace Practice.Classes
{
    public class Team
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int QuantityPeople { get; set; }
        protected static int IncreasingNumber = 1;
        protected static int IDChange()
        {
            return IncreasingNumber++;
        }

        public Team(string country, int quantityPeople)
        {
            Id = IDChange();
            Name = $"{country}#{Id}";
            Country = country;
            QuantityPeople = (quantityPeople<=0) ? 15 : quantityPeople;
        }
        public Team(string country)
        {
            Id = IDChange();
            Name = $"{country}#{Id}";
            Country = country;
            QuantityPeople = 15;
        }

    }
}
