using System;
using System.Collections.Generic;
using Practice.Classes;
using Practice.Interfaces;

namespace Practice
{
    internal class Program_practice
    {
        static void Main(string[] args)
        {
            var teams = new List<Team> { };

            Console.WriteLine("--- Создание команд ---");
            Console.WriteLine("Перед тем как приступить к шоу 'Большие Гонки', нужно создать команды.");
            Console.Write("Если не хотите вручную создавать команды, введите 1, иначе введите любой текст: ");
            if (Console.ReadLine() == "1")
            {
                teams.AddRange(new List<Team> { new Team("Россия"), new Team("Франция"), new Team("Китай"), new Team("Казахстан") });
            }
            else
            {
                Console.WriteLine("Если захотите остановить цикл создания команд, введите слово 'стоп'");
                string countryTeam = String.Empty;
                while (countryTeam.ToLower() != "стоп")
                {
                    if (countryTeam != String.Empty)
                    {
                        teams.Add(new Team(countryTeam));
                    }
                    Console.Write("Введите название страны команды: ");
                    countryTeam = Console.ReadLine();
                    
                }
                
            }

            var games = new List<IGame>
            {
                new SlideGame(),
                new PostmenGame(),
                new FishingGame(),
                new SeaGame(),
                new MousetrapGame(),
                new BeachGame(),
                new CookerGame()
            };
            var bigRaces = new BigRaces(teams, games);
            bigRaces.StartShow();
        }
    }
}
