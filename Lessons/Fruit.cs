using System;
namespace Lessons
{
    public class Fruit
    {
        public void EatFruit()
        {
            Console.WriteLine("I eat Fruit");
            //private is only accessible from within the class
            ThrowFruit();
        }

        //virtual change
        public virtual void EatFruit2()
        {
            Console.WriteLine("I eat Fruit 2");
            //private is only accessible from within the class
            ThrowFruit();
        }


        //private is only accessible from within the class
        private void ThrowFruit()
        {
            Console.WriteLine("Throwing fruit");

        }

    }


}
