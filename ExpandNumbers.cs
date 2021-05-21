using System.Collections.Generic;
using System.Linq;
using System;
namespace CodeWars
{
    public static class ExpandNumbers
    {
        public static string ExpandedForm(long num) 
        {
            string result = string.Empty;
            string numString = num.ToString();
            List<string> expandedNumStrings = new List<string>();
            for (var i = 0; i < numString.Length; i++)
            {
                if (numString[i] =='0')
                {
                    continue;
                }
                
                long longNum = long.Parse(numString[i].ToString()) * (long)Math.Pow(10, numString.Length - (i + 1));
                expandedNumStrings.Add(longNum.ToString());
            }
            result = String.Join(" + ", expandedNumStrings);
            return result;
        }
    }
}