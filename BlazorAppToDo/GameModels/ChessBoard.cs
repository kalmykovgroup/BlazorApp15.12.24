
using BlazorAppToDo.GameModels.Pieces;
using BlazorAppToDo.Interfaces;

namespace BlazorAppToDo.GameModels
{
    public class ChessBoard
    {

        private readonly ILogger<ChessBoard> _logger;

        public ChessField[,] board2D = new ChessField[8, 8];

        public ChessBoard(ILogger<ChessBoard> logger)
        {
            _logger = logger;
            _logger.LogInformation("Создан экземпляр класса ChessBoard.\n");

            InitializeBoard();
        }

      
        private void InitializeBoard()
        {
            // Создаем пустую доску
            for (int row = 0; row < board2D.GetLength(0); row++)
            {
                for (int col = 0; col < board2D.GetLength(1); col++)
                {
                    // Создаем поле с координатами
                    if(row < 2 || row > 5)
                    {
                        _logger.LogInformation($"Добавил {((row + col) % 2 == 0 ? "белую" : "черную")} пешку: (row:{row} col: {col})\n");

                        board2D[row, col] = new ChessField(new Pawn((row + col) % 2 == 0 ? ChessColor.White : ChessColor.Black, new Position(row, col)));
                    } 
                    else
                    {
                        _logger.LogInformation($"Добавил пустую клетку: (row:{row} col: {col})\n");

                        board2D[row, col] = new ChessField(null);
                    }                 
                }
            }

            _logger.LogDebug("Инициализация шахматной доски завершена.\n");

        }
    }
}
