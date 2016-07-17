using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    /// <summary>
    /// This extension class provides custom generic binary search.
    /// </summary>
    public static class ExtensionArray
    {
        /// <summary>
        /// This method finds index of element by using dichotomy method.
        /// </summary>
        /// <typeparam name="T">Type of element.</typeparam>
        /// <param name="array">Collection which may cantain the element.</param>
        /// <param name="element">Seeking element.</param>
        /// <param name="comparator">Comparison criterion.</param>
        /// <returns></returns>
        public static int BinarySearch<T>(this T[] array, T element, Func<T, T, int> comparator) 
        {
            if(array == null)
                throw new ArgumentNullException(nameof(array));

            if(array.Length == 0)
                throw new ArgumentException("Array can't be empty.");

            if(comparator == null)
                throw new ArgumentNullException(nameof(comparator));

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middleIndex = left + (right - left)/2;

                if (array[middleIndex].Equals(element))
                    return middleIndex;

                if (comparator(element, array[middleIndex]) == 1)
                    left = middleIndex + 1;
                else right = middleIndex - 1;
            }

            return -1;
        }
    }
}
