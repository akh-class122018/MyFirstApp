using System;
namespace Lessons
{
    public class TRex : Dinosaur
    {

        public override void EatFood()
        {
            Console.WriteLine("TRex eats");
        }
        public override void Move()
        {
            Console.WriteLine("TRex runs");
        }

        public override void Sleeps()
        {
            Console.WriteLine("TRex sleeps");
        }

        public override void Communicates()
        {
            Console.WriteLine("TRex roars only in Jurassic Park");
        }

        public override void SkinType()
        {
            Console.WriteLine("Feathery");
        }

        public override void Teeth()
        {
            Console.WriteLine("Razor sharp");
        }
    }

}