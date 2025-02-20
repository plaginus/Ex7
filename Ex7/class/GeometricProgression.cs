using System.ComponentModel;

public class GeometricProgression : Progression
{
    public GeometricProgression(int startNumber, int increaseNumber)
    {
        this.startNumber = startNumber;
        this.increaseNumber = increaseNumber;
    }

    public override int GetElement(int k)
    {
        checked
        {
            int result = (int)(startNumber * Math.Pow(increaseNumber, k - 1));
            return result;
        }
    }
}