public class Distraction : SmallExcercise
{
    public void Run()
    {
        int a, b;
        Console.WriteLine("Please input a number: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input a second number: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine(a + " + " + b + " = " + (a + b));
    }
}
