public class AnInterpolationExperiment : SmallExcercise
{
    public void Run()
    {
        Console.Write("Enter the first integer value: ");
        int numberOne = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer value: ");
        int numberTwo = int.Parse(Console.ReadLine());

        Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne+numberTwo}");
    }
}