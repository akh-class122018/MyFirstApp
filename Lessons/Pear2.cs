using System;
namespace Lessons
{
    //Filename Pear 2
    public partial class Pear
    {
        //can not have the same signature therefor 2 string
        public Pear(string message, string something)
        {
            Console.WriteLine(message + "is" + something);
            Peel();
        }

        partial void Peel()
        {
            Console.WriteLine("I peeled a pear");

        }


    }
}