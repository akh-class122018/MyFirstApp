using System;
using System.Collections.Generic;
using System.Text;

namespace AllDogs
{
    public class LargeDogs
    {
        int dogYears;
        int humanYears;

        public void ReadData()
        {
            Console.WriteLine("Enter how old your large dog is in human Years?");
            //humanYears = Convert.ToInt32(Console.ReadLine());
            dogYears = Convert.ToInt32(Console.ReadLine());

        }

        public void DogYearsConversionLarge()
        {
            if (dogYears == 1)
            {
                humanYears = ((dogYears - 1) * 4) + 15;
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);

            }

            else if (dogYears >= 2 && dogYears <= 5)
            {
                humanYears = ((dogYears - 1) * 4) + 15 + 5;
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 6)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (2 + 3);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 7)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (3 + 3);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }


            else if (dogYears == 8)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (3 + 4);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 9)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (4 + 5);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 10)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (4 + 6);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }


            else if (dogYears == 11)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (5 + 7);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 12)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (5 + 8);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 13)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (6 + 8);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }


            else if (dogYears == 14)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (6 + 10);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 15)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (7 + 10);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }

            else if (dogYears == 16)
            {
                humanYears = ((dogYears - 1) * 4) + (15 + 5) + (7 + 40);
                Console.WriteLine("Age of Large Size Dog in Dog Years is " + humanYears);
            }

            else
            {
                Console.WriteLine("Your dog is 17 years or older, we a currently unable to calcutale dog years");
            }

        }
    }
}
