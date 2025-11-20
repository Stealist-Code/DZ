using System;

namespace Practice.Classes
{
    class MousetrapGame: Game
    {
        public override void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Name} играет в {Name}. Они пытаются не попасть в мышеловку.");
        }
        public MousetrapGame(string name)
        {
            Name = name;
        }
        public MousetrapGame()
        {
            Name = "Мышеловка";
        }
    }
}
