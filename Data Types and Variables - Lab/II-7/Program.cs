using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Greeting
//
namespace II_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name_first = Console.ReadLine();
            string name_last = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {name_first} {name_last}.\r\nYou are {age} years old.");
        }
    }
}
