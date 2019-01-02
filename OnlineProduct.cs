using System;

namespace classwork
{
    public class OnlineProduct

    {
        string _name;
        string _picture;
        string _price;
        string _dimension;
        string _description;

        //standard long way of a Property
        public string Name {
            get {
                return _name;
            }
            set {
                this._name = value;
            } 
        }

        public string Picture {
            get {
                return _picture;
            }
            set {
                this._picture = value;
            }
        }

        public string Price {
            get {
                return _price;
            }
            set {
                this._price = value;
            }
        }




       // shortcut 1 line line of code property + field

        public string Dimension { get; set; }

        public string Description { get; set; }

        public void Buy()
        {
            Console.WriteLine("Product was bought");
        }
        public void Return()
        {
            Console.WriteLine("Product was returned");

        }
        public void Like()
        {
            Console.WriteLine("Product was liked");

        }
        public void SaveForLater()
        {
            Console.WriteLine("Product has been saved for later");

        }

        public void AddToWatchList()
        {
            Console.WriteLine("Product has been added to Watchlist");
        }

        public void PrepareForShipping()
        {
            Console.WriteLine("Product has been prepared for shipping");

        }
   
    }
}