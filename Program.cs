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
            Console.WriteLine(NextBiggerNumber.GetNextBiggerNumber(12));
            Console.WriteLine(NextBiggerNumber.GetNextBiggerNumber(513));
            Console.WriteLine(NextBiggerNumber.GetNextBiggerNumber(2017));
            Console.WriteLine(NextBiggerNumber.GetNextBiggerNumber(414));
            Console.WriteLine(NextBiggerNumber.GetNextBiggerNumber(144));
        }
        
    }
}
