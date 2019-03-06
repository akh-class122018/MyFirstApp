using Lessons;
using Quiz;
using AllDogs;

using System;
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
            // Console.WriteLine("Hello World!");
            // MyHouseResults();
            // MyOnlineProductResults();
            // MyNumericExamples();
            // MyStringExamples();
            // StatementSamples();
            // HouseSample();
            ///Console.WriteLine(" ");
            // OnlineProductSample();
            // Console.WriteLine(" ");
            // StructSample();

            //MyGradesSample();

            //DividesByThree();

            //FruitSample();

            //ParamsSample();

            //ModifierExample();
            //OutSample();

            //Lesson12();

            //AbstractDemo();

            //DeconstructSample();

            //FinalizerExample();

            //IndexerSample();

            //PartialSample();

            //AnotherHouseExample();

            //CollectionsSample();

            //TelevisonSample();

            // LabResults();

            //EnumConversion();

            //LeapYear();

            //Question5Struct();

            //MyDogYearsConversion();

            MyDogSizeCalculator();


            //MyDogYearsConversionSmall();
            //Console.WriteLine("BREAK");

            //MyDogYearsConversionMedium();
            //Console.WriteLine("BREAK");

            //MyDogYearsConversionLarge();
            // Console.WriteLine("BREAK");
        }

        static void MyDogSizeCalculator()
        {
            DogSizeCalculator dsc = new DogSizeCalculator();
            dsc.ReadData();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            dsc.SelectDogSize();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Thank You for using our Calculator");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");






        }


        static void MyDogYearsConversion()

        {
            DogYears obj = new DogYears();
            obj.ReadData();
            obj.DogYearsConversion();
        }


        static void MyDogYearsConversionSmall()
        {
            SmallDogs obje = new SmallDogs();
            obje.ReadData();
            obje.DogYearsConversionSmall();

        }

        static void MyDogYearsConversionMedium()
        {
            MediumDogs objee = new MediumDogs();
            objee.ReadData();
            objee.DogYearsConversionMedium();

        }
        static void MyDogYearsConversionLarge()
        {
            LargeDogs objj = new LargeDogs();
            objj.ReadData();
            objj.DogYearsConversionLarge();

        }

        static void Question5Struct()
        {
            TVS TV1;
            TVS TV2;

            TV1.TurnsOff = "with remote";
            TV1.TurnsOn = "with remote";
            TV1.Price = 2000.99m;
            TV1.IsMountable = false;

            Console.WriteLine("TV 1 turns off : {0}", TV1.TurnsOff);
            Console.WriteLine("TV 1 turns on : {0}", TV1.TurnsOn);
            Console.WriteLine("TV 1 Price is ${0}", TV1.Price);
            Console.WriteLine("TV 1 Is Mountable : {0}", TV1.IsMountable);


            TV2.TurnsOff = "with app";
            TV2.TurnsOn = "with app";
            TV2.Price = 4000.99m;
            TV2.IsMountable = true;

            Console.WriteLine("TV 2 turns off : {0}", TV2.TurnsOff);
            Console.WriteLine("TV 2 turns on : {0}", TV2.TurnsOn);
            Console.WriteLine("TV 2 Price is ${0}", TV2.Price);
            Console.WriteLine("TV 2 Is Mountable : {0}", TV2.IsMountable);


        }

        static void LeapYear()
        {
            LeapYear obj = new LeapYear();
            obj.readdata();
            obj.leap();
        }

        static void EnumConversion()
        {
            ConvertTypes lab2 = new ConvertTypes();
            lab2.ConversionFeet(4.5, ConvertTypes.FeetConvert.Centimeters);
            lab2.ConversionFeet(15.3, ConvertTypes.FeetConvert.Inches);
            lab2.ConversionFeet(8.33, ConvertTypes.FeetConvert.Yards);
            lab2.ConversionFeet(2.21, ConvertTypes.FeetConvert.Meters);
            lab2.ConversionFeet(11.1, ConvertTypes.FeetConvert.Millimeters);


        }

        static void LabResults()
        {

            LabResults lr1 = new LabResults();
            lr1.SampleConversion(ConvertEnum.mm);
            string _convervariable1 = lr1.SampleConversion(ConvertEnum.mm);
            string _convervariable2 = lr1.SampleConversion(ConvertEnum.cm);
            string _convervariable3 = lr1.SampleConversion(ConvertEnum.inch);
            string _convervariable4 = lr1.SampleConversion(ConvertEnum.m);
            string _convervariable5 = lr1.SampleConversion(ConvertEnum.y);
            Console.WriteLine(_convervariable1);
            Console.WriteLine(_convervariable2);
            Console.WriteLine(_convervariable3);
            Console.WriteLine(_convervariable4);
            Console.WriteLine(_convervariable5);

        }


        static void TelevisonSample()
        {

            HdTV myHdTv = new HdTV(65, 6);

            myHdTv.TurnsOn();
            myHdTv.TurnsOff();
            Console.WriteLine(myHdTv.Price);
            Console.WriteLine(myHdTv.Size);
            Console.WriteLine(myHdTv.NumberofPorts);
            Console.WriteLine(myHdTv.IsMountable);

            Console.WriteLine(" ");


            FourkTv myFourkTv = new FourkTv(70, 4, 5000, false);

            myFourkTv.TurnsOn();
            myFourkTv.TurnsOff();
            Console.WriteLine(myFourkTv.Size);
            Console.WriteLine(myFourkTv.NumberofPorts);
            Console.WriteLine(myFourkTv.Price);
            Console.WriteLine(myFourkTv.IsMountable);




        }

        static void Lesson12()
        {
            double temp = Utilities.CelsiusToFahrenheit("43.2");
            double temp2 = Utilities.FahrenheitToCelsius("109.76");

            Console.WriteLine(temp);
            Console.WriteLine(temp2);

        }

        static void CollectionsSample()
        {
            CollectionExamples ce = new CollectionExamples();
            ce.MyArrayListExample();
            ce.MyListExample();

        }

        static void GenericSample()
        {
            GenericList<int> myList = new GenericList<int>();
            myList.Add(10);

            GenericList<string> mySecondList = new GenericList<string>();
            mySecondList.Add("Happy");

            GenericList<TRex> myTrexList = new GenericList<TRex>();
            myTrexList.Add(new TRex());



        }

        static void AnotherHouseExample()

        {
            House myHouse = new House()
            {
                Roof = "Shingles",
                Window = "Double Pane",
                PaintDoor = "Red",
                Foundation = "Concrete"
            };
            Console.WriteLine("My windows choice is {0}", myHouse.Window);
            Console.WriteLine("My Paintdoor choice is {0}", myHouse.PaintDoor);
            Console.WriteLine("My foundation choice is {0}", myHouse.Foundation);

            Console.WriteLine("My roof choice is " + myHouse.Roof);




            /* also be written as    
            Console.WriteLine("My windows choice is " + myHouse.Window); */

        }

        static void PartialSample()
        {
            Pear pear = new Pear("yellow");
        }
        static void IndexerSample()
        {
            //class  variable name
            IndexerExample indexerExample = new IndexerExample();
            indexerExample[2] = 250;

            for (int i = 0; i < indexerExample.Length; i++)
            {
                //i 1st position in ths array
                Console.WriteLine("Postion {0} = {1}", i, indexerExample[i]);
            }
        }
        static void FinalizerExample()
        {
            FinalizerExample finalizerExample = new FinalizerExample("John", "Doe");

        }
        static void DeconstructSample()
        {
            string first = "Tom", last = "Jones";

            //create object, constructor, 2 variables variable to field
            Lesson13 lesson13 = new Lesson13("John", "Doe");

            //print values only
            Console.WriteLine("First Name = {0} and Last Name = {1}", first, last);

            //field to variable
            lesson13.Deconstruct(out first, out last);

            Console.WriteLine("First Name = {0} and Last Name = {1}", first, last);

        }

        static void AbstractDemo()
        {
            TRex myTrex = new TRex();
            Triceratops myTriceratops = new Triceratops();

            myTrex.EatFood();
            myTrex.Move();
            myTrex.Sleeps();
            myTrex.Communicates();
            myTrex.SkinType();
            myTrex.Teeth();

            Console.WriteLine(" ");

            myTriceratops.EatFood();
            // has not been overwritten so "the dinosaur moves"
            myTriceratops.Move();
            myTriceratops.Sleeps();
            myTriceratops.Communicates();
            myTriceratops.SkinType();
            myTriceratops.Teeth();

            Console.WriteLine(" ");

            Teradactyl myTeradactyl = new Teradactyl();

            myTeradactyl.EatFood();
            myTeradactyl.Move();
            myTeradactyl.Sleeps();
            myTeradactyl.Communicates();
            myTeradactyl.Teeth();
            myTeradactyl.SkinType();
        }

        static void Lesson12Sample()
        {
            double temp = Utilities.CelsiusToFahrenheit("43.2");
            double temp2 = Utilities.FahrenheitToCelsius("109.76");

            Console.WriteLine(temp);
            Console.WriteLine(temp2);

        }


        static void OutSample()
        {

            String myTestName, myTestSecondName;
            Lesson11 mylesson = new Lesson11();
            mylesson.OutSample("John Doe", out myTestName, out myTestSecondName);

            Console.WriteLine(myTestName);
            Console.WriteLine(myTestSecondName);

            // Output - myTestName = John & mySecondName = Doe
        }



        static void ModifierExample()
        {
            int test = 14;
            Lesson11 mylesson = new Lesson11();
            mylesson.RefSample(ref test);
            Console.WriteLine(test);
            // Output = 19

            // string first, second;
            // mylesson.OutSample("John Doe", out first, out second);
            // Console.WriteLine(first);
            // Console.WriteLine(second);


        }

        static void ParamsSample()
        {
            Lesson11 lesson = new Lesson11();
            lesson.Useparams(10, 3, 24, 36, 45, 120);

            lesson.Useparams(); //accepts 0 and more agruments, just creates a line when prints

            int[] intArray = { 2, 3, 4, 5, 6 };
            lesson.Useparams(intArray);

            lesson.Useparams2(1, "Happy", false, 34.5F);

            lesson.OptionalParam("Tom");
            lesson.OptionalParam("Ted", 19);

        }

        static void FruitSample()
        {
            Apple myApple = new Apple();
            myApple.EatFruit();

            Fruit myFruit = new Fruit();
            Orange myOrange = new Orange();
            myOrange.EatFruit();

            Apple myApple2 = new Apple();
            myApple2.EatFruit2();

            Fruit myFruit2 = new Fruit();
            Orange myOrange2 = new Orange();
            myOrange2.EatFruit2();

            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "Composite", "Blue");
            ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);

        }

        static void DividesByThree()
        {
            QuizClass1 myQuizClass1 = new QuizClass1();
            myQuizClass1.DividesByThree();
        }




        static void MyGradesSample()
        {
            QuizClass1 myQuizClass1 = new QuizClass1();
            myQuizClass1.SampleGrades(MyGrades.V);
            string _Grade1 = myQuizClass1.SampleGrades(MyGrades.E);
            string _Grade6 = myQuizClass1.SampleGrades(MyGrades.NA);
            Console.WriteLine(_Grade1);
            Console.WriteLine(_Grade6);

        }


        static void OnlineProductSample()
        {
            OnlineProduct myOnlineProduct = new OnlineProduct("Toybook", "Picture of a a toy book");

            Console.WriteLine(myOnlineProduct.Name);
            Console.WriteLine(myOnlineProduct.Price);
            Console.WriteLine(myOnlineProduct.Picture);
            Console.WriteLine(myOnlineProduct.Dimension);


            myOnlineProduct.Buy(true);

        }

        static void HouseSample()
        {
            House myHouse = new House("concrete", "triple pane");

            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation);

            myHouse.OpenDoor(true);

        }
        static void StructSample()
        {
            BookSample bookSample = new BookSample(4.99m, "Zombie Fallout", "Mark Tufo");

            Console.WriteLine("the book " + bookSample.title + " by " + bookSample.author + " is $" + bookSample.price);

        }

        static void StatementSamples()
        {
            StatementExamples se = new StatementExamples();
            //se.SampleIf();
            //Console.WriteLine(" ");
            //se.SampleIfElse();
            //Console.WriteLine(" ");
            //se.SampleIfChain();
            //Console.WriteLine(" ");
            //se.SampleIfAnd();
            //Console.WriteLine(" ");
            //se.SampleIfOr();
            //Console.WriteLine(" ");
            //se.SampleConditional();
            //Console.WriteLine(" ");
            //se.SampleSwitch(10);
            //Console.WriteLine(" ");
            //se.SampleWhile();
            //Console.WriteLine(" ");
            //se.SampleDoWhile();
            //Console.WriteLine(" ");

            //Console.WriteLine(" ");
            //Console.WriteLine(" ");
            //se.SampleFor();
            //Console.WriteLine(" ");
            //se.SampleForEach();

            //Console.WriteLine(" ");

            //string myString = se.JumpStatementExample("Sunday");
            //Console.WriteLine(myString);

            //Console.WriteLine(" ");

            //string myString1 = se.JumpStatementExample("Saturday");
            //Console.WriteLine(myString1);

            //string myString2 = se.JumpStatementExample("Friday");
            //Console.WriteLine(myString2);

            //Console.WriteLine(" ");

            //string myString3 = se.JumpStatementExample("Tuesday");
            //Console.WriteLine(myString3);

            //Console.WriteLine(" ");

            //string myString4 = se.JumpStatementExample("Monday");
            //Console.WriteLine(myString4);

            //BottlesSong();

            se.SampleDays(DaysOfWeek.Wed);

        }
        static void BottlesSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            string song = beer.BottlesOfBeerSong();
            Console.WriteLine(song);
        }

        static void MyStringExamples()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample
            ("Hello", "C Sharp", "Class");

            Console.WriteLine(words);

            StringTypes myTypes1 = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string mytestwords = myTypes1.StringBuilderExample
            ("Hi", "Second");

            Console.WriteLine(mytestwords);
            myTypes.CharTypeExample();
            myTypes.EscapeExample();
            myTypes.PlaceholderExample();

            myTypes.ArraySample();
            myTypes.MyHouseArray();
            myTypes.MultiArraySample();

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
