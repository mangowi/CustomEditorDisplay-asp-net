using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomDisplay.Models
{
    public class MyProductDbContext : DbContext
    {


        public MyProductDbContext() : base("name = CustomDispalyProduct")
        {
            
        }

        public  virtual  DbSet<Product> Products { get; set; }
    }
}