using System;
using System.Collections.Generic;
using Practice.Interfaces;

namespace Practice.Classes
{
    class BigRaces
    {
        public List<Team> Teams { get; set; }
        public List<IGame> Games { get; set; }

        public BigRaces(List<Team> teams, List<IGame> games)
        {
            Teams = teams;
            Games = games;
        }
        public BigRaces()
        {
            Teams = new List<Team>();
            Games = new List<IGame>();
        }
        public void AddTeam(Team team)
        {
            if (team != null)
            {
                Teams.Add(team);
                return;
            }
            Console.WriteLine("Команда не может быть null!");
        }
        public void AddGame(IGame game)
        {
            if (game != null)
            {
                Games.Add(game);
                return;
            }
            Console.WriteLine("Игра не может быть null!");
        }

        public void StartShow()
        {
            Console.WriteLine("--- Начинается шоу 'Большие Гонки'! ---");
            Console.WriteLine($"\n--- Команды({Teams.Count} шт) ---");
            foreach (var team in Teams)
            {
                Console.WriteLine(team.Name);
            }
            Console.WriteLine($"\n--- Игры({Games.Count} шт) ---");
            foreach (var game in Games)
            {
                Console.WriteLine(game.Name);
            }

            IGame[] gamesArray = Games.ToArray();

            if (Teams.Count == 0)
            {
                Console.WriteLine("\nК сожалению желающих участвовать в шоу 'Большие Гонки' не было.");
                return;
            }
            Console.WriteLine("\n--- Начало испытаний ---");
            foreach (var team in Teams)
            {
                Console.WriteLine($"\nКоманда {team.Name} приступает к испытаниям. -----");
                Mixing(gamesArray);
                foreach (var game in gamesArray)
                {
                    game.Play(team);
                }
            }   
        }
        public void Mixing<T>(T[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}
