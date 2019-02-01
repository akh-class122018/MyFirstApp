using System;

namespace classwork
{
    // class is a modifier, public can be seen by everybody

    public class House
    {
        // Attributes of a house, the following are fields
        string _foundation;
        string _roof;
        // default value added "double pane"
        string _window = "double pane";
        string _door;

        //standard long way of a Property
        public string Foundation
        {
            get
            {
                return _foundation;
            }
            set
            {
                this._foundation = value;

            }
        }
        // shortcut 1 line line of code property + field; Auto Property        
        // public string Roof { get; set; }

        // add default value/definition to auto property "Composite"
        public string Roof { get; set; } = "Composite";


        public string Window
        {
            get
            {
                return _window;
            }
            set
            {
                this._window = value;

            }
        }

        public string PaintDoor { get; set; }

        public House() { }

        // these fields need to be assigned Roof = "shingles"; PaintDoor = "Green";

        //orinal house file
        //public House(string foundation, string window)

        //{
        //this._foundation = foundation;
        // this._window = window;
        // this.Roof = "shingles";
        //this.PaintDoor = "Green";
        // }

        /*this runs below constructor :shingles, green are default constructor */
        public House(string foundation, string window)
        : this(foundation, window, "shingles", "Green")
        {

        }


        // doorPaint renamed on purpose so it is not confuse, roof and paintdoor are assinged in my parameter
        public House(string foundation, string window, string roof, string doorPaint)

        {
            this._foundation = foundation;
            this._window = window;
            this.Roof = roof;
            this.PaintDoor = doorPaint;

        }


        // Below are methods
        public void OpenDoor()
        {
            Console.WriteLine("The door opens");
        }

        // overload declare method with the same name but signature is different
        public void OpenDoor(bool isExterior)
        {
            if (isExterior)
            {
                Console.WriteLine("Open front door.");
            }
            else
            {
                Console.WriteLine("Open Bedroom door.");
            }
        }

        public void CloseDoor()
        {
            Console.WriteLine("The door closes");

        }




    }
}