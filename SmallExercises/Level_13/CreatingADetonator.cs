public class CreatingADetonator : SmallExcercise
{
    public void Run()
    {
        char[] detonator = "_._.__.___._____.________".ToCharArray();

        while(true)
        {
            DisplayDetonator(detonator);
            Console.WriteLine();
            int location = GetANumber("Please enter the detonator location you would like to fill: ");
            Fill(detonator, location);
            Console.WriteLine();
        }
    }

    private void Fill(char[] detonator, int location)
    {
        if(location >= 0 && location < detonator.Length)
        {
            if(detonator[location] == '_')
            {
                detonator[location] = 'X';
            }
        }
    }
        private void DisplayDetonator(char[] detonator)
    {
        DisplayChar('[');
        foreach (char c in detonator)
        {
            DisplayChar(c);
        }
        DisplayChar(']');
    }

    private void DisplayChar(char c)
    {
        string cerulean = "\e[38;2;0;143;190m";
        string darkGray = "\e[38;2;51;51;51m";
        string gold = "\e[38;2;255;215;0m";
        string alabasterGray = "\e[38;2;216;219;226m";
        switch (c)
        {
            case 'X':
                Console.Write($"{cerulean}{c}");
                break;
            case '_':
                Console.Write($"{darkGray}{c}");
                break;
            case '.':
                Console.Write($"{gold}{c}");
                break;
            case '[':
                Console.Write($"{alabasterGray}{c}");
                break;
            case ']':
                Console.Write($"{alabasterGray}{c}");
                break;
        }
    }

    private int GetANumber(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }
}
