using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Rectangle Properties
//
namespace Exc_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double square_side_a = double.Parse(Console.ReadLine());
            double square_side_b = double.Parse(Console.ReadLine());
            double square_perimeter = (square_side_a + square_side_b) * 2f;
            double square_area = square_side_a * square_side_b;
            double square_diagonal = Math.Sqrt(square_side_a * square_side_a + square_side_b * square_side_b);
            Console.WriteLine($"{square_perimeter}\n{square_area}\n{square_diagonal}");
        }
    }
}
