using Practice.Enums;
using System;

namespace Practice.Classes
{
    public class InorganicWaste : Waste
    {
        public string Material { get; set; }
        public InorganicWaste(string name, double weight, bool isHarm, double volume, string material) : base(name, weight, TypeGarbage.Inorganic, isHarm, volume)
        {
            Material = material;
        }
        public InorganicWaste() : base()
        {
            Type = TypeGarbage.Inorganic;
            Material = "Неизвестно";
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Материал: {Material}, Плотность: {Density()}";
        }
        public override void Disponse()
        {
            Console.WriteLine($"{Name} утилизируется путем сортировки и переработки");
        }
        public override void Recycle()
        {
            Console.WriteLine($"{Name} из {Material} может быть переработан в новое изделие");
        }
        public override void Decomposition()
        {
            Console.WriteLine($"{Name} не разлагается.");
        }
        public float Density()
        {
            float densityValue = (float)(Weight / Volume);
            return densityValue;
        }
    }
}
