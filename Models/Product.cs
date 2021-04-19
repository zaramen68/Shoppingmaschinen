using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoppingmaschinen.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int rest { get; set; }
        public void Buy()
        {
            rest = rest - 1;
        }
    }
}