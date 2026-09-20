FixedBoardGenerator boardGenerator = new();
Board board = boardGenerator.Generate();

for (int row = 0; row < board.Rows; row++)
{
    for (int column = 0; column < board.Columns; column++)
    {
        Console.Write(board.Cells[row,column].IsMine ? "*" : ".");
    }
    Console.WriteLine();
}

Console.ReadKey();

public class Board
{
    public Cell[,] Cells { get; }
    public int Rows { get; }
    public int Columns { get; }

    public Board(int rows, int columns, Location[] mineLocations)
    {
        Cells = new Cell[rows, columns];
        for (int row = 0; row < rows; row ++)
        {
            for (int col = 0; col < columns; col++)
            {
                Cells[row, col] = new Cell(false);
            }
        }

        foreach (Location location in mineLocations)
        {
            Cells[location.Row, location.Column] = new Cell(true);
        }

        Rows = rows;
        Columns = columns;
    }
}

public class Cell(bool isMine)
{
    public bool IsCovered { get; private set; } = true;
    public bool IsMine { get; } = isMine;

    public void Uncover() => IsCovered = false;
}

public class Location(int row, int column)
{
    public int Row { get; } = row;
    public int Column { get; } = column;
}

public class FixedBoardGenerator
{
    public Board Generate() => new Board(9, 9,
        [ new (1,1), new(1, 5), new(2, 4), new(2, 8), new(3, 5),
          new (5,2), new (5,7), new (7,2), new (7,6), new (8,4)  ]);
}