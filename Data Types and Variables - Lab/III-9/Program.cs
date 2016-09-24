using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Refactor Special Numbers
//
namespace III_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int current = 1; current <= input; current++)
            {
                int sum = 0;
                int copy_current = current;
                while (current > 0)
                {
                    sum += current % 10;
                    current = current / 10;
                }
                bool status = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{copy_current} -> {status}");
                //if we used the copy inside while() this whould have been useless...
                current = copy_current;
            }
        }
    }
}
