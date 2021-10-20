using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelorConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char Alphabet;
            Console.WriteLine("Enter a Alphabet To Check whether Vowel or Consonent");
            Alphabet = Convert.ToChar(Console.ReadLine());

            if (Alphabet == 'a' | Alphabet == 'A' | Alphabet == 'e' | Alphabet == 'E' | Alphabet == 'i' | Alphabet == 'I' | Alphabet == 'o' | Alphabet == 'O' | Alphabet == 'u' | Alphabet == 'U')
            {
                Console.WriteLine("Given" + " " + Alphabet + " is a Vowel");
            }
            else
            {
                Console.WriteLine("Given" + " " + Alphabet + " is a Consonent");
            }
        }
    }
}
