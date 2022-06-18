using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fda.Katas.VowelCount
{
    public static class Kata
    {
        public static char[] _vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            vowelCount = str.ToCharArray().Count(charac => _vowels.Contains(charac));

            return vowelCount;
        }

        public static int GetVowelCountBestSolution(string str) => str.Count(i => "aeiou".Contains(i));
    }
}
