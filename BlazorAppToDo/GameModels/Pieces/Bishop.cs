using BlazorAppToDo.Interfaces;

namespace BlazorAppToDo.GameModels.Pieces
{
    public class Bishop : ChessPiece
    {
        const int value = 3;
        public Bishop(ChessColor color, Position position) : base("Слон", color, position, value) { }
    }
}
