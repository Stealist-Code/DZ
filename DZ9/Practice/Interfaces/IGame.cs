using System;
using Practice.Classes;

namespace Practice.Interfaces
{
    public interface IGame
    {
        string Name { get; }
        void Play(Team team);
    }
}
