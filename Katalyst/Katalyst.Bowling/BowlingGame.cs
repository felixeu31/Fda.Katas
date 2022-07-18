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
        foreach (var frame in playValue.Split("|"))
        {
            foreach (var shotSymbol in frame)
            {
                AddShot(shotSymbol);
            }
        }
    }

    public int Score()
    {
        int sum = 0;
        
        foreach (var frame in _frames)
        {
            IEnumerable<Shot> followingShots = _frames
                .Where(x => x.FrameNumber > frame.FrameNumber)
                .SelectMany(x => x.Shots());
            
            sum += frame.Score(followingShots);
        }

        return sum;
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