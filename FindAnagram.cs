using System.Collections.Generic;
using System.Linq;
namespace CodeWars
{
    public static class FindAnagram
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> result = new List<string>();
            string sortedWord = string.Concat(word.OrderBy(x => x));
            foreach (var ele in words)
            {
                if (string.Concat(ele.OrderBy(x=>x)) == sortedWord)
                {
                    result.Add(ele);
                }
            }
            return result;
        }
    }
}