public class ThePrototype : SmallExcercise
{
    public void Run()
    {
        Console.Write("Please enter your secret number: ");
        int secretNumber = int.Parse(Console.ReadLine());

        Console.Clear();

        int guess;
        do {
            Console.Write("What is your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > secretNumber)
            {
                Console.WriteLine("Too high!");
            } else if (guess < secretNumber)
            {
                Console.WriteLine("Too low!");
            }
        } while (guess != secretNumber);

        Console.WriteLine($"Correct! The secret number was {secretNumber}...");
    }
}