using System.Collections.Generic;
using TicTacToe.Model;

namespace TicTacToe.Data
{
    public class GameBoard
    {
        private const int Size = 3;
        private readonly Slot[,] _slots;

        public GameBoard()
        {
            _slots = new Slot[Size, Size];
            for (var x = 0; x < Size; x++)
            for (var y = 0; y < Size; y++)
                _slots[x, y] = new Slot();
        }

        public Slot this[int x, int y]
        {
            get => _slots[x, y];
            private set => _slots[x, y] = value;
        }

        public List<Position> GetAvailableSlotPositions()
        {
            var possibleMoves = new List<Position>();
            for (var x = 0; x < Size; x++)
            for (var y = 0; y < Size; y++)
                if (this[x, y].IsAvailable)
                    possibleMoves.Add(new Position(x, y));
            return possibleMoves;
        }

        public void PlaceMarker(Position position, Marker marker)
        {
            PlaceMarker(position.X, position.Y, marker);
        }

        public void PlaceMarker(int x, int y, Marker marker)
        {
            if (!this[x, y].IsAvailable) throw new SlotUnAvailableException();
            this[x, y].Value = marker;
        }

        public string Render()
        {
            return
                $"\n {this[Position.Top, Position.Left]}  ║  {this[Position.Top, Position.Center]}  ║  {this[Position.Top, Position.Right]}\n" +
                "    ║     ║\n" +
                " ═══╬═════╬═══\n" +
                "    ║     ║\n" +
                $" {this[Position.Center, Position.Left]}  ║  {this[Position.Center, Position.Center]}  ║  {this[Position.Center, Position.Right]}\n" +
                "    ║     ║\n" +
                " ═══╬═════╬═══\n" +
                "    ║     ║\n" +
                $" {this[Position.Bottom, Position.Left]}  ║  {this[Position.Bottom, Position.Center]}  ║  {this[Position.Bottom, Position.Right]}\n";
        }
    }
}