using System;

namespace Quiz

{
    public class QuizClass1
    {
        public string SampleGrades(MyGrades grades)
        {
            switch (grades)
            {
                case MyGrades.E:
                    return "The Grade is Excellent.";
                case MyGrades.V:
                    return "The Grade is Very Good.";
                case MyGrades.G:
                    return "The Grade is Good.";
                case MyGrades.A:
                    return "The Grade is Average.";
                case MyGrades.F:
                    return "The Grade is Fail.";
                default:
                    return "This is not a valid Grade.";
            }
        }


        public void DividesByThree()
        {
            for (int i = 0; i < 50; i++)
            {

                if (i % 3 == 0)

                    Console.WriteLine("number = " + i);

            }
        }

    }
}

