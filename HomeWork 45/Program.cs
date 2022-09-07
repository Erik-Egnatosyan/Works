using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write the fibonachi legnth: ");
            int fibLength = Convert.ToInt32(Console.ReadLine());
            int[] fibNumbers = new int[fibLength + 2];
            int a0 = 0;
            int a1 = 1;

            fibNumbers[0] = a0;
            fibNumbers[1] = a1;

            for (int i = 2; i < fibLength + 2; i++)
            {
                int numbers = a0 += a1;
                fibNumbers[i] = numbers;

                a0 = a1;
                a1 = numbers;
                Console.WriteLine(fibNumbers[i]);
            }
        }
    }
}
