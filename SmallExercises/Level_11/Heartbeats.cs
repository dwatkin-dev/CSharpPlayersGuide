public class Heartbeats : SmallExcercise
{
    public void Run()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine($"{i}: OO");
            else if (i % 3 == 0) Console.WriteLine($"{i}: o.");
            else if (i % 5 == 0) Console.WriteLine($"{i}: .o");
            else Console.WriteLine($"{i}: ..");

            Thread.Sleep(100);
        }
    }
}