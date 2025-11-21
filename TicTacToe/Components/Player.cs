using TicTacToe.Enums;

namespace TicTacToe.Components;

public class Player(string name, Symbol symbol)
{
    public string Name { get; set; } = name;
    public Symbol Symbol { get; set; } = symbol;
}
