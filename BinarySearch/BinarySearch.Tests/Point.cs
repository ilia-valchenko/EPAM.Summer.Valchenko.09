using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Tests
{
    public class Point : IComparer<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point other)
        {
            if (other == null)
                return false;

            if (this.X == other.X && this.Y == other.Y)
                return true;

            return false;
        }

        public int Compare(Point p1, Point p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y)
                return 0;

            if (p1.X == p2.X)
            {
                if (p2.Y > p2.Y)
                    return 1;
            }
            else
            {
                if (p1.X > p2.X)
                    return 1;
            }
                

            return -1;
        }

        public override bool Equals(object obj) => this.Equals(obj as Point);

        public override string ToString() => $"X: {X}, Y: {Y}";
    }
}
