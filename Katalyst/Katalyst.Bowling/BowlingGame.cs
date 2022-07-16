namespace Katalyst.Bowling;

public class BowlingGame
{
    private readonly List<Frame> _frames;

    public BowlingGame()
    {
        _frames = new ();
    }
    public void AddShot(char shotValue)
    {
        var frame = GetCurrentFrame();

        if (frame == null)
        {
            frame = AddNewFrame();
        }
        
        frame.AddShot(shotValue);
    }

    public void AddShots(string playValue)
    {
        foreach (var pinCount in playValue)
        {
            AddShot(pinCount);
        }
    }

    public int Score()
    {
        return _frames.Sum(x => x.Score());
    }
    
    
    private Frame AddNewFrame()
    {
        Frame frame = new Frame();
        _frames.Add(frame);
        return frame;
    }

    private Frame GetCurrentFrame()
    {
        return _frames.FirstOrDefault(x => !x.IsCompleted());
    }
}