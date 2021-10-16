using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe.Rules
{
    public class VerticalRight : ThreeInRowChecker
    {
        protected override bool Validate(GameBoard gameBoard, Marker marker)
        {
            return gameBoard[Position.Top, Position.Right] == marker &&
                   gameBoard[Position.Center, Position.Right] == marker &&
                   gameBoard[Position.Bottom, Position.Right] == marker;
        }
    }
}