using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe.Rules
{
    public class VerticalCenter : ThreeInRowChecker
    {
        protected override bool Validate(GameBoard gameBoard, Marker marker)
        {
            return gameBoard[Position.Top, Position.Center] == marker &&
                   gameBoard[Position.Center, Position.Center] == marker &&
                   gameBoard[Position.Bottom, Position.Center] == marker;
        }
    }
}