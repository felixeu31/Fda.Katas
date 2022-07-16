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
        if(_shot1 == null)
            _shot1 = Shot.FromChar(shotValue);
        else if (_shot2 == null)
            _shot2 = Shot.FromChar(shotValue);
        else
            throw new Exception("Could not be registered in frame");
    }
    
    public int Score()
    {
        if (_shot1 != null && _shot1.IsStrike())
            return BowlingConstants.TotalNumberOfPins;
        
        if (_shot2 != null && _shot2.IsSpare())
            return BowlingConstants.TotalNumberOfPins;
        
        return (_shot1?.Score()).GetValueOrDefault() + (_shot2?.Score()).GetValueOrDefault();
    }

    public bool IsCompleted()
    {
        return _shot1 != null && _shot2 != null;
    }
}