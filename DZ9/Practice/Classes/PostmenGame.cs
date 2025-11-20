using System;

namespace Practice.Classes
{
    class PostmenGame : Game
    {
        public override void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Name} играет в {Name}. Они раздают письма.");
        }
        public PostmenGame(string name)
        {
            Name = name;
        }
        public PostmenGame()
        {
            Name = "Почтальоны";
        }
    }
}
