using System;
namespace Quiz
{
    public class FourkTv : TvModels
    {
        public override decimal Price { get; set; } = 1000.99m;

        public FourkTv(int size, int numberofPorts, decimal price, bool isMountable) : base(size, numberofPorts, price, isMountable)
        {
        }

        public override void TurnsOff()
        {
            Console.WriteLine("4KTV Turns off");
        }
        public override void TurnsOn()
        {
            Console.WriteLine("The 4kTV Turns on with a smart app");

        }


    }
}