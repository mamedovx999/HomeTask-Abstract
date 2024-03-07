using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_Abstract
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }


        public Product()
        {

        }
        public Product(string name, int price, int count)
        {
            
            Name = name;
            Price = price;
            Count = count;
        }

        public string Detail()
        {
            return $" Name: {Name}, Price: {Price}, Count: {Count}";
        }

        public void Discount(int discountRate)
        {
            Console.WriteLine(Price-(Price*discountRate)/100);
        }
    }
}
