using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Convert Speed Units
//
namespace Exc_11
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float time_hours = float.Parse(Console.ReadLine());
            float time_minutes = float.Parse(Console.ReadLine());
            float time_seconds = float.Parse(Console.ReadLine());

            float time_total_seconds = (time_hours * 60 * 60) + (time_minutes * 60) + time_seconds;

            float speed_mps = distance /time_total_seconds;
            float speed_kmph = (distance /1000f) / (time_total_seconds/3600f);
            float speed_mph = (distance / 1609.0f) / (time_hours + time_minutes/ 60.0f + time_seconds/ 3600.0f);
            Console.WriteLine($"{speed_mps}\n{speed_kmph}\n{speed_mph}");
        }
    }
}
