using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe.Rules
{
    public class HorizontalTop : ThreeInRowChecker
    {
        public override bool? Check(GameBoard gameBoard, Marker marker)
        {
            return Validate(gameBoard, marker) ? true : Next?.Check(gameBoard, marker);
        }

        protected override bool Validate(GameBoard gameBoard, Marker marker)
        {
            return gameBoard[Position.Top, Position.Left] == marker &&
                   gameBoard[Position.Top, Position.Center] == marker &&
                   gameBoard[Position.Top, Position.Right] == marker;
        }
    }
}