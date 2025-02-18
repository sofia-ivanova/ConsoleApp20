using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books =
        {
            new Book("Метро 2033", "Дмитрий Глуховски"),
            new Book("1984", "Джордж Оруел"),
            new Book("Престъпление и наказание", "Ф. Достоевски"),
            new Book("Алиса в страната на чудесата", "Луис Карол")
        };
            int n = books.Length;
            for (int i = 0; i < n-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if (books[j].Title[0] < books[minIndex].Title[0])
                    {
                        minIndex = j;
                    }
                    (books[i], books[minIndex]) = (books[minIndex], books[i]);
                }
            }
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.ReadKey();
        }
    }
}
