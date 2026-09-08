public class ReusingAVariable : SmallExcercise
{
    public void Run()
    {
        string symbol;
        Console.WriteLine("Enter a symbol: ");
        symbol = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(symbol + " " + symbol);
        Console.WriteLine(" " + symbol);
        Console.WriteLine(symbol + " " + symbol);
        Console.WriteLine();

        Console.WriteLine("Enter another symbol: ");
        symbol = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(symbol + "." + symbol + ".." + symbol);
        Console.WriteLine();
    }
}