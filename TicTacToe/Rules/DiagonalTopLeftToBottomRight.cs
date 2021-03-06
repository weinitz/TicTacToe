using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe.Rules
{
    public class DiagonalTopLeftToBottomRight : ThreeInRowChecker
    {
        protected override bool Validate(GameBoard gameBoard, Marker marker)
        {
            return gameBoard[Position.Top, Position.Left] == marker &&
                   gameBoard[Position.Center, Position.Center] == marker &&
                   gameBoard[Position.Bottom, Position.Right] == marker;
        }
    }
}