using System;

namespace Practice.Classes
{
    class SlideGame : Game
    {
        public override void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Name} играет в {Name}. Они скатываются с горки.");
        }
        public SlideGame(string name)
        {
            Name = name;
        }
        public SlideGame()
        {
            Name = "Горки";
        }
    }
}
