using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double power = 0;
            Console.WriteLine("Enter the Number to calculate Power of Two");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if (number < 31)
                {
                    power = Math.Pow(2, number);
                }
                else
                {
                    Console.WriteLine("Over Flow");
                }
            }

            Console.WriteLine(power);
        }
    }
}
