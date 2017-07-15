using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace CustomDisplay.Models
{


public class Product
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ProductId { get; set; }
    }
}