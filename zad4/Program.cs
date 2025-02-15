using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете основа: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете степен: ");
            int b = int.Parse(Console.ReadLine());
            int result = Power(a, b);
            Console.WriteLine($"{a}^{b} = {result}");
            Console.ReadKey();
        }
        static int Power(int a, int b)
        {
            if (b == 0)
                return 1;
            else
                return a * Power(a, b - 1);
        }
    }
}
