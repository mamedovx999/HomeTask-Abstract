﻿using System.Security.AccessControl;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string result;
            int arrayLength;
            do
            {
                Console.WriteLine("Enter array length:");
                result = Console.ReadLine();

            } while (!int.TryParse(result, out arrayLength));
            Book[] list = new Book[arrayLength];

            for (int i = 0; i < list.Length; i++)
            {
                int no;
                string strNo;
                do
                {
                    Console.WriteLine("Enter book number:");
                    strNo = Console.ReadLine();

                } while (!int.TryParse(strNo, out no));

                string name;
                do
                {
                    Console.WriteLine("Enter book name:");
                    name = Console.ReadLine();
                } while (string.IsNullOrEmpty(name));

                int price;
                string strPrice;
                do
                {
                    Console.WriteLine("Enter book price:");
                    strPrice = Console.ReadLine();
                } while (!int.TryParse(strPrice, out price));

                int count;
                string strCount;
                do
                {
                    Console.WriteLine("Enter book count:");
                    strCount = Console.ReadLine();
                } while (!int.TryParse(strCount, out count));

                string genre;
                do
                {
                    Console.WriteLine("Enter book genre:");
                    genre = Console.ReadLine();
                } while (string.IsNullOrEmpty(genre));

                Book book = new Book(no, name, price, count, genre);
                list[i] = book;
            }
            foreach (var item in list)
            {
                Console.WriteLine($"Book Name: {item.Name}");
                Console.WriteLine($"Book Price: {item.Price}");
                Console.WriteLine($"Book Count: {item.Count}");
                Console.WriteLine($"Book Genre: {item.Genre}");
                Console.WriteLine($"Book Number:{item.No}");
            }







        }
    }
    
}
