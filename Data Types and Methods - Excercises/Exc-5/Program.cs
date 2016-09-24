using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Boolean Variable
//
namespace Exc_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = Convert.ToBoolean(Console.ReadLine());
            string output = (input == true) ? "Yes" : "No";
            Console.WriteLine(output);
        }
    }
}
