using System;

namespace Quiz
{
    public abstract class TvModels : ITelevision
    {
        public string Size { get; set; }
        public virtual int Price { get; set; } = 500;
        public int NumberofPorts { get; set; }
        public bool IsMountable { get; set; } = true;

        public virtual void TurnsOn()
        {
            Console.WriteLine("The TV Turns on");

        }
        public abstract void TurnsOff();

        public TvModels(string size, int numberofPorts, int price, bool isMountable)
        {
            Size = size;
            NumberofPorts = numberofPorts;
            Price = price;
            IsMountable = isMountable;

        }

        public TvModels(string size, int numberofPorts)
        : this(size, numberofPorts, 500, true)
        {

        }
    }
}
