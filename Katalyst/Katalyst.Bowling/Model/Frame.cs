namespace Katalyst.Bowling;

internal class Frame
{
    public readonly int FrameNumber;

    private Shot _shot1;
    private Shot _shot2;

    public Frame(int frameNumber)
    {
        FrameNumber = frameNumber;
    }
    
    public void AddShot(char shotValue)
    {
        ValidateShotSymbol(shotValue);
        
        if (_shot1 == null)
        {
            if (shotValue == BowlingConstants.StrikeSymbol)
                _shot1 = Shot.FromScalar(BowlingConstants.TotalNumberOfPins);
            else if(int.TryParse(shotValue.ToString(), out int aux))
                _shot1 = Shot.FromScalar(aux);
            else
                throw new Exception("First shot could not be registered in frame");
        }
        else if (_shot2 == null)
        {
            if (shotValue == BowlingConstants.SpareSymbol)
                _shot2 = Shot.FromScalar(RemainingPins());
            else if(int.TryParse(shotValue.ToString(), out int aux))
                _shot2 = Shot.FromScalar(aux);
            else
                throw new Exception("Second shot could not be registered in frame");
        }
        else
            throw new Exception("Shot could not be registered in frame");
    }

    private void ValidateShotSymbol(char shotValue)
    {
        if(shotValue != BowlingConstants.StrikeSymbol 
           && shotValue != BowlingConstants.SpareSymbol 
           && !int.TryParse(shotValue.ToString(), out int aux))
            throw new ArgumentOutOfRangeException();
    }

    private int RemainingPins()
    {
        return BowlingConstants.TotalNumberOfPins
               - (_shot1?.PinsThrown).GetValueOrDefault()
               - (_shot2?.PinsThrown).GetValueOrDefault();
    }

    public int Score(IEnumerable<Shot> followingShots = null)
    {
        
        var framePinsThrown = (_shot1?.PinsThrown).GetValueOrDefault() + (_shot2?.PinsThrown).GetValueOrDefault();
        
        if (IsSpare())
            return framePinsThrown + (followingShots?.Take(1).Sum(x => x?.PinsThrown)).GetValueOrDefault();
        
        if (IsStrike())
            return framePinsThrown + (followingShots?.Take(2).Sum(x => x?.PinsThrown)).GetValueOrDefault();

        return framePinsThrown;
    }

    public bool IsCompleted()
    {
        return _shot1 != null && (IsStrike() || _shot2 != null);
    }

    public bool IsStrike()
    {
        return _shot1 != null && _shot1.PinsThrown == 10;
    }

    public bool IsSpare()
    {
        return RemainingPins() == 0 && _shot2 != null;
    }

    public IEnumerable<Shot> Shots()
    {
        var shots = new List<Shot>();
        
        if(_shot1 != null)
            shots.Add(_shot1);
        
        if(_shot2 != null)
            shots.Add(_shot2);

        return shots;
    }
}