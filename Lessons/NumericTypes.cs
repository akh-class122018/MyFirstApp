using System;

namespace Lessons
{
    public class NumericTypes
    // class level variables, can be used inside the entire class
    {
        /*Integral - signed */
        // -128 to -127
        sbyte _mySbyteValue = 2;

        // range -32,768 to 32,767
        short _myShortValue = 4;

        // range -2,147,483,648 to 2,147,483,647
        int _myIntValue = 25000;

        // range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,806
        long _myLongValue = 1_234_567L;
        long _myLongValue2 = 0x5F;

        /* Integral - Unsigned */
        // range 0 to 255
        byte myByteValue = 3;

        // range 0 to 65,535
        ushort _myUShortValue = 35;

        // range 0 to 4,294,967,295
        uint _myUIntValue = 2345U;

        // range 0 to 18,446,744,073,709,551,615
        ulong _myULongValue = 123456UL;

        /* real numbers */
        // range 3.4 +/- 38(7 digits)=
        float _myFloatValue = -123.6589F;

        // range 1.7 +/- 308(15 digits)
        double _myDoubleValue = 12.34;
        double _myDoubleValue2 = 1E06;

        //range -7.9228E+24 to 7.9228E+24
        decimal _myDecimalValue = 13.234M;

        // Type inference; the  GetType method returns variable type.
        public void GetSomeType()
        {
            //Double
            Console.WriteLine(3.0.GetType());
            //float
            Console.WriteLine(_myFloatValue.GetType());
        }
        // Method to demonstrate an Explicit cast from float to int.
        public int ConvertFloatToInt(float value)
        {
            int total = (int)value;
            return total;

        }
        // Method to demonstrate an implicit cast from int to long.
        public long LongFromInt(int value)
        {
            long total = value;
            return total;
        }
        public void BasicMath()
        {
            int myVal = 5, myOtherVal = 10;

            int addVal = myVal + myOtherVal;
            int subtractVal = myOtherVal - myVal;
            int multiplyVal = myVal * myOtherVal;
            int divisionVal = myVal / myOtherVal;
            int modulusVal = myVal % myOtherVal;

            // give console line space
            Console.WriteLine(" ");


            Console.WriteLine(addVal);
            Console.WriteLine(subtractVal);
            Console.WriteLine(multiplyVal);
            Console.WriteLine(divisionVal);
            Console.WriteLine(modulusVal);

        }

        public void CheckOperator()
        {
            /// same way of wrinting this int test = 100; int test2 = 100;
            int test = 100, test2 = 100;

            int testVal = checked(test * test2);
            checked
            {
                /*Unhandled Exception: System.OverflowException: Arithmetic operation resulted in an overflow.
                 at Lessons.NumericTypes.CheckOperator() in C:\Users\classroom\MyRepository\classwork\Lessons\NumericTypes.cs:line 99
                 at classwork.Program.MyNumericExamples() in C:\Users\classroom\MyRepository\classwork\Program.cs:line 34
                at classwork.Program.Main(String[] args) in C:\Users\classroom\MyRepository\classwork\Program.cs:line 20 , make the value 300000000 (8) to fail.*/
                int testAgain = test * 300;
                Console.WriteLine(testAgain);
            }
            Console.WriteLine(testVal);

        }

        public void IncrementDecrement()
        {
            int myValue = 13, myOther = 10;
            // myValue = myValue +1    Console.WriteLine(myValue++);
            // myOther = myOther -1    Console.WriteLine(myOther--);
            myValue++;
            Console.WriteLine(myValue);

            myOther--;
            Console.WriteLine(myOther);

            --myValue;
            Console.WriteLine(myValue);

            ++myOther;
            Console.WriteLine(myOther);
        }


        public void SpecialValues()
        {
            Console.WriteLine(2.0 / 0.0);
            Console.WriteLine(-2.0 / 0.0);
            Console.WriteLine(2.0 / -0.0);
            Console.WriteLine(-2.0 / -0.0);
            Console.WriteLine(0.0 / 0.0);
            Console.WriteLine((2.0 / -0.0) - (2.0 / 00));
            Console.WriteLine(0.0 / -0.0 == double.NaN);
            Console.WriteLine(double.IsNaN(0.0 / 0.0));
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));

        }

        public void ComparisonOperators()
        {
            bool isCorrect = true;

            /*bool values can be true or false. No cast type for bool to numeric types
         */
            int x = 3, y = 5, z = 3;

            Console.WriteLine(x == y); //false
            Console.WriteLine(x != y); //true
            Console.WriteLine(x == z); //true

        }


        public void OtherOperators()
        {
            int val1 = 5, val2 = 10;
            // val1 = val1 + val2  += Add to self
            Console.WriteLine(val1 += val2);
            // val1 = val1 << Val2   <<= Shift self left by
            Console.WriteLine(val1 <<= val2);

        }
    }
}