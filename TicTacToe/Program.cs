using TicTacToe.Components;

TicTacToeGame g = new();
var winner = g.StartGame();
Console.WriteLine(winner == "Tie" ? "It's a tie!" : $"{winner} wins!");
