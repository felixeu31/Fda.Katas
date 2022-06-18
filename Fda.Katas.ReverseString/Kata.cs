using System.Text;

namespace Fda.Katas.ReverseString
{
    public static class Kata
    {
        public static string Solution(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            StringBuilder solution = new StringBuilder();
            for (var i = str.Length - 1; i >= 0; i--)
            {
                solution.Append(str[i]);
            }

            return solution.ToString();
        }
    }
}