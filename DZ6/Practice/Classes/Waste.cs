using Practice.Enums;
using System;
using System.Collections.Generic;

namespace Practice.Classes
{
    public abstract class Waste
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public TypeGarbage Type { get; protected set; }
        public bool IsHarm { get; protected set; }
        public double Volume { get; protected set; }

        protected Waste(string name, double weight, TypeGarbage type, bool isHarm, double volume)
        {
            Name = name;
            Weight = weight;
            Type = type;
            IsHarm = isHarm;
            Volume = volume;
        }
        protected Waste()
        {
            Name = "Неизвестный";
            Weight = 0;
            Type = TypeGarbage.None;
            IsHarm = false;
        }
        public virtual string GetInfo()
        {
            return $"Название: {Name}, Вес: {Weight} кг, Тип: {Type}, Вред: {IsHarm}, Объем: {Volume} м^3";
        }
        public abstract void Disponse(); //Утилизация
        public virtual void Recycle()  //Переработка
        {
            Console.WriteLine($"{Name} может быть переработан");
        }
        public abstract void Decomposition(); //Разлагание

        public virtual double CalculateImpact() //Расчет экологического воздействия
        {
            double impact = Weight * (IsHarm ? 10.0 : 1.0);
            Console.WriteLine($"Экологическое воздействие {Name}: {impact}");
            return impact;
        }
    }
}

