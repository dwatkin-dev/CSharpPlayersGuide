public class SimulasTest : SmallExcercise
{
    public void Run()
    {
        ChestState currentState = ChestState.Locked;

        while(true)
        {
            Console.Write($"The chest is {currentState}. What would you like to do? ");
            string command = Console.ReadLine();

            switch(command)
            {
                case "open":
                    if (currentState == ChestState.Unlocked) currentState = ChestState.Open;
                    break;
                case "close":
                    if (currentState == ChestState.Open) currentState = ChestState.Unlocked;
                    break;
                case "unlock":
                    if (currentState == ChestState.Locked) currentState = ChestState.Unlocked;
                    break;
                case "lock":
                    if (currentState == ChestState.Unlocked) currentState = ChestState.Locked;
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }
}

public enum ChestState { Open, Unlocked, Locked }
