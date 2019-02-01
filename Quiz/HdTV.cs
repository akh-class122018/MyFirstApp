using System;

namespace Quiz
{
    public class HdTV : TvModels
    {
        public HdTV(string size, int numberofPorts) : base(size, numberofPorts)
        {
        }

        public override int Price { get; set; } = 700;
        public override void TurnsOff()
        {
            Console.WriteLine("HDTV Turns off");
        }
        public override void TurnsOn()
        {
            Console.WriteLine("The HDTV Turns on with a physical remote");

        }


    }
}

