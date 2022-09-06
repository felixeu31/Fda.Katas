namespace Katalyst.Bowling;

internal class Bonus
{
    private Shot _shot1;
    private Shot _shot2;
    private readonly int _extraBalls;

    public Bonus(int extraBalls)
    {
        _extraBalls = extraBalls;
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
                throw new Exception("First shot could not be registered in bonus");
        }
        else if (_shot2 == null)
        {
            if (shotValue == BowlingConstants.StrikeSymbol)
                _shot2 = Shot.FromScalar(BowlingConstants.TotalNumberOfPins);
            else if (shotValue == BowlingConstants.SpareSymbol)
                _shot2 = Shot.FromScalar(RemainingPins());
            else if(int.TryParse(shotValue.ToString(), out int aux))
                _shot2 = Shot.FromScalar(aux);
            else
                throw new Exception("Second shot could not be registered in bonus");
        }
        else
            throw new Exception("Shot could not be registered in bonus");
    }

    private void ValidateShotSymbol(char shotValue)
    {
        if(shotValue != BowlingConstants.StrikeSymbol 
           && shotValue != BowlingConstants.SpareSymbol 
           && !int.TryParse(shotValue.ToString(), out _))
            throw new ArgumentOutOfRangeException();
    }

    private int RemainingPins()
    {
        return BowlingConstants.TotalNumberOfPins
               - (_shot1?.PinsThrown).GetValueOrDefault()
               - (_shot2?.PinsThrown).GetValueOrDefault();
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