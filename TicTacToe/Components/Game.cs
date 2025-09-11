using TicTacToe.Enums;

namespace TicTacToe.Components;

public class TicTacToeGame
{
    private readonly Queue<Player> players = new();
    private readonly Board gameBoard = new(3);

    public string StartGame()
    {
        InitializePlayers();

        while (true)
        {
            gameBoard.PrintBoard();

            if (gameBoard.GetFreeCellCount() == 0)
                return "Tie";

            var currentPlayer = players.Peek();

            var (row, column) = GetValidMove(currentPlayer);

            if (IsThereAWinner(row, column, gameBoard))
                return currentPlayer.Name;

            players.Enqueue(players.Dequeue());
        }
    }

    private void InitializePlayers()
    {
        Console.Write("Enter Player 1 Name: ");
        var player1Name = Console.ReadLine() ?? "Player 1";

        Console.Write("Enter Player 2 Name: ");
        var player2Name = Console.ReadLine() ?? "Player 2";

        players.Enqueue(new Player(player1Name, Symbol.X));
        players.Enqueue(new Player(player2Name, Symbol.O));
    }

    private (int row, int column) GetValidMove(Player player)
    {
        while (true)
        {
            Console.Write($"{player.Name}, enter row and column (0-based, separated by space): ");
            var input = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (input?.Length == 2
                && int.TryParse(input[0], out int row)
                && int.TryParse(input[1], out int column)
                && row >= 0 && row < gameBoard.Size
                && column >= 0 && column < gameBoard.Size
                && gameBoard.AddPiece(row, column, player.Symbol))
            {
                return (row, column);
            }

            Console.WriteLine("Invalid input or cell already occupied. Try again.");
        }
    }

    private static bool IsThereAWinner(int row, int column, Board gameBoard)
    {
        int size = gameBoard.Size;
        var symbol = gameBoard.Grid[row][column];

        // Check the row
        bool rowWin = true;
        for (int i = 0; i < size; i++)
        {
            if (gameBoard.Grid[row][i] == null || gameBoard.Grid[row][i] != symbol)
            {
                rowWin = false;
                break;
            }
        }

        // Check the column
        bool colWin = true;
        for (int i = 0; i < size; i++)
        {
            if (gameBoard.Grid[i][column] == null || gameBoard.Grid[i][column] != symbol)
            {
                colWin = false;
                break;
            }
        }

        // Check main diagonal
        bool diagWin = true;
        if (row == column)
        {
            for (int i = 0; i < size; i++)
            {
                if (gameBoard.Grid[i][i] == null || gameBoard.Grid[i][i] != symbol)
                {
                    diagWin = false;
                    break;
                }
            }
        }
        else
        {
            diagWin = false;
        }

        // Check anti-diagonal
        bool antiDiagWin = true;
        if (row + column == size - 1)
        {
            for (int i = 0; i < size; i++)
            {
                if (gameBoard.Grid[i][size - 1 - i] == null || gameBoard.Grid[i][size - 1 - i] != symbol)
                {
                    antiDiagWin = false;
                    break;
                }
            }
        }
        else
        {
            antiDiagWin = false;
        }

        return rowWin || colWin || diagWin || antiDiagWin;
    }
}
