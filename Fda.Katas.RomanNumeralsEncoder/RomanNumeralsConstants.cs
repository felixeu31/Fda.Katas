namespace Fda.Katas.RomanNumeralsEncoder;

public class RomanNumeralsConstants
{
    public static  Dictionary<int, string> Units = new Dictionary<int, string>()
    {
        { 0, string.Empty },
        { 1, "I" },
        { 2, "II" },
        { 3, "III" },
        { 4, "IV"},
        { 5, "V" },
        { 6, "VI" },
        { 7, "VII" },
        { 8, "VIII" },
        { 9, "IX" }
    };
    public static  Dictionary<int, string> Tens = new Dictionary<int, string>()
    {
        { 0, string.Empty },
        { 1, "X" },
        { 2, "XX" },
        { 3, "XXX" },
        { 4, "XL"},
        { 5, "L" },
        { 6, "LX" },
        { 7, "LXX" },
        { 8, "LXXX" },
        { 9, "XC" }
    };
    public static  Dictionary<int, string> Hundreds = new Dictionary<int, string>()
    {
        { 0, string.Empty },
        { 1, "C" },
        { 2, "CC" },
        { 3, "CCC" },
        { 4, "CD"},
        { 5, "D" },
        { 6, "DC" },
        { 7, "DCC" },
        { 8, "DCCC" },
        { 9, "CM" }
    };
    public static  Dictionary<int, string> Thousands = new Dictionary<int, string>()
    {
        { 0, string.Empty },
        { 1, "M" },
        { 2, "MM" },
        { 3, "MMM" },
    };

    public static Dictionary<int, Dictionary<int, string>> RomanNumerals = new Dictionary<int, Dictionary<int, string>>()
    {
        { 1, Units },
        { 2, Tens },
        { 3, Hundreds },
        { 4, Thousands },
    };
}