namespace TicTacToe
{
    public class Judger
    {
        private readonly ThreeInRowChecker _threeInRowChecker;

        public Judger()
        {
            _threeInRowChecker = ThreeInRowChecker.Create();
        }


        public void Judge(Game game)
        {
            if (IsDraw(game)) Draw(game);
            if (IsThreeInRow(game)) PlayerWon(game);
        }

        private bool IsThreeInRow(Game game)
        {
            var threeInRowCheck = _threeInRowChecker.Check(game.GameBoard, game.CurrentPlayer.Marker);
            return threeInRowCheck.HasValue && threeInRowCheck.Value;
        }

        private static void PlayerWon(Game game)
        {
            game.CurrentPlayer.IncreaseScore();
            game.SetState(game.WonState);
        }

        private static void Draw(Game game)
        {
            game.SetState(game.DrawState);
        }

        private static bool IsDraw(Game game)
        {
            return game.AvailableMarkers == 0;
        }
    }
}