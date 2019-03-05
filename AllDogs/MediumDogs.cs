using System;
using System.Collections.Generic;
using System.Text;

namespace AllDogs
{
    public class MediumDogs
    {
        int dogYearsM;
        int humanYearsM;

        public void ReadData()
        {
            Console.WriteLine("Enter how old your medium sized dog is in human Years?");
            dogYearsM = Convert.ToInt32(Console.ReadLine());

        }

        public void DogYearsConversionMedium()
        {
            if (dogYearsM == 1)
            {
                humanYearsM = ((dogYearsM - 1) * 4) + 15;
                Console.WriteLine("Age of Medium Sized Dog in Dog Years is " + humanYearsM);

            }

            else if (dogYearsM >= 2 && dogYearsM >= 5)
            {
                //humanYearsM = ((dogYearsM - 1) * 4) + 15 + 5;
                humanYearsM = ((dogYearsM - 1) * 4) + 20;

                Console.WriteLine("Age of Medium Sized Dog in Dog Years is " + humanYearsM);
            }

            else if (dogYearsM == 6)
            {
                //humanYearsM = ((dogYearsM - 1) * 4) + (15 + 5) + 2;
                humanYearsM = ((dogYearsM - 1) * 4) + 22;
                Console.WriteLine("Age of Medium Sized Dog in Dog Years is " + humanYearsM);
            }

            else if (dogYearsM == 7 && dogYearsM == 8)
            {
                //humanYearsM = ((dogYearsM - 1) * 4) + (15 + 5) + 3;
                humanYearsM = ((dogYearsM - 1) * 4) + 23;

                Console.WriteLine("Age of Medium Sized Dog in Dog Years is " + humanYearsM);
            }

            else if (dogYearsM == 9 && dogYearsM == 10)
            {
                //humanYearsM = ((dogYearsM - 1) * 4) + (15 + 5) + 4;
                humanYearsM = ((dogYearsM - 1) * 4) + 24;

                Console.WriteLine("Age of Medium Sized Dog in Dog Years is " + humanYearsM);
            }

            else if (dogYearsM == 11 && dogYearsM == 12)
            {
                //humanYearsM = (((dogYearsM - 1) * 4) + (15 + 5) + 5);
                humanYearsM = (((dogYearsM - 1) * 4) + 25);

                Console.WriteLine("Age of Medium Sized Dog in Dog Years is " + humanYearsM);
            }

            else if (dogYearsM == 13 && dogYearsM == 14)
            {
                //humanYearsM = ((dogYearsM - 1) * 4) + (15 + 5) + 6;
                humanYearsM = ((dogYearsM - 1) * 4) + 26;
                Console.WriteLine("Age of Medium Sized Dog in Dog Years is " + humanYearsM);
            }

            else if (dogYearsM == 15 && dogYearsM == 16)
            {
                //humanYearsM = ((dogYearsM - 1) * 4) + (15 + 5) + 7;
                humanYearsM = ((dogYearsM - 1) * 4) + 27;

                Console.WriteLine("Age of Medium Sized Dog in Dog Years is " + humanYearsM);
            }
        }
    }
}