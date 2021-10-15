using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe.Rules
{
    public class HorizontalBottom : ThreeInRowChecker
    {
        public override bool? Check(GameBoard gameBoard, Marker marker)
        {
            return Validate(gameBoard, marker) ? true : Next?.Check(gameBoard, marker);
        }

        protected override bool Validate(GameBoard gameBoard, Marker marker)
        {
            return gameBoard[Position.Bottom, Position.Left] == marker &&
                   gameBoard[Position.Bottom, Position.Center] == marker &&
                   gameBoard[Position.Bottom, Position.Right] == marker;
        }
    }
}