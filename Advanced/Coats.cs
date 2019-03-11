﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public delegate string MyCoat(string message);

    public class Coats
    {
        public event MyCoat MyEventCoat;

        //property, private set
        public string MyResult { get; private set; }

        //default constructor

        public Coats()
        {
            this.MyEventCoat += new MyCoat(this.MyFavoriteCoat);
            MyResult = MyEventCoat("Trench");

        }

        public string MyFavoriteCoat(string message)
        {
            return "My favorite coat is " + message;
        }
    }
}
