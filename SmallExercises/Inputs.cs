public class Inputs : SmallExcercise
{
    public void Run()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("Welcome " + name);
        Console.WriteLine();
    }
}
