using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Book: product
    {
        public string Genre { get; set; }
        

        public Book(int No , string Name , int price, int count,string genre):base (No, Name, price, count)
        {
            Genre = genre;
        }
    }
}
