using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Special Numbers
//
namespace II_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int copy_i = i;
                while (copy_i != 0)
                {
                    sum += copy_i % 10;
                    copy_i /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine(i + " -> True");
                }
                else { Console.WriteLine(i + " -> False"); }
            }
        }
    }
}
