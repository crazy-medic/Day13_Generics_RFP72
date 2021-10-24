using System;
using System.Collections.Generic;
using System.Text;

namespace LargestNumber
{
    public class CompareValues<T> where T : IComparable
    {
        public T[] value;
        public CompareValues(T[] value)
        {
            this.value = value;
        }
        public T[] Sorting(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var SortedArray = Sorting(values);
            return SortedArray[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintingMaximumValue()
        {
            var maximum = MaxValue(this.value);
            Console.WriteLine("The max of the values is : " + maximum);
        }
    }
}
