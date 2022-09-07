using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pls write second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int max = a > b ? a : b;
        }
    }
}
