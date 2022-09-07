using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] medium = new int[11];
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("Write num: ");
                int numbers = Convert.ToInt32(Console.ReadLine());
                medium[count] = numbers;
                count++;
                if (numbers == 0)
                {
                    break;
                }
            }
            int sum = 0;
            int countnum = 0;
            foreach (int n in medium)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    countnum++;
                }
            }
            double average = (double)sum / countnum;
            Console.WriteLine(average);
        }
    }
}
