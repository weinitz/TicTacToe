namespace TicTacToe.States
{
    public abstract class GameState
    {
        public virtual void SwitchCurrentPlayer(Game game)
        {
        }

        public abstract void Play(Game game);
        public abstract string Render(Game game);
    }
}