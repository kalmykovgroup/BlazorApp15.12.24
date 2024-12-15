using BlazorAppToDo.Interfaces;

namespace BlazorAppToDo.GameModels.Pieces
{
    public class Pawn : ChessPiece
    {
        const int value = 1;
        public Pawn(ChessColor color, Position position) : base("Пешка", color, position, value) { }
    }
}
