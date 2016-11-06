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
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());
            decimal diff_AB = (decimal)Math.Abs(numA - numB);
            decimal eps = 0.000001m;
            Console.WriteLine(diff_AB < eps); //Because why not
        }
    }
}
