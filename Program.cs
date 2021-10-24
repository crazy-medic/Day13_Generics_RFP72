using System;

namespace LargestNumber
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            int First, Second, Third;
            Console.WriteLine("Largest number of given numbers!");
            GetInput get = new GetInput();
            First = get.GetInt();
            Second = get.GetInt();
            Third = get.GetInt();
            CompareValues LN = new CompareValues();
            int largest = LN.LargestNum(First, Second, Third);
            Console.WriteLine("Largest number of {0} {1} and {2} is : {3}", First, Second, Third, largest);
        }
    }
}
