namespace TicTacToe.States
{
    public class PlayState : GameState
    {
        public override void SwitchCurrentPlayer(Game game)
        {
            game.CurrentPlayer = game.CurrentPlayer.Equals(game.Player) ? game.Opponent : game.Player;
        }

        public override void Play(Game game)
        {
            try
            {
                game.CurrentPlayer.PlaceMarker(game.GameBoard);
                game.MarkerAddedToGameBoard();
                game.Play();
            }
            catch (SlotUnAvailableException)
            {
                game.Play();
                throw;
            }
        }

        public override string Render(Game game)
        {
            return
                $"{game.GameBoard.Render()}\n---------------------------\nPlayer: {game.Player.Score}\tOpponent: {game.Opponent.Score}";
        }
    }
}