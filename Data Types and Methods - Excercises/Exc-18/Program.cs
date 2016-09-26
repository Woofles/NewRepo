using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// *Different Integers Size
/// sbyte < byte < short < ushort < int < uint < long
/// </summary>
namespace Exc_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //
            sbyte dummy_sbyte;
            byte dummy_byte;
            short dummy_short;
            ushort dummy_ushort;
            int dummy_int;
            uint dummy_uint;
            long dummy_long;
            //
            if (long.TryParse(input,out dummy_long))
            {
                Console.WriteLine(input + " can fit in:");
                if (sbyte.TryParse(input,out dummy_sbyte)) { Console.WriteLine("* sbyte"); }
                if (byte.TryParse(input, out dummy_byte)) { Console.WriteLine("* byte"); }
                if (short.TryParse(input, out dummy_short)) { Console.WriteLine("* short"); }
                if (ushort.TryParse(input, out dummy_ushort)) { Console.WriteLine("* ushort"); }
                if (int.TryParse(input, out dummy_int)) { Console.WriteLine("* int"); }
                if (uint.TryParse(input, out dummy_uint)) { Console.WriteLine("* uint"); }
                Console.WriteLine("* long"); //...obviously.
            }
            else
            {
                Console.WriteLine(input + " can't fit in any type"); // Because of previous comment.
            }
        }
    }
}
