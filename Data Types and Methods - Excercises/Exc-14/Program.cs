using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Integer to Hex and Binary
//
namespace Exc_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(input, 16).ToUpper());
            Console.WriteLine(Convert.ToString(input, 2));
        }
    }
}
