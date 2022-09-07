using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Pls write the Length: ");
            int leng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pls write the Width: ");
            int widt = Convert.ToInt32(Console.ReadLine());
            int[,] number = new int[leng,widt];
            int sum = 0;
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    int newNum = rnd.Next(1, 9);
                    number[i,j] = newNum;
                    Console.Write($" {number[i,j]} ");
                    sum += number[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);
        }
    }
}
