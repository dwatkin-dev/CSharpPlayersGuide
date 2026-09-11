public class Map : SmallExcercise
{
    public void Run()
    {
        int[,] map = new int[6, 6] { { 0, 1, 0, 1, 1, 3 }, { 2, 1, 4, 2, 3, 1 }, { 1, 2, 2, 3, 1, 0 }, { 2, 2, 3, 5, 0, 1 }, { 3, 3, 2, 1, 1, 1 }, { 1, 2, 3, 1, 0, 0 } };

        for (int row = 0;  row < map.GetLength(0); row++)
        {
            for (int col = 0; col < map.GetLength(1); col++) 
            {
                switch (map[row, col])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("..");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("##");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("~~");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[]");
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("()");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}