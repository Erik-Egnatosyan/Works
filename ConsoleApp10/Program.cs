using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Pls write the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[n];
            for (int i = 0; i < number.Length; i++)
            {
                int newNum = rnd.Next(1, 9);
                number[i] = newNum;
                Console.Write($" {number[i]} ");
            }
            Console.WriteLine();
            if (n % 2 == 0)
            {
                Console.WriteLine("Pls try another number");
            }
            else if (n % 2 != 0)
            {
                int Enum = (number.Length / 2);
                Console.WriteLine($"Your media number is: {number[Enum]} ");
            }
        }
    }
}
