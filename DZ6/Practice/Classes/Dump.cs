using System;
using System.Collections.Generic;

namespace Practice.Classes
{
    public class Dump
    {
        public string Location { get; set; }
        public double Capacity { get; set; }
        public double CurrentLoad { get; private set; }
        public List<Waste> Wastes { get; private set; }
        public Dump(string location, double capacity)
        {
            Location = location;
            Capacity = capacity;
            CurrentLoad = 0;
            Wastes = new List<Waste>();
        }
        public void AddWaste(Waste waste)
        {
            if (CurrentLoad + waste.Volume <= Capacity)
            {
                Wastes.Add(waste);
                CurrentLoad += waste.Volume;
                Console.WriteLine($"Мусор {waste.Name} добавлен на свалку {Location}.");
            }
            else
            {
                Console.WriteLine($"Свалка переполнена! Нельзя добавить мусор {waste.Name}.");
            }
        }

        public void RemoveWaste(string name)
        {
            Waste waste = null;
            foreach (Waste w in Wastes)
            {
                if (w.Name.ToLower() == name.ToLower())
                {
                    waste = w;
                    break;
                }
            }

            if (waste != null)
            {
                Wastes.Remove(waste);
                CurrentLoad -= waste.Volume;
                Console.WriteLine($"Мусор {name} удален со свалки {Location}.");
            }
            else
            {
                Console.WriteLine("Мусор не найден.");
            }
        }

        public void ShowAllWastes()
        {
            Console.WriteLine($"Отходы на свалке {Location}:");
            foreach (var waste in Wastes)
            {
                Console.WriteLine(waste.GetInfo());
            }
        }

        public double CalculateTotalImpact()
        {
            double total = 0;
            foreach (var waste in Wastes)
            {
                total += waste.CalculateImpact();
            }
            Console.WriteLine($"Общее экологическое воздействие свалки: {total}");
            return total;
        }

        public void OptimizeDump() //Сортировка по весу
        {
            for (int i = 0; i < Wastes.Count - 1; i++)
            {
                for (int j = 0; j < Wastes.Count - i - 1; j++)
                {
                    if (Wastes[j].Weight > Wastes[j + 1].Weight)
                    {
                        Waste temp = Wastes[j];
                        Wastes[j] = Wastes[j + 1];
                        Wastes[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Отходы отсортированы по весу.");
        }
    }
}
