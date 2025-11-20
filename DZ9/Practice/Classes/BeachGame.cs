using System;

namespace Practice.Classes
{
    class BeachGame: Game
    {
        public override void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Name} играет в {Name}. Они строят песчаные замки.");
        }
        public BeachGame(string name)
        {
            Name = name;
        }
        public BeachGame()
        {
            Name = "Пляж";
        }
    }
}
