using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe.Rules
{
    public class VerticalLeft : ThreeInRowChecker
    {
        public override bool? Check(GameBoard gameBoard, Marker marker)
        {
            return Validate(gameBoard, marker) ? true : Next?.Check(gameBoard, marker);
        }

        protected override bool Validate(GameBoard gameBoard, Marker marker)
        {
            return gameBoard[Position.Top, Position.Left] == marker &&
                   gameBoard[Position.Center, Position.Left] == marker &&
                   gameBoard[Position.Bottom, Position.Left] == marker;
        }
    }
}