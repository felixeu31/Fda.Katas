namespace Katalyst.Bowling;

public class BowlingGame
{
    private List<BallPlay> BallPlays = new List<BallPlay>();

    public void Roll(char c)
    {
        BallPlays.Add(BallPlay.FromChar(c));
    }

    public void Roll(string c)
    {
        foreach (var pinCount in c)
        {
            Roll(pinCount);
        }
    }

    public int Score()
    {
        return BallPlays.Sum(x => x.Score());
    }
}