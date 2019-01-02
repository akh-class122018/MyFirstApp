using System;
using Lessons;

/* This namespace represents the file folder that the class is in */
namespace classwork
{
    //class is a blueprint of an object
    class Program
    {
        //static = no copy, meaning there is only 1
        //void = is a return type
        //main = is a method name
        //string[] = is a an array and a parameter
        static void Main(string[] args)
        {
            /* console = class inside a system, Writeclass.method takes a parameter */
            Console.WriteLine("Hello World!");
            MyHouseResults();
            MyOnlineProductResults();
            MyNumericExamples();
    

        }
        static void MyNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();
            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));

            myTypes.BasicMath();

            myTypes.CheckOperator();

            myTypes.IncrementDecrement();

            myTypes.SpecialValues();

            myTypes.ComparisonOperators();

            myTypes.OtherOperators();

        }
        static void MyHouseResults()
        // Created and object instance of House called myHouse
        {
            House myHouse = new House();
            //This sets the value of Red to the object
            myHouse.PaintDoor = "Red";
            // The door closes
            myHouse.CloseDoor();
            //This gets the value of Red from the object
            Console.WriteLine(myHouse.PaintDoor);
            //This is a second object instance of House
            House mySecondHouse = new House();
            mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";
            //This gets the value of green from the object
            Console.WriteLine(mySecondHouse.PaintDoor);
            Console.WriteLine(myHouse.PaintDoor);

            // The door closes
            myHouse.CloseDoor();
            // The door opens
            myHouse.OpenDoor();
        }


        static void MyOnlineProductResults()
        {
            // Created and object instance of  online product called myOnlineProduct

            OnlineProduct myOnlineProduct = new OnlineProduct();

            //my first online product is a Ball
            myOnlineProduct.Name = "Ball";
            Console.WriteLine(myOnlineProduct.Name);
            myOnlineProduct.Buy();
            myOnlineProduct.Return();
            myOnlineProduct.Price = "5.0 Euro";
            Console.WriteLine(myOnlineProduct.Price);
            myOnlineProduct.AddToWatchList();
            myOnlineProduct.Picture = "Picture of a Basketball";
            Console.WriteLine(myOnlineProduct.Picture);
            myOnlineProduct.Description = "This is a Basketball";
            myOnlineProduct.Dimension = "Radius 15 inches";
            Console.WriteLine(myOnlineProduct.Description);
            Console.WriteLine(myOnlineProduct.Dimension);

            OnlineProduct mySecondOnlineProduct = new OnlineProduct();
            //my second online product is a Book
            mySecondOnlineProduct.Name = "Book";
            Console.WriteLine(mySecondOnlineProduct.Name);
            mySecondOnlineProduct.AddToWatchList();
            mySecondOnlineProduct.Price = "20 Dollars";
            Console.WriteLine(mySecondOnlineProduct.Price);
            mySecondOnlineProduct.Description = "This is a Cookbook";
            Console.WriteLine(mySecondOnlineProduct.Description);
            mySecondOnlineProduct.Dimension = "8.5 X 11 inches";
            Console.WriteLine(mySecondOnlineProduct.Dimension);

            OnlineProduct myThirdOnlineProduct = new OnlineProduct();
            //my third online product is a toy
            myThirdOnlineProduct.Name = "Toy";
            Console.WriteLine(myThirdOnlineProduct.Name);
            myThirdOnlineProduct.Like();
            myThirdOnlineProduct.PrepareForShipping();
            myThirdOnlineProduct.Price = "$10";
            Console.WriteLine(myThirdOnlineProduct.Price);
            myThirdOnlineProduct.Description = "This is a Toy";
            Console.WriteLine(myThirdOnlineProduct.Description);
            myThirdOnlineProduct.Dimension = "25 inch x 13 feet";
            Console.WriteLine(myThirdOnlineProduct.Dimension);
            myThirdOnlineProduct.Buy();
            myThirdOnlineProduct.Return();
        }
    }
}

