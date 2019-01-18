using System;
namespace Lessons
{

    public abstract class Dinosaur : IPrehistoric
    {
        public abstract void EatFood();

        // public virtual can't use semicolon at end needs { } instead
        public virtual void Move()
        {
            Console.WriteLine("The Dinosaur moves");
        }
        public abstract void Sleeps();

        public virtual void Communicates()
        {
            Console.WriteLine("The Dinosaur can communicate");
        }

        public abstract void SkinType();
        public abstract void Teeth();
    }


}
