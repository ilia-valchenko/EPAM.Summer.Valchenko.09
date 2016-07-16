using System;
using NUnit.Framework;

namespace BinarySearch.Tests
{
    [TestFixture]
    public class BinarySearch_Tests
    {
        [TestCase(new int[] { 7, 12, 6, 9, 4, 0, 0, 3, 1 }, 4, TestName = "FindElement4ExpectedIndex4", ExpectedResult = 4)]
        [TestCase(new int[] { 7, 12, 6, 9, 4, 0, 0, 3, 1 }, 12, TestName = "FindElement12ExpectedIndex8", ExpectedResult = 8)]
        [TestCase(new int[] { 7, 12, 6, 9, 4, 0, 0, 3, 1 }, 7, TestName = "FindElement7ExpectedIndex6", ExpectedResult = 6)]
        [TestCase(new int[] { }, 7, TestName = "FindingElementInEmptyArray", ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 7, TestName = "FindingElementInNullArray", ExpectedException = typeof(ArgumentNullException))]
        public int FindingInt32ElementTest(int[] array, int element)
        {
            Array.Sort(array);
            return array.BinarySearch(element, Comparator.comparatorForInt32);
        }

        [TestCase(TestName = "FindPoint", ExpectedResult = 2)]
        public int FindingPointTest()
        {
            Point[] points =
            {
                new Point(0, 1),
                new Point(1, 1),
                new Point(3, 2),
                new Point(9, 1),
                new Point(9, 4)
            };

            Point element = new Point(3,2);

            return points.BinarySearch(element, Comparator.comparatorForPoint);
        }
    }
}
