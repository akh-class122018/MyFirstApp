using System;
using System.Collections.Generic;
using System.Text;
using Quiz;
using Lessons;

namespace AllDogs
{
    public class DogSizeCalculator
    {
        int dogWeight;

        SmallDogs sdog = new SmallDogs();

        MediumDogs mdog = new MediumDogs();

        LargeDogs ldog = new LargeDogs();


        public void ReadData()
        {
            Console.WriteLine("Please tell us your dog\'s weight in pounds(l)bs");
            dogWeight = Convert.ToInt32(Console.ReadLine());

        }

        public void SelectDogSize()
        {
            if (dogWeight <= 20)
            {
                Console.WriteLine("Thank You for entering the information. Your Dog is small.");
                Console.WriteLine(" ");
                sdog.ReadData();
            }

            else if (dogWeight == 21 && dogWeight <= 50)
            {
                Console.WriteLine("Thank You for entering the information. Your Dog is medium sized.");
                Console.WriteLine(" ");
                mdog.ReadData();
            }

            else if (dogWeight >= 50)
            {
                Console.WriteLine("Thank You for entering the information. Your Dog is Large.");
                Console.WriteLine(" ");
                ldog.ReadData();

            }

        }

    }
}