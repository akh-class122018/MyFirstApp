using System;
namespace Lessons
{
    public class FinalizerExample
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public FinalizerExample(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        ~FinalizerExample()
        {
            //Console.WriteLine("Finalizer called");
            System.Diagnostics.Trace.WriteLine("Finalizing is called");
        }

    }
}