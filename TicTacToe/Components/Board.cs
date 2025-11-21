using TicTacToe.Enums;

namespace TicTacToe.Components;

public class Board
{
    public int Size { get; }
    public Symbol?[][] Grid { get; }

    public Board(int size)
    {
        Size = size;
        Grid  = new Symbol?[size][];

        for (int i = 0; i < size; i++)
        {
            Grid[i] = new Symbol?[size];
        }
    }

    public bool AddPiece(int row, int column, Symbol symbol)
    {
        if (Grid[row][column] is not null)
            return false;

        Grid[row][column] = symbol;
        return true;
    }

    public int GetFreeCellCount()
    {
        int count = 0;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Grid[i][j] is null)
                    count++;
            }
        }
        return count;
    }

    public void PrintBoard()
    {
        Console.WriteLine();

        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                string display = Grid[i][j]?.ToString() ?? " ";
                Console.Write($"  {display}  ");

                if (j < Size - 1)
                    Console.Write("|");
            }

            Console.WriteLine();
            
            if (i < Size - 1)
            {
                Console.WriteLine(new string('-', Size * 6 - 1));
            }
        }

        Console.WriteLine();
    }
}