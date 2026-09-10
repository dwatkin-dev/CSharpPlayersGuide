public class MustGoFaster : SmallExcercise
{
    public void Run()
    {
        Console.Write("Enter symbol: ");
        string symbol = Console.ReadLine();

        string response = symbol switch
        {
            "x" => "Route to channel 2.",
            "o" => "Route to channel 3.",
            "^" => "Route to channel 1.",
            "#" => "Route to channel 4.",
            _ => "Apologies. I do not know that one."
        };

        Console.WriteLine(response);
    }
}

