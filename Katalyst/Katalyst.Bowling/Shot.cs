namespace Katalyst.Bowling;

public class Shot
{
    private static readonly char[] ValidBallPlays = new []{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'x', '/', '-'};
    private readonly char _value;

    private Shot(char c)
    {
        if (!ValidBallPlays.Contains(c))
            throw new ArgumentOutOfRangeException("ballPlay");
        
        _value = c;
    }

    public static Shot FromChar(char c)
    {
        return new Shot(c);
    }

    public int Score()
    {
        int ballScore;
        
        if (_value == BowlingConstants.StrikeSymbol)
            ballScore = 10;
        else if (int.TryParse(_value.ToString(), out int aux))
            ballScore = aux;
        else
            ballScore = 0;

        return ballScore;
    }

    public bool IsStrike()
    {
        return _value == BowlingConstants.StrikeSymbol;
    }

    public bool IsSpare()
    {
        return _value == BowlingConstants.SpareSymbol;
    }

    public bool IsANumberOfPins()
    {
        if (IsStrike() || IsSpare())
            return false;

        return true;
    }
}