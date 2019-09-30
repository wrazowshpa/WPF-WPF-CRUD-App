using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Electronics 
    {
        public string Item { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
        /*
        public Electronics(string item, double price)
        {
            Item = Item;
            Price = Price;
        }
        */
    }
}
