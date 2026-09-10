public class Retrieval : SmallExcercise
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

        int a = numberOne % 10;
        int b = numberTwo % 10;
        int c = (numberOne + numberTwo) % 10;
        int d = (numberOne * numberTwo) % 10;
        int e = (numberOne * 3) % 10;
        int f = (numberTwo * 5) % 10;

        string output = $"""
            [{a}][{b}]
            [{c}][{d}]
            [{e}][{f}]
            """;
        Console.WriteLine(output);

    }
}
