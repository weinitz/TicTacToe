using TicTacToe.Data;
using TicTacToe.Model;
using TicTacToe.Rules;

namespace TicTacToe
{
    public abstract class ThreeInRowChecker
    {
        protected ThreeInRowChecker Next { get; private set; }

        public static ThreeInRowChecker Create()
        {
            var threeInRowChecker = new DiagonalBottomLeftToTopRight();
            threeInRowChecker
                .RegisterNext(new DiagonalTopLeftToBottomRight())
                .RegisterNext(new HorizontalCenter())
                .RegisterNext(new HorizontalTop())
                .RegisterNext(new HorizontalBottom())
                .RegisterNext(new VerticalRight())
                .RegisterNext(new VerticalCenter())
                .RegisterNext(new VerticalLeft());
            return threeInRowChecker;
        }

        public ThreeInRowChecker RegisterNext(ThreeInRowChecker next)
        {
            Next = next;
            return Next;
        }

        public abstract bool? Check(GameBoard gameBoard, Marker marker);

        protected abstract bool Validate(GameBoard gameBoard, Marker marker);
    }
}