using System;
using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe
{
    public class ConsolePlayer : Player
    {
        public static Position Position = new Position(0, 0);

        public ConsolePlayer(Marker marker) : base(marker)
        {
        }

        protected override Position GetPosition(GameBoard gameBoard)
        {
            do
            {
                Console.SetCursorPosition(Position.Y * 6 + 1, Position.X * 4 + 1);
                var key = Console.ReadKey(true).Key;
                MoveMarkerOnBoard(key);
                if (IsEnter(key)) return Position;
            } while (true);
        }

        private static void MoveMarkerOnBoard(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Position.MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    Position.MoveDown();
                    break;
                case ConsoleKey.LeftArrow:
                    Position.MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    Position.MoveRight();
                    break;
            }
        }

        public static bool IsEnter(ConsoleKey key)
        {
            return key == ConsoleKey.Enter;
        }
    }
}