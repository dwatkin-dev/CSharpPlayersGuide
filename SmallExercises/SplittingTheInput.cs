public class SplittingTheInput : SmallExcercise
{
    public void Run()
    {
        string input = Console.ReadLine();
        int comma = input.IndexOf(",");
        string stringOne = input.Substring(0, comma);
        string stringTwo = input.Substring(comma + 1);
        stringOne.Trim();
        stringTwo.Trim();
        int numberOne = int.Parse(stringOne);
        int numberTwo = int.Parse(stringTwo);

        Console.WriteLine($"{numberOne},{numberTwo}");
    }
}
