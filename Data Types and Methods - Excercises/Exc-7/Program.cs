using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Exchange Variable Values
//
namespace Exc_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = int.Parse(Console.ReadLine());
            int var2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:\na = {0}\nb = {1}", var1, var2);
            var1 = var1 + var2;
            var2 = var1 - var2;
            var1 = var1 - var2;
            Console.WriteLine("After:\na = {0}\nb = {1}", var1, var2);
        }
    }
}
