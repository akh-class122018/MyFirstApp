using System;

namespace Quiz
{
    public interface ITelevision
    {
        void TurnsOn();

        void TurnsOff();

        decimal Price { get; set; }
    }
}