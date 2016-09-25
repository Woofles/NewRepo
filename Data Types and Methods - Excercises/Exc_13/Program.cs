using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Vowel or Digit
//
namespace Exc_13
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if ((input == 'a') || (input == 'e') || (input == 'i') || (input == 'o') || (input == 'u'))
            {
                Console.WriteLine("vowel");
            }
            else if (input >= 48 && input <= 57)
            {
                Console.WriteLine("digit");
            }
            else { Console.WriteLine("other"); }
        }
    }
}
