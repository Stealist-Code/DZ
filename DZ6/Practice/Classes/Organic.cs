using Practice.Enums;
using System;

namespace Practice.Classes
{
    public class OrganicWaste : Waste
    {
        public int DecompositionTime { get; set; }
        public OrganicWaste(string name, double weight, bool isHarm, double volume, int decompositionTime) : base(name, weight, TypeGarbage.Organic, isHarm, volume)
        {
            DecompositionTime = decompositionTime;
        }
        public OrganicWaste() : base()
        {
            Type = TypeGarbage.Organic;
            DecompositionTime = 30;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Время разложения (в днях): {DecompositionTime}, Свежесть: {Status()}";
        }
        public override void Disponse()
        {
            Console.WriteLine($"{Name} утилизируется путем компостирования");
        }
        public override void Recycle()
        {
            Console.WriteLine($"{Name} может быть переработан в удобрение");
        }
        public override void Decomposition()
        {
            Console.WriteLine($"{Name} разлагается за {DecompositionTime} дней.");
        }
        public Freshness Status()
        {
            if ( DecompositionTime < 5 )
            {
                return Freshness.New;
            }
            else if ( DecompositionTime < 10)
            {
                return Freshness.Average;
            }
            else
            {
                return Freshness.Old;
            }

        }
    }
}
