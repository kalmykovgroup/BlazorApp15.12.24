using BlazorAppToDo.Interfaces;

namespace BlazorAppToDo.GameModels.Pieces
{
    public class King : ChessPiece
    {
        const int value = int.MaxValue;
        public King(ChessColor color, Position position) : base("Король", color, position, value) { }
    }
}
