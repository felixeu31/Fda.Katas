namespace Fda.Katas.RomanNumeralsEncoder;

public class RomanConvert
{
    public static string Solution(int value)
    {
        if(value>0 && value <= 10)
            return GetRomanFromOneDigit(value);
        return "not found";
    }

    private static string GetRomanFromOneDigit(int value)
    {
        if (Math.Abs(RomanSymbol.I - value) <= 2)
            return RomanSymbol.I;
        
        if (Math.Abs(RomanSymbol.V - value) <= 2)
            return RomanSymbol.V;
        
        if (Math.Abs(RomanSymbol.X - value) <= 2)
            return RomanSymbol.X;

        return "not valid";
    }
}