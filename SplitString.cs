using System;
using System.Linq;
namespace CodeWars
{
    public static class SplitString
    {
        public static string[] Solution(string str)
        {
            string[] result = new string[(int)Math.Ceiling(str.Length/2.0)];
            int position = 0;
            var strEnum = str.GetEnumerator();
            while (strEnum.MoveNext())
            {
                char char1 = strEnum.Current;
                if (strEnum.MoveNext())
                {
                    result[position] = string.Concat(char1, strEnum.Current);
                }
                else
                {
                    result[position] = string.Concat(char1, '_');
                }
                position++;
            }

            return result;
        }
    }
}