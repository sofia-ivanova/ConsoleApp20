using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int number = int.Parse(Console.ReadLine());
            int sum = SumDigits(number); // Използваме Math.Abs, за да избегнем проблеми с отрицателни числа
            Console.WriteLine("Сумата на цифрите е: " + sum);
            Console.ReadKey();
        }
        static int SumDigits(int num)
        {
            if (num == 0)
                return 0;
            else
                return (num % 10) + SumDigits(num / 10);
        }
    }
}
