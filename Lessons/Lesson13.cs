using System;
namespace Lessons
{
    public class Lesson13
    {
        string _firstName, _lastName;

        //passing variables in
        public Lesson13(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            Console.WriteLine("Constructor Called");
        }

        //pulling variables out, reverse of constructor
        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = this._firstName;
            lastName = this._lastName;
            Console.WriteLine("Deconstruct Called");
        }
    }
}