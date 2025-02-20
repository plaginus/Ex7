namespace Ex7;

class Program
{
    static void Main(string[] args)
    {
        Test1();
    }

    static void Test1()
    {

        Console.WriteLine("\n////// Test: ArithmeticProgression \\\\\\\\\\\\\n");

        Console.WriteLine("Enter start number and increase number for arithmetic progression");
        int sn = Convert.ToInt32(Console.ReadLine());
        int en = Convert.ToInt32(Console.ReadLine());
        ArithmeticProgression ar1 = new ArithmeticProgression(sn, en);
        Console.WriteLine("Enter number for element progression");
        int kn = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{kn}-th element of progression is {ar1.GetElement(kn)}");

        Console.WriteLine("\n////// Test: GeometricProgression \\\\\\\\\\\\\n");

        Console.WriteLine("Enter start number and increase number for arithmetic progression");
        sn = Convert.ToInt32(Console.ReadLine());
        en = Convert.ToInt32(Console.ReadLine());
        GeometricProgression gr1 = new GeometricProgression(sn, en);
        Console.WriteLine("Enter number for element progression");
        kn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{kn}-th element of progression is {gr1.GetElement(kn)}");
    }
}
