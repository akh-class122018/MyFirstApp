﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class SmallDogs
    {
        int dogYears;
        int humanYears;

        public void ReadData()
        {
            Console.WriteLine("Enter how old your small dog is in human Years?");
            //humanYears = Convert.ToInt32(Console.ReadLine());
            dogYears = Convert.ToInt32(Console.ReadLine());

        }

        public void DogYearsConversion()
        {
            if (dogYears == 1)
            {
                humanYears = ((dogYears - 1) * 4) + 15;
                Console.WriteLine("Age of Dog in Dog Years is " + humanYears);

            }

            else if (dogYears >= 2)
            {
                humanYears = ((dogYears - 1) * 4) + 15 + 5;
                Console.WriteLine("Age of Dog in Dog Years is " + humanYears);
            }

            Console.ReadLine();
        }
    }
}