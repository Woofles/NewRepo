using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Triples of Latin Letters
//
namespace II_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                char letter_1 = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    char letter_2 = (char)('a' + j);
                    for (int k = 0; k < n; k++)
                    {
                        char letter_3 = (char)('a' + k);
                        Console.WriteLine("{0}{1}{2}",letter_1,letter_2,letter_3);
                    }
                }
            }
        }
    }
}
//#Ragequit
