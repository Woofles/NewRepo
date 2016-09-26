using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// *Comparing Floats
/// </summary>
namespace Exc_16
{
    class Program
    {
        static void Main(string[] args)
        {
            float numA = float.Parse(Console.ReadLine());
            float numB = float.Parse(Console.ReadLine());
            decimal diff_AB = (decimal)Math.Abs(numA - numB);
            decimal eps = 0.000005m;
            Console.WriteLine(diff_AB < eps); //Because why not
        }
    }
}
