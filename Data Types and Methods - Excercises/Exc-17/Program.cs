using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Print Part of the ASCII Table
/// </summary>
namespace Exc_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int char_first = int.Parse(Console.ReadLine());
            int char_last = int.Parse(Console.ReadLine());
            for (int i = char_first; i <= char_last; i++)
            {
                Console.Write((char)i+" ");
            }
            Console.WriteLine();
        }
    }
}
