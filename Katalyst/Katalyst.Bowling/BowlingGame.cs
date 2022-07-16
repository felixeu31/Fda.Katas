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
        var currentFrame = GetCurrentFrame();

        if (currentFrame == null || currentFrame.IsCompleted())
        {
            currentFrame = AddNewFrame(currentFrame);
        }
        
        currentFrame.AddShot(shotValue);
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
    
    
    private Frame AddNewFrame(Frame currentFrame)
    {
        var nextFrameNumber = (currentFrame?.FrameNumber).GetValueOrDefault() + 1;
        
        Frame frame = new Frame(nextFrameNumber);
        _frames.Add(frame);
        
        return frame;
    }

    private Frame GetCurrentFrame()
    {
        return _frames.OrderBy(x => x.FrameNumber).LastOrDefault();
    }
}