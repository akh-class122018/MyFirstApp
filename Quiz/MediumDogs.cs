using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class MediumDogs
    {
        int dogYears;
        int humanYears;

        public void ReadData()
        {
            Console.WriteLine("Enter how old your medium dog is in human Years?");
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

            else if (dogYears >= 2 && dogYears >= 5)
            {
                humanYears = ((dogYears - 1) * 4) + 15 + 5;
                Console.WriteLine("Age of Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 6)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + 2;
                Console.WriteLine("Age of Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 7 && dogYears == 8)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + 3;
                Console.WriteLine("Age of Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 9 && dogYears == 10)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + 4;
                Console.WriteLine("Age of Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 11 && dogYears == 12)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + 5;
                Console.WriteLine("Age of Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 13 && dogYears == 14)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + 6;
                Console.WriteLine("Age of Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 15 && dogYears == 16)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + 7;
                Console.WriteLine("Age of Dog in Dog Years is " + humanYears);
            }

            Console.ReadLine();
        }
    }
}