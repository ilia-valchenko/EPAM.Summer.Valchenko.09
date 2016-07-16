using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearch.Tests;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points =
            {
                new Point(3, 2),
                new Point(9, 4),
                new Point(0, 1),
                new Point(9, 1),
                new Point(1, 1)
            };

            Array.Sort(points);

            foreach (var VARIABLE in points)
            {
                Console.Write(VARIABLE + " ");
            }

            Console.WriteLine("\n\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
