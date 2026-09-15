public class CustomArrows : SmallExcercise
{
    // Arrow class and associated enums are in VinFletchersArrows.cs
    public void Run()
    {
        ArrowheadShape arrowhead;
        FletchingType fletching;
        float weight;

        Console.WriteLine("Vin's Arrow Shop");
        Console.WriteLine();
        PrintArrowheads();
        while (true)
        {
            int choice = GetANumber("Please select an Arrowhead type using the appropriate number: ");
            if (NumberInRange(choice, 1, 3))
            {
                arrowhead = choice switch
                {
                    1 => ArrowheadShape.Broadhead,
                    2 => ArrowheadShape.Field,
                    3 => ArrowheadShape.Blunt
                };
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice...");
            }
        }

        Console.WriteLine();
        PrintFletchings();
        while (true)
        {
            int choice = GetANumber("Please select a Fletching type using the appropriate number: ");
            if (NumberInRange(choice, 1, 3))
            {
                fletching = choice switch
                {
                    1 => FletchingType.GooseFeathers,
                    2 => FletchingType.TurkeyFeathers,
                    3 => FletchingType.ChickenFeathers
                };
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice...");
            }
        }

        Console.WriteLine();
        while (true)
        {
            int choice = GetANumber("Please select a weight between 30 and 50: ");
            if (NumberInRange(choice, 30, 50))
            {
                weight = choice;
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice...");
            }
        }

        Arrow arrow = new(weight, arrowhead, fletching);
        Console.WriteLine();
        Console.WriteLine("You have chosen: ");
        arrow.PrintArrow();
    }

    public void PrintFletchings()
    {
        Console.WriteLine("Please select a Fletching type:");
        Console.WriteLine("1. Goose Feathers");
        Console.WriteLine("2. Turkey Feathers");
        Console.WriteLine("3. Chicken Feathers");
    }

    public void PrintArrowheads()
    {
        Console.WriteLine("Please select an Arrowhead type:");
        Console.WriteLine("1. Broadhead");
        Console.WriteLine("2. Field");
        Console.WriteLine("3. Blunt");
    }

    public int GetANumber(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine()!);
    }

    public bool NumberInRange(int number, int min, int max)
    {
        return number >= min && number <= max;

    }
}
