using System;

namespace LargestNumber
{
    class Program
    {
        public int a;
        public double b;
        public string c;
        public static void Main(string[] args)
        {
            CompareValues<int> obj1 = new CompareValues<int>(10, 20, 30);
            CompareValues<double> obj2 = new CompareValues<double>(12.3, 23.4, 34.50);
            CompareValues<string> obj3 = new CompareValues<string>("abc", "bca", "cba");
            int a = obj1.MaxMethod();
            Console.WriteLine(a);
            double b = obj2.MaxMethod();
            Console.WriteLine(b);
            string c = obj3.MaxMethod();
            Console.WriteLine(c);
        }
    }
}
