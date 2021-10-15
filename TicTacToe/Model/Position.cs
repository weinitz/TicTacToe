namespace TicTacToe.Model
{
    public struct Position
    {
        public const int Size = 3;
        public const int Top = 0;
        public const int Left = 0;
        public const int Center = 1;
        public const int Right = Size - 1;
        public const int Bottom = Size - 1;
        public const int Steps = 1;

        public int X;
        public int Y;

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoveUp()
        {
            var isTop = X <= Top;
            X = isTop ? Bottom : X - Steps;
        }

        public void MoveDown()
        {
            var isBottom = X >= Bottom;
            X = isBottom ? Top : X + Steps;
        }

        public void MoveLeft()
        {
            var isLeft = Y <= Left;
            Y = isLeft ? Right : Y - Steps;
        }

        public void MoveRight()
        {
            var isRight = Y >= Right;
            Y = isRight ? Left : Y + Steps;
        }
    }
}