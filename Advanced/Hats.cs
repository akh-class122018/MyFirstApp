using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class Hats
    {
        public delegate void TryHat(string type);

        public string HatType { get; }
        public int HatSize { get; }

        //default constructor
        public Hats()
        {
            //assinging method to delegate. Tryonhat methods assined to delegate
            //my object of the delegate
            TryHat myHat = TryOnHat;
            TryALargerHat("fadora", 7, myHat);

        }
        //constructor with 1 parameter
        public Hats(int size)
        {
            this.HatSize = size;
        }


        //constructor  with 2 parameter
        public Hats(string type, int size)
        {
            this.HatSize = size;
            this.HatType = type;
        }

        public void TryOnHat(string message)
        {
            Console.WriteLine(message);
        }

        //tryon=delegate       

        public void TryALargerHat(string type, int oldSize, TryHat another)
        //constructor no parameters
        {
            another("I tried on a " + type + " hat at size " + (oldSize + 1).ToString());

        }

        public void FindLuckyHat(string message)
        {
            Console.WriteLine("Lucky hat is {0}", message);
        }

        public void FindUglyHat(string message)
        {
            Console.WriteLine("Ugly hat is {0}", message);
        }

    }


}

