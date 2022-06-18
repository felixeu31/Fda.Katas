namespace Fda.Katas.MiddleCharacter
{
    public static class StringExtensions
    {
        public static bool IsEven(this string? input)
        {
            if (input == null)
                return false;
            
            if (input.Trim().Equals(string.Empty))
                return true;

            if (input.Length % 2 == 0)
                return true;
            
            return false;
        }
    }
}