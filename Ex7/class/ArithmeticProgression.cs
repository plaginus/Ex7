public class ArithmeticProgression : Progression
{
    public ArithmeticProgression(int startNumber, int increaseNumber)
    {
        this.startNumber = startNumber;
        this.increaseNumber = increaseNumber;
    }

    public override int GetElement(int k)
    {
        return startNumber + increaseNumber * (k - 1);
    }
}
