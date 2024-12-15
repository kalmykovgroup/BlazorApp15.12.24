using BlazorAppToDo.Interfaces;

namespace BlazorAppToDo.GameModels.Pieces
{
    public class Queen : ChessPiece
    {
        const int value = 9;
        public Queen(ChessColor color, Position position) : base("Королева", color, position, value) { }
    }
}
