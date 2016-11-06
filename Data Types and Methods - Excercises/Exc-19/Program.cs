using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// * Thea the Photographer
/// </summary>
namespace Exc_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_pictures = int.Parse(Console.ReadLine());
            int filter_time = int.Parse(Console.ReadLine());
            int filter_factor = int.Parse(Console.ReadLine());
            int upload_time = int.Parse(Console.ReadLine());
            //
            double percent = filter_factor / 100.0;
            int pictures_filtered = (int)Math.Ceiling(total_pictures * percent);

            long time_filter = total_pictures * (long)filter_time;
            long time_upload = pictures_filtered * (long)upload_time;

            long total_time = time_filter + time_upload;
            Console.WriteLine(TimeSpan.FromSeconds(total_time).ToString(@"d\:hh\:mm\:mm"));
        }
    }
}
