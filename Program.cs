using System;

namespace LargestNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            CompareValues<int> gen = new CompareValues<int>(arr);
            gen.PrintingMaximumValue();
        }
    }
}