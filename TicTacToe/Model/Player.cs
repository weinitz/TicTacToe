using TicTacToe.Data;

namespace TicTacToe.Model
{
    public abstract class Player
    {
        protected Marker _marker;

        protected Player(Marker marker)
        {
            _marker = marker;
        }

        public Marker Marker => _marker;
        public int Score { get; private set; }

        public void PlaceMarker(GameBoard gameBoard)
        {
            var position = GetPosition(gameBoard);
            gameBoard.PlaceMarker(position, _marker);
        }

        protected abstract Position GetPosition(GameBoard gameBoard);

        public void IncreaseScore()
        {
            Score++;
        }
    }
}