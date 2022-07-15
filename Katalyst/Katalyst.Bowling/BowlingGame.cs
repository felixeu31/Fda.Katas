namespace Katalyst.Bowling;

public class BowlingGame
{
    private int _score = 0;

    public void Roll(char c)
    {
        if (c == 'x')
            _score += 10;
        else if (int.TryParse(c.ToString(), out int aux))
            _score += aux;
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
        return _score;
    }
}