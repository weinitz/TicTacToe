using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe.Rules
{
    public class HorizontalCenter : ThreeInRowChecker
    {
        public override bool? Check(GameBoard gameBoard, Marker marker)
        {
            return Validate(gameBoard, marker) ? true : Next?.Check(gameBoard, marker);
        }

        protected override bool Validate(GameBoard gameBoard, Marker marker)
        {
            return gameBoard[Position.Center, Position.Left] == marker &&
                   gameBoard[Position.Center, Position.Center] == marker &&
                   gameBoard[Position.Center, Position.Right] == marker;
        }
    }
}