using System;

namespace LargestNumber
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            string First, Second, Third;
            Console.WriteLine("Largest number of given numbers!");
            GetInput get = new GetInput();
            First = get.GetString();
            Second = get.GetString();
            Third = get.GetString();
            CompareValues LN = new CompareValues();
            string largest = LN.LargestNum(First, Second, Third);
            Console.WriteLine("Largest number of {0} {1} and {2} is : {3}", First, Second, Third, largest);
        }
    }
}
