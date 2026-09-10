public class Reset : SmallExcercise
{
    public void Run()
    {
        string symbol;
        int channel;
        
        Console.Write("Enter symbol: ");
        symbol = Console.ReadLine();

        switch (symbol)
        {
            case "x":
                channel = 2;
                Console.WriteLine(channel);
                break;
            case "o":
                channel = 3;
                Console.WriteLine(channel);
                break;
            case "^":
                channel = 1;
                Console.WriteLine(channel);
                break;
            case "#":
                channel = 4;
                Console.WriteLine(channel);
                break;
            default:
                Console.WriteLine("Apologies. I do not know that one.");
                break;

             
        }
    }
}

