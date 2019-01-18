using System;
namespace Lessons
{
    public class Teradactyl : Dinosaur
    {
        public override void EatFood()
        {
            Console.WriteLine("Teradactyl eats");
        }
        public override void Move()
        {
            Console.WriteLine("Teradactyl flyes");
        }

        public override void SkinType()
        {
            Console.WriteLine("Feathers");
        }

        public override void Sleeps()
        {
            Console.WriteLine("Teradactyl sleeps");
        }

        public override void Teeth()
        {
            Console.WriteLine("Beaks filled with about 90 sharp teeth");
        }
    }
}