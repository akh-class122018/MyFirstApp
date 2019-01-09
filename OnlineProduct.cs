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
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }

        public string Picture
        {
            get
            {
                return _picture;
            }
            set
            {
                this._picture = value;
            }
        }

        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                this._price = value;
            }
        }




        // shortcut 1 line line of code property + field

        public string Dimension { get; set; }

        public string Description { get; set; }

        public OnlineProduct() { }

        public OnlineProduct(string name, string picture)
        {
            this._name = name;
            this._picture = picture;
            this.Price = "5 dollars";
            this.Dimension = "5 inch by 6 inch";
        }

        public OnlineProduct(string name, string picture, string price, string dimension, string description)
        {
            this._name = name;
            this._picture = picture;
            this.Price = price;
            this.Dimension = dimension;
            this.Description = description;
        }

        public void Buy()
        {
            Console.WriteLine("Product was bought");
        }

        //overload
        public void Buy(bool paidWithCC)
        {
            if (paidWithCC)
            {
                Console.WriteLine("Product was bought with Credit Card");

            }
            else
                Console.WriteLine("Product was bought with Other Payment");
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