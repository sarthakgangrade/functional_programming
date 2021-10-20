using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coinflip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of times to flipcoin");
            int NumberOfFlips = int.Parse(Console.ReadLine());

            int HeadCount = 0;
            int TailCount = 0;
            int HeadPercentage = 0;
            int TailPercentage = 0;

            for (int i = 0; i < NumberOfFlips; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(2);

                if (randomNumber == 1)
                {
                    HeadCount++;
                }
                else if (randomNumber == 0)
                {
                    TailCount++;
                }

                Console.WriteLine("Head Counts: " + HeadCount);
                Console.WriteLine("Tail Counts: " + TailCount);
                Console.WriteLine("Flips : " + NumberOfFlips);

                HeadPercentage = ((HeadCount * 100) / NumberOfFlips);
                TailPercentage = ((TailCount * 100) / NumberOfFlips);

                Console.WriteLine("Head Percentage is : " + HeadPercentage);
                Console.WriteLine("Tail Percentage is : " + TailPercentage);
            }
        }
    }
}
