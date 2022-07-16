namespace Katalyst.Bowling;

public class Shot
{
    public readonly int PinsThrown;

    private Shot(int pinsThrown)
    {
        if (pinsThrown < 0 || pinsThrown > BowlingConstants.TotalNumberOfPins)
            throw new ArgumentOutOfRangeException();
        
        PinsThrown = pinsThrown;
    }

    public static Shot FromScalar(int pinsThrown)
    {
        return new Shot(pinsThrown);
    }
    
    public static implicit operator int(Shot shot)
    {
        return shot.PinsThrown;
    }

    public static explicit operator Shot(int value)
    {
        return new Shot(value);
    }

    public static Shot FromStrike()
    {
        return new Shot(10);
    }
}