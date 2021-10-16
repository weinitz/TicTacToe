using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe.Rules
{
    public class DiagonalBottomLeftToTopRight : ThreeInRowChecker
    {
        protected override bool Validate(GameBoard gameBoard, Marker marker)
        {
            return gameBoard[Position.Bottom, Position.Left] == marker &&
                   gameBoard[Position.Center, Position.Center] == marker &&
                   gameBoard[Position.Top, Position.Right] == marker;
        }
    }
}