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
            string highestNumberString = string.Concat(longNumString.OrderByDescending(x => x));
            long highestNumber = long.Parse(highestNumberString);
            if (n != highestNumber)
            {
                for (var i = n+1; i <= highestNumber; i++)
                {
                    if (highestNumberString == string.Concat(i.ToString().OrderByDescending(x=>x)))
                    {
                        result = i;
                        break;
                    }
                }
            }
            return result;

        }
    }
}