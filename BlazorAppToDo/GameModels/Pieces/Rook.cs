using BlazorAppToDo.Interfaces;

namespace BlazorAppToDo.GameModels.Pieces
{
    public class Rook : ChessPiece
    {
        const int value = 5;
        public Rook(ChessColor color, Position position) : base("Ладья", color, position, value) { }
    }
}
