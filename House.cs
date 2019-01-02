using System;

namespace classwork
{
   // class is a modifier, public can be seen by everybody

    public class House
    {
      // Attributes of a house, the following are fields
        string _foundation;
        string _roof;
        string _window;
        string _door;

        //standard long way of a Property
        public string Foundation 
        {
            get {
                return _foundation;
            }
            set {
                this._foundation = value;
            
            } 
        }
       // shortcut 1 line line of code property + field
        public string Roof { get; set; }
        public string Window 
        {
            get {
                return _window;
            }
            set {
                this._window = value;
            
            } 
        }

       public string PaintDoor { get; set; }

       // Below are methods
        public void OpenDoor()
        {
            Console.WriteLine("The door opens");
        }
        public void CloseDoor()
        {
            Console.WriteLine("The door closes");

        }
    }
}