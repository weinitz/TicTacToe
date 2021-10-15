using System;
using TicTacToe.Data;
using TicTacToe.Model;
using TicTacToe.States;

namespace TicTacToe
{
    public class Game
    {
        private readonly Judger _judger;
        public readonly Player Opponent;
        public readonly Player Player;
        public Player CurrentPlayer;
        public DrawState DrawState;
        public GameBoard GameBoard;
        public GameOverState GameOverState;
        public PlayState PlayState;
        public WonState WonState;

        public Game(Player player, Player opponent)
        {
            PlayState = new PlayState();
            GameOverState = new GameOverState();
            WonState = new WonState();
            DrawState = new DrawState();
            Player = player;
            Opponent = opponent;
            _judger = new Judger();
            Reset();
        }

        public int AvailableMarkers { get; private set; }

        public GameState CurrentGameState { get; private set; }

        public void MarkerAddedToGameBoard()
        {
            AvailableMarkers--;
            _judger.Judge(this);
            SwitchCurrentPlayer();
        }

        public void SetState(GameState state)
        {
            CurrentGameState = state;
        }

        public void SwitchCurrentPlayer()
        {
            CurrentGameState.SwitchCurrentPlayer(this);
        }

        public string Render()
        {
            return CurrentGameState.Render(this);
        }

        public void Print()
        {
            Console.Clear();
            var rendered = Render();
            Console.WriteLine(rendered);
        }

        public void Play()
        {
            Print();
            CurrentGameState.Play(this);
        }

        public void PlayInfinite()
        {
            do
            {
                Play();
            } while (CurrentGameState is GameOverState);
        }

        public void Reset()
        {
            CurrentPlayer = Player;
            CurrentGameState = PlayState;
            AvailableMarkers = 3 * 3;
            GameBoard = new GameBoard();
        }
    }
}