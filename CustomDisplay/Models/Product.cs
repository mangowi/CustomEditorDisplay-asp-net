using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace CustomDisplay.Models
{


public class Product
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [DataType(DataType.MultilineText)]
       // [UIHint("PreOrderOrAvailable")]
       [UIHint("DateTimePicker")]
        public DateTime ReleaseDate { get; set; }
        public int ProductId { get; set; }
    }
}