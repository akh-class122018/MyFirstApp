using System;
namespace Lessons
{
    public class Lesson11
    {
        public const int MY_VALUE = 25;

        /* Method to demonstare a constant Which cannot change its value; */

        public void SampleLesson11()
        {
            const string today = "Wednesday";
            // MY_VALUE = 35;// Can not change the value
            //Can use it with other variables
            int total = MY_VALUE * 2;
            Console.WriteLine(total);

            //error The left-hand side of an assignment must be a variable, property or indexer [classwork]
            // today = "Friday";

        }


        public void Useparams(params int[] items)
        {

            for (int i = 0; i < items.Length; i++)
            {

                Console.Write(items[i] + " ");

            }

            Console.WriteLine();

        }

        public void Useparams2(params object[] items)// when you put object you do not define a type
        {

            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }

            Console.WriteLine();

        }

        public void OptionalParam(string name, int age = 45)
        {
            Console.WriteLine(name + " is " + age + " years old.");
        }

        public void RefSample(ref int value)
        {
            value = value + 5;
            Console.WriteLine(value);
            // Output = 19
        }

        public void OutSample(string name, out string firstName, out string lastName)
        {
            int myIndex = name.LastIndexOf(' ');
            firstName = name.Substring(0, myIndex);
            lastName = name.Substring(myIndex + 1);
        }



    }
}