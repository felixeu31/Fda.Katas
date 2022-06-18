namespace Fda.Katas.MiddleCharacter;

public class Kata
{
    public static string GetMiddle(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        if (text.IsEven())
            return GetMiddleFromEven(text);
        
        return GetMiddleFromOdd(text);
    }


    private static string GetMiddleFromEven(string text)
    {
        int padding = (text.Length - 2) / 2;

        var result = RemovePadding(text, padding, 2);
        
        return result;
    }

    private static string GetMiddleFromOdd(string text)
    {
        int padding = (text.Length - 1) / 2;

        var result = RemovePadding(text, padding, 1);
        
        return result;
    }

    private static string RemovePadding(string text, int padding, int length)
    {
        return text.Substring(padding,  length);
    }
}