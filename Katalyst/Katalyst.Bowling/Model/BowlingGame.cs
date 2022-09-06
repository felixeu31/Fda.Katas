using FluentAssertions;

namespace Katalyst.Bowling;

public class BowlingGame
{
    private readonly List<Frame> _frames;
    private Bonus _bonus;

    public BowlingGame()
    {
        _frames = new ();
    }
    public void AddShot(char shotValue)
    {
        var currentFrame = MustStartNewFramework() ? StartNewFrame() : GetCurrentFrame();  

        if (AreRegularFramesCompleted())
        {
            if (_bonus == null)
                _bonus = new Bonus(currentFrame.IsStrike() ? 2 : currentFrame.IsSpare() ? 1 : 0);
            
            _bonus.AddShot(shotValue);
        }
        else
            currentFrame.AddShot(shotValue);
    }

    private bool AreRegularFramesCompleted()
    {
        return _frames.Count(x => x.IsCompleted()) == 10;
    }

    private bool MustStartNewFramework()
    {
        Frame? currentFrame = GetCurrentFrame();
        return (currentFrame == null || currentFrame.IsCompleted()) && _frames.Count < 10;
    }

    public void AddShots(string playValue)
    {
        // foreach (var frame in playValue.Split("|"))
        // {
        //     foreach (var shotSymbol in frame)
        //     {
        //         AddShot(shotSymbol);
        //     }
        // }

        var shotSymbols = playValue.Replace("|", string.Empty).ToArray();

        foreach (var shotSymbol in shotSymbols)
        {
            AddShot(shotSymbol);
        }
    }

    public int Score()
    {
        int sum = 0;
        
        foreach (var frame in _frames)
        {
            IEnumerable<Shot> followingShots = _frames
                .Where(x => x.FrameNumber > frame.FrameNumber)
                .SelectMany(x => x.Shots())
                .Union(_bonus?.Shots() ?? new List<Shot>());

            sum += frame.Score(followingShots);
        }

        return sum;
    }
    
    
    private Frame StartNewFrame()
    {
        var nextFrameNumber = (GetCurrentFrame()?.FrameNumber).GetValueOrDefault() + 1;
        
        Frame frame = new Frame(nextFrameNumber);
        _frames.Add(frame);
        
        return frame;
    }

    private Frame? GetCurrentFrame()
    {
        return _frames.MaxBy(x => x.FrameNumber);
    }
}