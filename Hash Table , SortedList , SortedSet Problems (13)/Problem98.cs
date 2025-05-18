using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem98
    {
        //Problem 98: Organize Movie Showtimes.

        static void Main1()
        {

            // Create a dictionary to store movie showtimes
           SortedList<string, List<DateTime>> movieShowtimes = new SortedList<string, List<DateTime>>();

            // Add movie showtimes
            movieShowtimes.Add("Movie A", new List<DateTime> { new DateTime(2023, 10, 1, 14, 0, 0), new DateTime(2023, 10, 1, 18, 0, 0) });
            movieShowtimes.Add("Movie B", new List<DateTime> { new DateTime(2023, 10, 1, 16, 0, 0), new DateTime(2023, 10, 1, 20, 0, 0) });
            movieShowtimes.Add("Movie C", new List<DateTime> { new DateTime(2023, 10, 1, 15, 0, 0), new DateTime(2023, 10, 1, 19, 0, 0) });
            // Display the showtimes for each movie

            foreach (var movie in movieShowtimes)
            {
                Console.WriteLine($"Showtimes for {movie.Key}:");
                foreach (var showtime in movie.Value)
                {
                    Console.WriteLine($"- {showtime.ToString("yyyy-MM-dd HH:mm")}");
                }
            }
        }

    }
}
