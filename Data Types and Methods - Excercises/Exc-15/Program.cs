using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Fast Prime Checker - Refactor
//
/// <summary>
//int ___Do___ = int.Parse(Console.ReadLine());
//for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
//{
//    bool TowaLIE = true;
//    for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
//    {
//        if (DAVIDIM % delio == 0)
//        {
//            TowaLIE = false;
//            break;
//        }
//    }
//    Console.WriteLine($"{DAVIDIM} is prime -> {TowaLIE}");
//}
/// </summary>
namespace Exc_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_upperLimit = int.Parse(Console.ReadLine());
            for (int num_toCheck = 2; num_toCheck <= num_upperLimit; num_toCheck++)
            {
                bool num_isPrime = true;
                for (int factor = 2; factor <= Math.Sqrt(num_toCheck); factor++)
                {
                    if (num_toCheck % factor == 0)
                    {
                        num_isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num_toCheck} -> {num_isPrime}");
            }
        }
    }
}
