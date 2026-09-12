public class GettingANumber : SmallExcercise
{
    public void Run()
    {
        while(true)
        {
            Console.WriteLine(GetANumber("Please enter a number: "));
        }
    }

    private int GetANumber(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }
}
