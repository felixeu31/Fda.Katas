namespace Fda.Katas.MultiplesOf3Or5;

public class Kata
{
    public static int Solution(int value)
    {
        if(value <= 0)
            return 0;
        
        return Enumerable.Range(1, value-1).Where(x => x % 5 == 0 || x % 3 == 0).Sum();
    }
}