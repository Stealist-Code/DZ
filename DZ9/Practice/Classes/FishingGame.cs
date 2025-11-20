using System;

namespace Practice.Classes
{
    class FishingGame : Game
    {
        public override void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Name} играет в {Name}. Они рыбачат.");
        }
        public FishingGame(string name)
        {
            Name = name;
        }
        public FishingGame()
        {
            Name = "Рыбалка";
        }
    }
}
