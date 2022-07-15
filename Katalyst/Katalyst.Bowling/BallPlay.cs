namespace Katalyst.Bowling;

public class BallPlay
{
    private static readonly char[] ValidBallPlays = new []{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'x', '/', '-'};
    private readonly char _ballPlay;

    private BallPlay(char c)
    {
        if (!ValidBallPlays.Contains(c))
            throw new ArgumentOutOfRangeException("ballPlay");
        
        _ballPlay = c;
    }

    public static BallPlay FromChar(char c)
    {
        return new BallPlay(c);
    }

    public int Score()
    {
        int ballScore;
        
        if (_ballPlay == 'x')
            ballScore = 10;
        else if (int.TryParse(_ballPlay.ToString(), out int aux))
            ballScore = aux;
        else
            ballScore = 0;

        return ballScore;
    }
}