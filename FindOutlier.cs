using System.Collections.Generic;
using System.Linq;
using System;

namespace CodeWars
{
    public static class FindOutlier
    {
        public static int Find(int[] integers)
        {
            int result = 0;
            var sample = integers.Take(3);
            bool outlierIsEven = sample.Where(x => x % 2 == 0).Count() < 2;
            if(outlierIsEven)
            {
                foreach (var ele in integers)
                {
                    if (ele % 2 == 0)
                    {
                        result = ele;
                        break;
                    }
                }
            }
            else
            {
                foreach (var ele in integers)
                {
                    if (ele % 2 != 0)
                    {
                        result = ele;
                        break;
                    }
                }
            }
            return result;


        }
    }
}