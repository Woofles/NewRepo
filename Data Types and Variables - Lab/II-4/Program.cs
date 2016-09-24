using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Elevator
//
namespace II_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses = n / p;
            if (n%p!=0) { courses++; }
            Console.WriteLine(courses);
        }
    }
}
