using System.Linq;

namespace CodeWars
{
    public static class NextBiggerNumber
    {
        //2301
        public static long GetNextBiggerNumber(long n)
        {
            long result = -1L;
            string longNumString = n.ToString();
            long highestNumber = long.Parse(string.Concat(longNumString.OrderByDescending(x => x)));
            if (n != highestNumber)
            {
                for (int i = longNumString.Length - 1, j = 2; i > 0; i -= 2, j++)
                {
                    string newLongNumString = longNumString.Substring(0, longNumString.Length - j)
                                            + string.Concat(longNumString.Substring(i - 1, j).OrderByDescending(x => x));

                    if (long.Parse(newLongNumString) > n)
                    {
                        result = long.Parse(newLongNumString);
                        break;
                    }
                    
                }
            }
            return result;

        }
    }
}