using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe.Rules
{
    public class VerticalRight : ThreeInRowChecker
    {
        public override bool? Check(GameBoard gameBoard, Marker marker)
        {
            return Validate(gameBoard, marker) ? true : Next?.Check(gameBoard, marker);
        }

        protected override bool Validate(GameBoard gameBoard, Marker marker)
        {
            return gameBoard[Position.Top, Position.Right] == marker &&
                   gameBoard[Position.Center, Position.Right] == marker &&
                   gameBoard[Position.Bottom, Position.Right] == marker;
        }
    }
}