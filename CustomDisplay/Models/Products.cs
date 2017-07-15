using System;
using System.Collections.Generic;

namespace CustomDisplay.Models
{
    public static  class Products
    {


        public static List<Product> GetProducts()
        {
            var products = new List<Product>
                {
                   new Product {Name = "Bada", Price = 24.9M, ReleaseDate = DateTime.Parse("12/10/1993")},
                   new Product {Name = "Wada", Price = 2.9M, ReleaseDate = DateTime.Parse("11/10/2014")},
                   new Product {Name = "Tada", Price = 0.9M, ReleaseDate = DateTime.Parse("2/10/2000")},
                   new Product {Name = "Vada", Price = 8.9M, ReleaseDate = DateTime.Parse("12/10/1993")},
                   new Product {Name = "Fada", Price = 12.9M, ReleaseDate = DateTime.Parse("12/10/1993")},
                   new Product {Name = "Sada", Price = 2.9M, ReleaseDate = DateTime.Parse("12/10/1993")},
                   new Product {Name = "Qada", Price = 4.9M, ReleaseDate = DateTime.Parse("12/10/1993")}

                };
          return  products;

        }



    }
}