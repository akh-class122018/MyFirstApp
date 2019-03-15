using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class ExceptionExamples
    {
        string _exampleNull = null;

        public void MyException()
        {
            try
            {
                Console.WriteLine(_exampleNull);
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine("Null Exception thrown " + ex.Message);
            }

        }

        public void MyArrayException()
        {
            string[] names = { "Dave", "Matt", "Jody" };
            string[] values = { "24", "42", "38" };
            string[] values2 = { "2433333", "42444444", "38543" };


            try
            {
                //byte b = byte.Parse(names[3]);
                byte b = byte.Parse(values[1]);
                Console.WriteLine(b);

                byte bb = byte.Parse(values2[1]);
                Console.WriteLine(bb);


            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please provide at least one argument!");
            }

            catch (FormatException e)
            {
                Console.WriteLine("this is not a number!");
            }

            catch (OverflowException eo)
            {
                Console.WriteLine("You've given more than a byte!");
            }




        }
    }
}
