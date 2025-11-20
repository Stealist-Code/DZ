using System;

namespace Practice.Classes
{
    class CookerGame : Game
    {
        public override void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Name} играет в {Name}. Они готовят блюда.");
        }
        public CookerGame(string name)
        {
            Name = name;
        }
        public CookerGame()
        {
            Name = "Повар";
        }
    }
}
