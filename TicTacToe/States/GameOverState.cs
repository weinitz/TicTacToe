using System;

namespace TicTacToe.States
{
    public class GameOverState : GameState
    {
        public override void Play(Game game)
        {
            GetInput:
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Enter:
                    game.Reset();
                    game.Play();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default: goto GetInput;
            }
        }

        public override string Render(Game game)
        {
            return "Play Again [enter], or quit [escape]?";
        }
    }
}