using System.Reflection.Emit;
using System.Diagnostics;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("21 = "+NextBiggerNumber.GetNextBiggerNumber(12));
            Console.WriteLine("531 = "+ NextBiggerNumber.GetNextBiggerNumber(513));
            Console.WriteLine("2071 = "+NextBiggerNumber.GetNextBiggerNumber(2017));
            Console.WriteLine("441 = "+NextBiggerNumber.GetNextBiggerNumber(414));
            Console.WriteLine("414 = "+NextBiggerNumber.GetNextBiggerNumber(144));
        }
        
    }
}
