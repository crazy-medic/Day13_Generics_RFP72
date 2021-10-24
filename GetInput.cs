using System;
using System.Collections.Generic;
using System.Text;

namespace LargestNumber
{
    class GetInput
    {
        
        public int GetInt()
        {
            Console.WriteLine("Enter any integer number");
            return(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
