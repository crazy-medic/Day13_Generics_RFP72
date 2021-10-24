using System;
using System.Collections.Generic;
using System.Text;

namespace LargestNumber
{
    public class CompareValues<T> where T : IComparable
    {
        public T first, second, third;
        public CompareValues(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T MaxValue(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            return default;
        }
        public T MaxMethod()
        {
            T max = CompareValues<T>.MaxValue(this.first, this.second, this.third);
            return max;
        }
    }
}
