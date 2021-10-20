using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargetAmongThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1;
            int Number2;
            int Number3;

            Console.Write("Input the 1st number :");
            Number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the  2nd number :");
            Number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 3rd  number :");
            Number3 = Convert.ToInt32(Console.ReadLine());

            if (Number1 > Number2)
            {
                if (Number1 > Number3)

                    Console.Write("The 1st Number is the greatest among three. \n\n");
                else
                    Console.Write("The 3rd Number is the greatest among three. \n\n");

            }
            else if (Number2 > Number3)
                Console.Write("The 2nd Number is the greatest among three. \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three. \n\n");
        }
    }
}
