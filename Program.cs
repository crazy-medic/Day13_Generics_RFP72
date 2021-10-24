using System;

namespace LargestNumber
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            double First, Second, Third;
            Console.WriteLine("Largest number of given numbers!");
            GetInput get = new GetInput();
            First = get.GetDouble();
            Second = get.GetDouble();
            Third = get.GetDouble();
            CompareValues LN = new CompareValues();
            double largest = LN.LargestNum(First, Second, Third);
            Console.WriteLine("Largest number of {0} {1} and {2} is : {3}", First, Second, Third, largest);
        }
    }
}
