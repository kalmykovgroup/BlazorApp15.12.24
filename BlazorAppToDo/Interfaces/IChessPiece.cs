using BlazorAppToDo.GameModels;

namespace BlazorAppToDo.Interfaces
{
    public enum ChessColor { White, Black }

    public interface IChessPiece
    {
        public string Name { get; set; }
        public ChessColor ChessColor {  get; set; }
        public Position Position { get; set; }
        public int Value { get; set; }
    }
}
