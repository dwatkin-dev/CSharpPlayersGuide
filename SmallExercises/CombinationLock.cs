public class CombinationLock : SmallExcercise
{
    public void Run()
    {
        Console.Write("Enter a 3 digit combination: ");
        string combination = Console.ReadLine();

        if(combination.Length == 3 && char.IsDigit(combination[0]) && char.IsDigit(combination[1]) && char.IsDigit(combination[2]))
        {
            Console.WriteLine(combination);
        }else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}