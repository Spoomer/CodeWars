using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;

namespace CodeWars
{
    public static class Primer
    {
        public static List<int> Primes { get; set; }= new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        
        public static void TestPrimer()
        {
            Stopwatch stopwatch = new Stopwatch();
            bool abgeschlossen = true;
            for (var i = 0; i < 1000; i++)
            {
                int random = RandomNumberGenerator.GetInt32(Int32.MaxValue);
                stopwatch.Start();
                bool isPrime = Primer.IsPrimeBetter(random);
                stopwatch.Stop();
                //Console.WriteLine($"{random} ist {(isPrime ? "eine" : "keine")} Primezahl - Dauer:{stopwatch.ElapsedMilliseconds}");
                if(stopwatch.ElapsedMilliseconds>12000)
                {
                    Console.WriteLine($"{i} von 1000 Tests unter 12 Sek geschafft.");
                    abgeschlossen =false;
                    break;
                }
            }
            if (abgeschlossen==true)
            {
                Console.WriteLine($"1000 Tests in {stopwatch.ElapsedMilliseconds}");
            }
        }
        
        
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            double root = Math.Pow(n, 0.5);
            int rootint = (int)root;
            if (root - Math.Round(root) == 0) return false;
            if (Primes.Contains(n)) return true;
            for (int i = 0; i < Primes.Count; i++)
            {
                if (rootint < Primes[i]) return true;
                if (n % Primes[i] == 0) return false;
            }
            var numbers = Enumerable.Range(Primes.Last(),rootint-Primes.Last()).ToList();
            var checki = new List<int>();

            while (true)
            {
                var multiples = new List<int>();
                int toCheck = numbers.Except(checki).FirstOrDefault();
                if (toCheck == default) break;
                int multiple = 0;
                for (var j = 2; multiple < rootint; j++)
                {
                    multiple = toCheck * j;
                    if (multiple > rootint) break;
                    multiples.Add(multiple);
                }
                checki.Add(toCheck);
                numbers = numbers.Except(multiples).ToList();
            }
            Primes = Primes.Union(numbers).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (n % numbers[i] == 0) return false;
            }
            return true;
        }
        public static bool IsPrimeBetter(int n)
        {
        if (n <= 1)
            return false;
            
        for (int i = 2; i*i <= n; i++)
        {
            if (n % i == 0)
            return false;
        }  
            
        return true;
        }
    }
}