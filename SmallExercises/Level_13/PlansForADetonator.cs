public class PlansForADetonator : SmallExcercise
{
    public void Run()
    {
        DisplayDetonator("__.__.XX.___.X".ToCharArray());
        Console.WriteLine();
        DisplayDetonator("____.XX.XXX.___.X".ToCharArray());
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
}