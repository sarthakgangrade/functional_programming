using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to check Even Or Odd");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + "The Number Even");
            }
            else
            {
                Console.WriteLine(number + "The number is Odd");
            }
        }
    }
}
