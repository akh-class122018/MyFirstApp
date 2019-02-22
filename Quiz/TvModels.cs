using System;

namespace Quiz
{
    public abstract class TvModels : ITelevision
    {
        public int Size { get; set; }
        public virtual decimal Price { get; set; } = 600.99m;
        public int NumberofPorts { get; set; }
        public bool IsMountable { get; set; } = true;

        public virtual void TurnsOn()
        {
            Console.WriteLine("The TV Turns on");

        }
        public abstract void TurnsOff();

        public TvModels(int size, int numberofPorts, decimal price, bool isMountable)
        {
            Size = size;
            NumberofPorts = numberofPorts;
            Price = price;
            IsMountable = isMountable;

        }

        public TvModels(int size, int numberofPorts)
        : this(size, numberofPorts, 899.98m, true)
        {

        }
    }
}
