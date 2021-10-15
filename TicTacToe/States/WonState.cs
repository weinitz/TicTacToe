using System;

namespace TicTacToe.States
{
    public class WonState : GameState
    {
        public override void Play(Game game)
        {
            game.SetState(game.GameOverState);
            Console.ReadKey();
        }

        public override string Render(Game game)
        {
            return game.CurrentPlayer.Equals(game.Player)
                ? @"
.----. .-.     .--..-.  .-..----..----.    .-. . .-. .----. .-. .-.
| {}  }| |    / {} \\ \/ / | {_  | {}  }   | |/ \| |/  {}  \|  `| |
| .--' | `--./  /\  \}  {  | {__ | .-. \   |  .'.  |\      /| |\  |
`-'    `----'`-'  `-'`--'  `----'`-' `-'   `-'   `-' `----' `-' `-'
"
                : @"
 .----. .----. .----.  .----. .-. .-..----..-. .-. .---.    .-. . .-. .----. .-. .-.
/  {}  \| {}  }| {}  }/  {}  \|  `| || {_  |  `| |{_   _}   | |/ \| |/  {}  \|  `| |
\      /| .--' | .--' \      /| |\  || {__ | |\  |  | |     |  .'.  |\      /| |\  |
 `----' `-'    `-'     `----' `-' `-'`----'`-' `-'  `-'     `-'   `-' `----' `-' `-'
";
        }
    }
}