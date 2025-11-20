using Practice.Interfaces;
using System;

namespace Practice.Classes
{
    abstract class Game : IGame
    {
        public string Name { get; set; }
        public abstract void Play(Team team);
    }
}
