using System;

namespace Quiz
{
    public interface ITelevision
    {
        void TurnsOn();

        void TurnsOff();

        int Price { get; set; }
    }
}