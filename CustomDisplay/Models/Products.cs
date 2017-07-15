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
                   new Product {Name = "Bada", Price = 24.9M, ProductId = 1, ReleaseDate = DateTime.Parse("12/10/2093")},
                   new Product {Name = "Wada", Price = 2.9M, ProductId = 2, ReleaseDate = DateTime.Parse("11/10/1024")},
                   new Product {Name = "Tada", Price = 0.9M, ProductId = 3, ReleaseDate = DateTime.Parse("2/10/2050")},
                   new Product {Name = "Vada", Price = 8.9M,ProductId = 4,ReleaseDate = DateTime.Parse("12/10/1993")},
                   new Product {Name = "Fada", Price = 12.9M, ProductId = 5, ReleaseDate = DateTime.Parse("12/10/1993")},
                   new Product {Name = "Sada", Price = 2.9M, ProductId = 6, ReleaseDate = DateTime.Parse("12/10/1993")},
                   new Product {Name = "Qada", Price = 4.9M, ProductId = 7, ReleaseDate = DateTime.Parse("12/10/2093")}

                };
          return  products;

        }



    }
}