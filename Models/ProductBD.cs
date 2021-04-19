using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoppingmaschinen.Models
{
    public class ProductBD
    {
        public static List<Product>  Products = new List<Product>
            {
                new Product()
                {
                    id = 0,
                    name = "Шоколад",
                    price = 13,
                    rest = 10
                },

                new Product()
                {
                    id = 1,
                    name = "печенье",
                    price = 18,
                    rest = 20
                },

                new Product()
                {
                    id = 2,
                    name = "чай",
                    price = 21,
                    rest = 20
                },


                new Product()
                {
                    id = 3,
                    name = "Кофе",
                    price = 35,
                    rest = 15
                }
            };

    }
}