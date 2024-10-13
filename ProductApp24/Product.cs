using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp24
{
    public class Product
    {
        public static int Counter = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Product(string name, double price, double quantity)
        {
            Id = Counter++;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
