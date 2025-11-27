using System;
using Practice.Enums;
using Practice;

namespace Practice.Classes
{

    public class Person
    {
        public delegate void ReactionHandler(string personName, string reaction);
        public static event ReactionHandler OnReaction;

        public string Name;
        public Hobby Hobby;
        public string Reaction;

        public Person(string name, Hobby hobby, string reaction)
        {
            Name = name;
            Hobby = hobby;
            Reaction = reaction;
        }
        public bool ReactEvent(Hobby eventHobby)
        {
            if (this.Hobby == eventHobby)
            {
                OnReaction.Invoke(this.Name, this.Reaction);
                return true;
            }
            return false;
        }
    }
}
