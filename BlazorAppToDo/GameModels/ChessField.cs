namespace BlazorAppToDo.GameModels
{
    public class ChessField
    { 
        public ChessPiece? ChessPiece { get; set; }  // Тип фигуры  

        public ChessField(ChessPiece? chessPiece)
        {
            ChessPiece = chessPiece;
        }
    }
}
