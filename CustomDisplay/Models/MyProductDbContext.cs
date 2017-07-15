using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomDisplay.Models
{
    public class MyProductDbContext : DbContext
    {


        public MyProductDbContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True;Pooling=False")
        {
            
        }

        public  virtual  DbSet<Product> Products { get; set; }
    }
}