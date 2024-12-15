using BlazorAppToDo.Interfaces;

namespace BlazorAppToDo.GameModels.Pieces
{
    public class Knight : ChessPiece
    {
        const int value = 3;
        public Knight(ChessColor color, Position position) : base("Конь", color, position, value) { }
    }
}
