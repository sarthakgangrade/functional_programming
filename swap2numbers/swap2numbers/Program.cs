using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap2numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = 0;
            int SecondNumber = 0;
            int temp = 0;
            Console.Write("Enter First Number: ");
            FirstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            SecondNumber = int.Parse(Console.ReadLine());

            temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = temp;

            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + FirstNumber);
            Console.WriteLine("Second Number : " + SecondNumber);
        }
    }
}
