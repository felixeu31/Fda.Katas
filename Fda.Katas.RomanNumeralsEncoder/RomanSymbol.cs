namespace Fda.Katas.RomanNumeralsEncoder;

public class RomanSymbol
{
    private static readonly IDictionary<RomanSymbol, int> symbols = 
        new Dictionary<RomanSymbol, int>();


    public static readonly RomanSymbol I = new(nameof(I), 1);
    public static readonly RomanSymbol V = new(nameof(V), 5);
    public static readonly RomanSymbol X = new(nameof(X), 10);
    public static readonly RomanSymbol L = new(nameof(L), 50);
    public static readonly RomanSymbol C = new(nameof(C), 100);
    public static readonly RomanSymbol D = new(nameof(D), 500);
    public static readonly RomanSymbol M = new(nameof(M), 1000);

    private RomanSymbol(string symbol, int value)
    {
        this.symbol = symbol;
        this.value = value;
        symbols.Add(this, value);
    }

    internal string symbol;
    internal int value;
    
    
    public static implicit operator int(RomanSymbol romanSymbol)
    {
        return romanSymbol.value;
    }
    
    public static implicit operator string(RomanSymbol romanSymbol)
    {
        return romanSymbol.symbol;
    }

    public static IReadOnlyCollection<RomanSymbol>? Values => symbols.Values as IReadOnlyCollection<RomanSymbol>;
}