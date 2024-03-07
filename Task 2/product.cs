using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class product
    {
        public int  No { get; set; }
        public string  Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }


        public product(int no, string name, int price, int count)
        {
            No = no;
            Name = name;
            Price = price;
            Count = count;
        }

    }
}
