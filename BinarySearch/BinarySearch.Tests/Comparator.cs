using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Tests
{
    public static class Comparator
    {
        public static readonly Func<int, int, int> comparatorForInt32 = delegate (int x, int y)
        {
            if (x == y)
                return 0;

            if (x > y)
                return 1;

            return -1;
        };

        public static readonly Func<Point, Point, int> comparatorForPoint = delegate (Point p1, Point p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y)
                return 0;

            if (p1.X > p2.Y)
                return 1;

            return -1;
        };
    }
}
