using System.Collections;
using System.Collections.Generic;
using System;
namespace Lessons
{
    public class CollectionExamples
    {

        public void MyListExample()
        {
            List<Dinosaur> myDino = new List<Dinosaur>();
            myDino.Add(new TRex());

            myDino.Add(new TRex() { Travel = "Stomp" });
            myDino.Add(new Triceratops() { Travel = "Trample" });

            myDino.Add(new Teradactyl());
            myDino.Add(new Teradactyl() { Travel = "Fly" });



            foreach (Dinosaur dino in myDino)
            {
                Console.WriteLine("These dinos travel by {0}", dino.Travel);

                Console.WriteLine(dino);
            }
        }

        public void MyArrayListExample()
        {
            ArrayList MyArrayList = new ArrayList();
            MyArrayList.Add("hello");
            MyArrayList.Add("World");
            MyArrayList.Add(42);
            MyArrayList.Add(84);

            Console.WriteLine("Count = {0}", MyArrayList.Count);

            Console.WriteLine(" ");

            MyArrayList.Remove(42);
            MyArrayList.RemoveAt(0);

            Console.WriteLine("Count = " + MyArrayList.Count);

            Console.WriteLine(" ");


            MyArrayList.Add("Other");
            MyArrayList.Add("Stuff");

            foreach (Object item in MyArrayList)
            {
                Console.WriteLine("Type = {0}", item);
            }

        }
    }
}