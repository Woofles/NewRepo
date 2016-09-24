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
            int distance = int.Parse(Console.ReadLine());
            int time_hours = int.Parse(Console.ReadLine());
            int time_minutes = int.Parse(Console.ReadLine());
            int time_seconds = int.Parse(Console.ReadLine());
            TimeSpan time = new TimeSpan(time_hours, time_minutes, time_seconds);
            float speed_mps = (float)(distance / time.TotalSeconds);
            float speed_kmph = (float)((distance / 1000) / time.TotalHours);
            float speed_mph = (float)((distance / 1609d) / time.TotalHours);
            Console.WriteLine($"{speed_mps:f6}\n{speed_kmph:f6}\n{speed_mph:f6}");
        }
    }
}
