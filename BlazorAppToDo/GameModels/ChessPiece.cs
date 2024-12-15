using BlazorAppToDo.Interfaces;

namespace BlazorAppToDo.GameModels
{
    public class ChessPiece : IChessPiece
    {
        public string Name { get; set; }        // Название фигуры (например, "Pawn")
        public ChessColor ChessColor { get; set; }       // Цвет фигуры ("White" или "Black")
        public Position Position { get; set; }    // Текущая позиция на доске (например, "A1")
        public int Value { get; set; }

        public ChessPiece(string name, ChessColor chessColor, Position position, int value)
        {
            Name = name;
            ChessColor = chessColor;
            Position = position;
            Value = value;
        }
    }
}
