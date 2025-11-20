using System;

namespace Practice.Classes
{
    class SeaGame: Game
    {
        public override void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Name} играет в {Name}. Они изображают море.");
        }
        public SeaGame(string name)
        {
            Name = name;
        }
        public SeaGame()
        {
            Name = "Море";
        }
    }
}
