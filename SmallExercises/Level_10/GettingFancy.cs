public class GettingFancy : SmallExcercise
{
    public void Run()
    {
        Console.Title = "Getting Fancy";

        Console.Write("Please enter an integer: ");
        int numberOne = int.Parse(Console.ReadLine());

        Console.Write("Please enter a second integer: ");
        int numberTwo = int.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");

        Console.Beep();

        Console.ReadKey();

        Console.Clear();
    }
}